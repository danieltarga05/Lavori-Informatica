namespace Studente
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txt_studenti = new System.Windows.Forms.TextBox();
            this.Studente = new System.Windows.Forms.ListBox();
            this.btn_carica = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_studenti
            // 
            this.txt_studenti.Location = new System.Drawing.Point(219, 72);
            this.txt_studenti.Name = "txt_studenti";
            this.txt_studenti.Size = new System.Drawing.Size(159, 23);
            this.txt_studenti.TabIndex = 0;
            // 
            // Studente
            // 
            this.Studente.FormattingEnabled = true;
            this.Studente.ItemHeight = 15;
            this.Studente.Location = new System.Drawing.Point(219, 130);
            this.Studente.Name = "Studente";
            this.Studente.Size = new System.Drawing.Size(120, 169);
            this.Studente.TabIndex = 2;
            // 
            // btn_carica
            // 
            this.btn_carica.Location = new System.Drawing.Point(219, 101);
            this.btn_carica.Name = "btn_carica";
            this.btn_carica.Size = new System.Drawing.Size(75, 23);
            this.btn_carica.TabIndex = 3;
            this.btn_carica.Text = "carica";
            this.btn_carica.UseVisualStyleBackColor = true;
            this.btn_carica.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_carica);
            this.Controls.Add(this.Studente);
            this.Controls.Add(this.txt_studenti);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txt_studenti;
        private ListBox Studente;
        private Button btn_carica;
    }
}