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

namespace FlottaNavake
{
    public partial class InserimentoNave : Form
    {
        public StatoNave stato;
        public InserimentoNave()
        {
            InitializeComponent();
        }

        private void InserimentoNave_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length < 21 || textbox3.Text.Length < 5 || textBox2.Text.Length < 4)
                Close();
            else
                MessageBox.Show("Hai errato in qualcosa");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            stato = (StatoNave)comboBox1.SelectedIndex;
        }

        private void TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void TextBox_KeyPress2(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || char.IsSymbol(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
