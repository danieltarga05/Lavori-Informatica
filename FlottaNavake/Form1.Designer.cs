namespace FlottaNavake
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.creaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.naveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inserisciToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificaStatoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comandanteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inserisciToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Stazza = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Velocità = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Stato = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.naveToolStripMenuItem,
            this.comandanteToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.creaToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // creaToolStripMenuItem
            // 
            this.creaToolStripMenuItem.Name = "creaToolStripMenuItem";
            this.creaToolStripMenuItem.Size = new System.Drawing.Size(98, 22);
            this.creaToolStripMenuItem.Text = "Crea";
            this.creaToolStripMenuItem.Click += new System.EventHandler(this.creaToolStripMenuItem_Click);
            // 
            // naveToolStripMenuItem
            // 
            this.naveToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inserisciToolStripMenuItem,
            this.modificaStatoToolStripMenuItem});
            this.naveToolStripMenuItem.Name = "naveToolStripMenuItem";
            this.naveToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.naveToolStripMenuItem.Text = "Nave";
            this.naveToolStripMenuItem.Click += new System.EventHandler(this.naveToolStripMenuItem_Click);
            // 
            // inserisciToolStripMenuItem
            // 
            this.inserisciToolStripMenuItem.Name = "inserisciToolStripMenuItem";
            this.inserisciToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.inserisciToolStripMenuItem.Text = "Inserisci";
            this.inserisciToolStripMenuItem.Click += new System.EventHandler(this.inserisciToolStripMenuItem_Click);
            // 
            // modificaStatoToolStripMenuItem
            // 
            this.modificaStatoToolStripMenuItem.Name = "modificaStatoToolStripMenuItem";
            this.modificaStatoToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.modificaStatoToolStripMenuItem.Text = "Modifica Stato";
            this.modificaStatoToolStripMenuItem.Click += new System.EventHandler(this.modificaStatoToolStripMenuItem_Click);
            // 
            // comandanteToolStripMenuItem
            // 
            this.comandanteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inserisciToolStripMenuItem1});
            this.comandanteToolStripMenuItem.Name = "comandanteToolStripMenuItem";
            this.comandanteToolStripMenuItem.Size = new System.Drawing.Size(88, 20);
            this.comandanteToolStripMenuItem.Text = "Comandante";
            // 
            // inserisciToolStripMenuItem1
            // 
            this.inserisciToolStripMenuItem1.Name = "inserisciToolStripMenuItem1";
            this.inserisciToolStripMenuItem1.Size = new System.Drawing.Size(116, 22);
            this.inserisciToolStripMenuItem1.Text = "Inserisci";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nome,
            this.Stazza,
            this.Velocità,
            this.Stato});
            this.dataGridView1.Location = new System.Drawing.Point(174, 138);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(443, 150);
            this.dataGridView1.TabIndex = 1;
            // 
            // Nome
            // 
            this.Nome.HeaderText = "Nome";
            this.Nome.Name = "Nome";
            // 
            // Stazza
            // 
            this.Stazza.HeaderText = "Stazza";
            this.Stazza.Name = "Stazza";
            // 
            // Velocità
            // 
            this.Velocità.HeaderText = "Velocità";
            this.Velocità.Name = "Velocità";
            // 
            // Stato
            // 
            this.Stato.HeaderText = "Stato";
            this.Stato.Name = "Stato";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(171, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Flotta: ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem naveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem comandanteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inserisciToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inserisciToolStripMenuItem1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Stazza;
        private System.Windows.Forms.DataGridViewTextBoxColumn Velocità;
        private System.Windows.Forms.DataGridViewTextBoxColumn Stato;
        private System.Windows.Forms.ToolStripMenuItem creaToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem modificaStatoToolStripMenuItem;
    }
}

