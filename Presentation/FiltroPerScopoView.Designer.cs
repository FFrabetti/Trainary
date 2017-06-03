namespace Trainary.Presentation
{
    partial class FiltroPerScopoView
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
            this._scopoLabel = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this._okButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // _scopoLabel
            // 
            this._scopoLabel.AutoSize = true;
            this._scopoLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._scopoLabel.Location = new System.Drawing.Point(12, 32);
            this._scopoLabel.Name = "_scopoLabel";
            this._scopoLabel.Size = new System.Drawing.Size(119, 19);
            this._scopoLabel.TabIndex = 12;
            this._scopoLabel.Text = "Seleziona scopo:";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(153, 30);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(178, 21);
            this.comboBox1.TabIndex = 13;
            // 
            // _okButton
            // 
            this._okButton.Location = new System.Drawing.Point(267, 81);
            this._okButton.Name = "_okButton";
            this._okButton.Size = new System.Drawing.Size(75, 23);
            this._okButton.TabIndex = 14;
            this._okButton.Text = "OK";
            this._okButton.UseVisualStyleBackColor = true;
            // 
            // FiltroPerScopoView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(354, 116);
            this.Controls.Add(this._okButton);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this._scopoLabel);
            this.Name = "FiltroPerScopoView";
            this.Text = "FiltroPerScopoView";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label _scopoLabel;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button _okButton;
    }
}