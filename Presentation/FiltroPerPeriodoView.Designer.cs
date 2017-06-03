namespace Trainary.Presentation
{
    partial class FiltroPerPeriodoView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this._selezionareLabel = new System.Windows.Forms.Label();
            this._dataInizioLabel = new System.Windows.Forms.Label();
            this._dataFineLabel = new System.Windows.Forms.Label();
            this._dataInizio = new System.Windows.Forms.DateTimePicker();
            this._dataFine = new System.Windows.Forms.DateTimePicker();
            this._okButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // _selezionareLabel
            // 
            this._selezionareLabel.AutoSize = true;
            this._selezionareLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._selezionareLabel.Location = new System.Drawing.Point(12, 18);
            this._selezionareLabel.Name = "_selezionareLabel";
            this._selezionareLabel.Size = new System.Drawing.Size(91, 19);
            this._selezionareLabel.TabIndex = 11;
            this._selezionareLabel.Text = "Selezionare:";
            // 
            // _dataInizioLabel
            // 
            this._dataInizioLabel.AutoSize = true;
            this._dataInizioLabel.Font = new System.Drawing.Font("Lucida Fax", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._dataInizioLabel.Location = new System.Drawing.Point(13, 54);
            this._dataInizioLabel.Name = "_dataInizioLabel";
            this._dataInizioLabel.Size = new System.Drawing.Size(78, 16);
            this._dataInizioLabel.TabIndex = 12;
            this._dataInizioLabel.Text = "Data inizio";
            // 
            // _dataFineLabel
            // 
            this._dataFineLabel.AutoSize = true;
            this._dataFineLabel.Font = new System.Drawing.Font("Lucida Fax", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._dataFineLabel.Location = new System.Drawing.Point(13, 86);
            this._dataFineLabel.Name = "_dataFineLabel";
            this._dataFineLabel.Size = new System.Drawing.Size(66, 16);
            this._dataFineLabel.TabIndex = 13;
            this._dataFineLabel.Text = "Data fine";
            // 
            // _dataInizio
            // 
            this._dataInizio.Location = new System.Drawing.Point(97, 54);
            this._dataInizio.Name = "_dataInizio";
            this._dataInizio.Size = new System.Drawing.Size(198, 20);
            this._dataInizio.TabIndex = 14;
            // 
            // _dataFine
            // 
            this._dataFine.Location = new System.Drawing.Point(97, 86);
            this._dataFine.Name = "_dataFine";
            this._dataFine.Size = new System.Drawing.Size(198, 20);
            this._dataFine.TabIndex = 15;
            // 
            // _okButton
            // 
            this._okButton.Location = new System.Drawing.Point(204, 130);
            this._okButton.Name = "_okButton";
            this._okButton.Size = new System.Drawing.Size(75, 23);
            this._okButton.TabIndex = 16;
            this._okButton.Text = "OK";
            this._okButton.UseVisualStyleBackColor = true;
            // 
            // FiltroPerPeriodoView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(307, 165);
            this.Controls.Add(this._okButton);
            this.Controls.Add(this._dataFine);
            this.Controls.Add(this._dataInizio);
            this.Controls.Add(this._dataFineLabel);
            this.Controls.Add(this._dataInizioLabel);
            this.Controls.Add(this._selezionareLabel);
            this.Name = "FiltroPerPeriodoView";
            this.Text = "Filtro per periodo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label _selezionareLabel;
        private System.Windows.Forms.Label _dataInizioLabel;
        private System.Windows.Forms.Label _dataFineLabel;
        private System.Windows.Forms.DateTimePicker _dataInizio;
        private System.Windows.Forms.DateTimePicker _dataFine;
        private System.Windows.Forms.Button _okButton;
    }
}