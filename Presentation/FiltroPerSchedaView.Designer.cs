﻿namespace Trainary.Presentation
{
    partial class FiltroPerSchedaView
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
            this._schedaLabel = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this._okButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // _schedaLabel
            // 
            this._schedaLabel.AutoSize = true;
            this._schedaLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._schedaLabel.Location = new System.Drawing.Point(12, 34);
            this._schedaLabel.Name = "_schedaLabel";
            this._schedaLabel.Size = new System.Drawing.Size(127, 19);
            this._schedaLabel.TabIndex = 10;
            this._schedaLabel.Text = "Seleziona scheda:";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(164, 32);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(154, 21);
            this.comboBox1.TabIndex = 11;
            // 
            // _okButton
            // 
            this._okButton.Location = new System.Drawing.Point(243, 81);
            this._okButton.Name = "_okButton";
            this._okButton.Size = new System.Drawing.Size(75, 23);
            this._okButton.TabIndex = 12;
            this._okButton.Text = "OK";
            this._okButton.UseVisualStyleBackColor = true;
            // 
            // FiltroPerSchedaView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(330, 116);
            this.Controls.Add(this._okButton);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this._schedaLabel);
            this.Name = "FiltroPerSchedaView";
            this.Text = "Filtro per scheda";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label _schedaLabel;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button _okButton;
    }
}