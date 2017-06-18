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
            this.components = new System.ComponentModel.Container();
            this._treeView = new System.Windows.Forms.TreeView();
            this._splitContainer = new System.Windows.Forms.SplitContainer();
            this._attributiControl = new Trainary.view.AttributiControl();
            this._tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this._attivitaLabel = new System.Windows.Forms.Label();
            this._descLabel = new System.Windows.Forms.Label();
            this._attrezziLabel = new System.Windows.Forms.Label();
            this._attivitaValueLabel = new System.Windows.Forms.Label();
            this._descValueLabel = new System.Windows.Forms.Label();
            this._attrezziValueLabel = new System.Windows.Forms.Label();
            this._errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this._dialogButtonsControl = new Trainary.view.DialogButtonsControl();
            ((System.ComponentModel.ISupportInitialize)(this._splitContainer)).BeginInit();
            this._splitContainer.Panel1.SuspendLayout();
            this._splitContainer.Panel2.SuspendLayout();
            this._splitContainer.SuspendLayout();
            this._tableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // _treeView
            // 
            this._treeView.Dock = System.Windows.Forms.DockStyle.Fill;
            this._treeView.Location = new System.Drawing.Point(0, 0);
            this._treeView.Name = "_treeView";
            this._treeView.Size = new System.Drawing.Size(213, 350);
            this._treeView.TabIndex = 0;
            // 
            // _splitContainer
            // 
            this._splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this._splitContainer.Location = new System.Drawing.Point(0, 0);
            this._splitContainer.Name = "_splitContainer";
            // 
            // _splitContainer.Panel1
            // 
            this._splitContainer.Panel1.Controls.Add(this._treeView);
            // 
            // _splitContainer.Panel2
            // 
            this._splitContainer.Panel2.Controls.Add(this._attributiControl);
            this._splitContainer.Panel2.Controls.Add(this._tableLayoutPanel);
            this._splitContainer.Size = new System.Drawing.Size(644, 350);
            this._splitContainer.SplitterDistance = 213;
            this._splitContainer.TabIndex = 1;
            // 
            // _attributiControl
            // 
            this._attributiControl.AutoSize = true;
            this._attributiControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this._attributiControl.Location = new System.Drawing.Point(0, 80);
            this._attributiControl.Margin = new System.Windows.Forms.Padding(0);
            this._attributiControl.Name = "_attributiControl";
            this._attributiControl.Padding = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this._attributiControl.Size = new System.Drawing.Size(427, 270);
            this._attributiControl.TabIndex = 7;
            // 
            // _tableLayoutPanel
            // 
            this._tableLayoutPanel.ColumnCount = 2;
            this._tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this._tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 66.66666F));
            this._tableLayoutPanel.Controls.Add(this._attivitaLabel, 0, 0);
            this._tableLayoutPanel.Controls.Add(this._descLabel, 0, 1);
            this._tableLayoutPanel.Controls.Add(this._attrezziLabel, 0, 2);
            this._tableLayoutPanel.Controls.Add(this._attivitaValueLabel, 1, 0);
            this._tableLayoutPanel.Controls.Add(this._descValueLabel, 1, 1);
            this._tableLayoutPanel.Controls.Add(this._attrezziValueLabel, 1, 2);
            this._tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this._tableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this._tableLayoutPanel.Name = "_tableLayoutPanel";
            this._tableLayoutPanel.Padding = new System.Windows.Forms.Padding(0, 7, 0, 0);
            this._tableLayoutPanel.RowCount = 3;
            this._tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this._tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this._tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this._tableLayoutPanel.Size = new System.Drawing.Size(427, 80);
            this._tableLayoutPanel.TabIndex = 6;
            // 
            // _attivitaLabel
            // 
            this._attivitaLabel.AutoSize = true;
            this._attivitaLabel.Location = new System.Drawing.Point(3, 10);
            this._attivitaLabel.Margin = new System.Windows.Forms.Padding(3);
            this._attivitaLabel.Name = "_attivitaLabel";
            this._attivitaLabel.Size = new System.Drawing.Size(39, 13);
            this._attivitaLabel.TabIndex = 0;
            this._attivitaLabel.Text = "Attivita";
            // 
            // _descLabel
            // 
            this._descLabel.AutoSize = true;
            this._descLabel.Location = new System.Drawing.Point(3, 30);
            this._descLabel.Margin = new System.Windows.Forms.Padding(3);
            this._descLabel.Name = "_descLabel";
            this._descLabel.Size = new System.Drawing.Size(62, 13);
            this._descLabel.TabIndex = 1;
            this._descLabel.Text = "Descrizione";
            // 
            // _attrezziLabel
            // 
            this._attrezziLabel.AutoSize = true;
            this._attrezziLabel.Location = new System.Drawing.Point(3, 50);
            this._attrezziLabel.Margin = new System.Windows.Forms.Padding(3);
            this._attrezziLabel.Name = "_attrezziLabel";
            this._attrezziLabel.Size = new System.Drawing.Size(41, 13);
            this._attrezziLabel.TabIndex = 2;
            this._attrezziLabel.Text = "Attrezzi";
            // 
            // _attivitaValueLabel
            // 
            this._attivitaValueLabel.AutoSize = true;
            this._attivitaValueLabel.Location = new System.Drawing.Point(145, 10);
            this._attivitaValueLabel.Margin = new System.Windows.Forms.Padding(3);
            this._attivitaValueLabel.Name = "_attivitaValueLabel";
            this._attivitaValueLabel.Size = new System.Drawing.Size(97, 13);
            this._attivitaValueLabel.TabIndex = 3;
            this._attivitaValueLabel.Text = "_attivitaValueLabel";
            // 
            // _descValueLabel
            // 
            this._descValueLabel.AutoSize = true;
            this._descValueLabel.Location = new System.Drawing.Point(145, 30);
            this._descValueLabel.Margin = new System.Windows.Forms.Padding(3);
            this._descValueLabel.Name = "_descValueLabel";
            this._descValueLabel.Size = new System.Drawing.Size(89, 13);
            this._descValueLabel.TabIndex = 4;
            this._descValueLabel.Text = "_descValueLabel";
            // 
            // _attrezziValueLabel
            // 
            this._attrezziValueLabel.AutoSize = true;
            this._attrezziValueLabel.Location = new System.Drawing.Point(145, 50);
            this._attrezziValueLabel.Margin = new System.Windows.Forms.Padding(3);
            this._attrezziValueLabel.Name = "_attrezziValueLabel";
            this._attrezziValueLabel.Size = new System.Drawing.Size(99, 13);
            this._attrezziValueLabel.TabIndex = 5;
            this._attrezziValueLabel.Text = "_attrezziValueLabel";
            // 
            // _errorProvider
            // 
            this._errorProvider.ContainerControl = this;
            // 
            // _dialogButtonsControl
            // 
            this._dialogButtonsControl.AutoSize = true;
            this._dialogButtonsControl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this._dialogButtonsControl.Location = new System.Drawing.Point(0, 350);
            this._dialogButtonsControl.Name = "_dialogButtonsControl";
            this._dialogButtonsControl.Size = new System.Drawing.Size(644, 51);
            this._dialogButtonsControl.TabIndex = 0;
            // 
            // NewEsercizioForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 401);
            this.Controls.Add(this._splitContainer);
            this.Controls.Add(this._dialogButtonsControl);
            this.Name = "NewEsercizioForm";
            this.Text = "Nuovo Esercizio";
            this._splitContainer.Panel1.ResumeLayout(false);
            this._splitContainer.Panel2.ResumeLayout(false);
            this._splitContainer.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._splitContainer)).EndInit();
            this._splitContainer.ResumeLayout(false);
            this._tableLayoutPanel.ResumeLayout(false);
            this._tableLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DialogButtonsControl _dialogButtonsControl;
        private System.Windows.Forms.TreeView _treeView;
        private System.Windows.Forms.SplitContainer _splitContainer;
        private System.Windows.Forms.TableLayoutPanel _tableLayoutPanel;
        private System.Windows.Forms.Label _attivitaLabel;
        private System.Windows.Forms.Label _descLabel;
        private System.Windows.Forms.Label _attrezziLabel;
        private System.Windows.Forms.Label _attivitaValueLabel;
        private System.Windows.Forms.Label _descValueLabel;
        private System.Windows.Forms.Label _attrezziValueLabel;
        private System.Windows.Forms.ErrorProvider _errorProvider;
        private AttributiControl _attributiControl;
    }
}