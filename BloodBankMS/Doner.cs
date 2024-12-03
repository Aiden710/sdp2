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
using System.Xml;

namespace BloodBankMS
{
    public partial class Doner : Form
    {
        public Doner()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Doner_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"DAta Source=" con);  // eijaygay vedio dekhe comment korte hbe
            con.open();
            SqlCommand cmd = new SqlComment(" select * from hospitaltab", con);
            sqlDataAdapter da = new sqlDataAdapterAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"DAta Source=" con);  // eijaygay vedio dekhe comment korte hbe
            con.open();
            SqlCommand cmd = new SqlComment(" // eijaygay code likhte hbe" con);
            cmd.Parameters.Addwithvalue("@DonarID" int.Parse(textBox1.Text));
            cmd.Parameters.Addwithvalue("@DonerName", textBox3.Text);
            cmd.Parameters.Addwithvalue("@Gender", textBox3.Text);
            cmd.Parameters.Addwithvalue("@Address", textBox4.Text);
            cmd.Parameters.Addwithvalue("@Phone", textBox5.Text);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("REcord Inserted Successfully");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"DAta Source=" con);  // eijaygay vedio dekhe comment korte hbe
            con.open();
            SqlCommand cmd = new SqlComment(" // eijaygay code likhte hbe" con);
            cmd.Parameters.Addwithvalue("@DonarID" int.Parse(textBox1.Text));
            cmd.Parameters.Addwithvalue("@DonerName", textBox3.Text);
            cmd.Parameters.Addwithvalue("@Gender", textBox3.Text);
            cmd.Parameters.Addwithvalue("@Address", textBox4.Text);
            cmd.Parameters.Addwithvalue("@Phone", textBox5.Text);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("REcord Inserted Successfully");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"DAta Source=" con);  // eijaygay vedio dekhe comment korte hbe
            con.open();
            SqlCommand cmd = new SqlComment(" // eijaygay code likhte hbe" con);
            cmd.Parameters.Addwithvalue("@DonarID" int.Parse(textBox1.Text));
            
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("REcord delete Successfully");
        }
    }
}
