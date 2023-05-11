using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ESTRAI_V2
{
    public partial class Form1 : Form
    {
        int estrazione;
        List<int> s = new List<int>();
        List<int> lotto = new List<int>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void visualizzaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random estratti = new Random();
            estrazione = estratti.Next(1, 91);
            int max = 6;
            while (lotto.Exists(tmp => tmp == estrazione))// finchè contiene gli elementi nella nostra lista, estraiamo i numeri
            {
                estrazione = estratti.Next(1, 91);
            }
            lotto.Add(estrazione);
            if (lotto.Count == max)//quando la lista avrà raggiunto il massimo, mi fermo
            {
                MessageBox.Show("Estratti tutti i numeri");
                button1.Enabled = false;
            }
            else
            {// scrivo i valori nella textbox con un foreach
                textBox1.Text = "";
                lotto.ForEach(tmp => textBox1.Text += tmp.ToString() + " ");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Modale fm = new Modale();
            List<int> supporto = new List<int>();
            supporto = s.FindAll(tmp => lotto.Contains(tmp));
            if (supporto.Count == 2)
                MessageBox.Show("Hai fatto ambo");
            else if (supporto.Count == 3)
                MessageBox.Show("Hai fatto terna");
            else if (supporto.Count == 4)
                MessageBox.Show("Hai fatto quaterna");
            else if (supporto.Count == 5)
                MessageBox.Show("Hai fatto cinquina");
            else
                MessageBox.Show("Non hai vinto");
        }

        private void estraiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int max = 6;//valore per il controllo del riempimento della textbox
            Random num = new Random();
            Modale fm = new Modale();
            fm.ShowDialog();
            while (s.Exists(tmp => tmp == fm.estrazione))// finchè contiene gli elementi nella nostra lista, estraiamo i numeri
            {
                fm.estrazione = int.Parse(textBox2.Text);
            }
            s.Add(fm.estrazione);
            if (s.Count == max)//quando la lista avrà raggiunto il massimo, mi fermo
            {
                MessageBox.Show("Estratti tutti i numeri");

            }
            else
            {// scrivo i valori nella textbox con un foreach
                textBox2.Text = "";
                s.ForEach(tmp => textBox2.Text += tmp.ToString() + " ");
            }
        }
    }
}
