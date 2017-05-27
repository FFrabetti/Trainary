namespace Trainary.test
{
    partial class AttributiForm
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
            this._attributiControl = new Trainary.view.AttributiControl();
            this.SuspendLayout();
            // 
            // _attributiControl
            // 
            this._attributiControl.AutoSize = true;
            this._attributiControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this._attributiControl.Location = new System.Drawing.Point(0, 0);
            this._attributiControl.Name = "_attributiControl";
            this._attributiControl.Size = new System.Drawing.Size(695, 337);
            this._attributiControl.TabIndex = 0;
            // 
            // AttributiForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(695, 337);
            this.Controls.Add(this._attributiControl);
            this.Name = "AttributiForm";
            this.Text = "AttributiForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private view.AttributiControl _attributiControl;
    }
}