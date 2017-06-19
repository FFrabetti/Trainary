namespace Trainary.view
{
    partial class SelezionaEserciziSeduta
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
            this._treeView = new System.Windows.Forms.TreeView();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dialogButtonsControl1
            // 
            this.dialogButtonsControl1.AutoSize = true;
            this.dialogButtonsControl1.Location = new System.Drawing.Point(0, 215);
            this.dialogButtonsControl1.Name = "dialogButtonsControl1";
            this.dialogButtonsControl1.Size = new System.Drawing.Size(285, 48);
            this.dialogButtonsControl1.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this._treeView);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(285, 187);
            this.panel1.TabIndex = 3;
            // 
            // _treeView
            // 
            this._treeView.Dock = System.Windows.Forms.DockStyle.Fill;
            this._treeView.Location = new System.Drawing.Point(0, 0);
            this._treeView.Name = "_treeView";
            this._treeView.Size = new System.Drawing.Size(285, 187);
            this._treeView.TabIndex = 0;
            // 
            // SelezionaEserciziSeduta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dialogButtonsControl1);
            this.Name = "SelezionaEserciziSeduta";
            this.Text = "SelezionaEserciziSeduta";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DialogButtonsControl dialogButtonsControl1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TreeView _treeView;
    }
}