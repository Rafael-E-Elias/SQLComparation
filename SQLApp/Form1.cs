using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Collections;
using System.Data.Odbc;
using System.Threading;
using System.IO;

namespace SQLApp
{
    public partial class Form1 : Form
    {



        //Utilizar SQLConnection
        //string connstr = "Driver={SQL Server};Server=myServerAddress;Database=myDataBase;Uid=myUsername;Pwd=myPassword;";
        OdbcConnection Conexion = new OdbcConnection("DSN=; Uid=;Pwd=");
        //LoginDB log = new LoginDB();
        

        public Form1()
        {
            InitializeComponent();
            
        }


        

        private void On_Click(object sender, EventArgs e)
        {
            try
            {
                Thread.Sleep(1000);
                Conexion.Open();
                MessageBox.Show("Se abrió la conexión con el servidor SQL Server y se conecto con la base de datos");
                pictureBox1.Visible = false;
                On.Visible = false;
                pictureBox2.Visible = true;
                Out.Visible = true;
                Seleccionar.Enabled = true;
                AllDataBases();
                Aceptar.Enabled = true;
                LeerCSV();

            }
            catch(Exception ex)
            {
                string mensaje = ex.Message;
                MessageBox.Show(mensaje);
               
            }





        }

        private void Out_Click(object sender, EventArgs e)
        {
            try
            {
                Conexion.Close();
                pictureBox2.Visible = false;
                Out.Visible = false;
                pictureBox1.Visible = true;
                On.Visible = true;
                DataBases.Items.Clear();
                listBox1.Items.Clear();
                Seleccionar.Enabled = false;
                comparar.Enabled = false;
                simple.Enabled = true;
                Thread.Sleep(1000);
                MessageBox.Show("Se cerro la conexión con el servidor SQL Server y se desconecto con la base de datos");
            }catch(Exception ex)
            {
                string mensaje = ex.Message;
                MessageBox.Show(mensaje);
            }

            

        }


        /*AllDataBases
         * Este metodo genera un array con todas las DB que componen el servidor al cual se conecto 
         */ 
        private void AllDataBases()
        {
            OdbcCommand comand;
            OdbcDataReader read;
            ArrayList DBs = new ArrayList();
            string cmd = "select name from sys.databases ";
           comand = new OdbcCommand(cmd, Conexion);
            comand.CommandType = CommandType.Text;
            comand.Connection = Conexion;
            read = comand.ExecuteReader();
            while (read.Read())
            {
                DBs.Add(read.GetString(0));
            }
            read.Close();
            foreach (var obj in DBs)
                DataBases.Items.Add(obj);
                   
        }



        /*TablasaComparar
         * Este metodo retorna la tabla que usaremos para realizar la comparacion con el Schema
         */ 
        public string TablasaComparar()
        {
            string parametrosTabla = "";
            if (comboBox1.SelectedItem.ToString()=="")
            {
                parametrosTabla = "[DB].[dbo].[tabla]";
            }
            else
            {
                parametrosTabla = "[DB].[dbo].[tabla]";
            }
            return parametrosTabla;
        }




         /*SQL_TABLES
          * Este metodo actualmente no esta en uso
          * Realiza una comparacion entre el esquema de la DB seleccionada y nos devuele una lista de Tablas faltantes
        private void SQL_TABLES()
        {
            
            OdbcCommand comand;
            OdbcDataReader read;
            DataTable sqltable = new DataTable();
            string query = "select a.TABLA, a.COLUMNA, a.TIPO, b.TABLE_NAME from [].[dbo].[tablas] a full join (SELECT TABLE_NAME, COLUMN_NAME, DATA_TYPE FROM [].INFORMATION_SCHEMA.COLUMNS) b on a.TABLA = b.TABLE_NAME where b.TABLE_NAME is null";
            comand = new OdbcCommand(query, Conexion);
            comand.CommandType = CommandType.Text;
            comand.Connection = Conexion;
            read = comand.ExecuteReader();
            for (int i = 0; i < read.FieldCount; i++)
            {
                sqltable.Columns.Add(read.GetName(i), typeof(string));
                while (read.Read())
                {
                    sqltable.Rows.Add(read.GetString(i));
                }
                dataGridView1.DataSource = sqltable;
            }
            read.Close();

        }
        */




