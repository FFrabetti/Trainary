namespace Trainary.Presentation
{
    partial class AllenamentoForm
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
            this._allenamentoLabel = new System.Windows.Forms.Label();
            this.dialogButtonsControl1 = new Trainary.view.DialogButtonsControl();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this._aggiungiEsercizioButton = new System.Windows.Forms.Button();
            this._aggiungiCircuitoButton = new System.Windows.Forms.Button();
            this._aggiungiDatiButton = new System.Windows.Forms.Button();
            this._eliminaEsercizioButton = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // _allenamentoLabel
            // 
            this._allenamentoLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this._allenamentoLabel.AutoSize = true;
            this._allenamentoLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._allenamentoLabel.Location = new System.Drawing.Point(156, 9);
            this._allenamentoLabel.Name = "_allenamentoLabel";
            this._allenamentoLabel.Size = new System.Drawing.Size(97, 19);
            this._allenamentoLabel.TabIndex = 0;
            this._allenamentoLabel.Text = "Allenamento ";
            // 
            // dialogButtonsControl1
            // 
            this.dialogButtonsControl1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.dialogButtonsControl1.AutoSize = true;
            this.dialogButtonsControl1.Location = new System.Drawing.Point(-1, 323);
            this.dialogButtonsControl1.Name = "dialogButtonsControl1";
            this.dialogButtonsControl1.Size = new System.Drawing.Size(410, 49);
            this.dialogButtonsControl1.TabIndex = 10;
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel1.AutoSize = true;
            this.panel1.Location = new System.Drawing.Point(14, 121);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(260, 79);
            this.panel1.TabIndex = 12;
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel2.AutoSize = true;
            this.panel2.Controls.Add(this.dateTimePicker1);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(12, 40);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(306, 66);
            this.panel2.TabIndex = 13;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(73, 23);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Data:";
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.panel3.AutoSize = true;
            this.panel3.Controls.Add(this.treeView1);
            this.panel3.Location = new System.Drawing.Point(14, 217);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(301, 106);
            this.panel3.TabIndex = 14;
            // 
            // treeView1
            // 
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView1.Location = new System.Drawing.Point(0, 0);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(301, 106);
            this.treeView1.TabIndex = 1;
            // 
            // _aggiungiEsercizioButton
            // 
            this._aggiungiEsercizioButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this._aggiungiEsercizioButton.Location = new System.Drawing.Point(289, 121);
            this._aggiungiEsercizioButton.Name = "_aggiungiEsercizioButton";
            this._aggiungiEsercizioButton.Size = new System.Drawing.Size(107, 23);
            this._aggiungiEsercizioButton.TabIndex = 15;
            this._aggiungiEsercizioButton.Text = "Aggiungi esercizio";
            this._aggiungiEsercizioButton.UseVisualStyleBackColor = true;
            this._aggiungiEsercizioButton.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // _aggiungiCircuitoButton
            // 
            this._aggiungiCircuitoButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this._aggiungiCircuitoButton.Location = new System.Drawing.Point(289, 150);
            this._aggiungiCircuitoButton.Name = "_aggiungiCircuitoButton";
            this._aggiungiCircuitoButton.Size = new System.Drawing.Size(107, 23);
            this._aggiungiCircuitoButton.TabIndex = 16;
            this._aggiungiCircuitoButton.Text = "Aggiungi circuito";
            this._aggiungiCircuitoButton.UseVisualStyleBackColor = true;
            this._aggiungiCircuitoButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // _aggiungiDatiButton
            // 
            this._aggiungiDatiButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this._aggiungiDatiButton.Location = new System.Drawing.Point(321, 245);
            this._aggiungiDatiButton.Name = "_aggiungiDatiButton";
            this._aggiungiDatiButton.Size = new System.Drawing.Size(88, 23);
            this._aggiungiDatiButton.TabIndex = 17;
            this._aggiungiDatiButton.Text = "Aggiungi dati";
            this._aggiungiDatiButton.UseVisualStyleBackColor = true;
            // 
            // _eliminaEsercizioButton
            // 
            this._eliminaEsercizioButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this._eliminaEsercizioButton.Location = new System.Drawing.Point(289, 179);
            this._eliminaEsercizioButton.Name = "_eliminaEsercizioButton";
            this._eliminaEsercizioButton.Size = new System.Drawing.Size(107, 23);
            this._eliminaEsercizioButton.TabIndex = 18;
            this._eliminaEsercizioButton.Text = "Elimina esercizio";
            this._eliminaEsercizioButton.UseVisualStyleBackColor = true;
            // 
            // AllenamentoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(417, 368);
            this.Controls.Add(this._eliminaEsercizioButton);
            this.Controls.Add(this._aggiungiDatiButton);
            this.Controls.Add(this._aggiungiCircuitoButton);
            this.Controls.Add(this._aggiungiEsercizioButton);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dialogButtonsControl1);
            this.Controls.Add(this._allenamentoLabel);
            this.Name = "AllenamentoForm";
            this.Text = "Allenamento ";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label _allenamentoLabel;
        private view.DialogButtonsControl dialogButtonsControl1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button _aggiungiEsercizioButton;
        private System.Windows.Forms.Button _aggiungiCircuitoButton;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Button _aggiungiDatiButton;
        private System.Windows.Forms.Button _eliminaEsercizioButton;
    }
}