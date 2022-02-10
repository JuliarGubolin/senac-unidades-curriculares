using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pessoasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //this.Close();
            //Form1 é o menu principal
            Form2 FrmPessoas = new Form2();
            //Abrir o novo form no modeo MDI parent
            FrmPessoas.MdiParent = this;
            FrmPessoas.Show();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //Testar conexão
        /*SqlConnection conn = new SqlConnection();
            conn.ConnectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString();
            conn.Open();
            MessageBox.Show("OBA.", "Sucesso");*/
    }
}
