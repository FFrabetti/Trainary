namespace Trainary.view
{
    partial class NewEsercizioForm
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
            this._treeView = new System.Windows.Forms.TreeView();
            this._centrePanel = new System.Windows.Forms.Panel();
            this._listBoxControl = new Trainary.view.ListBoxControl();
            this._bottomPanel = new System.Windows.Forms.Panel();
            this._okButton = new System.Windows.Forms.Button();
            this._cancelButton = new System.Windows.Forms.Button();
            this._topPanel = new System.Windows.Forms.Panel();
            this._tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this._nameLabel = new System.Windows.Forms.Label();
            this._descLabel = new System.Windows.Forms.Label();
            this._toolsLabel = new System.Windows.Forms.Label();
            this._nameValueLabel = new System.Windows.Forms.Label();
            this._descValueLabel = new System.Windows.Forms.Label();
            this._toolsValueLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this._centrePanel.SuspendLayout();
            this._bottomPanel.SuspendLayout();
            this._topPanel.SuspendLayout();
            this._tableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this._treeView);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this._centrePanel);
            this.splitContainer1.Panel2.Controls.Add(this._bottomPanel);
            this.splitContainer1.Panel2.Controls.Add(this._topPanel);
            this.splitContainer1.Size = new System.Drawing.Size(529, 375);
            this.splitContainer1.SplitterDistance = 176;
            this.splitContainer1.TabIndex = 0;
            // 
            // _treeView
            // 
            this._treeView.Dock = System.Windows.Forms.DockStyle.Fill;
            this._treeView.Location = new System.Drawing.Point(0, 0);
            this._treeView.Name = "_treeView";
            this._treeView.Size = new System.Drawing.Size(176, 375);
            this._treeView.TabIndex = 0;
            // 
            // _centrePanel
            // 
            this._centrePanel.Controls.Add(this._listBoxControl);
            this._centrePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this._centrePanel.Location = new System.Drawing.Point(0, 100);
            this._centrePanel.Name = "_centrePanel";
            this._centrePanel.Size = new System.Drawing.Size(349, 224);
            this._centrePanel.TabIndex = 2;
            // 
            // _listBoxControl
            // 
            this._listBoxControl.AutoSize = true;
            this._listBoxControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this._listBoxControl.Location = new System.Drawing.Point(0, 0);
            this._listBoxControl.Name = "_listBoxControl";
            this._listBoxControl.Size = new System.Drawing.Size(349, 224);
            this._listBoxControl.TabIndex = 0;
            // 
            // _bottomPanel
            // 
            this._bottomPanel.Controls.Add(this._okButton);
            this._bottomPanel.Controls.Add(this._cancelButton);
            this._bottomPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this._bottomPanel.Location = new System.Drawing.Point(0, 324);
            this._bottomPanel.Name = "_bottomPanel";
            this._bottomPanel.Size = new System.Drawing.Size(349, 51);
            this._bottomPanel.TabIndex = 1;
            // 
            // _okButton
            // 
            this._okButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._okButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this._okButton.Location = new System.Drawing.Point(181, 16);
            this._okButton.Name = "_okButton";
            this._okButton.Size = new System.Drawing.Size(75, 23);
            this._okButton.TabIndex = 1;
            this._okButton.Text = "OK";
            this._okButton.UseVisualStyleBackColor = true;
            // 
            // _cancelButton
            // 
            this._cancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this._cancelButton.Location = new System.Drawing.Point(262, 16);
            this._cancelButton.Name = "_cancelButton";
            this._cancelButton.Size = new System.Drawing.Size(75, 23);
            this._cancelButton.TabIndex = 0;
            this._cancelButton.Text = "Cancel";
            this._cancelButton.UseVisualStyleBackColor = true;
            // 
            // _topPanel
            // 
            this._topPanel.Controls.Add(this._tableLayoutPanel);
            this._topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this._topPanel.Location = new System.Drawing.Point(0, 0);
            this._topPanel.Name = "_topPanel";
            this._topPanel.Size = new System.Drawing.Size(349, 100);
            this._topPanel.TabIndex = 0;
            // 
            // _tableLayoutPanel
            // 
            this._tableLayoutPanel.ColumnCount = 2;
            this._tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this._tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this._tableLayoutPanel.Controls.Add(this._nameLabel, 0, 0);
            this._tableLayoutPanel.Controls.Add(this._descLabel, 0, 1);
            this._tableLayoutPanel.Controls.Add(this._toolsLabel, 0, 2);
            this._tableLayoutPanel.Controls.Add(this._nameValueLabel, 1, 0);
            this._tableLayoutPanel.Controls.Add(this._descValueLabel, 1, 1);
            this._tableLayoutPanel.Controls.Add(this._toolsValueLabel, 1, 2);
            this._tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this._tableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this._tableLayoutPanel.Name = "_tableLayoutPanel";
            this._tableLayoutPanel.RowCount = 3;
            this._tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this._tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this._tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this._tableLayoutPanel.Size = new System.Drawing.Size(349, 100);
            this._tableLayoutPanel.TabIndex = 0;
            // 
            // _nameLabel
            // 
            this._nameLabel.AutoSize = true;
            this._nameLabel.Location = new System.Drawing.Point(3, 0);
            this._nameLabel.Name = "_nameLabel";
            this._nameLabel.Size = new System.Drawing.Size(39, 13);
            this._nameLabel.TabIndex = 0;
            this._nameLabel.Text = "Attivita";
            // 
            // _descLabel
            // 
            this._descLabel.AutoSize = true;
            this._descLabel.Location = new System.Drawing.Point(3, 20);
            this._descLabel.Name = "_descLabel";
            this._descLabel.Size = new System.Drawing.Size(62, 13);
            this._descLabel.TabIndex = 1;
            this._descLabel.Text = "Descrizione";
            // 
            // _toolsLabel
            // 
            this._toolsLabel.AutoSize = true;
            this._toolsLabel.Location = new System.Drawing.Point(3, 40);
            this._toolsLabel.Name = "_toolsLabel";
            this._toolsLabel.Size = new System.Drawing.Size(41, 13);
            this._toolsLabel.TabIndex = 2;
            this._toolsLabel.Text = "Attrezzi";
            // 
            // _nameValueLabel
            // 
            this._nameValueLabel.AutoSize = true;
            this._nameValueLabel.Location = new System.Drawing.Point(177, 0);
            this._nameValueLabel.Name = "_nameValueLabel";
            this._nameValueLabel.Size = new System.Drawing.Size(92, 13);
            this._nameValueLabel.TabIndex = 3;
            this._nameValueLabel.Text = "_nameValueLabel";
            // 
            // _descValueLabel
            // 
            this._descValueLabel.AutoSize = true;
            this._descValueLabel.Location = new System.Drawing.Point(177, 20);
            this._descValueLabel.Name = "_descValueLabel";
            this._descValueLabel.Size = new System.Drawing.Size(89, 13);
            this._descValueLabel.TabIndex = 4;
            this._descValueLabel.Text = "_descValueLabel";
            // 
            // _toolsValueLabel
            // 
            this._toolsValueLabel.AutoSize = true;
            this._toolsValueLabel.Location = new System.Drawing.Point(177, 40);
            this._toolsValueLabel.Name = "_toolsValueLabel";
            this._toolsValueLabel.Size = new System.Drawing.Size(88, 13);
            this._toolsValueLabel.TabIndex = 5;
            this._toolsValueLabel.Text = "_toolsValueLabel";
            // 
            // NewEsercizioForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 375);
            this.Controls.Add(this.splitContainer1);
            this.Name = "NewEsercizioForm";
            this.Text = "NewEsercizioForm";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this._centrePanel.ResumeLayout(false);
            this._centrePanel.PerformLayout();
            this._bottomPanel.ResumeLayout(false);
            this._topPanel.ResumeLayout(false);
            this._tableLayoutPanel.ResumeLayout(false);
            this._tableLayoutPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TreeView _treeView;
        private System.Windows.Forms.Panel _centrePanel;
        private ListBoxControl _listBoxControl;
        private System.Windows.Forms.Panel _bottomPanel;
        private System.Windows.Forms.Button _okButton;
        private System.Windows.Forms.Button _cancelButton;
        private System.Windows.Forms.Panel _topPanel;
        private System.Windows.Forms.TableLayoutPanel _tableLayoutPanel;
        private System.Windows.Forms.Label _nameLabel;
        private System.Windows.Forms.Label _descLabel;
        private System.Windows.Forms.Label _toolsLabel;
        private System.Windows.Forms.Label _nameValueLabel;
        private System.Windows.Forms.Label _descValueLabel;
        private System.Windows.Forms.Label _toolsValueLabel;
    }
}