       /*SchemaDB
        * Este metodo es incompleto
        * Deberia devolver una vista en el GridView de cualquier consulta SQL realizada
        private void SchemaDB()
        {
            OdbcCommand comand;
            OdbcDataReader read;
            DataTable DBtable = new DataTable();
            string db = DataBases.Text;
            string query = "SELECT TABLE_NAME, COLUMN_NAME, DATA_TYPE FROM[" + db + "].INFORMATION_SCHEMA.COLUMNS";
            comand = new OdbcCommand(query, Conexion);
            comand.CommandType = CommandType.Text;
            comand.Connection = Conexion;
            read = comand.ExecuteReader();
            for (int i = 0; i < read.FieldCount; i++)
            {
                DBtable.Columns.Add(read.GetName(i), typeof(string));
                while (read.Read())
                {
                    DBtable.Rows.Add(read.GetString(i));
                }
                dataGridView1.DataSource = DBtable;
            }
            read.Close();
        }
        
        */        
        
        
        /* Metodo SchemaDBmanual
         * genera un esquema de la base de datos seleccionada
         * genera un vista en el obj GridView del:
         * nombre de la tabla, la columna y el tipo de dato que compone la db selecionada
         */                 
        private void SchemaDBManual()
        {
            OdbcCommand comand;
            OdbcDataReader read;
            List<string> tablas = new List<string>();
            List<string> columna = new List<string>();
            List<string> tipo = new List<string>();
            DataTable DBtable = new DataTable();
            string db = DataBases.Text;
            string query = "SELECT TABLE_NAME, COLUMN_NAME, DATA_TYPE FROM[" + db + "].INFORMATION_SCHEMA.COLUMNS";
            comand = new OdbcCommand(query, Conexion);
            comand.CommandType = CommandType.Text;
            comand.Connection = Conexion;
            read = comand.ExecuteReader();
            while (read.Read())
            {
                
                tablas.Add(read.GetString(0));
                columna.Add(read.GetString(1));
                tipo.Add(read.GetString(2));
                
            }
            for (int i = 0; i < read.FieldCount; i++)
            {
                DBtable.Columns.Add(read.GetName(i), typeof(string));                
            }
           
            for (int j = 0; j < tablas.Count; j++)
            {
                DBtable.Rows.Add(tablas[j],columna[j],tipo[j]);
                                     
            }
            dataGridView1.DataSource = DBtable;
            read.Close();
        }




        /*ComparacionSchema
         * Este metodo compara los columnas TABLE_NAME, COLUMN_NAME, DATA_TYPE, CHARACTER_MAXIMUM_LENGTH de INFORMATION_SCHEMA.COLUMNS de la BD seleccionada
         * Nos devuelve una lista de con los nombre de las tablas que no tuvo coincidencia en la busqueda
         */

