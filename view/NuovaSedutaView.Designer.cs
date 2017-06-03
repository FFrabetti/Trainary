namespace Trainary.Presentation
{
    partial class NuovaSedutaView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NuovaSedutaView));
            this._codiceLabel = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this._okButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // _codiceLabel
            // 
            this._codiceLabel.AutoSize = true;
            this._codiceLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._codiceLabel.Location = new System.Drawing.Point(29, 19);
            this._codiceLabel.Name = "_codiceLabel";
            this._codiceLabel.Size = new System.Drawing.Size(60, 19);
            this._codiceLabel.TabIndex = 9;
            this._codiceLabel.Text = "Codice:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(104, 18);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(148, 20);
            this.textBox1.TabIndex = 10;
            // 
            // _okButton
            // 
            this._okButton.Location = new System.Drawing.Point(212, 55);
            this._okButton.Name = "_okButton";
            this._okButton.Size = new System.Drawing.Size(75, 23);
            this._okButton.TabIndex = 11;
            this._okButton.Text = "OK";
            this._okButton.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(3, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 201);
            this.label1.TabIndex = 12;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // NuovaSedutaView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(299, 265);
            this.Controls.Add(this.label1);
            this.Controls.Add(this._okButton);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this._codiceLabel);
            this.Name = "NuovaSedutaView";
            this.Text = "Nuova seduta";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label _codiceLabel;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button _okButton;
        private System.Windows.Forms.Label label1;
    }
}