namespace Trainary.Presentation
{
    partial class FiltroPerSedutaView
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
            this._schedaLabel = new System.Windows.Forms.Label();
            this._schedeCombo = new System.Windows.Forms.ComboBox();
            this._seduteCombo = new System.Windows.Forms.ComboBox();
            this._sedutaLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // _schedaLabel
            // 
            this._schedaLabel.AutoSize = true;
            this._schedaLabel.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._schedaLabel.Location = new System.Drawing.Point(23, 25);
            this._schedaLabel.Name = "_schedaLabel";
            this._schedaLabel.Size = new System.Drawing.Size(116, 16);
            this._schedaLabel.TabIndex = 13;
            this._schedaLabel.Text = "Seleziona scheda:";
            // 
            // _schedeCombo
            // 
            this._schedeCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._schedeCombo.FormattingEnabled = true;
            this._schedeCombo.Location = new System.Drawing.Point(154, 20);
            this._schedeCombo.Name = "_schedeCombo";
            this._schedeCombo.Size = new System.Drawing.Size(154, 21);
            this._schedeCombo.TabIndex = 14;
            // 
            // _seduteCombo
            // 
            this._seduteCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._seduteCombo.FormattingEnabled = true;
            this._seduteCombo.Location = new System.Drawing.Point(154, 54);
            this._seduteCombo.Name = "_seduteCombo";
            this._seduteCombo.Size = new System.Drawing.Size(154, 21);
            this._seduteCombo.TabIndex = 16;
            // 
            // _sedutaLabel
            // 
            this._sedutaLabel.AutoSize = true;
            this._sedutaLabel.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._sedutaLabel.Location = new System.Drawing.Point(23, 59);
            this._sedutaLabel.Name = "_sedutaLabel";
            this._sedutaLabel.Size = new System.Drawing.Size(114, 16);
            this._sedutaLabel.TabIndex = 15;
            this._sedutaLabel.Text = "Seleziona seduta:";
            // 
            // FiltroPerSedutaView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(328, 223);
            this.Controls.Add(this._seduteCombo);
            this.Controls.Add(this._sedutaLabel);
            this.Controls.Add(this._schedeCombo);
            this.Controls.Add(this._schedaLabel);
            this.Name = "FiltroPerSedutaView";
            this.Text = "FiltroPerSedutaView";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label _schedaLabel;
        private System.Windows.Forms.ComboBox _schedeCombo;
        private System.Windows.Forms.ComboBox _seduteCombo;
        private System.Windows.Forms.Label _sedutaLabel;
    }
}