        private void ComparacionSchema()
        {
            OdbcCommand comand;
            OdbcDataReader read;
            List<string> tablas = new List<string>();
            List<string> columna = new List<string>();
            List<string> tipo = new List<string>();
            List<string> tamaño = new List<string>();
            List<string> TABLE_NAME = new List<string>();
            List<string> COLUMN_NAME = new List<string>();
            List<string> DATA_TYPE = new List<string>();
            List<string> CHARACTER_LENGTH = new List<string>();           
        DataTable DBtable = new DataTable();
            string tab = TablasaComparar();
            string db = DataBases.Text;            
            string query = "select a.TABLA, a.COLUMNA, a.TIPO, a.TAMAÑO, case when b.TABLE_NAME is null then '' else b.TABLE_NAME end as TABLE_NAME, case when b.COLUMN_NAME is null then '' else b.COLUMN_NAME end COLUMN_NAME, case when b.DATA_TYPE is null then '' else b.DATA_TYPE end DATA_TYPE, case when b.CHARACTER_MAXIMUM_LENGTH is null then '' else b.CHARACTER_MAXIMUM_LENGTH end as CHARACTER_LENGTH from "+tab+" a full join (select TABLE_NAME, COLUMN_NAME, DATA_TYPE, CHARACTER_MAXIMUM_LENGTH from["+ db +"].INFORMATION_SCHEMA.COLUMNS) b on a.TABLA = b.TABLE_NAME and a.COLUMNA = b.COLUMN_NAME and a.TIPO = b.DATA_TYPE where b.TABLE_NAME is null or b.CHARACTER_MAXIMUM_LENGTH<> a.TAMAÑO";
            comand = new OdbcCommand(query, Conexion);
            comand.CommandType = CommandType.Text;
            comand.Connection = Conexion;
            read = comand.ExecuteReader();
            while (read.Read())
            {

                tablas.Add(read.GetString(0));
                columna.Add(read.GetString(1));
                tipo.Add(read.GetString(2));
                tamaño.Add(read.GetString(3));
               TABLE_NAME.Add(read.GetString(4));
                COLUMN_NAME.Add(read.GetString(5));
                DATA_TYPE.Add(read.GetString(6));
                CHARACTER_LENGTH.Add(read.GetString(7));

                

            }
            for (int i = 0; i < read.FieldCount; i++)
            {
                DBtable.Columns.Add(read.GetName(i), typeof(string));
            }

            for (int j = 0; j < tablas.Count; j++)
            {
                DBtable.Rows.Add(tablas[j],
                                 columna[j],
                                 tipo[j],
                                 tamaño[j],
                                 TABLE_NAME[j],
                                 COLUMN_NAME[j],
                                 DATA_TYPE[j],
                                 CHARACTER_LENGTH[j]
                                 );
            }
            dataGridView1.DataSource = DBtable;
            read.Close();
        }

        


        
        /*ComparacionSimple
         * Este metodo compara los columnas TABLE_NAME, COLUMN_NAME, DATA_TYPE de INFORMATION_SCHEMA.COLUMNS de la BD seleccionada
         * Nos devuelve una lista de con los nombre de las tablas que no tuvo coincidencia en la busqueda
         */

        private void ComparacionSimple()
        {
            OdbcCommand comand;
            OdbcDataReader read;
            List<string> tablas = new List<string>();
            List<string> columna = new List<string>();
            List<string> tipo = new List<string>();
            List<string> tamaño = new List<string>();
            List<string> TABLE_NAME = new List<string>();
            List<string> COLUMN_NAME = new List<string>();
            List<string> DATA_TYPE = new List<string>();
            DataTable DBtable = new DataTable();
            string tab = TablasaComparar();
            string db = DataBases.Text;            
            string query = "select a.TABLA, a.COLUMNA, a.TIPO, a.TAMAÑO,case when b.TABLE_NAME is null then '' else b.TABLE_NAME end as TABLE_NAME, case when b.COLUMN_NAME is null then '' else b.COLUMN_NAME end COLUMN_NAME, case when b.DATA_TYPE is null then '' else b.DATA_TYPE end DATA_TYPE from "+tab+" a full join (select TABLE_NAME, COLUMN_NAME, DATA_TYPE from["+ db +"].INFORMATION_SCHEMA.COLUMNS) b on a.TABLA = b.TABLE_NAME and a.COLUMNA = b.COLUMN_NAME and a.TIPO = b.DATA_TYPE where b.TABLE_NAME is null";
            comand = new OdbcCommand(query, Conexion);
            comand.CommandType = CommandType.Text;
            comand.Connection = Conexion;
            read = comand.ExecuteReader();
            while (read.Read())
            {

                tablas.Add(read.GetString(0));
                columna.Add(read.GetString(1));
                tipo.Add(read.GetString(2));
                tamaño.Add(read.GetString(3));
                TABLE_NAME.Add(read.GetString(4));
                COLUMN_NAME.Add(read.GetString(5));
                DATA_TYPE.Add(read.GetString(6));
            }
            for (int i = 0; i < read.FieldCount; i++)
            {
                DBtable.Columns.Add(read.GetName(i), typeof(string));
            }

            for (int j = 0; j < tablas.Count; j++)
            {
                DBtable.Rows.Add(tablas[j],
                                 columna[j],
                                 tipo[j],
                                 tamaño[j],
                                 TABLE_NAME[j],
                                 COLUMN_NAME[j],
                                 DATA_TYPE[j]
                                 );
            }
            dataGridView1.DataSource = DBtable;
            read.Close();

            
        }





