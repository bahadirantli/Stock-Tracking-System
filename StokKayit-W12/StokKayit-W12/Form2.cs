using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace StokKayit_W12
{
    public partial class Form2 : Form
    {
        SqlConnection con;
        SqlDataReader dr;
        SqlCommand com;
        public Form2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string user = textBox1.Text;
            string password = textBox2.Text;
            con = new SqlConnection("Data Source=DESKTOP-N3ECN9S;Initial Catalog=Stok3;Integrated Security=True");
            com = new SqlCommand();
            con.Open(); 
            com.Connection = con;
            com.CommandText = "Select*From Kullanici_Bilgi where kullanici_adi = '" + textBox1.Text + "' And sifre = '" + textBox2.Text + "'";
            dr = com.ExecuteReader();
            if (dr.Read())
            {
                MessageBox.Show("Successfully Entered!");
                Form1 fr1 = new Form1();
                fr1.ShowDialog();
            }
            else
            {
                MessageBox.Show("Wrong username or password!");
            }
            con.Close();
        }
    }
}
