namespace Trainary.view
{
    partial class AttributiControl
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
            this.components = new System.ComponentModel.Container();
            this._buttonsPanel = new System.Windows.Forms.Panel();
            this._cancelButton = new System.Windows.Forms.Button();
            this._okButton = new System.Windows.Forms.Button();
            this._tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this._nameLabel = new System.Windows.Forms.Label();
            this._nameTextBox = new System.Windows.Forms.TextBox();
            this._typeLabel = new System.Windows.Forms.Label();
            this._typeComboBox = new System.Windows.Forms.ComboBox();
            this._valueLabel = new System.Windows.Forms.Label();
            this._valuePanel = new System.Windows.Forms.Panel();
            this._errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this._buttonsPanel.SuspendLayout();
            this._tableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // _buttonsPanel
            // 
            this._buttonsPanel.AutoSize = true;
            this._buttonsPanel.Controls.Add(this._cancelButton);
            this._buttonsPanel.Controls.Add(this._okButton);
            this._buttonsPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this._buttonsPanel.Location = new System.Drawing.Point(0, 267);
            this._buttonsPanel.Name = "_buttonsPanel";
            this._buttonsPanel.Size = new System.Drawing.Size(392, 51);
            this._buttonsPanel.TabIndex = 0;
            // 
            // _cancelButton
            // 
            this._cancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this._cancelButton.Location = new System.Drawing.Point(305, 14);
            this._cancelButton.Name = "_cancelButton";
            this._cancelButton.Size = new System.Drawing.Size(75, 23);
            this._cancelButton.TabIndex = 1;
            this._cancelButton.Text = "Cancella";
            this._cancelButton.UseVisualStyleBackColor = true;
            // 
            // _okButton
            // 
            this._okButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._okButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this._okButton.Location = new System.Drawing.Point(224, 14);
            this._okButton.Name = "_okButton";
            this._okButton.Size = new System.Drawing.Size(75, 23);
            this._okButton.TabIndex = 0;
            this._okButton.Text = "OK";
            this._okButton.UseVisualStyleBackColor = true;
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
            this._tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this._tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this._tableLayoutPanel.Size = new System.Drawing.Size(392, 267);
            this._tableLayoutPanel.TabIndex = 1;
            // 
            // _nameLabel
            // 
            this._nameLabel.AutoSize = true;
            this._nameLabel.Location = new System.Drawing.Point(3, 0);
            this._nameLabel.Name = "_nameLabel";
            this._nameLabel.Size = new System.Drawing.Size(35, 13);
            this._nameLabel.TabIndex = 0;
            this._nameLabel.Text = "Nome";
            // 
            // _nameTextBox
            // 
            this._nameTextBox.Location = new System.Drawing.Point(133, 3);
            this._nameTextBox.Name = "_nameTextBox";
            this._nameTextBox.Size = new System.Drawing.Size(121, 20);
            this._nameTextBox.TabIndex = 1;
            // 
            // _typeLabel
            // 
            this._typeLabel.AutoSize = true;
            this._typeLabel.Location = new System.Drawing.Point(3, 26);
            this._typeLabel.Name = "_typeLabel";
            this._typeLabel.Size = new System.Drawing.Size(28, 13);
            this._typeLabel.TabIndex = 2;
            this._typeLabel.Text = "Tipo";
            // 
            // _typeComboBox
            // 
            this._typeComboBox.FormattingEnabled = true;
            this._typeComboBox.Location = new System.Drawing.Point(133, 29);
            this._typeComboBox.Name = "_typeComboBox";
            this._typeComboBox.Size = new System.Drawing.Size(121, 21);
            this._typeComboBox.TabIndex = 3;
            // 
            // _valueLabel
            // 
            this._valueLabel.AutoSize = true;
            this._valueLabel.Location = new System.Drawing.Point(3, 46);
            this._valueLabel.Name = "_valueLabel";
            this._valueLabel.Size = new System.Drawing.Size(37, 13);
            this._valueLabel.TabIndex = 4;
            this._valueLabel.Text = "Valore";
            // 
            // _valuePanel
            // 
            this._valuePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this._valuePanel.Location = new System.Drawing.Point(133, 49);
            this._valuePanel.Name = "_valuePanel";
            this._valuePanel.Size = new System.Drawing.Size(256, 215);
            this._valuePanel.TabIndex = 5;
            // 
            // _errorProvider
            // 
            this._errorProvider.ContainerControl = this;
            // 
            // AttributiControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this._tableLayoutPanel);
            this.Controls.Add(this._buttonsPanel);
            this.Name = "AttributiControl";
            this.Size = new System.Drawing.Size(392, 318);
            this._buttonsPanel.ResumeLayout(false);
            this._tableLayoutPanel.ResumeLayout(false);
            this._tableLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel _buttonsPanel;
        private System.Windows.Forms.Button _cancelButton;
        private System.Windows.Forms.Button _okButton;
        private System.Windows.Forms.TableLayoutPanel _tableLayoutPanel;
        private System.Windows.Forms.Label _nameLabel;
        private System.Windows.Forms.TextBox _nameTextBox;
        private System.Windows.Forms.Label _typeLabel;
        private System.Windows.Forms.ComboBox _typeComboBox;
        private System.Windows.Forms.Label _valueLabel;
        private System.Windows.Forms.Panel _valuePanel;
        private System.Windows.Forms.ErrorProvider _errorProvider;
    }
}
