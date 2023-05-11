
namespace Tiro_a_segno
{
    partial class Main
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.btnClose = new System.Windows.Forms.Button();
            this.pnlArea = new System.Windows.Forms.Panel();
            this.pcFigura = new System.Windows.Forms.PictureBox();
            this.Step = new System.Windows.Forms.Timer(this.components);
            this.btnFacile = new System.Windows.Forms.RadioButton();
            this.btnMedio = new System.Windows.Forms.RadioButton();
            this.btnDifficile = new System.Windows.Forms.RadioButton();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.lblUccisioni = new System.Windows.Forms.Label();
            this.lblContUcc = new System.Windows.Forms.Label();
            this.btnMosca = new System.Windows.Forms.RadioButton();
            this.btnFarfalla = new System.Windows.Forms.RadioButton();
            this.btnApe = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnSTOP = new System.Windows.Forms.Button();
            this.pnlArea.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcFigura)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnClose.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.Black;
            this.btnClose.Location = new System.Drawing.Point(721, 386);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // pnlArea
            // 
            this.pnlArea.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlArea.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlArea.BackgroundImage")));
            this.pnlArea.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlArea.Controls.Add(this.pcFigura);
            this.pnlArea.Location = new System.Drawing.Point(12, 12);
            this.pnlArea.Name = "pnlArea";
            this.pnlArea.Size = new System.Drawing.Size(703, 397);
            this.pnlArea.TabIndex = 1;
            this.pnlArea.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // pcFigura
            // 
            this.pcFigura.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pcFigura.BackColor = System.Drawing.Color.Transparent;
            this.pcFigura.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pcFigura.BackgroundImage")));
            this.pcFigura.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pcFigura.Location = new System.Drawing.Point(654, 349);
            this.pcFigura.Name = "pcFigura";
            this.pcFigura.Size = new System.Drawing.Size(49, 48);
            this.pcFigura.TabIndex = 0;
            this.pcFigura.TabStop = false;
            this.pcFigura.Click += new System.EventHandler(this.pcFigura_Click);
            // 
            // Step
            // 
            this.Step.Interval = 1000;
            this.Step.Tick += new System.EventHandler(this.Step_Tick);
            // 
            // btnFacile
            // 
            this.btnFacile.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFacile.AutoSize = true;
            this.btnFacile.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnFacile.Location = new System.Drawing.Point(6, 19);
            this.btnFacile.Name = "btnFacile";
            this.btnFacile.Size = new System.Drawing.Size(53, 17);
            this.btnFacile.TabIndex = 2;
            this.btnFacile.Text = "Facile";
            this.btnFacile.UseVisualStyleBackColor = false;
            this.btnFacile.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // btnMedio
            // 
            this.btnMedio.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMedio.AutoSize = true;
            this.btnMedio.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnMedio.Location = new System.Drawing.Point(6, 55);
            this.btnMedio.Name = "btnMedio";
            this.btnMedio.Size = new System.Drawing.Size(54, 17);
            this.btnMedio.TabIndex = 3;
            this.btnMedio.Text = "Medio";
            this.btnMedio.UseVisualStyleBackColor = false;
            this.btnMedio.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // btnDifficile
            // 
            this.btnDifficile.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDifficile.AutoSize = true;
            this.btnDifficile.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnDifficile.Location = new System.Drawing.Point(6, 91);
            this.btnDifficile.Name = "btnDifficile";
            this.btnDifficile.Size = new System.Drawing.Size(59, 17);
            this.btnDifficile.TabIndex = 4;
            this.btnDifficile.Text = "Difficile";
            this.btnDifficile.UseVisualStyleBackColor = false;
            this.btnDifficile.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "mosca.gif");
            this.imageList1.Images.SetKeyName(1, "farfalla.gif");
            this.imageList1.Images.SetKeyName(2, "ape.gif");
            this.imageList1.Images.SetKeyName(3, "prato.gif");
            // 
            // lblUccisioni
            // 
            this.lblUccisioni.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUccisioni.AutoSize = true;
            this.lblUccisioni.Location = new System.Drawing.Point(721, 12);
            this.lblUccisioni.Name = "lblUccisioni";
            this.lblUccisioni.Size = new System.Drawing.Size(56, 13);
            this.lblUccisioni.TabIndex = 6;
            this.lblUccisioni.Text = "Uccisioni: ";
            // 
            // lblContUcc
            // 
            this.lblContUcc.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblContUcc.AutoSize = true;
            this.lblContUcc.Location = new System.Drawing.Point(775, 12);
            this.lblContUcc.Name = "lblContUcc";
            this.lblContUcc.Size = new System.Drawing.Size(13, 13);
            this.lblContUcc.TabIndex = 7;
            this.lblContUcc.Text = "0";
            this.lblContUcc.Click += new System.EventHandler(this.lblContUcc_Click);
            // 
            // btnMosca
            // 
            this.btnMosca.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMosca.AutoSize = true;
            this.btnMosca.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnMosca.Location = new System.Drawing.Point(6, 19);
            this.btnMosca.Name = "btnMosca";
            this.btnMosca.Size = new System.Drawing.Size(57, 17);
            this.btnMosca.TabIndex = 9;
            this.btnMosca.Text = "Mosca";
            this.btnMosca.UseVisualStyleBackColor = false;
            this.btnMosca.CheckedChanged += new System.EventHandler(this.btnMosca_CheckedChanged);
            // 
            // btnFarfalla
            // 
            this.btnFarfalla.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFarfalla.AutoSize = true;
            this.btnFarfalla.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnFarfalla.Location = new System.Drawing.Point(6, 56);
            this.btnFarfalla.Name = "btnFarfalla";
            this.btnFarfalla.Size = new System.Drawing.Size(59, 17);
            this.btnFarfalla.TabIndex = 10;
            this.btnFarfalla.Text = "Farfalla";
            this.btnFarfalla.UseVisualStyleBackColor = false;
            this.btnFarfalla.CheckedChanged += new System.EventHandler(this.btnFarfalla_CheckedChanged);
            // 
            // btnApe
            // 
            this.btnApe.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnApe.AutoSize = true;
            this.btnApe.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnApe.Location = new System.Drawing.Point(6, 91);
            this.btnApe.Name = "btnApe";
            this.btnApe.Size = new System.Drawing.Size(44, 17);
            this.btnApe.TabIndex = 11;
            this.btnApe.Text = "Ape";
            this.btnApe.UseVisualStyleBackColor = false;
            this.btnApe.CheckedChanged += new System.EventHandler(this.btnApe_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnFacile);
            this.groupBox1.Controls.Add(this.btnMedio);
            this.groupBox1.Controls.Add(this.btnDifficile);
            this.groupBox1.Location = new System.Drawing.Point(721, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(75, 114);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Difficoltà";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnMosca);
            this.groupBox2.Controls.Add(this.btnFarfalla);
            this.groupBox2.Controls.Add(this.btnApe);
            this.groupBox2.Location = new System.Drawing.Point(721, 148);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(75, 114);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Immagine";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // btnSTOP
            // 
            this.btnSTOP.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSTOP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnSTOP.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSTOP.ForeColor = System.Drawing.Color.Black;
            this.btnSTOP.Location = new System.Drawing.Point(721, 268);
            this.btnSTOP.Name = "btnSTOP";
            this.btnSTOP.Size = new System.Drawing.Size(75, 23);
            this.btnSTOP.TabIndex = 8;
            this.btnSTOP.Text = "STOP";
            this.btnSTOP.UseVisualStyleBackColor = false;
            this.btnSTOP.Click += new System.EventHandler(this.btnSTOP_Click);
            // 
            // Main
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSTOP);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblContUcc);
            this.Controls.Add(this.lblUccisioni);
            this.Controls.Add(this.pnlArea);
            this.Controls.Add(this.btnClose);
            this.Cursor = System.Windows.Forms.Cursors.Cross;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Main";
            this.Text = "MoscaKiller";
            this.HelpButtonClicked += new System.ComponentModel.CancelEventHandler(this.Main_HelpButtonClicked);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnlArea.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pcFigura)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private System.Windows.Forms.Panel pnlArea;
        private System.Windows.Forms.PictureBox pcFigura;
        private System.Windows.Forms.Timer Step;
        private System.Windows.Forms.RadioButton btnFacile;
        private System.Windows.Forms.RadioButton btnMedio;
        private System.Windows.Forms.RadioButton btnDifficile;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Label lblUccisioni;
        private System.Windows.Forms.Label lblContUcc;
        private System.Windows.Forms.RadioButton btnMosca;
        private System.Windows.Forms.RadioButton btnFarfalla;
        private System.Windows.Forms.RadioButton btnApe;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnSTOP;
    }
}