        /*CountTablas
         * Agrupo los registros devueltos en la comparacion de esquema complejo y contabiliza las tablas faltantes en la Db seleccionada
         * Muestra un lista de las tablas faltantes en la DB seleccionada
         */
         
        private void CountTablas()
        {
            OdbcCommand comand;
            OdbcDataReader read;
            List<string> count = new List<string>();
            string tab = TablasaComparar();
            string db = DataBases.Text;
            string query = "select distinct a.TABLA from "+tab+" a full join (select TABLE_NAME, COLUMN_NAME, DATA_TYPE, CHARACTER_MAXIMUM_LENGTH from["+ db +"].INFORMATION_SCHEMA.COLUMNS) b on a.TABLA = b.TABLE_NAME and a.COLUMNA = b.COLUMN_NAME and a.TIPO = b.DATA_TYPE where b.TABLE_NAME is null or b.CHARACTER_MAXIMUM_LENGTH<> a.TAMAÑO";
            comand = new OdbcCommand(query, Conexion);
            comand.CommandType = CommandType.Text;
            comand.Connection = Conexion;
            read = comand.ExecuteReader();
            while (read.Read())
            {
                count.Add(read.GetString(0));
            }
            label1.Text = count.Count.ToString();
            foreach (string tb in count)
                listBox1.Items.Add(tb);

        }


        
        /*CountTablasSimple
         * Agrupo los registros devueltos en la comparacion de esquema simple y contabiliza las tablas faltantes en la Db seleccionada
         * Muestra un lista de las tablas faltantes en la DB seleccionada
         */
         
        protected List<string> CountTablasSimple()
        {
            OdbcCommand comand;
            OdbcDataReader read;
            List<string> count = new List<string>();
            string tab = TablasaComparar();
            string db = DataBases.Text;            
            string query = "select distinct a.TABLA from "+tab+" a full join (select TABLE_NAME, COLUMN_NAME, DATA_TYPE from["+ db +"].INFORMATION_SCHEMA.COLUMNS) b on a.TABLA = b.TABLE_NAME and a.COLUMNA = b.COLUMN_NAME and a.TIPO = b.DATA_TYPE where b.TABLE_NAME is null or b.TABLE_NAME<> a.TABLA ";
            comand = new OdbcCommand(query, Conexion);
            comand.CommandType = CommandType.Text;
            comand.Connection = Conexion;
            read = comand.ExecuteReader();
            while (read.Read())
            {
                count.Add(read.GetString(0));
            }

            label1.Text = count.Count.ToString();
            foreach (string tb in count)
                listBox1.Items.Add(tb);
            return count;

        }


       
 
        /*AllTables
         * Genera un array con todas las tablas que corresponden a la DB seleccionada
         * Muestra todas las tablas que corresonden a la DB seleccionada
         */
         
