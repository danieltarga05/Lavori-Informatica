namespace Data_Visuale
{
    public partial class Form1 : Form
    {
        
        int data, giorno, mese, anno;
        string meses;

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

            data = int.Parse(textBox1.Text);
            int dataSenzaGiorno, dataSenzaMese;
            giorno = data / 1000000;
            dataSenzaGiorno = data % 1000000;
            mese = dataSenzaGiorno / 10000;
            dataSenzaMese = mese % 10000;
            anno = dataSenzaMese;
            
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                switch(mese)
                {
                    case 1: meses = "Gennaio"; break;
                    case 2: meses = "Febbraio"; break;
                    case 3: meses = "MArzo"; break;
                    case 4: meses = "Aprile"; break;
                    case 5: meses = "Maggio"; break;
                    case 6: meses = "Giugno"; break;
                    case 7: meses = "Luglio"; break;
                    case 8: meses = "Agosto"; break;
                    case 9: meses = "Settembre"; break;
                    case 10: meses = "Ottobre"; break;
                    case 11: meses = "Novembre"; break;
                    case 12: meses = "Dicembre"; break;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((anno % 4 == 0 && anno % 100 != 0) || anno % 400 == 0 || giorno>0 && giorno < 32 || mese >0 && mese<13)
            {
                MessageBox.Show("Data inserita correttamente", "Corretto", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Data inserita erroneamente", "Corretto", MessageBoxButtons.OK);
            }

        }

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}