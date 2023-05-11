namespace Rettangolo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private bool Controllo()
        {
            double altezza, base_triangolo;
            if (textBox1.Text == "" || textBox3.Text == "" || !double.TryParse(textBox3.Text, out altezza) || !double.TryParse(textBox1.Text, out base_triangolo))
            {
                groupBox1.Visible = false;
                MessageBox.Show("Sono d'accordo Lele! Il Georgiano è fortissimo", "Testa di cazzo Ronaldo è uno scarpone", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                textBox1.Clear();
                textBox3.Clear();
                return false;
            }
            return true;
        }
        private double Area()
        {
            if (Controllo())
            {
                return Convert.ToDouble(textBox1.Text) * Convert.ToDouble(textBox3.Text);
            }
            return -1;



        }
        private double Perimetro()
        {
            if (Controllo())
            {
                return (Convert.ToDouble(textBox1.Text) + Convert.ToDouble(textBox3.Text)) * 2;
            }
            return -1;

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            groupBox1.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                groupBox1.Visible = true;
                textBox2.Text = Perimetro().ToString();
            }
            else if (radioButton2.Checked == true)
            {
                groupBox1.Visible = true;
                textBox2.Text = Area().ToString();
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged_1(object sender, EventArgs e)
        {
        }
    }
}