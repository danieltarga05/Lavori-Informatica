using System.Diagnostics.CodeAnalysis;

namespace Studente
{
    public partial class Form1 : Form
    {
        struct studenti
        {
            public string nome;
            public double voto;
            public override string ToString()
            {
                return nome + " " + voto;
            }
        }
        public Form1()
        {
            InitializeComponent();
        }
        List<studenti> studentiList = new List<studenti>();
        private void button1_Click(object sender, EventArgs e)
        {
            studenti s = new studenti();
            string[] tmp  = new string[3];
            tmp = txt_studenti.Text.Split(' ');

            bool controllo = ShowContato(tmp);

            if (controllo)
            {
                Studente.DataSource = null;
                s.nome = tmp[0] + tmp[1];
                s.voto = double.Parse(tmp[2]);
                studentiList.Add(s);
                studentiList.ForEach(c => Studente.Items.Add(c.nome + " " + c.voto));
                Studente.DataSource = studentiList.FindAll(x => x.voto >= 7 && x.voto<=10);
            }
            else 
            {
                MessageBox.Show("Banane, Lamponi");
            }

            txt_studenti.Clear();
        }
        bool ShowContato(string[] vettore)
        {
            double contato = 0;

            if (!double.TryParse(vettore[2], out contato))
            {
                return false;
            }
            if (string.IsNullOrEmpty(vettore[0]) || string.IsNullOrEmpty(vettore[1]))
            {
                return false;
            }

            return true;
        }
    }
}