        private void AllTables()
        {   
                     OdbcCommand comand;
                    OdbcDataReader lector;
                    ArrayList tablas = new ArrayList();
            string db = DataBases.Text;
            string cmd = "SELECT TABLE_NAME FROM [" +db+"].INFORMATION_SCHEMA.TABLES WHERE TABLE_TYPE = 'BASE TABLE' AND TABLE_NAME <> 'sysdiagrams'  ORDER BY TABLE_NAME";
                    comand = new OdbcCommand(cmd, Conexion);
                    comand.CommandType = CommandType.Text;
                    comand.Connection = Conexion;
                    lector = comand.ExecuteReader();
                    while (lector.Read())
                    {
                        tablas.Add(lector.GetString(0));
                    }
                    lector.Close();
            label3.Text = tablas.Count.ToString();
            foreach (var obj in tablas)
                listBox1.Items.Add(obj);
            
        }

        /*CreateTable
         *Este metodo crea una tabla y le inserta la columna Id dentro de la DB seleccionada
         *El nombre de la tabla a crear debe ser pasada como parametro
         */
        private void CreateTable(string table)
        {
            OdbcCommand command;
            string db = DataBases.Text;
            string cmd = " Use " + db + "; create table " + table + " ( Id int PRIMARY KEY IDENTITY(1,1) NOT NULL); ";
            command = new OdbcCommand(cmd, Conexion);
            command.CommandType = CommandType.Text;
            command.Connection = Conexion;
            command.ExecuteNonQuery();
        }


        /*CreateTableAutomatical
         * Este metodo toma como parametro un array del metodo CountTablasSimple
         * ya que este meteodo devuelve un array con las tablas que faltan crear en la db comparada
         */ 
        private void CreateTableAutomatical()
        {
            foreach (string table in CountTablasSimple())
            {
                CreateTable(table);
            }

        }

        /*LlenarTabla
         * Este metodo genera las tablas necesarias para completar la base de datos comparada.
         */
        private void LlenarTabla()
        {
            OdbcCommand comand;
            OdbcDataReader read;
            List<string> tablas = new List<string>();
            List<string> columna = new List<string>();
            List<string> tipo = new List<string>();
            List<string> tamaño = new List<string>();
            string tab = TablasaComparar();
            string db = DataBases.Text;
            string query = "select a.TABLA, a.COLUMNA, a.TIPO, a.TAMAÑO,case when b.TABLE_NAME is null then '' else b.TABLE_NAME end as TABLE_NAME, case when b.COLUMN_NAME is null then '' else b.COLUMN_NAME end COLUMN_NAME, case when b.DATA_TYPE is null then '' else b.DATA_TYPE end DATA_TYPE from " + tab + " a full join (select TABLE_NAME, COLUMN_NAME, DATA_TYPE from[" + db + "].INFORMATION_SCHEMA.COLUMNS) b on a.TABLA = b.TABLE_NAME and a.COLUMNA = b.COLUMN_NAME and a.TIPO = b.DATA_TYPE where b.TABLE_NAME is null";
            comand = new OdbcCommand(query, Conexion);
            comand.CommandType = CommandType.Text;
            comand.Connection = Conexion;
            read = comand.ExecuteReader();
            while (read.Read())
            {
                tablas.Add(read.GetString(0));
                columna.Add(read.GetString(1));
                tipo.Add(read.GetString(2));
                tamaño.Add(read.GetString(3));
            }
            

            for (int i = 0; i < tablas.Count; i++)
            { string varc = tipo[i];
                if (varc.Equals("varchar", StringComparison.OrdinalIgnoreCase)){
                    string cmd = " Use " + db + "; ALTER TABLE " + tablas[i] + " ADD "+ columna[i] +" "+tipo[i] + " ("+ tamaño[i] +");";
                    OdbcCommand command;
                    command = new OdbcCommand(cmd, Conexion);
                    command.CommandType = CommandType.Text;
                    command.Connection = Conexion;
                    command.ExecuteNonQuery();
                }
                else if (varc.Equals("nvarchar", StringComparison.OrdinalIgnoreCase)){
                    string cmd = " Use " + db + "; ALTER TABLE " + tablas[i] + " ADD " + columna[i] + " " + tipo[i] + " (" + tamaño[i] + ");";
                    OdbcCommand command;
                    command = new OdbcCommand(cmd, Conexion);
                    command.CommandType = CommandType.Text;
                    command.Connection = Conexion;
                    command.ExecuteNonQuery();
                }
                else
                {
                    string cmd = " Use " + db + "; ALTER TABLE " + tablas[i] + " ADD " + columna[i] +" "+ tipo[i];
                    OdbcCommand command;
                    command = new OdbcCommand(cmd, Conexion);
                    command.CommandType = CommandType.Text;
                    command.Connection = Conexion;
                    command.ExecuteNonQuery();
                }
                read.Close();
            }
                     

        }

        

