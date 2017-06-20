namespace Trainary.view
{
    partial class DatiForm
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
            this.dialogButtonsControl1 = new Trainary.view.DialogButtonsControl();
            this.panel1 = new System.Windows.Forms.Panel();
            this._attributiControl = new Trainary.view.AttributiControl();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dialogButtonsControl1
            // 
            this.dialogButtonsControl1.AutoSize = true;
            this.dialogButtonsControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dialogButtonsControl1.Location = new System.Drawing.Point(0, 325);
            this.dialogButtonsControl1.Name = "dialogButtonsControl1";
            this.dialogButtonsControl1.Size = new System.Drawing.Size(444, 45);
            this.dialogButtonsControl1.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this._attributiControl);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(444, 325);
            this.panel1.TabIndex = 2;
            // 
            // _attributiControl
            // 
            this._attributiControl.AutoSize = true;
            this._attributiControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this._attributiControl.Location = new System.Drawing.Point(0, 0);
            this._attributiControl.Name = "_attributiControl";
            this._attributiControl.Padding = new System.Windows.Forms.Padding(3);
            this._attributiControl.Size = new System.Drawing.Size(444, 325);
            this._attributiControl.TabIndex = 1;
            // 
            // DatiForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 370);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dialogButtonsControl1);
            this.Name = "DatiForm";
            this.Text = "Aggiungi dati";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DialogButtonsControl dialogButtonsControl1;
        private System.Windows.Forms.Panel panel1;
        private AttributiControl _attributiControl;
    }
}