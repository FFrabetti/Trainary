namespace Trainary.test.view
{
    partial class ListForm
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
            this._topPanel = new System.Windows.Forms.Panel();
            this._bottomPanel = new System.Windows.Forms.Panel();
            this._centerPanel = new System.Windows.Forms.Panel();
            this._textBox = new System.Windows.Forms.TextBox();
            this._listBoxControl = new Trainary.view.ListBoxControl();
            this._bottomPanel.SuspendLayout();
            this._centerPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // _topPanel
            // 
            this._topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this._topPanel.Location = new System.Drawing.Point(0, 0);
            this._topPanel.Name = "_topPanel";
            this._topPanel.Size = new System.Drawing.Size(500, 44);
            this._topPanel.TabIndex = 0;
            // 
            // _bottomPanel
            // 
            this._bottomPanel.Controls.Add(this._textBox);
            this._bottomPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this._bottomPanel.Location = new System.Drawing.Point(0, 199);
            this._bottomPanel.Name = "_bottomPanel";
            this._bottomPanel.Size = new System.Drawing.Size(500, 100);
            this._bottomPanel.TabIndex = 1;
            // 
            // _centerPanel
            // 
            this._centerPanel.Controls.Add(this._listBoxControl);
            this._centerPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this._centerPanel.Location = new System.Drawing.Point(0, 44);
            this._centerPanel.Name = "_centerPanel";
            this._centerPanel.Size = new System.Drawing.Size(500, 155);
            this._centerPanel.TabIndex = 2;
            // 
            // _textBox
            // 
            this._textBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this._textBox.Location = new System.Drawing.Point(0, 0);
            this._textBox.Multiline = true;
            this._textBox.Name = "_textBox";
            this._textBox.Size = new System.Drawing.Size(500, 100);
            this._textBox.TabIndex = 0;
            // 
            // _listBoxControl
            // 
            this._listBoxControl.AutoSize = true;
            this._listBoxControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this._listBoxControl.Location = new System.Drawing.Point(0, 0);
            this._listBoxControl.Name = "_listBoxControl";
            this._listBoxControl.Size = new System.Drawing.Size(500, 155);
            this._listBoxControl.TabIndex = 0;
            // 
            // ListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 299);
            this.Controls.Add(this._centerPanel);
            this.Controls.Add(this._bottomPanel);
            this.Controls.Add(this._topPanel);
            this.Name = "ListForm";
            this.Text = "ListForm";
            this._bottomPanel.ResumeLayout(false);
            this._bottomPanel.PerformLayout();
            this._centerPanel.ResumeLayout(false);
            this._centerPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel _topPanel;
        private System.Windows.Forms.Panel _bottomPanel;
        private System.Windows.Forms.TextBox _textBox;
        private System.Windows.Forms.Panel _centerPanel;
        private Trainary.view.ListBoxControl _listBoxControl;
    }
}