        private void Seleccionar_Click(object sender, EventArgs e)
        {
            try
            {
                Esquema.Enabled = true;
                listBox1.Items.Clear();
                comparar.Enabled = true;
                simple.Enabled = true;
            }
            catch (Exception ex)
            {
                string mensaje = ex.Message;
                MessageBox.Show(mensaje);
            }
            
            
        }

        private void Esquema_Click(object sender, EventArgs e)
        {
            try
            {
                AllTables();
                SchemaDBManual();
                Esquema.Enabled = false;
            }
            catch(Exception ex)
            {
                string mensaje = ex.Message;
                MessageBox.Show(mensaje);
            }
            
            
        }

        private void comparar_Click(object sender, EventArgs e)
        {
            try
            {
                listBox1.Items.Clear();
                Thread.Sleep(1000);
                ComparacionSchema();
                CountTablas();
                comparar.Enabled = false;
            }catch(Exception ex)
            {
                string mensaje = ex.Message;
                MessageBox.Show(mensaje);
            }
            
        }

                
        private void simple_Click(object sender, EventArgs e)
        {
            try
            {
                listBox1.Items.Clear();
                Thread.Sleep(1000);
                ComparacionSimple();
                CountTablasSimple();
                simple.Enabled = false;
                Manual.Enabled = true;
                crear.Enabled = true;
                button1.Enabled = true;
            }
            catch (Exception ex)
            {
                string mensaje = ex.Message;
                MessageBox.Show(mensaje);
            }
            
        }

        private void Limpiar_Click(object sender, EventArgs e)
        {
            
            listBox1.Items.Clear();
            label1.Text = "";
        }


        private void Aceptar_Click(object sender, EventArgs e)
        {
            TablasaComparar();
        }




        private void crear_Click(object sender, EventArgs e)
        {
           
            try
            {
                
                Thread.Sleep(2000);
                LlenarTabla();
                Thread.Sleep(2000);
                MessageBox.Show("La insercion de las tablas se completo con exito");
            }
            catch(Exception ex)
            {
                string mensaje = ex.Message;
                MessageBox.Show(mensaje);
                
            }
           
        }



        private void Manual_Click(object sender, EventArgs e)
        {
            try
            {
                Form manual = new ExceptionFrame();
                manual.Show();
            }
            catch(Exception ex)
            {
                string mensaje = ex.Message;
                MessageBox.Show(mensaje);
      
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                CreateTableAutomatical();
                MessageBox.Show("La creacion de las tablas se llevo acabo con exito");
            }catch(Exception ex)
            {
                string mensaje = ex.Message;
                MessageBox.Show(mensaje);
            }
        }



       
        








