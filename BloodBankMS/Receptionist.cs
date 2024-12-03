using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Data.SqlClient

using System.Xml;

namespace BloodBankMS
{
    public partial class Receptionist : Form
    {
        public Receptionist()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-HEEKBHE\SQLEXPRESS;Initial Catalog=hospitaldb;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into receptab values(@rid,@name,@address,@phone)", con);
            cmd.Parameters.AddWithValue("@RID", int.Parse(textBox1.Text));
            cmd.Parameters.AddWithValue("@Name", textBox2.Text);
            cmd.Parameters.AddWithValue("@Address", textBox3.Text);
            cmd.Parameters.AddWithValue("@Phone", textBox4.Text);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Record Inserted Successfully");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-HEEKBHE\SQLEXPRESS;Initial Catalog=hospitaldb;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("update recepted set name=@name,address=@adress,phone=@phone where rid=@rid)", con);
            cmd.Parameters.AddWithValue("@RID", int.Parse(textBox1.Text));
            cmd.Parameters.AddWithValue("@Name", textBox2.Text);
            cmd.Parameters.AddWithValue("@Address", textBox3.Text);
            cmd.Parameters.AddWithValue("@Phone", textBox4.Text);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Record Updated Successfully");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-HEEKBHE\SQLEXPRESS;Initial Catalog=hospitaldb;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("delete receptab where rid = @rid)", con);
            cmd.Parameters.AddWithValue("@RID", int.Parse(textBox1.Text));

            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Record Deleted Successfully");
        }

        private void Receptionist_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"DAta Source=" con);  // eijaygay vedio dekhe comment korte hbe
            con.open();
            SqlCommand cmd = new SqlComment(" select * from receptab", con);
            sqlDataAdapter da = new sqlDataAdapterAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
    }
}
