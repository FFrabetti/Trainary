using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Trainary.model;
using Trainary.utils;

namespace Trainary.presenter.filtri
{
    [Label("Filtro per seduta")]
    public class FiltroPerSedutaPresenter : FiltroPresenter
    {
        private Label _schedaLabel = new Label();
        private Label _sedutaLabel = new Label();
        private ComboBox _schedeCombo = new ComboBox();
        private ComboBox _seduteCombo = new ComboBox();

        private List<Scheda> _schede = new List<Scheda>();
        private List<Seduta> _sedute = new List<Seduta>();

        public FiltroPerSedutaPresenter()
        {
            // _schedaLabel
            this._schedaLabel.AutoSize = true;
            this._schedaLabel.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._schedaLabel.Location = new System.Drawing.Point(23, 25);
            this._schedaLabel.Size = new System.Drawing.Size(116, 16);
            this._schedaLabel.TabIndex = 13;
            this._schedaLabel.Text = "Seleziona scheda:";
            
            // _schedeCombo
            this._schedeCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._schedeCombo.FormattingEnabled = true;
            this._schedeCombo.Location = new System.Drawing.Point(154, 20);
            this._schedeCombo.Size = new System.Drawing.Size(154, 21);
            this._schedeCombo.TabIndex = 14;
             
            // _seduteCombo
            this._seduteCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._seduteCombo.FormattingEnabled = true;
            this._seduteCombo.Location = new System.Drawing.Point(154, 54);
            this._seduteCombo.Size = new System.Drawing.Size(154, 21);
            this._seduteCombo.TabIndex = 16;
            
            // _sedutaLabel
            this._sedutaLabel.AutoSize = true;
            this._sedutaLabel.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._sedutaLabel.Location = new System.Drawing.Point(23, 59);
            this._sedutaLabel.Size = new System.Drawing.Size(114, 16);
            this._sedutaLabel.TabIndex = 15;
            this._sedutaLabel.Text = "Seleziona seduta:";

            InizializeSchedeCombo();
        }

        private void InizializeSchedeCombo()
        {
            foreach (Scheda scheda in GestoreSchede.GetInstance().GetSchede())
                _schede.Add(scheda);

            _schedeCombo.DataSource = _schede;
        }

        private void InizializeSeduteCombo()
        {
            Scheda scheda = (Scheda)_schedeCombo.SelectedItem;
            foreach (Seduta seduta in scheda.Sedute)
                _sedute.Add(seduta);

            _seduteCombo.DataSource = _sedute;
        }

        public override void DrawControls(Panel panel)
        {
            panel.Controls.Add(_schedaLabel);
            panel.Controls.Add(_sedutaLabel);
            panel.Controls.Add(_schedeCombo);
            panel.Controls.Add(_seduteCombo);
            InizializeSeduteCombo();
        }

        public override object GetOpzione()
        {
            Seduta seduta = null;
            try
            {
                seduta = (Seduta)_seduteCombo.SelectedItem;
            }
            catch
            { }
            return seduta;
        }
    }
}
