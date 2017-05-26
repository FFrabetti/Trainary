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
            this.listView1 = new System.Windows.Forms.ListView();
            this.Tipo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Data = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this._indietroButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // _selezionaFiltroLabel
            // 
            this._selezionaFiltroLabel.AutoSize = true;
            this._selezionaFiltroLabel.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._selezionaFiltroLabel.Location = new System.Drawing.Point(89, 18);
            this._selezionaFiltroLabel.Name = "_selezionaFiltroLabel";
            this._selezionaFiltroLabel.Size = new System.Drawing.Size(109, 17);
            this._selezionaFiltroLabel.TabIndex = 0;
            this._selezionaFiltroLabel.Text = "Seleziona filtro:";
            // 
            // _comboBox
            // 
            this._comboBox.BackColor = System.Drawing.Color.White;
            this._comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._comboBox.ForeColor = System.Drawing.Color.Black;
            this._comboBox.FormattingEnabled = true;
            this._comboBox.Location = new System.Drawing.Point(215, 14);
            this._comboBox.Name = "_comboBox";
            this._comboBox.Size = new System.Drawing.Size(155, 21);
            this._comboBox.TabIndex = 1;
            // 
            // _allenamentiLabel
            // 
            this._allenamentiLabel.AutoSize = true;
            this._allenamentiLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._allenamentiLabel.Location = new System.Drawing.Point(229, 52);
            this._allenamentiLabel.Name = "_allenamentiLabel";
            this._allenamentiLabel.Size = new System.Drawing.Size(118, 16);
            this._allenamentiLabel.TabIndex = 4;
            this._allenamentiLabel.Text = "Allenamenti svolti: ";
            // 
            // _annullaButton
            // 
            this._annullaButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._annullaButton.Location = new System.Drawing.Point(388, 12);
            this._annullaButton.Name = "_annullaButton";
            this._annullaButton.Size = new System.Drawing.Size(75, 23);
            this._annullaButton.TabIndex = 6;
            this._annullaButton.Text = "Annulla";
            this._annullaButton.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Tipo,
            this.Data});
            this.listView1.Location = new System.Drawing.Point(92, 80);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(385, 195);
            this.listView1.TabIndex = 7;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // Tipo
            // 
            this.Tipo.Text = "Tipo";
            this.Tipo.Width = 206;
            // 
            // Data
            // 
            this.Data.Text = "Data";
            this.Data.Width = 174;
            // 
            // _indietroButton
            // 
            this._indietroButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._indietroButton.Location = new System.Drawing.Point(500, 300);
            this._indietroButton.Name = "_indietroButton";
            this._indietroButton.Size = new System.Drawing.Size(75, 23);
            this._indietroButton.TabIndex = 8;
            this._indietroButton.Text = "Indietro";
            this._indietroButton.UseVisualStyleBackColor = true;
            // 
            // FormDiario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(597, 345);
            this.Controls.Add(this._indietroButton);
            this.Controls.Add(this.listView1);
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
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader Tipo;
        private System.Windows.Forms.ColumnHeader Data;
        private System.Windows.Forms.Button _indietroButton;
    }
}

