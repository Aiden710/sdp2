namespace BloodBankMS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hospital h1 = new Hospital();
            h1.Show();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Doner dr = new Doner();
            dr.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Blood bd = new Blood();
            bd.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Receptionist rt = new Receptionist();
            rt.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Bank bk = new Bank();
            bk.Show();  
        }
    }
}
