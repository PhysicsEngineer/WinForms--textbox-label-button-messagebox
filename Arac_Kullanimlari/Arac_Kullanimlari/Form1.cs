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
            MessageBox.Show("Mesaj Kutusu A��ld�");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label2.Text = "Cem";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label6.Text = "Cem";
            label7.Text = "Soyad";
            label8.Text = "Fizik M�hendisi";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = "Fizik M�hendisli�i";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox2.Text = "Ayd�nl�k";
            label9.Text = textBox2.Text;

            textBox3.Text = "BART";


        }
        private void button6_Click(object sender, EventArgs e)
        {
            label11.Text = textBox5.Text;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Mesaj Kutusu A�t�n");
            label12.Text = textBox4.Text;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            label13.Text= textBox6.Text;
            MessageBox.Show("Element De�i�tirildi");
        }
    }
}