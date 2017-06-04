namespace Trainary.test.view
{
    partial class EserciziListForm
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
            this._listBoxControl = new Trainary.view.ListBoxControl();
            this.SuspendLayout();
            // 
            // _listBoxControl
            // 
            this._listBoxControl.AutoSize = true;
            this._listBoxControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this._listBoxControl.Location = new System.Drawing.Point(0, 0);
            this._listBoxControl.Name = "_listBoxControl";
            this._listBoxControl.Size = new System.Drawing.Size(450, 333);
            this._listBoxControl.TabIndex = 0;
            // 
            // EserciziListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 333);
            this.Controls.Add(this._listBoxControl);
            this.Name = "EserciziListForm";
            this.Text = "EserciziListForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Trainary.view.ListBoxControl _listBoxControl;
    }
}