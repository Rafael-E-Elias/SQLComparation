using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Odbc;
using System.Threading;

namespace SQLApp
{
    public partial class ExceptionFrame : Form
    {
        OdbcConnection Conexion = new OdbcConnection("DSN=dsamphibia_2017; Uid=sa;Pwd=D1g1srvargsql2015");
        public ExceptionFrame()
        {
            InitializeComponent();
        }


        private void InsertarRegistro()
        {
            try
            {
                Conexion.Open();
                string cmd = richTextBox1.Text;
                OdbcCommand command;
                command = new OdbcCommand(cmd, Conexion);
                command.CommandType = CommandType.Text;
                command.Connection = Conexion;
                command.ExecuteNonQuery();
                Conexion.Close();
                Thread.Sleep(1000);
                MessageBox.Show("La sentencia de ejecuto con exito");
            }catch(Exception ex)
            {
                string mensaje = ex.Message;
                MessageBox.Show(mensaje);
            }
            
        }




        private void insert_Click(object sender, EventArgs e)
        {
            InsertarRegistro();
        }

        private void Limpiar_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
        }
    }
}
