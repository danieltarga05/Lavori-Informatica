using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlottaNavake
{
    public partial class ModStato : Form
    {
        public StatoNave stato;
        public ModStato()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

                stato = (StatoNave)comboBox1.SelectedIndex;
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ModStato_Load(object sender, EventArgs e)
        {

        }
    }
}
