namespace Arac_Kullanimlari
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Mesaj Kutusu Açýldý");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label2.Text = "Cem";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label6.Text = "Cem";
            label7.Text = "Soyad";
            label8.Text = "Fizik Mühendisi";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = "Fizik Mühendisliði";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox2.Text = "Aydýnlýk";
            label9.Text = textBox2.Text;

            textBox3.Text = "BART";


        }
        private void button6_Click(object sender, EventArgs e)
        {
            label11.Text = textBox5.Text;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Mesaj Kutusu Açtýn");
            label12.Text = textBox4.Text;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            label13.Text= textBox6.Text;
            MessageBox.Show("Element Deðiþtirildi");
        }
    }
}