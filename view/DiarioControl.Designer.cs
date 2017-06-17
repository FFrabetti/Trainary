namespace Trainary.view
{
    partial class DiarioControl
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
            this._filtriLabel = new System.Windows.Forms.Label();
            this._okButton = new System.Windows.Forms.Button();
            this._panel = new System.Windows.Forms.Panel();
            this._annullaButton = new System.Windows.Forms.Button();
            this._allenamentiLabel = new System.Windows.Forms.Label();
            this._comboBox = new System.Windows.Forms.ComboBox();
            this._selezionaFiltroLabel = new System.Windows.Forms.Label();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // _filtriLabel
            // 
            this._filtriLabel.AutoSize = true;
            this._filtriLabel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this._filtriLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._filtriLabel.Location = new System.Drawing.Point(3, 241);
            this._filtriLabel.Name = "_filtriLabel";
            this._filtriLabel.Size = new System.Drawing.Size(0, 15);
            this._filtriLabel.TabIndex = 25;
            // 
            // _okButton
            // 
            this._okButton.Location = new System.Drawing.Point(283, 141);
            this._okButton.Name = "_okButton";
            this._okButton.Size = new System.Drawing.Size(75, 23);
            this._okButton.TabIndex = 24;
            this._okButton.Text = "OK";
            this._okButton.UseVisualStyleBackColor = true;
            // 
            // _panel
            // 
            this._panel.Location = new System.Drawing.Point(28, 41);
            this._panel.Name = "_panel";
            this._panel.Size = new System.Drawing.Size(330, 94);
            this._panel.TabIndex = 23;
            // 
            // _annullaButton
            // 
            this._annullaButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._annullaButton.Location = new System.Drawing.Point(283, 12);
            this._annullaButton.Name = "_annullaButton";
            this._annullaButton.Size = new System.Drawing.Size(75, 23);
            this._annullaButton.TabIndex = 20;
            this._annullaButton.Text = "Annulla";
            this._annullaButton.UseVisualStyleBackColor = true;
            // 
            // _allenamentiLabel
            // 
            this._allenamentiLabel.AutoSize = true;
            this._allenamentiLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._allenamentiLabel.Location = new System.Drawing.Point(7, 210);
            this._allenamentiLabel.Name = "_allenamentiLabel";
            this._allenamentiLabel.Size = new System.Drawing.Size(139, 18);
            this._allenamentiLabel.TabIndex = 19;
            this._allenamentiLabel.Text = "Allenamenti svolti";
            // 
            // _comboBox
            // 
            this._comboBox.BackColor = System.Drawing.Color.White;
            this._comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._comboBox.ForeColor = System.Drawing.Color.Black;
            this._comboBox.FormattingEnabled = true;
            this._comboBox.Location = new System.Drawing.Point(122, 12);
            this._comboBox.Name = "_comboBox";
            this._comboBox.Size = new System.Drawing.Size(155, 21);
            this._comboBox.TabIndex = 18;
            // 
            // _selezionaFiltroLabel
            // 
            this._selezionaFiltroLabel.AutoSize = true;
            this._selezionaFiltroLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._selezionaFiltroLabel.Location = new System.Drawing.Point(6, 14);
            this._selezionaFiltroLabel.Name = "_selezionaFiltroLabel";
            this._selezionaFiltroLabel.Size = new System.Drawing.Size(113, 19);
            this._selezionaFiltroLabel.TabIndex = 17;
            this._selezionaFiltroLabel.Text = "Seleziona filtro:";
            // 
            // listBox2
            // 
            this.listBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(3, 3);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(538, 108);
            this.listBox2.TabIndex = 28;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this._selezionaFiltroLabel);
            this.panel1.Controls.Add(this._comboBox);
            this.panel1.Controls.Add(this._filtriLabel);
            this.panel1.Controls.Add(this._annullaButton);
            this.panel1.Controls.Add(this._allenamentiLabel);
            this.panel1.Controls.Add(this._okButton);
            this.panel1.Controls.Add(this._panel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(3);
            this.panel1.Size = new System.Drawing.Size(544, 259);
            this.panel1.TabIndex = 29;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.listBox2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 259);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(3);
            this.panel2.Size = new System.Drawing.Size(544, 114);
            this.panel2.TabIndex = 30;
            // 
            // DiarioControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "DiarioControl";
            this.Size = new System.Drawing.Size(544, 373);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label _filtriLabel;
        private System.Windows.Forms.Button _okButton;
        private System.Windows.Forms.Panel _panel;
        private System.Windows.Forms.Button _annullaButton;
        private System.Windows.Forms.Label _allenamentiLabel;
        private System.Windows.Forms.ComboBox _comboBox;
        private System.Windows.Forms.Label _selezionaFiltroLabel;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}