        /*ArrayTablas
         * Actualmente este metodo no esta en uso
         * Este metodo nos retorna un ArrayList con las tablas el usuario tiene y cumples con los requerimientos
         * 
    private ArrayList ArrayTablas()
        {
            OdbcCommand comand;
            OdbcDataReader lector;
            ArrayList tablas = new ArrayList();
            string db = DataBases.Text;
            string cmd = "select distinct tabla from [tablas_sql] t full join (select TABLE_NAME, COLUMN_NAME from [" + db + "].INFORMATION_SCHEMA.COLUMNS)ts on t.TABLA = ts.TABLE_NAME where ts.TABLE_NAME = t.TABLA";
            comand = new OdbcCommand(cmd, Conexion);
            comand.CommandType = CommandType.Text;
            comand.Connection = Conexion;
            lector = comand.ExecuteReader();
            while (lector.Read())                             
            {
                tablas.Add(lector.GetString(0));
            }
            lector.Close();
            
            return tablas;

        }
     */

        /*ControlColumnas
         * Este metodo esta en desarrollo
         * Comparar el esquema de db con nuestra tabla de db
         * 
            private void ControlColumnas()
            {
                OdbcCommand comand;
                OdbcDataReader lector;
                ArrayList ColumnaTabla = new ArrayList();
                ArrayList ColumnaSchema = new ArrayList();
                string db = DataBases.Text;
                ArrayList tables = ArrayTablas();
                string tbl = "";
                for(int i = 0; i<tables.Count; i++)
                {
                    tbl = tables[i].ToString();
                    Console.WriteLine("Var tbl:"+ tbl);
                }

                string cmdtb = "select columna from [tablas_sql] where TABLA = '"+ tbl +"'";
                string cmdsch = "select COLUMN_NAME from [DBAMPHIBIA2017_CONFIG].INFORMATION_SCHEMA.COLUMNS where TABLE_NAME = '"+ tbl +"' ";
                comand = new OdbcCommand(cmdtb,Conexion);
                comand.CommandType = CommandType.Text;
                comand.Connection = Conexion;
                lector = comand.ExecuteReader();
                while (lector.Read())                             //["+db+"]
                {
                    ColumnaTabla.Add(lector.GetString(0));
                }

                comand = new OdbcCommand(cmdsch, Conexion);
                comand.CommandType = CommandType.Text;
                comand.Connection = Conexion;
                lector = comand.ExecuteReader();
                while (lector.Read())                             //["+db+"]
                {
                    ColumnaSchema.Add(lector.GetString(0));
                }
                lector.Close();

                ArrayList ColunMal = new ArrayList();
                ArrayList TblMal = new ArrayList();
                ArrayList columnBien = new ArrayList();
                ArrayList tablBien = new ArrayList();
                string Csche = "";
                string Ctb = "";
                for (int i = 0; i < ColumnaTabla.Count; i++)
                {
                    Ctb = ColumnaTabla[i].ToString();
                    Csche = ColumnaSchema[i].ToString();
                    Console.WriteLine("Columna de la tabla:" + Ctb);
                    Console.WriteLine("Columna del schema:" + Csche);
                }


                    if (Ctb.Equals(Csche,StringComparison.OrdinalIgnoreCase))
                    {
                        columnBien.Add(ColumnaTabla[i]);
                        tablBien.Add(tbl);
                    }
                    else
                    {
                        Console.WriteLine("La columna incorrecta es:" + Ctb);
                        ColunMal.Add(ColumnaTabla[i]);
                        TblMal.Add(tbl);

                    }


                }
                foreach (var ob in columnBien){
                    Console.WriteLine("Columnas bien:" + ob);
                }

                    foreach (var oj in ColunMal) {
                    Console.WriteLine("Columnas Mal:" + oj);
                }

                Console.WriteLine("Columnas incorrectas:" + ColunMal.Count);
                Console.WriteLine("Columnas correctas:" + tablBien.Count);
                Console.WriteLine("Tabla:"+tbl);

                */

        /*
        ArrayList tables = ArrayTablas();
        foreach(var obj in tables)
        {
            Console.WriteLine(obj);
        }        


    }*/












    }
}





  