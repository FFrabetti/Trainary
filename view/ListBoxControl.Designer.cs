namespace Trainary.view
{
    partial class ListBoxControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this._buttonsPanel = new System.Windows.Forms.Panel();
            this._label = new System.Windows.Forms.Label();
            this._removeButton = new System.Windows.Forms.Button();
            this._addButton = new System.Windows.Forms.Button();
            this._mainPanel = new System.Windows.Forms.Panel();
            this._listBox = new System.Windows.Forms.ListBox();
            this._buttonsPanel.SuspendLayout();
            this._mainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // _buttonsPanel
            // 
            this._buttonsPanel.Controls.Add(this._label);
            this._buttonsPanel.Controls.Add(this._removeButton);
            this._buttonsPanel.Controls.Add(this._addButton);
            this._buttonsPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this._buttonsPanel.Location = new System.Drawing.Point(0, 0);
            this._buttonsPanel.Name = "_buttonsPanel";
            this._buttonsPanel.Size = new System.Drawing.Size(322, 47);
            this._buttonsPanel.TabIndex = 1;
            // 
            // _label
            // 
            this._label.AutoSize = true;
            this._label.Location = new System.Drawing.Point(3, 17);
            this._label.Name = "_label";
            this._label.Size = new System.Drawing.Size(29, 13);
            this._label.TabIndex = 2;
            this._label.Text = "label";
            // 
            // _removeButton
            // 
            this._removeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._removeButton.Location = new System.Drawing.Point(247, 12);
            this._removeButton.Name = "_removeButton";
            this._removeButton.Size = new System.Drawing.Size(75, 23);
            this._removeButton.TabIndex = 1;
            this._removeButton.Text = "Remove";
            this._removeButton.UseVisualStyleBackColor = true;
            // 
            // _addButton
            // 
            this._addButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._addButton.Location = new System.Drawing.Point(166, 12);
            this._addButton.Name = "_addButton";
            this._addButton.Size = new System.Drawing.Size(75, 23);
            this._addButton.TabIndex = 0;
            this._addButton.Text = "Add";
            this._addButton.UseVisualStyleBackColor = true;
            // 
            // _mainPanel
            // 
            this._mainPanel.AutoSize = true;
            this._mainPanel.BackColor = System.Drawing.SystemColors.Control;
            this._mainPanel.Controls.Add(this._listBox);
            this._mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this._mainPanel.Location = new System.Drawing.Point(0, 47);
            this._mainPanel.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this._mainPanel.Name = "_mainPanel";
            this._mainPanel.Size = new System.Drawing.Size(322, 114);
            this._mainPanel.TabIndex = 2;
            // 
            // _listBox
            // 
            this._listBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this._listBox.FormattingEnabled = true;
            this._listBox.Location = new System.Drawing.Point(0, 0);
            this._listBox.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this._listBox.Name = "_listBox";
            this._listBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this._listBox.Size = new System.Drawing.Size(322, 114);
            this._listBox.TabIndex = 0;
            // 
            // ListBoxControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this._mainPanel);
            this.Controls.Add(this._buttonsPanel);
            this.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.Name = "ListBoxControl";
            this.Size = new System.Drawing.Size(322, 161);
            this._buttonsPanel.ResumeLayout(false);
            this._buttonsPanel.PerformLayout();
            this._mainPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel _buttonsPanel;
        private System.Windows.Forms.Label _label;
        private System.Windows.Forms.Button _removeButton;
        private System.Windows.Forms.Button _addButton;
        private System.Windows.Forms.Panel _mainPanel;
        private System.Windows.Forms.ListBox _listBox;
    }
}
