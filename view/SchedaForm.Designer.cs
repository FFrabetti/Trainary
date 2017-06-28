﻿namespace Trainary.Presentation
{
    partial class SchedaForm
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
            this._nomeLabel = new System.Windows.Forms.Label();
            this._nome = new System.Windows.Forms.TextBox();
            this._dataInizioLabel = new System.Windows.Forms.Label();
            this._descrizioneLabel = new System.Windows.Forms.Label();
            this._scopoLabel = new System.Windows.Forms.Label();
            this._descrizione = new System.Windows.Forms.TextBox();
            this._seduteLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this._nuovoEsercizioButton = new System.Windows.Forms.Button();
            this._nuovaSedutaButton = new System.Windows.Forms.Button();
            this._dataInizio = new System.Windows.Forms.DateTimePicker();
            this._dataFine = new System.Windows.Forms.DateTimePicker();
            this._dataFineLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this._durata = new System.Windows.Forms.TextBox();
            this._rinominaSedutaButton = new System.Windows.Forms.Button();
            this._eliminaEsercizioButton = new System.Windows.Forms.Button();
            this._dataFineRadioButton = new System.Windows.Forms.RadioButton();
            this._durataRadioButton = new System.Windows.Forms.RadioButton();
            this.dialogButtonsControl1 = new Trainary.view.DialogButtonsControl();
            this._rimuoviSedutaButton = new System.Windows.Forms.Button();
            this._nuovoCircuitoButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this._seduteTreeView = new System.Windows.Forms.TreeView();
            this.buttonsel = new System.Windows.Forms.Button();
            this._scopoComboBox = new System.Windows.Forms.ComboBox();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // _nomeLabel
            // 
            this._nomeLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this._nomeLabel.AutoSize = true;
            this._nomeLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._nomeLabel.Location = new System.Drawing.Point(22, 18);
            this._nomeLabel.Name = "_nomeLabel";
            this._nomeLabel.Size = new System.Drawing.Size(62, 19);
            this._nomeLabel.TabIndex = 1;
            this._nomeLabel.Text = "Nome*:";
            // 
            // _nome
            // 
            this._nome.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this._nome.Location = new System.Drawing.Point(172, 17);
            this._nome.Name = "_nome";
            this._nome.Size = new System.Drawing.Size(195, 20);
            this._nome.TabIndex = 2;
            // 
            // _dataInizioLabel
            // 
            this._dataInizioLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this._dataInizioLabel.AutoSize = true;
            this._dataInizioLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._dataInizioLabel.ForeColor = System.Drawing.Color.Black;
            this._dataInizioLabel.Location = new System.Drawing.Point(22, 156);
            this._dataInizioLabel.Name = "_dataInizioLabel";
            this._dataInizioLabel.Size = new System.Drawing.Size(93, 19);
            this._dataInizioLabel.TabIndex = 7;
            this._dataInizioLabel.Text = "Data inizio*:";
            // 
            // _descrizioneLabel
            // 
            this._descrizioneLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
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
            this._scopoLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this._scopoLabel.AutoSize = true;
            this._scopoLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._scopoLabel.Location = new System.Drawing.Point(22, 51);
            this._scopoLabel.Name = "_scopoLabel";
            this._scopoLabel.Size = new System.Drawing.Size(54, 19);
            this._scopoLabel.TabIndex = 9;
            this._scopoLabel.Text = "Scopo:";
            // 
            // _descrizione
            // 
            this._descrizione.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this._descrizione.Location = new System.Drawing.Point(172, 86);
            this._descrizione.Multiline = true;
            this._descrizione.Name = "_descrizione";
            this._descrizione.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this._descrizione.Size = new System.Drawing.Size(195, 52);
            this._descrizione.TabIndex = 11;
            // 
            // _seduteLabel
            // 
            this._seduteLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this._seduteLabel.AutoSize = true;
            this._seduteLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._seduteLabel.ForeColor = System.Drawing.Color.Black;
            this._seduteLabel.Location = new System.Drawing.Point(22, 282);
            this._seduteLabel.Name = "_seduteLabel";
            this._seduteLabel.Size = new System.Drawing.Size(64, 19);
            this._seduteLabel.TabIndex = 13;
            this._seduteLabel.Text = "Sedute :";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Red;
            this.label1.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(23, 515);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(335, 15);
            this.label1.TabIndex = 18;
            this.label1.Text = "Nota: i campi contrassegnati con * sono obbligatori";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // _nuovoEsercizioButton
            // 
            this._nuovoEsercizioButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this._nuovoEsercizioButton.Enabled = false;
            this._nuovoEsercizioButton.Location = new System.Drawing.Point(344, 393);
            this._nuovoEsercizioButton.Name = "_nuovoEsercizioButton";
            this._nuovoEsercizioButton.Size = new System.Drawing.Size(101, 23);
            this._nuovoEsercizioButton.TabIndex = 23;
            this._nuovoEsercizioButton.Text = "Nuovo esercizio";
            this._nuovoEsercizioButton.UseVisualStyleBackColor = true;
            // 
            // _nuovaSedutaButton
            // 
            this._nuovaSedutaButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this._nuovaSedutaButton.Location = new System.Drawing.Point(344, 304);
            this._nuovaSedutaButton.Name = "_nuovaSedutaButton";
            this._nuovaSedutaButton.Size = new System.Drawing.Size(101, 23);
            this._nuovaSedutaButton.TabIndex = 22;
            this._nuovaSedutaButton.Text = "Nuova seduta";
            this._nuovaSedutaButton.UseVisualStyleBackColor = true;
            // 
            // _dataInizio
            // 
            this._dataInizio.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this._dataInizio.Location = new System.Drawing.Point(185, 156);
            this._dataInizio.Name = "_dataInizio";
            this._dataInizio.Size = new System.Drawing.Size(182, 20);
            this._dataInizio.TabIndex = 24;
            // 
            // _dataFine
            // 
            this._dataFine.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this._dataFine.Location = new System.Drawing.Point(185, 188);
            this._dataFine.Name = "_dataFine";
            this._dataFine.Size = new System.Drawing.Size(182, 20);
            this._dataFine.TabIndex = 26;
            // 
            // _dataFineLabel
            // 
            this._dataFineLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this._dataFineLabel.AutoSize = true;
            this._dataFineLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._dataFineLabel.ForeColor = System.Drawing.Color.Black;
            this._dataFineLabel.Location = new System.Drawing.Point(22, 189);
            this._dataFineLabel.Name = "_dataFineLabel";
            this._dataFineLabel.Size = new System.Drawing.Size(76, 19);
            this._dataFineLabel.TabIndex = 25;
            this._dataFineLabel.Text = "Data fine:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(23, 222);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 19);
            this.label2.TabIndex = 27;
            this.label2.Text = "Durata (giorni):";
            // 
            // _durata
            // 
            this._durata.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this._durata.Location = new System.Drawing.Point(185, 222);
            this._durata.Name = "_durata";
            this._durata.Size = new System.Drawing.Size(182, 20);
            this._durata.TabIndex = 29;
            // 
            // _rinominaSedutaButton
            // 
            this._rinominaSedutaButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this._rinominaSedutaButton.Enabled = false;
            this._rinominaSedutaButton.Location = new System.Drawing.Point(344, 333);
            this._rinominaSedutaButton.Name = "_rinominaSedutaButton";
            this._rinominaSedutaButton.Size = new System.Drawing.Size(101, 23);
            this._rinominaSedutaButton.TabIndex = 31;
            this._rinominaSedutaButton.Text = "Rinomina seduta";
            this._rinominaSedutaButton.UseVisualStyleBackColor = true;
            // 
            // _eliminaEsercizioButton
            // 
            this._eliminaEsercizioButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this._eliminaEsercizioButton.Enabled = false;
            this._eliminaEsercizioButton.Location = new System.Drawing.Point(344, 455);
            this._eliminaEsercizioButton.Name = "_eliminaEsercizioButton";
            this._eliminaEsercizioButton.Size = new System.Drawing.Size(101, 23);
            this._eliminaEsercizioButton.TabIndex = 30;
            this._eliminaEsercizioButton.Text = "Elimina esercizio";
            this._eliminaEsercizioButton.UseVisualStyleBackColor = true;
            // 
            // _dataFineRadioButton
            // 
            this._dataFineRadioButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this._dataFineRadioButton.AutoSize = true;
            this._dataFineRadioButton.Checked = true;
            this._dataFineRadioButton.Location = new System.Drawing.Point(165, 193);
            this._dataFineRadioButton.Name = "_dataFineRadioButton";
            this._dataFineRadioButton.Size = new System.Drawing.Size(14, 13);
            this._dataFineRadioButton.TabIndex = 33;
            this._dataFineRadioButton.TabStop = true;
            this._dataFineRadioButton.UseVisualStyleBackColor = true;
            // 
            // _durataRadioButton
            // 
            this._durataRadioButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this._durataRadioButton.AutoSize = true;
            this._durataRadioButton.Location = new System.Drawing.Point(165, 225);
            this._durataRadioButton.Name = "_durataRadioButton";
            this._durataRadioButton.Size = new System.Drawing.Size(14, 13);
            this._durataRadioButton.TabIndex = 34;
            this._durataRadioButton.UseVisualStyleBackColor = true;
            // 
            // dialogButtonsControl1
            // 
            this.dialogButtonsControl1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.dialogButtonsControl1.AutoSize = true;
            this.dialogButtonsControl1.Location = new System.Drawing.Point(0, 552);
            this.dialogButtonsControl1.Name = "dialogButtonsControl1";
            this.dialogButtonsControl1.Size = new System.Drawing.Size(459, 59);
            this.dialogButtonsControl1.TabIndex = 35;
            // 
            // _rimuoviSedutaButton
            // 
            this._rimuoviSedutaButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this._rimuoviSedutaButton.Location = new System.Drawing.Point(344, 364);
            this._rimuoviSedutaButton.Name = "_rimuoviSedutaButton";
            this._rimuoviSedutaButton.Size = new System.Drawing.Size(101, 23);
            this._rimuoviSedutaButton.TabIndex = 37;
            this._rimuoviSedutaButton.Text = "Elimina Seduta";
            this._rimuoviSedutaButton.UseVisualStyleBackColor = true;
            // 
            // _nuovoCircuitoButton
            // 
            this._nuovoCircuitoButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this._nuovoCircuitoButton.Location = new System.Drawing.Point(344, 425);
            this._nuovoCircuitoButton.Name = "_nuovoCircuitoButton";
            this._nuovoCircuitoButton.Size = new System.Drawing.Size(101, 23);
            this._nuovoCircuitoButton.TabIndex = 38;
            this._nuovoCircuitoButton.Text = "Nuovo Circuito";
            this._nuovoCircuitoButton.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.panel2.AutoSize = true;
            this.panel2.Controls.Add(this._seduteTreeView);
            this.panel2.Location = new System.Drawing.Point(26, 304);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(312, 183);
            this.panel2.TabIndex = 40;
            // 
            // _seduteTreeView
            // 
            this._seduteTreeView.Dock = System.Windows.Forms.DockStyle.Fill;
            this._seduteTreeView.Location = new System.Drawing.Point(0, 0);
            this._seduteTreeView.Name = "_seduteTreeView";
            this._seduteTreeView.Size = new System.Drawing.Size(312, 183);
            this._seduteTreeView.TabIndex = 17;
            this._seduteTreeView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this._seduteTreeView_AfterSelect_1);
            // 
            // buttonsel
            // 
            this.buttonsel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonsel.Enabled = false;
            this.buttonsel.Location = new System.Drawing.Point(344, 485);
            this.buttonsel.Name = "buttonsel";
            this.buttonsel.Size = new System.Drawing.Size(101, 23);
            this.buttonsel.TabIndex = 41;
            this.buttonsel.Text = "Annulla selezione";
            this.buttonsel.UseVisualStyleBackColor = true;
            // 
            // _scopoComboBox
            // 
            this._scopoComboBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this._scopoComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._scopoComboBox.FormattingEnabled = true;
            this._scopoComboBox.Location = new System.Drawing.Point(172, 52);
            this._scopoComboBox.Name = "_scopoComboBox";
            this._scopoComboBox.Size = new System.Drawing.Size(195, 21);
            this._scopoComboBox.TabIndex = 42;
            // 
            // SchedaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(459, 611);
            this.Controls.Add(this._scopoComboBox);
            this.Controls.Add(this.buttonsel);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this._nuovoCircuitoButton);
            this.Controls.Add(this._rimuoviSedutaButton);
            this.Controls.Add(this.dialogButtonsControl1);
            this.Controls.Add(this._durataRadioButton);
            this.Controls.Add(this._dataFineRadioButton);
            this.Controls.Add(this._rinominaSedutaButton);
            this.Controls.Add(this._eliminaEsercizioButton);
            this.Controls.Add(this._durata);
            this.Controls.Add(this.label2);
            this.Controls.Add(this._dataFine);
            this.Controls.Add(this._dataFineLabel);
            this.Controls.Add(this._dataInizio);
            this.Controls.Add(this._nuovoEsercizioButton);
            this.Controls.Add(this._nuovaSedutaButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this._seduteLabel);
            this.Controls.Add(this._descrizione);
            this.Controls.Add(this._scopoLabel);
            this.Controls.Add(this._descrizioneLabel);
            this.Controls.Add(this._dataInizioLabel);
            this.Controls.Add(this._nome);
            this.Controls.Add(this._nomeLabel);
            this.Name = "SchedaForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nuova scheda";
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label _nomeLabel;
        private System.Windows.Forms.TextBox _nome;
        private System.Windows.Forms.Label _dataInizioLabel;
        private System.Windows.Forms.Label _descrizioneLabel;
        private System.Windows.Forms.Label _scopoLabel;
        private System.Windows.Forms.TextBox _descrizione;
        private System.Windows.Forms.Label _seduteLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button _nuovoEsercizioButton;
        private System.Windows.Forms.Button _nuovaSedutaButton;
        private System.Windows.Forms.DateTimePicker _dataInizio;
        private System.Windows.Forms.DateTimePicker _dataFine;
        private System.Windows.Forms.Label _dataFineLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox _durata;
        private System.Windows.Forms.Button _rinominaSedutaButton;
        private System.Windows.Forms.Button _eliminaEsercizioButton;
        private System.Windows.Forms.RadioButton _dataFineRadioButton;
        private System.Windows.Forms.RadioButton _durataRadioButton;
        private view.DialogButtonsControl dialogButtonsControl1;
        private System.Windows.Forms.Button _rimuoviSedutaButton;
        private System.Windows.Forms.Button _nuovoCircuitoButton;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TreeView _seduteTreeView;
        private System.Windows.Forms.Button buttonsel;
        private System.Windows.Forms.ComboBox _scopoComboBox;
    }
}