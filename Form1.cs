using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using Npgsql;
using System.IO;

namespace Login_and_Register_System
{
    public partial class frmRegister : Form
    {
        public frmRegister()
        {
            InitializeComponent();
        }

       
        private void Form1_Load(object sender, EventArgs e)
        {
            txtSalario.Text = "Ex:1000.95";
            txtSalario.ForeColor = Color.Gray; // 

            txtTaxaMinima.Text = "Ex:1.15";
            txtTaxaMinima.ForeColor = Color.Gray; // 

            txtTaxaMaxima.Text = "Ex:2.48";
            txtTaxaMaxima.ForeColor = Color.Gray; // 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            txtSalario.Focus();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void registrationButton_Click(object sender, EventArgs e)
        {
            
        }

       

        private void label6_Click_1(object sender, EventArgs e)
        {

            new LoginForm().Show();
            this.Hide();
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSalario_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTaxaMinima_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTaxaMaxima_TextChanged(object sender, EventArgs e)
        {

        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            using (OpenFileDialog upload = new OpenFileDialog())
            {
                upload.Filter = "Txt Files|*.txt";
                upload.Title = "Select File";
                if (upload.ShowDialog() != DialogResult.OK)
                    return;
                string filePath = upload.FileName;
               
            }
        }
    }
}