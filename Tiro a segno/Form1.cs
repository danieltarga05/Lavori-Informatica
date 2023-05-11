using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tiro_a_segno
{
    public partial class Main : Form
    {
        private System.Windows.Forms.Button btnClose;
        Point Posizione;
        Random xy;
        int i = 0;
        public Main()
        {
            InitializeComponent();
            Posizione = new Point();
            xy = new Random();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            //Step.Interval = 500;
            //Step.Enabled=true;
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Step_Tick(object sender, EventArgs e)
        {
            //Step.Enabled = false;
            //MessageBox.Show("Tick","Messaggio",MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            Posizione.X = xy.Next(0, (pnlArea.ClientSize.Width-pcFigura.Width)+1);
            Posizione.Y = xy.Next(0, (pnlArea.ClientSize.Height - pcFigura.Height) + 1);
            pcFigura.Location = Posizione;

        }

        private void pcFigura_Click(object sender, EventArgs e)
        {
            if (btnFacile.Checked || btnMedio.Checked || btnDifficile.Checked && Step.Enabled)
            {
                lblContUcc.Text = i + "";
                i++;
            }            
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            Step.Interval = 1000;
            Step.Enabled = true;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            Step.Interval = 750;
            Step.Enabled = true;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            Step.Interval = 500;
            Step.Enabled=true;
        }

        private void lblContUcc_Click(object sender, EventArgs e)
        {

        }

        private void btnMosca_CheckedChanged(object sender, EventArgs e)
        {
            pcFigura.BackgroundImage = imageList1.Images[0];
        }

        private void btnFarfalla_CheckedChanged(object sender, EventArgs e)
        {
            pcFigura.BackgroundImage = imageList1.Images[1];
        }

        private void btnApe_CheckedChanged(object sender, EventArgs e)
        {
            pcFigura.BackgroundImage = imageList1.Images[2];
        }

        private void btnBassa_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnAlta_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void Main_HelpButtonClicked(object sender, CancelEventArgs e)
        {
        }

        private void btnSTOP_Click(object sender, EventArgs e)
        {
            btnFacile.Checked = false;
            btnDifficile.Checked = false;
            btnMedio.Checked = false;
            Step.Enabled = false;
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
