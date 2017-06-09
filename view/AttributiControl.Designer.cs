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
            this._titleLabel = new System.Windows.Forms.Label();
            this._topPanel = new System.Windows.Forms.Panel();
            this._newAttributoControl = new Trainary.view.NewAttributoControl();
            this._listBoxControl = new Trainary.view.ListBoxControl();
            this._errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this._topPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // _titleLabel
            // 
            this._titleLabel.AutoSize = true;
            this._titleLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this._titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._titleLabel.Location = new System.Drawing.Point(0, 0);
            this._titleLabel.Margin = new System.Windows.Forms.Padding(3);
            this._titleLabel.Name = "_titleLabel";
            this._titleLabel.Size = new System.Drawing.Size(121, 17);
            this._titleLabel.TabIndex = 0;
            this._titleLabel.Text = "Nuovo Attributo";
            // 
            // _topPanel
            // 
            this._topPanel.AutoSize = true;
            this._topPanel.Controls.Add(this._newAttributoControl);
            this._topPanel.Controls.Add(this._titleLabel);
            this._topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this._topPanel.Location = new System.Drawing.Point(3, 3);
            this._topPanel.Name = "_topPanel";
            this._topPanel.Size = new System.Drawing.Size(412, 95);
            this._topPanel.TabIndex = 1;
            // 
            // _newAttributoControl
            // 
            this._newAttributoControl.AutoSize = true;
            this._newAttributoControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this._newAttributoControl.Location = new System.Drawing.Point(0, 17);
            this._newAttributoControl.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this._newAttributoControl.Name = "_newAttributoControl";
            this._newAttributoControl.Padding = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this._newAttributoControl.Size = new System.Drawing.Size(412, 78);
            this._newAttributoControl.TabIndex = 1;
            // 
            // _listBoxControl
            // 
            this._listBoxControl.AutoSize = true;
            this._listBoxControl.BackColor = System.Drawing.SystemColors.Control;
            this._listBoxControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this._listBoxControl.Location = new System.Drawing.Point(3, 98);
            this._listBoxControl.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this._listBoxControl.Name = "_listBoxControl";
            this._listBoxControl.Size = new System.Drawing.Size(412, 168);
            this._listBoxControl.TabIndex = 2;
            // 
            // _errorProvider
            // 
            this._errorProvider.ContainerControl = this;
            // 
            // AttributiControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this._listBoxControl);
            this.Controls.Add(this._topPanel);
            this.Name = "AttributiControl";
            this.Padding = new System.Windows.Forms.Padding(3);
            this.Size = new System.Drawing.Size(418, 269);
            this._topPanel.ResumeLayout(false);
            this._topPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label _titleLabel;
        private System.Windows.Forms.Panel _topPanel;
        private NewAttributoControl _newAttributoControl;
        private ListBoxControl _listBoxControl;
        private System.Windows.Forms.ErrorProvider _errorProvider;
    }
}
