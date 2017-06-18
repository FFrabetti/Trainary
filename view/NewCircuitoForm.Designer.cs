namespace Trainary.view
{
    partial class NewCircuitoForm
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
            this._dialogButtonsControl = new Trainary.view.DialogButtonsControl();
            this._splitContainer = new System.Windows.Forms.SplitContainer();
            this._attributiControl = new Trainary.view.AttributiControl();
            this._listBoxControl = new Trainary.view.ListBoxControl();
            ((System.ComponentModel.ISupportInitialize)(this._splitContainer)).BeginInit();
            this._splitContainer.Panel1.SuspendLayout();
            this._splitContainer.Panel2.SuspendLayout();
            this._splitContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // _dialogButtonsControl
            // 
            this._dialogButtonsControl.AutoSize = true;
            this._dialogButtonsControl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this._dialogButtonsControl.Location = new System.Drawing.Point(0, 409);
            this._dialogButtonsControl.Name = "_dialogButtonsControl";
            this._dialogButtonsControl.Size = new System.Drawing.Size(511, 48);
            this._dialogButtonsControl.TabIndex = 0;
            // 
            // _splitContainer
            // 
            this._splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this._splitContainer.Location = new System.Drawing.Point(0, 0);
            this._splitContainer.Name = "_splitContainer";
            this._splitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // _splitContainer.Panel1
            // 
            this._splitContainer.Panel1.Controls.Add(this._attributiControl);
            // 
            // _splitContainer.Panel2
            // 
            this._splitContainer.Panel2.Controls.Add(this._listBoxControl);
            this._splitContainer.Size = new System.Drawing.Size(511, 409);
            this._splitContainer.SplitterDistance = 224;
            this._splitContainer.TabIndex = 1;
            // 
            // _attributiControl
            // 
            this._attributiControl.AutoSize = true;
            this._attributiControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this._attributiControl.Location = new System.Drawing.Point(0, 0);
            this._attributiControl.Name = "_attributiControl";
            this._attributiControl.Padding = new System.Windows.Forms.Padding(3);
            this._attributiControl.Size = new System.Drawing.Size(511, 224);
            this._attributiControl.TabIndex = 0;
            // 
            // _listBoxControl
            // 
            this._listBoxControl.AutoSize = true;
            this._listBoxControl.BackColor = System.Drawing.SystemColors.Control;
            this._listBoxControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this._listBoxControl.Location = new System.Drawing.Point(0, 0);
            this._listBoxControl.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this._listBoxControl.Name = "_listBoxControl";
            this._listBoxControl.Padding = new System.Windows.Forms.Padding(3);
            this._listBoxControl.Size = new System.Drawing.Size(511, 181);
            this._listBoxControl.TabIndex = 0;
            // 
            // NewCircuitoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 457);
            this.Controls.Add(this._splitContainer);
            this.Controls.Add(this._dialogButtonsControl);
            this.Name = "NewCircuitoForm";
            this.Text = "Nuovo Circuito";
            this._splitContainer.Panel1.ResumeLayout(false);
            this._splitContainer.Panel1.PerformLayout();
            this._splitContainer.Panel2.ResumeLayout(false);
            this._splitContainer.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._splitContainer)).EndInit();
            this._splitContainer.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DialogButtonsControl _dialogButtonsControl;
        private System.Windows.Forms.SplitContainer _splitContainer;
        private AttributiControl _attributiControl;
        private ListBoxControl _listBoxControl;
    }
}