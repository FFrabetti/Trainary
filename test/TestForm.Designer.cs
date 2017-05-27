namespace Trainary.test
{
    partial class TestForm
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this._groupBox = new System.Windows.Forms.GroupBox();
            this._showDialogButton = new System.Windows.Forms.Button();
            this._attributiRadioButton = new System.Windows.Forms.RadioButton();
            this._eserciziRadioButton = new System.Windows.Forms.RadioButton();
            this._textBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this._groupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this._showDialogButton);
            this.splitContainer1.Panel1.Controls.Add(this._groupBox);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this._textBox);
            this.splitContainer1.Size = new System.Drawing.Size(445, 327);
            this.splitContainer1.SplitterDistance = 128;
            this.splitContainer1.TabIndex = 0;
            // 
            // _groupBox
            // 
            this._groupBox.Controls.Add(this._eserciziRadioButton);
            this._groupBox.Controls.Add(this._attributiRadioButton);
            this._groupBox.Location = new System.Drawing.Point(12, 12);
            this._groupBox.Name = "_groupBox";
            this._groupBox.Size = new System.Drawing.Size(200, 100);
            this._groupBox.TabIndex = 0;
            this._groupBox.TabStop = false;
            // 
            // _showDialogButton
            // 
            this._showDialogButton.Location = new System.Drawing.Point(287, 32);
            this._showDialogButton.Name = "_showDialogButton";
            this._showDialogButton.Size = new System.Drawing.Size(75, 23);
            this._showDialogButton.TabIndex = 1;
            this._showDialogButton.Text = "Show dialog";
            this._showDialogButton.UseVisualStyleBackColor = true;
            this._showDialogButton.Click += new System.EventHandler(this._showDialogButton_Click);
            // 
            // _attributiRadioButton
            // 
            this._attributiRadioButton.AutoSize = true;
            this._attributiRadioButton.Location = new System.Drawing.Point(7, 20);
            this._attributiRadioButton.Name = "_attributiRadioButton";
            this._attributiRadioButton.Size = new System.Drawing.Size(60, 17);
            this._attributiRadioButton.TabIndex = 0;
            this._attributiRadioButton.TabStop = true;
            this._attributiRadioButton.Text = "Attributi";
            this._attributiRadioButton.UseVisualStyleBackColor = true;
            // 
            // _eserciziRadioButton
            // 
            this._eserciziRadioButton.AutoSize = true;
            this._eserciziRadioButton.Location = new System.Drawing.Point(7, 43);
            this._eserciziRadioButton.Name = "_eserciziRadioButton";
            this._eserciziRadioButton.Size = new System.Drawing.Size(61, 17);
            this._eserciziRadioButton.TabIndex = 1;
            this._eserciziRadioButton.TabStop = true;
            this._eserciziRadioButton.Text = "Esercizi";
            this._eserciziRadioButton.UseVisualStyleBackColor = true;
            // 
            // _textBox
            // 
            this._textBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this._textBox.Location = new System.Drawing.Point(0, 0);
            this._textBox.Multiline = true;
            this._textBox.Name = "_textBox";
            this._textBox.Size = new System.Drawing.Size(445, 195);
            this._textBox.TabIndex = 0;
            // 
            // TestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 327);
            this.Controls.Add(this.splitContainer1);
            this.Name = "TestForm";
            this.Text = "TestForm";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this._groupBox.ResumeLayout(false);
            this._groupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button _showDialogButton;
        private System.Windows.Forms.GroupBox _groupBox;
        private System.Windows.Forms.RadioButton _eserciziRadioButton;
        private System.Windows.Forms.RadioButton _attributiRadioButton;
        private System.Windows.Forms.TextBox _textBox;
    }
}