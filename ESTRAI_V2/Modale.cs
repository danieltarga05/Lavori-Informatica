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
    public partial class Modale : Form
    {
        public int estrazione;
        public Modale()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(textBox1.Text, out estrazione) || estrazione < 0 || estrazione > 91)
                MessageBox.Show("Hai sbagliato");
            else
                Close();
        }
    }
}
