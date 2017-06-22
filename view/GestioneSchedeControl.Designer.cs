namespace Trainary.view
{
    partial class GestioneSchedeControl
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

        #region Codice generato da Progettazione componenti

        /// <summary> 
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare 
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel2 = new System.Windows.Forms.Panel();
            this.listView1 = new System.Windows.Forms.ListView();
            this._nome = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this._scopo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this._descrizione = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this._periodo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this._rimuoviSchedaButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this._allenamentiLabel = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel2.Controls.Add(this.listView1);
            this.panel2.Location = new System.Drawing.Point(10, 113);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(649, 260);
            this.panel2.TabIndex = 1;
            // 
            // listView1
            // 
            this.listView1.Alignment = System.Windows.Forms.ListViewAlignment.Left;
            this.listView1.BackColor = System.Drawing.SystemColors.Window;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this._nome,
            this._scopo,
            this._descrizione,
            this._periodo});
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.Location = new System.Drawing.Point(0, 0);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(649, 260);
            this.listView1.TabIndex = 34;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged_1);
            // 
            // _nome
            // 
            this._nome.Text = "Nome";
            this._nome.Width = 124;
            // 
            // _scopo
            // 
            this._scopo.Text = "Scopo";
            this._scopo.Width = 144;
            // 
            // _descrizione
            // 
            this._descrizione.Text = "Descrizione";
            this._descrizione.Width = 173;
            // 
            // _periodo
            // 
            this._periodo.Text = "Periodo di validità";
            this._periodo.Width = 164;
            // 
            // _rimuoviSchedaButton
            // 
            this._rimuoviSchedaButton.Location = new System.Drawing.Point(519, 66);
            this._rimuoviSchedaButton.Name = "_rimuoviSchedaButton";
            this._rimuoviSchedaButton.Size = new System.Drawing.Size(103, 23);
            this._rimuoviSchedaButton.TabIndex = 34;
            this._rimuoviSchedaButton.Text = "Rimuovi ";
            this._rimuoviSchedaButton.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(519, 33);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 26);
            this.button1.TabIndex = 33;
            this.button1.Text = "Nuova scheda";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // _allenamentiLabel
            // 
            this._allenamentiLabel.AutoSize = true;
            this._allenamentiLabel.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._allenamentiLabel.Location = new System.Drawing.Point(286, 73);
            this._allenamentiLabel.Name = "_allenamentiLabel";
            this._allenamentiLabel.Size = new System.Drawing.Size(73, 18);
            this._allenamentiLabel.TabIndex = 32;
            this._allenamentiLabel.Text = "Schede:";
            this._allenamentiLabel.Click += new System.EventHandler(this._allenamentiLabel_Click);
            // 
            // GestioneSchedeControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.Controls.Add(this._rimuoviSchedaButton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this._allenamentiLabel);
            this.Controls.Add(this.panel2);
            this.Name = "GestioneSchedeControl";
            this.Size = new System.Drawing.Size(678, 395);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader _nome;
        private System.Windows.Forms.ColumnHeader _scopo;
        private System.Windows.Forms.ColumnHeader _descrizione;
        private System.Windows.Forms.ColumnHeader _periodo;
        private System.Windows.Forms.Button _rimuoviSchedaButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label _allenamentiLabel;
    }
}
