using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SQLApp
{
    public partial class LoginDB : Form
    {
        public LoginDB()
        {
            InitializeComponent();



        }

        private string dns;
        private string user;
        private string pwd;

        public string Dns { get => "DNS=" + dns; set => dns = value; }
        public string User { get => "Uid=" + user; set => user = value; }
        public string Pwd { get => "Pwd=" + pwd; set => pwd = value; }









        public string DatosDB()
        {
            return Dns + ";" + User + ";" + Pwd;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dns = textBoxDNS.Text;
            user = textBoxUser.Text;
            pwd = textBoxPwd.Text;
            Console.WriteLine(DatosDB());
        }
    }
}
