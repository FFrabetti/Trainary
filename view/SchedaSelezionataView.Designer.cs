namespace Trainary.Presentation
{
    partial class SchedaSelezionataView
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Esercizio 1: Esercizio.FullToString()");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Esercizio 2: Esercizio.FullToString()");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Esercizio 3: Esercizio.FullToString()");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Esercizio 4: Esercizio.FullToString()");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("ecc");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Seduta A", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3,
            treeNode4,
            treeNode5});
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Esercizio 1");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Esercizio 2");
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("Seduta B", new System.Windows.Forms.TreeNode[] {
            treeNode7,
            treeNode8});
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("ecc");
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("ecc");
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("ecc");
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("Seduta C", new System.Windows.Forms.TreeNode[] {
            treeNode10,
            treeNode11,
            treeNode12});
            this._nomeLabel = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this._eliminaButton = new System.Windows.Forms.Button();
            this._periodoLabel = new System.Windows.Forms.Label();
            this._descrizioneLabel = new System.Windows.Forms.Label();
            this._scopoLabel = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this._seduteLabel = new System.Windows.Forms.Label();
            this._indietroButton = new System.Windows.Forms.Button();
            this._salvaButton = new System.Windows.Forms.Button();
            this._nuovoEsercizioButton = new System.Windows.Forms.Button();
            this._nuovaSedutaButton = new System.Windows.Forms.Button();
            this._eliminaEsercizioButton = new System.Windows.Forms.Button();
            this._rinominaSedutaButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // _nomeLabel
            // 
            this._nomeLabel.AutoSize = true;
            this._nomeLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._nomeLabel.Location = new System.Drawing.Point(22, 18);
            this._nomeLabel.Name = "_nomeLabel";
            this._nomeLabel.Size = new System.Drawing.Size(54, 19);
            this._nomeLabel.TabIndex = 1;
            this._nomeLabel.Text = "Nome:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(165, 17);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(190, 20);
            this.textBox1.TabIndex = 2;
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(26, 222);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "Nodo3";
            treeNode1.Text = "Esercizio 1: Esercizio.FullToString()";
            treeNode2.Name = "Nodo4";
            treeNode2.Text = "Esercizio 2: Esercizio.FullToString()";
            treeNode3.Name = "Nodo5";
            treeNode3.Text = "Esercizio 3: Esercizio.FullToString()";
            treeNode4.Name = "Nodo11";
            treeNode4.Text = "Esercizio 4: Esercizio.FullToString()";
            treeNode5.Name = "Nodo12";
            treeNode5.Text = "ecc";
            treeNode6.Name = "Nodo0";
            treeNode6.Text = "Seduta A";
            treeNode7.Name = "Nodo6";
            treeNode7.Text = "Esercizio 1";
            treeNode8.Name = "Nodo7";
            treeNode8.Text = "Esercizio 2";
            treeNode9.Name = "Nodo1";
            treeNode9.Text = "Seduta B";
            treeNode10.Name = "Nodo8";
            treeNode10.Text = "ecc";
            treeNode11.Name = "Nodo9";
            treeNode11.Text = "ecc";
            treeNode12.Name = "Nodo10";
            treeNode12.Text = "ecc";
            treeNode13.Name = "Nodo2";
            treeNode13.Text = "Seduta C";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode6,
            treeNode9,
            treeNode13});
            this.treeView1.Size = new System.Drawing.Size(302, 180);
            this.treeView1.TabIndex = 6;
            // 
            // _eliminaButton
            // 
            this._eliminaButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this._eliminaButton.Cursor = System.Windows.Forms.Cursors.Default;
            this._eliminaButton.ForeColor = System.Drawing.Color.Black;
            this._eliminaButton.Location = new System.Drawing.Point(370, 406);
            this._eliminaButton.Name = "_eliminaButton";
            this._eliminaButton.Size = new System.Drawing.Size(75, 23);
            this._eliminaButton.TabIndex = 5;
            this._eliminaButton.Text = "Elimina";
            this._eliminaButton.UseVisualStyleBackColor = false;
            // 
            // _periodoLabel
            // 
            this._periodoLabel.AutoSize = true;
            this._periodoLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._periodoLabel.ForeColor = System.Drawing.Color.Black;
            this._periodoLabel.Location = new System.Drawing.Point(22, 157);
            this._periodoLabel.Name = "_periodoLabel";
            this._periodoLabel.Size = new System.Drawing.Size(138, 19);
            this._periodoLabel.TabIndex = 7;
            this._periodoLabel.Text = "Periodo di  validità:";
            // 
            // _descrizioneLabel
            // 
            this._descrizioneLabel.AutoSize = true;
            this._descrizioneLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._descrizioneLabel.Location = new System.Drawing.Point(22, 86);
            this._descrizioneLabel.Name = "_descrizioneLabel";
            this._descrizioneLabel.Size = new System.Drawing.Size(92, 19);
            this._descrizioneLabel.TabIndex = 8;
            this._descrizioneLabel.Text = "Descrizione:";
            // 
            // _scopoLabel
            // 
            this._scopoLabel.AutoSize = true;
            this._scopoLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._scopoLabel.Location = new System.Drawing.Point(22, 51);
            this._scopoLabel.Name = "_scopoLabel";
            this._scopoLabel.Size = new System.Drawing.Size(54, 19);
            this._scopoLabel.TabIndex = 9;
            this._scopoLabel.Text = "Scopo:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(165, 50);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(190, 20);
            this.textBox2.TabIndex = 10;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(165, 86);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox3.Size = new System.Drawing.Size(190, 52);
            this.textBox3.TabIndex = 11;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(165, 156);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(190, 20);
            this.textBox4.TabIndex = 12;
            // 
            // _seduteLabel
            // 
            this._seduteLabel.AutoSize = true;
            this._seduteLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._seduteLabel.ForeColor = System.Drawing.Color.Black;
            this._seduteLabel.Location = new System.Drawing.Point(22, 200);
            this._seduteLabel.Name = "_seduteLabel";
            this._seduteLabel.Size = new System.Drawing.Size(60, 19);
            this._seduteLabel.TabIndex = 13;
            this._seduteLabel.Text = "Sedute:";
            // 
            // _indietroButton
            // 
            this._indietroButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this._indietroButton.Cursor = System.Windows.Forms.Cursors.Default;
            this._indietroButton.ForeColor = System.Drawing.Color.Black;
            this._indietroButton.Location = new System.Drawing.Point(370, 466);
            this._indietroButton.Name = "_indietroButton";
            this._indietroButton.Size = new System.Drawing.Size(75, 23);
            this._indietroButton.TabIndex = 14;
            this._indietroButton.Text = "Indietro";
            this._indietroButton.UseVisualStyleBackColor = false;
            // 
            // _salvaButton
            // 
            this._salvaButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this._salvaButton.Cursor = System.Windows.Forms.Cursors.Default;
            this._salvaButton.ForeColor = System.Drawing.Color.Black;
            this._salvaButton.Location = new System.Drawing.Point(370, 437);
            this._salvaButton.Name = "_salvaButton";
            this._salvaButton.Size = new System.Drawing.Size(75, 23);
            this._salvaButton.TabIndex = 15;
            this._salvaButton.Text = "Salva";
            this._salvaButton.UseVisualStyleBackColor = false;
            // 
            // _nuovoEsercizioButton
            // 
            this._nuovoEsercizioButton.Enabled = false;
            this._nuovoEsercizioButton.Location = new System.Drawing.Point(344, 282);
            this._nuovoEsercizioButton.Name = "_nuovoEsercizioButton";
            this._nuovoEsercizioButton.Size = new System.Drawing.Size(101, 23);
            this._nuovoEsercizioButton.TabIndex = 21;
            this._nuovoEsercizioButton.Text = "Nuovo esercizio";
            this._nuovoEsercizioButton.UseVisualStyleBackColor = true;
            // 
            // _nuovaSedutaButton
            // 
            this._nuovaSedutaButton.Location = new System.Drawing.Point(344, 222);
            this._nuovaSedutaButton.Name = "_nuovaSedutaButton";
            this._nuovaSedutaButton.Size = new System.Drawing.Size(101, 23);
            this._nuovaSedutaButton.TabIndex = 20;
            this._nuovaSedutaButton.Text = "Nuova seduta";
            this._nuovaSedutaButton.UseVisualStyleBackColor = true;
            // 
            // _eliminaEsercizioButton
            // 
            this._eliminaEsercizioButton.Enabled = false;
            this._eliminaEsercizioButton.Location = new System.Drawing.Point(344, 311);
            this._eliminaEsercizioButton.Name = "_eliminaEsercizioButton";
            this._eliminaEsercizioButton.Size = new System.Drawing.Size(101, 23);
            this._eliminaEsercizioButton.TabIndex = 22;
            this._eliminaEsercizioButton.Text = "Elimina esercizio";
            this._eliminaEsercizioButton.UseVisualStyleBackColor = true;
            // 
            // _rinominaSedutaButton
            // 
            this._rinominaSedutaButton.Enabled = false;
            this._rinominaSedutaButton.Location = new System.Drawing.Point(344, 251);
            this._rinominaSedutaButton.Name = "_rinominaSedutaButton";
            this._rinominaSedutaButton.Size = new System.Drawing.Size(101, 23);
            this._rinominaSedutaButton.TabIndex = 23;
            this._rinominaSedutaButton.Text = "Rinomina seduta";
            this._rinominaSedutaButton.UseVisualStyleBackColor = true;
            // 
            // SchedaSelezionataView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(459, 496);
            this.Controls.Add(this._rinominaSedutaButton);
            this.Controls.Add(this._eliminaEsercizioButton);
            this.Controls.Add(this._nuovoEsercizioButton);
            this.Controls.Add(this._nuovaSedutaButton);
            this.Controls.Add(this._salvaButton);
            this.Controls.Add(this._indietroButton);
            this.Controls.Add(this._seduteLabel);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this._scopoLabel);
            this.Controls.Add(this._descrizioneLabel);
            this.Controls.Add(this._periodoLabel);
            this.Controls.Add(this._eliminaButton);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this._nomeLabel);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Name = "SchedaSelezionataView";
            this.Text = "Scheda";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label _nomeLabel;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Button _eliminaButton;
        private System.Windows.Forms.Label _periodoLabel;
        private System.Windows.Forms.Label _descrizioneLabel;
        private System.Windows.Forms.Label _scopoLabel;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label _seduteLabel;
        private System.Windows.Forms.Button _indietroButton;
        private System.Windows.Forms.Button _salvaButton;
        private System.Windows.Forms.Button _nuovoEsercizioButton;
        private System.Windows.Forms.Button _nuovaSedutaButton;
        private System.Windows.Forms.Button _eliminaEsercizioButton;
        private System.Windows.Forms.Button _rinominaSedutaButton;
    }
}