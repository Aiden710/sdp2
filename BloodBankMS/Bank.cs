using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace BloodBankMS
{
    public partial class Bank : Form
    {
        public Bank()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-HEEKBHE\SQLEXPRESS;Initial Catalog=blooddb;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("update banktab set bloodType=@bloodType,orders=@orders where bankID=@bankID", con);
            cmd.Parameters.AddWithValue("@BankID", int.Parse(textBox1.Text));
            cmd.Parameters.AddWithValue("@BloodType", textBox2.Text);
            cmd.Parameters.AddWithValue("@Orders", textBox3.Text);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Record Updated Successfully");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-HEEKBHE\SQLEXPRESS;Initial Catalog=blooddb;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("update banktab set bloodType=@bloodType,orders=@orders where bankID=@bankID", con);
            cmd.Parameters.AddWithValue("@BankID", int.Parse(textBox1.Text));
            cmd.Parameters.AddWithValue("@BloodType", textBox2.Text);
            cmd.Parameters.AddWithValue("@Orders", textBox3.Text);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Record Updated Successfully");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-HEEKBHE\SQLEXPRESS;Initial Catalog=bank;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("delete banktab where bankid=@bankid", con);
            cmd.Parameters.AddWithValue("@BankID", int.Parse(textBox1.Text));
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Record Deleted Successfully");
        }

        private void Bank_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"DAta Source=" con);  // eijaygay vedio dekhe comment korte hbe
            con.open();
            SqlCommand cmd = new SqlComment(" select * from banktab", con);
            sqlDataAdapter da = new sqlDataAdapterAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
    }
}
