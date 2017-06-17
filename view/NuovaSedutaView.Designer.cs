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
            this.panel1 = new System.Windows.Forms.Panel();
            this.dialogButtonsControl1 = new Trainary.view.DialogButtonsControl();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(353, 0);
            this.panel1.TabIndex = 0;
            // 
            // dialogButtonsControl1
            // 
            this.dialogButtonsControl1.AutoSize = true;
            this.dialogButtonsControl1.Location = new System.Drawing.Point(0, 214);
            this.dialogButtonsControl1.Name = "dialogButtonsControl1";
            this.dialogButtonsControl1.Size = new System.Drawing.Size(299, 61);
            this.dialogButtonsControl1.TabIndex = 1;
            // 
            // NuovaSedutaView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(353, 265);
            this.Controls.Add(this.dialogButtonsControl1);
            this.Controls.Add(this.panel1);
            this.Name = "NuovaSedutaView";
            this.Text = "Nuova seduta";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private view.DialogButtonsControl dialogButtonsControl1;
    }
}