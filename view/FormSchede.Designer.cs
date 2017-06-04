namespace Trainary.Presentation
{
    partial class FormSchede
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
            this._allenamentiLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this._nome = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this._scopo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this._descrizione = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this._periodo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this._indietroButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // _allenamentiLabel
            // 
            this._allenamentiLabel.AutoSize = true;
            this._allenamentiLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._allenamentiLabel.Location = new System.Drawing.Point(299, 69);
            this._allenamentiLabel.Name = "_allenamentiLabel";
            this._allenamentiLabel.Size = new System.Drawing.Size(65, 16);
            this._allenamentiLabel.TabIndex = 5;
            this._allenamentiLabel.Text = "Schede:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(519, 21);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 26);
            this.button1.TabIndex = 6;
            this.button1.Text = "Nuova scheda";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.SystemColors.Window;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this._nome,
            this._scopo,
            this._descrizione,
            this._periodo});
            this.listView1.Enabled = false;
            this.listView1.Location = new System.Drawing.Point(32, 98);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(590, 175);
            this.listView1.TabIndex = 7;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // _nome
            // 
            this._nome.Text = "Nome";
            this._nome.Width = 124;
            // 
            // _scopo
            // 
            this._scopo.Text = "Scopo";
            this._scopo.Width = 144;
            // 
            // _descrizione
            // 
            this._descrizione.Text = "Descrizione";
            this._descrizione.Width = 163;
            // 
            // _periodo
            // 
            this._periodo.Text = "Periodo di validità";
            this._periodo.Width = 154;
            // 
            // _indietroButton
            // 
            this._indietroButton.Location = new System.Drawing.Point(547, 311);
            this._indietroButton.Name = "_indietroButton";
            this._indietroButton.Size = new System.Drawing.Size(75, 23);
            this._indietroButton.TabIndex = 8;
            this._indietroButton.Text = "Indietro";
            this._indietroButton.UseVisualStyleBackColor = true;
            // 
            // FormSchede
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(652, 346);
            this.Controls.Add(this._indietroButton);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this._allenamentiLabel);
            this.Name = "FormSchede";
            this.Text = "Gestione schede";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label _allenamentiLabel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader _nome;
        private System.Windows.Forms.ColumnHeader _scopo;
        private System.Windows.Forms.ColumnHeader _descrizione;
        private System.Windows.Forms.ColumnHeader _periodo;
        private System.Windows.Forms.Button _indietroButton;
    }
}