namespace Trainary.Presentation
{
    partial class AllenamentoExtraView
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
            this._allenamentoExtraabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this._salvaButton = new System.Windows.Forms.Button();
            this._indietroButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // _allenamentoExtraabel
            // 
            this._allenamentoExtraabel.AutoSize = true;
            this._allenamentoExtraabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._allenamentoExtraabel.Location = new System.Drawing.Point(122, 9);
            this._allenamentoExtraabel.Name = "_allenamentoExtraabel";
            this._allenamentoExtraabel.Size = new System.Drawing.Size(134, 19);
            this._allenamentoExtraabel.TabIndex = 0;
            this._allenamentoExtraabel.Text = "Allenamento Extra";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Data:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(27, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Esercizi:";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(109, 82);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(160, 20);
            this.textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.textBox2.Enabled = false;
            this.textBox2.Location = new System.Drawing.Point(109, 128);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox2.Size = new System.Drawing.Size(265, 138);
            this.textBox2.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(27, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Nome:";
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.textBox3.Location = new System.Drawing.Point(109, 47);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(160, 20);
            this.textBox3.TabIndex = 8;
            // 
            // _salvaButton
            // 
            this._salvaButton.Location = new System.Drawing.Point(239, 289);
            this._salvaButton.Name = "_salvaButton";
            this._salvaButton.Size = new System.Drawing.Size(75, 23);
            this._salvaButton.TabIndex = 9;
            this._salvaButton.Text = "Salva";
            this._salvaButton.UseVisualStyleBackColor = true;
            // 
            // _indietroButton
            // 
            this._indietroButton.Location = new System.Drawing.Point(320, 289);
            this._indietroButton.Name = "_indietroButton";
            this._indietroButton.Size = new System.Drawing.Size(75, 23);
            this._indietroButton.TabIndex = 10;
            this._indietroButton.Text = "Indietro";
            this._indietroButton.UseVisualStyleBackColor = true;
            // 
            // AllenamentoExtraView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(408, 329);
            this.Controls.Add(this._indietroButton);
            this.Controls.Add(this._salvaButton);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this._allenamentoExtraabel);
            this.Name = "AllenamentoExtraView";
            this.Text = "Allenamento Programmato";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label _allenamentoExtraabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button _salvaButton;
        private System.Windows.Forms.Button _indietroButton;
    }
}