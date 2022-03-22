namespace SQLApp
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.DataBases = new System.Windows.Forms.ComboBox();
            this.Out = new System.Windows.Forms.Button();
            this.On = new System.Windows.Forms.Button();
            this.db = new System.Windows.Forms.Label();
            this.tb = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Esquema = new System.Windows.Forms.Button();
            this.Seleccionar = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comparar = new System.Windows.Forms.Button();
            this.simple = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.Cdbselec = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Limpiar = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.Aceptar = new System.Windows.Forms.Button();
            this.crear = new System.Windows.Forms.Button();
            this.Manual = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.Login = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // DataBases
            // 
            this.DataBases.FormattingEnabled = true;
            this.DataBases.Location = new System.Drawing.Point(960, 129);
            this.DataBases.Name = "DataBases";
            this.DataBases.Size = new System.Drawing.Size(288, 21);
            this.DataBases.TabIndex = 0;
            // 
            // Out
            // 
            this.Out.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Out.Location = new System.Drawing.Point(12, 52);
            this.Out.Name = "Out";
            this.Out.Size = new System.Drawing.Size(55, 29);
            this.Out.TabIndex = 5;
            this.Out.Text = "Off";
            this.Out.UseVisualStyleBackColor = true;
            this.Out.Visible = false;
            this.Out.Click += new System.EventHandler(this.Out_Click);
            // 
            // On
            // 
            this.On.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.On.Location = new System.Drawing.Point(14, 52);
            this.On.Name = "On";
            this.On.Size = new System.Drawing.Size(55, 29);
            this.On.TabIndex = 6;
            this.On.Text = "On";
            this.On.UseVisualStyleBackColor = true;
            this.On.Click += new System.EventHandler(this.On_Click);
            // 
            // db
            // 
            this.db.AutoSize = true;
            this.db.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.db.Location = new System.Drawing.Point(956, 102);
            this.db.Name = "db";
            this.db.Size = new System.Drawing.Size(103, 24);
            this.db.TabIndex = 8;
            this.db.Text = "Data Bases";
            // 
            // tb
            // 
            this.tb.AutoSize = true;
            this.tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb.Location = new System.Drawing.Point(952, 367);
            this.tb.Name = "tb";
            this.tb.Size = new System.Drawing.Size(331, 24);
            this.tb.TabIndex = 9;
            this.tb.Text = "Tablas faltantes en la DB seleccionada";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(14, 87);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(932, 660);
            this.dataGridView1.TabIndex = 12;
            // 
            // Esquema
            // 
            this.Esquema.Enabled = false;
            this.Esquema.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Esquema.Location = new System.Drawing.Point(1142, 171);
            this.Esquema.Name = "Esquema";
            this.Esquema.Size = new System.Drawing.Size(106, 26);
            this.Esquema.TabIndex = 14;
            this.Esquema.Text = "Ver esquema ";
            this.Esquema.UseVisualStyleBackColor = true;
            this.Esquema.Click += new System.EventHandler(this.Esquema_Click);
            // 
            // Seleccionar
            // 
            this.Seleccionar.Enabled = false;
            this.Seleccionar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Seleccionar.Location = new System.Drawing.Point(960, 171);
            this.Seleccionar.Name = "Seleccionar";
            this.Seleccionar.Size = new System.Drawing.Size(112, 26);
            this.Seleccionar.TabIndex = 23;
            this.Seleccionar.Text = "Seleccionar";
            this.Seleccionar.UseVisualStyleBackColor = true;
            this.Seleccionar.Click += new System.EventHandler(this.Seleccionar_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(960, 426);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(288, 147);
            this.listBox1.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1096, 405);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 18);
            this.label1.TabIndex = 25;
            // 
            // comparar
            // 
            this.comparar.Enabled = false;
            this.comparar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comparar.Location = new System.Drawing.Point(1142, 314);
            this.comparar.Name = "comparar";
            this.comparar.Size = new System.Drawing.Size(119, 34);
            this.comparar.TabIndex = 26;
            this.comparar.Text = "compleja";
            this.comparar.UseVisualStyleBackColor = true;
            this.comparar.Click += new System.EventHandler(this.comparar_Click);
            // 
            // simple
            // 
            this.simple.Enabled = false;
            this.simple.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simple.Location = new System.Drawing.Point(969, 315);
            this.simple.Name = "simple";
            this.simple.Size = new System.Drawing.Size(103, 34);
            this.simple.TabIndex = 27;
            this.simple.Text = "simple";
            this.simple.UseVisualStyleBackColor = true;
            this.simple.Click += new System.EventHandler(this.simple_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(956, 282);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(217, 20);
            this.label2.TabIndex = 28;
            this.label2.Text = "Comparacion de esquema";
            // 
            // Cdbselec
            // 
            this.Cdbselec.AutoSize = true;
            this.Cdbselec.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cdbselec.Location = new System.Drawing.Point(969, 221);
            this.Cdbselec.Name = "Cdbselec";
            this.Cdbselec.Size = new System.Drawing.Size(223, 16);
            this.Cdbselec.TabIndex = 29;
            this.Cdbselec.Text = "Tablas de la DB seleccionada:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1198, 221);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(13, 16);
            this.label3.TabIndex = 30;
            this.label3.Text = "-";
            // 
            // Limpiar
            // 
            this.Limpiar.Location = new System.Drawing.Point(960, 596);
            this.Limpiar.Name = "Limpiar";
            this.Limpiar.Size = new System.Drawing.Size(75, 23);
            this.Limpiar.TabIndex = 31;
            this.Limpiar.Text = "Limpiar";
            this.Limpiar.UseVisualStyleBackColor = true;
            this.Limpiar.Click += new System.EventHandler(this.Limpiar_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Amphibia_Config",
            "Amphibia_Web"});
            this.comboBox1.Location = new System.Drawing.Point(960, 25);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(245, 21);
            this.comboBox1.TabIndex = 32;
            // 
            // Aceptar
            // 
            this.Aceptar.Enabled = false;
            this.Aceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Aceptar.Location = new System.Drawing.Point(960, 55);
            this.Aceptar.Name = "Aceptar";
            this.Aceptar.Size = new System.Drawing.Size(112, 26);
            this.Aceptar.TabIndex = 33;
            this.Aceptar.Text = "Aceptar";
            this.Aceptar.UseVisualStyleBackColor = true;
            this.Aceptar.Click += new System.EventHandler(this.Aceptar_Click);
            // 
            // crear
            // 
            this.crear.Enabled = false;
            this.crear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.crear.Location = new System.Drawing.Point(1142, 686);
            this.crear.Name = "crear";
            this.crear.Size = new System.Drawing.Size(106, 41);
            this.crear.TabIndex = 34;
            this.crear.Text = "Insertar columnas";
            this.crear.UseVisualStyleBackColor = true;
            this.crear.Click += new System.EventHandler(this.crear_Click);
            // 
            // Manual
            // 
            this.Manual.Enabled = false;
            this.Manual.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Manual.Location = new System.Drawing.Point(1136, 587);
            this.Manual.Name = "Manual";
            this.Manual.Size = new System.Drawing.Size(112, 41);
            this.Manual.TabIndex = 35;
            this.Manual.Text = "Manual";
            this.Manual.UseVisualStyleBackColor = true;
            this.Manual.Click += new System.EventHandler(this.Manual_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(1006, 638);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(205, 20);
            this.label4.TabIndex = 36;
            this.label4.Text = "Generar tablas faltantes";
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(990, 686);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 41);
            this.button1.TabIndex = 37;
            this.button1.Text = "Crear Tablas";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Login
            // 
            this.Login.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Login.Location = new System.Drawing.Point(86, 52);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(61, 29);
            this.Login.TabIndex = 38;
            this.Login.Text = "Log";
            this.Login.UseVisualStyleBackColor = true;
            this.Login.Visible = false;

            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::SQLApp.Properties.Resources.login_square_arrow_button_outline_icon_icons_com_73220;
            this.pictureBox3.Location = new System.Drawing.Point(101, 12);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(37, 34);
            this.pictureBox3.TabIndex = 39;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Visible = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::SQLApp.Properties.Resources.favicon;
            this.pictureBox2.Location = new System.Drawing.Point(12, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(57, 34);
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SQLApp.Properties.Resources.DB;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(51, 34);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1282, 762);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.Login);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Manual);
            this.Controls.Add(this.crear);
            this.Controls.Add(this.Aceptar);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.Limpiar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Cdbselec);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.simple);
            this.Controls.Add(this.comparar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.Seleccionar);
            this.Controls.Add(this.Esquema);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.tb);
            this.Controls.Add(this.db);
            this.Controls.Add(this.On);
            this.Controls.Add(this.Out);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.DataBases);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox DataBases;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button Out;
        private System.Windows.Forms.Button On;
        private System.Windows.Forms.Label db;
        private System.Windows.Forms.Label tb;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Esquema;
        private System.Windows.Forms.Button Seleccionar;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button comparar;
        private System.Windows.Forms.Button simple;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Cdbselec;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Limpiar;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button Aceptar;
        private System.Windows.Forms.Button crear;
        private System.Windows.Forms.Button Manual;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Login;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}

