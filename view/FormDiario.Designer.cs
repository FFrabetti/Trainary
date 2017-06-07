namespace Trainary
{
    partial class FormDiario
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
            this._selezionaFiltroLabel = new System.Windows.Forms.Label();
            this._comboBox = new System.Windows.Forms.ComboBox();
            this._allenamentiLabel = new System.Windows.Forms.Label();
            this._annullaButton = new System.Windows.Forms.Button();
            this._listView = new System.Windows.Forms.ListView();
            this._dataColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this._nomeColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this._indietroButton = new System.Windows.Forms.Button();
            this._panel = new System.Windows.Forms.Panel();
            this._okButton = new System.Windows.Forms.Button();
            this._filtriLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // _selezionaFiltroLabel
            // 
            this._selezionaFiltroLabel.AutoSize = true;
            this._selezionaFiltroLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._selezionaFiltroLabel.Location = new System.Drawing.Point(22, 21);
            this._selezionaFiltroLabel.Name = "_selezionaFiltroLabel";
            this._selezionaFiltroLabel.Size = new System.Drawing.Size(113, 19);
            this._selezionaFiltroLabel.TabIndex = 0;
            this._selezionaFiltroLabel.Text = "Seleziona filtro:";
            // 
            // _comboBox
            // 
            this._comboBox.BackColor = System.Drawing.Color.White;
            this._comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._comboBox.ForeColor = System.Drawing.Color.Black;
            this._comboBox.FormattingEnabled = true;
            this._comboBox.Location = new System.Drawing.Point(153, 19);
            this._comboBox.Name = "_comboBox";
            this._comboBox.Size = new System.Drawing.Size(155, 21);
            this._comboBox.TabIndex = 1;
            this._comboBox.SelectedIndexChanged += new System.EventHandler(this._comboBox_SelectedIndexChanged);
            // 
            // _allenamentiLabel
            // 
            this._allenamentiLabel.AutoSize = true;
            this._allenamentiLabel.Font = new System.Drawing.Font("Lucida Fax", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._allenamentiLabel.Location = new System.Drawing.Point(56, 196);
            this._allenamentiLabel.Name = "_allenamentiLabel";
            this._allenamentiLabel.Size = new System.Drawing.Size(150, 17);
            this._allenamentiLabel.TabIndex = 4;
            this._allenamentiLabel.Text = "Allenamenti svolti";
            // 
            // _annullaButton
            // 
            this._annullaButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._annullaButton.Location = new System.Drawing.Point(326, 17);
            this._annullaButton.Name = "_annullaButton";
            this._annullaButton.Size = new System.Drawing.Size(75, 23);
            this._annullaButton.TabIndex = 6;
            this._annullaButton.Text = "Annulla";
            this._annullaButton.UseVisualStyleBackColor = true;
            this._annullaButton.Click += new System.EventHandler(this._annullaButton_Click);
            // 
            // _listView
            // 
            this._listView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this._listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this._dataColumn,
            this._nomeColumn});
            this._listView.FullRowSelect = true;
            this._listView.GridLines = true;
            this._listView.Location = new System.Drawing.Point(49, 234);
            this._listView.MultiSelect = false;
            this._listView.Name = "_listView";
            this._listView.Size = new System.Drawing.Size(444, 200);
            this._listView.TabIndex = 7;
            this._listView.UseCompatibleStateImageBehavior = false;
            this._listView.View = System.Windows.Forms.View.Details;
            this._listView.SelectedIndexChanged += new System.EventHandler(this._listView_SelectedIndexChanged);
            // 
            // _dataColumn
            // 
            this._dataColumn.Text = "Data";
            this._dataColumn.Width = 193;
            // 
            // _nomeColumn
            // 
            this._nomeColumn.Text = "Nome";
            this._nomeColumn.Width = 243;
            // 
            // _indietroButton
            // 
            this._indietroButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._indietroButton.Location = new System.Drawing.Point(441, 449);
            this._indietroButton.Name = "_indietroButton";
            this._indietroButton.Size = new System.Drawing.Size(75, 23);
            this._indietroButton.TabIndex = 8;
            this._indietroButton.Text = "Indietro";
            this._indietroButton.UseVisualStyleBackColor = true;
            // 
            // _panel
            // 
            this._panel.Location = new System.Drawing.Point(71, 46);
            this._panel.Name = "_panel";
            this._panel.Size = new System.Drawing.Size(330, 94);
            this._panel.TabIndex = 9;
            // 
            // _okButton
            // 
            this._okButton.Location = new System.Drawing.Point(326, 146);
            this._okButton.Name = "_okButton";
            this._okButton.Size = new System.Drawing.Size(75, 23);
            this._okButton.TabIndex = 15;
            this._okButton.Text = "OK";
            this._okButton.UseVisualStyleBackColor = true;
            this._okButton.Click += new System.EventHandler(this._okButton_Click);
            // 
            // _filtriLabel
            // 
            this._filtriLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._filtriLabel.Location = new System.Drawing.Point(228, 187);
            this._filtriLabel.Name = "_filtriLabel";
            this._filtriLabel.Size = new System.Drawing.Size(215, 44);
            this._filtriLabel.TabIndex = 16;
            // 
            // FormDiario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(534, 482);
            this.Controls.Add(this._filtriLabel);
            this.Controls.Add(this._okButton);
            this.Controls.Add(this._panel);
            this.Controls.Add(this._indietroButton);
            this.Controls.Add(this._listView);
            this.Controls.Add(this._annullaButton);
            this.Controls.Add(this._allenamentiLabel);
            this.Controls.Add(this._comboBox);
            this.Controls.Add(this._selezionaFiltroLabel);
            this.Name = "FormDiario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Diario";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label _selezionaFiltroLabel;
        private System.Windows.Forms.ComboBox _comboBox;
        private System.Windows.Forms.Label _allenamentiLabel;
        private System.Windows.Forms.Button _annullaButton;
        private System.Windows.Forms.ListView _listView;
        private System.Windows.Forms.ColumnHeader _dataColumn;
        private System.Windows.Forms.Button _indietroButton;
        private System.Windows.Forms.Panel _panel;
        private System.Windows.Forms.Button _okButton;
        private System.Windows.Forms.Label _filtriLabel;
        private System.Windows.Forms.ColumnHeader _nomeColumn;
    }
}
