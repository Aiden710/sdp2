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
    public partial class Hospital : Form
    {
        public Hospital()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"DAta Source=" con);  // eijaygay vedio dekhe comment korte hbe
            con.open();
            SqlCommand cmd = new SqlComment(" // eijaygay code likhte hbe" con);
            cmd.Parameters.Addwithvalue("@Name" int.Parse(textBox1.Text));
            cmd.Parameters.Addwithvalue("@Adress", textBox3.Text);
            cmd.Parameters.Addwithvalue("@Email", textBox3.Text);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("REcord Inserted Successfully");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"DAta Source=" con);  // eijaygay vedio dekhe comment korte hbe
            con.open();
            SqlCommand cmd = new SqlComment(" // eijaygay code likhte hbe" con);

            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Record Deleted  Successfully");
        }

        private void Hospital_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"DAta Source=" con);  // eijaygay vedio dekhe comment korte hbe
            con.open();
            SqlCommand cmd = new SqlComment(" select * from hospitaltab", con);
            sqlDataAdapter da = new sqlDataAdapterAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;

        }
    }
}
