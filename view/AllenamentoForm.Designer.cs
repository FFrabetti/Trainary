namespace Trainary.Presentation
{
    partial class AllenamentoForm
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
            this._allenamentoLabel = new System.Windows.Forms.Label();
            this.inserisciDataEserciziControl1 = new Trainary.view.InserisciDataEserciziControl();
            this.dialogButtonsControl1 = new Trainary.view.DialogButtonsControl();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // _allenamentoLabel
            // 
            this._allenamentoLabel.AutoSize = true;
            this._allenamentoLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._allenamentoLabel.Location = new System.Drawing.Point(122, 9);
            this._allenamentoLabel.Name = "_allenamentoLabel";
            this._allenamentoLabel.Size = new System.Drawing.Size(97, 19);
            this._allenamentoLabel.TabIndex = 0;
            this._allenamentoLabel.Text = "Allenamento ";
            // 
            // inserisciDataEserciziControl1
            // 
            this.inserisciDataEserciziControl1.AutoSize = true;
            this.inserisciDataEserciziControl1.Location = new System.Drawing.Point(12, 116);
            this.inserisciDataEserciziControl1.Name = "inserisciDataEserciziControl1";
            this.inserisciDataEserciziControl1.Size = new System.Drawing.Size(298, 171);
            this.inserisciDataEserciziControl1.TabIndex = 9;
            // 
            // dialogButtonsControl1
            // 
            this.dialogButtonsControl1.AutoSize = true;
            this.dialogButtonsControl1.Location = new System.Drawing.Point(-2, 282);
            this.dialogButtonsControl1.Name = "dialogButtonsControl1";
            this.dialogButtonsControl1.Size = new System.Drawing.Size(410, 49);
            this.dialogButtonsControl1.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(332, 133);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(34, 43);
            this.button1.TabIndex = 11;
            this.button1.Text = "+";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(31, 31);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(260, 79);
            this.panel1.TabIndex = 12;
            // 
            // AllenamentoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(408, 329);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dialogButtonsControl1);
            this.Controls.Add(this.inserisciDataEserciziControl1);
            this.Controls.Add(this._allenamentoLabel);
            this.Name = "AllenamentoForm";
            this.Text = "Allenamento ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label _allenamentoLabel;
        private view.InserisciDataEserciziControl inserisciDataEserciziControl1;
        private view.DialogButtonsControl dialogButtonsControl1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
    }
}