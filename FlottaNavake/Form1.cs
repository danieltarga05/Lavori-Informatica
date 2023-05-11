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
    public partial class Form1 : Form                                                
    {
        List<Nave> Nave = new List<Nave>();
        public Form1()
        {
            InitializeComponent();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            label1.Visible = false;
        }

        private void naveToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void inserisciToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InserimentoNave fm = new InserimentoNave();
            fm.ShowDialog();
            Nave n = new Nave(fm.textBox1.Text, fm.textbox3.Text, fm.textBox2.Text, fm.stato);
            if (n.AggiungiNave(n))
                dataGridView1.Rows.Add(n.Nome, n.Stazza, n.Velocita, n.StatoNave);
            else
                throw new Exception("Errore");
            
        }
        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void creaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InsFlotta fm = new InsFlotta();
            fm.ShowDialog();
            Flotta fl = new Flotta(fm.textBox1.Text, fm.textBox2.Text, fm.textBox3.Text);
            fm.textBox1.Text = fl.FLotta;
            fm.textBox2.Text = fl.Armatore;
            fm.textBox3.Text = fl.Sede;
            label1.Visible = true;
            label1.Text = $"Flotta : {fl.FLotta}, Armatore: {fl.Armatore}, Sede: {fl.Sede}";

        }

        private void modificaStatoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int indice = (Nave.FindIndex(tmp => tmp == Nave[dataGridView1.CurrentRow.Index]));
            ModStato fm = new ModStato();
            fm.ShowDialog();
            
                if (Nave[indice].StatoNave == StatoNave.Demolita)
                {
                    MessageBox.Show("Errore");
                }
                else
                {
                    if (indice == -1)
                    {
                        MessageBox.Show("Errore");
                    }
                    else
                    {
                        Nave[indice].StatoNave = fm.stato;
                        dataGridView1.Rows.Insert(dataGridView1.CurrentRow.Index, fm.stato);
                        dataGridView1.Rows.Remove(dataGridView1.CurrentRow);


                    }
                }
            }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}