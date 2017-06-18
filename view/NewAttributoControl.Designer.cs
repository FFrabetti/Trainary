namespace Trainary.view
{
    partial class NewAttributoControl
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
            this._tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this._nameLabel = new System.Windows.Forms.Label();
            this._nameTextBox = new System.Windows.Forms.TextBox();
            this._typeLabel = new System.Windows.Forms.Label();
            this._typeComboBox = new System.Windows.Forms.ComboBox();
            this._valueLabel = new System.Windows.Forms.Label();
            this._valuePanel = new System.Windows.Forms.Panel();
            this._tableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // _tableLayoutPanel
            // 
            this._tableLayoutPanel.AutoSize = true;
            this._tableLayoutPanel.ColumnCount = 2;
            this._tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this._tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 66.66666F));
            this._tableLayoutPanel.Controls.Add(this._nameLabel, 0, 0);
            this._tableLayoutPanel.Controls.Add(this._nameTextBox, 1, 0);
            this._tableLayoutPanel.Controls.Add(this._typeLabel, 0, 1);
            this._tableLayoutPanel.Controls.Add(this._typeComboBox, 1, 1);
            this._tableLayoutPanel.Controls.Add(this._valueLabel, 0, 2);
            this._tableLayoutPanel.Controls.Add(this._valuePanel, 1, 2);
            this._tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this._tableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this._tableLayoutPanel.Name = "_tableLayoutPanel";
            this._tableLayoutPanel.RowCount = 3;
            this._tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this._tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this._tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this._tableLayoutPanel.Size = new System.Drawing.Size(394, 86);
            this._tableLayoutPanel.TabIndex = 1;
            // 
            // _nameLabel
            // 
            this._nameLabel.AutoSize = true;
            this._nameLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this._nameLabel.Location = new System.Drawing.Point(3, 3);
            this._nameLabel.Margin = new System.Windows.Forms.Padding(3);
            this._nameLabel.Name = "_nameLabel";
            this._nameLabel.Size = new System.Drawing.Size(35, 20);
            this._nameLabel.TabIndex = 0;
            this._nameLabel.Text = "Nome";
            this._nameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // _nameTextBox
            // 
            this._nameTextBox.Location = new System.Drawing.Point(134, 3);
            this._nameTextBox.Name = "_nameTextBox";
            this._nameTextBox.Size = new System.Drawing.Size(121, 20);
            this._nameTextBox.TabIndex = 1;
            // 
            // _typeLabel
            // 
            this._typeLabel.AutoSize = true;
            this._typeLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this._typeLabel.Location = new System.Drawing.Point(3, 29);
            this._typeLabel.Margin = new System.Windows.Forms.Padding(3);
            this._typeLabel.Name = "_typeLabel";
            this._typeLabel.Size = new System.Drawing.Size(28, 21);
            this._typeLabel.TabIndex = 2;
            this._typeLabel.Text = "Tipo";
            this._typeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // _typeComboBox
            // 
            this._typeComboBox.FormattingEnabled = true;
            this._typeComboBox.Location = new System.Drawing.Point(134, 29);
            this._typeComboBox.Name = "_typeComboBox";
            this._typeComboBox.Size = new System.Drawing.Size(121, 21);
            this._typeComboBox.TabIndex = 3;
            // 
            // _valueLabel
            // 
            this._valueLabel.AutoSize = true;
            this._valueLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this._valueLabel.Location = new System.Drawing.Point(3, 56);
            this._valueLabel.Margin = new System.Windows.Forms.Padding(3);
            this._valueLabel.Name = "_valueLabel";
            this._valueLabel.Size = new System.Drawing.Size(37, 27);
            this._valueLabel.TabIndex = 4;
            this._valueLabel.Text = "Valore";
            this._valueLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // _valuePanel
            // 
            this._valuePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this._valuePanel.Location = new System.Drawing.Point(134, 56);
            this._valuePanel.Name = "_valuePanel";
            this._valuePanel.Size = new System.Drawing.Size(257, 27);
            this._valuePanel.TabIndex = 5;
            // 
            // NewAttributoControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this._tableLayoutPanel);
            this.Name = "NewAttributoControl";
            this.Size = new System.Drawing.Size(394, 86);
            this._tableLayoutPanel.ResumeLayout(false);
            this._tableLayoutPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel _tableLayoutPanel;
        private System.Windows.Forms.Label _nameLabel;
        private System.Windows.Forms.TextBox _nameTextBox;
        private System.Windows.Forms.Label _typeLabel;
        private System.Windows.Forms.ComboBox _typeComboBox;
        private System.Windows.Forms.Label _valueLabel;
        private System.Windows.Forms.Panel _valuePanel;
    }
}
