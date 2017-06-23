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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this._allenamentiLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this._rimuoviSchedaButton = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this._nome = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this._scopo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this._descrizione = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this._periodo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this._allenamentiLabel);
            this.splitContainer1.Panel1.Controls.Add(this.button1);
            this.splitContainer1.Panel1.Controls.Add(this._rimuoviSchedaButton);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.listView1);
            this.splitContainer1.Panel2.Padding = new System.Windows.Forms.Padding(20);
            this.splitContainer1.Size = new System.Drawing.Size(713, 507);
            this.splitContainer1.SplitterDistance = 100;
            this.splitContainer1.TabIndex = 35;
            // 
            // _allenamentiLabel
            // 
            this._allenamentiLabel.AutoSize = true;
            this._allenamentiLabel.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._allenamentiLabel.Location = new System.Drawing.Point(304, 71);
            this._allenamentiLabel.Name = "_allenamentiLabel";
            this._allenamentiLabel.Size = new System.Drawing.Size(73, 18);
            this._allenamentiLabel.TabIndex = 37;
            this._allenamentiLabel.Text = "Schede:";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(590, 63);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 26);
            this.button1.TabIndex = 38;
            this.button1.Text = "Nuova scheda";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // _rimuoviSchedaButton
            // 
            this._rimuoviSchedaButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._rimuoviSchedaButton.Location = new System.Drawing.Point(590, 34);
            this._rimuoviSchedaButton.Name = "_rimuoviSchedaButton";
            this._rimuoviSchedaButton.Size = new System.Drawing.Size(103, 23);
            this._rimuoviSchedaButton.TabIndex = 39;
            this._rimuoviSchedaButton.Text = "Rimuovi ";
            this._rimuoviSchedaButton.UseVisualStyleBackColor = true;
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
            this.listView1.Location = new System.Drawing.Point(20, 20);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(673, 363);
            this.listView1.TabIndex = 40;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
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
            // GestioneSchedeControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.Controls.Add(this.splitContainer1);
            this.Name = "GestioneSchedeControl";
            this.Size = new System.Drawing.Size(713, 507);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label _allenamentiLabel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button _rimuoviSchedaButton;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader _nome;
        private System.Windows.Forms.ColumnHeader _scopo;
        private System.Windows.Forms.ColumnHeader _descrizione;
        private System.Windows.Forms.ColumnHeader _periodo;
    }
}
