namespace Trainary.Presentation
{
    partial class RinominaSedutaView
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
            this._codiceLabel = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dialogButtonsControl1 = new Trainary.view.DialogButtonsControl();
            this.SuspendLayout();
            // 
            // _codiceLabel
            // 
            this._codiceLabel.AutoSize = true;
            this._codiceLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._codiceLabel.Location = new System.Drawing.Point(12, 9);
            this._codiceLabel.Name = "_codiceLabel";
            this._codiceLabel.Size = new System.Drawing.Size(155, 19);
            this._codiceLabel.TabIndex = 9;
            this._codiceLabel.Text = "Inserisci nuovo nome:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(16, 31);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(203, 20);
            this.textBox1.TabIndex = 10;
            // 
            // dialogButtonsControl1
            // 
            this.dialogButtonsControl1.AutoSize = true;
            this.dialogButtonsControl1.Location = new System.Drawing.Point(30, 66);
            this.dialogButtonsControl1.Name = "dialogButtonsControl1";
            this.dialogButtonsControl1.Size = new System.Drawing.Size(202, 41);
            this.dialogButtonsControl1.TabIndex = 11;
            // 
            // RinominaSedutaView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(244, 113);
            this.Controls.Add(this.dialogButtonsControl1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this._codiceLabel);
            this.Name = "RinominaSedutaView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rinomina seduta";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label _codiceLabel;
        private System.Windows.Forms.TextBox textBox1;
        private view.DialogButtonsControl dialogButtonsControl1;
    }
}