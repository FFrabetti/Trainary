using System;
using System.Windows.Forms;
using Trainary.model;
using Trainary.utils;

namespace Trainary.presenter
{
    [Label("Filtro per seduta")]
    public class FiltroPerSedutaPresenter : FiltroPresenter
    {
        private Label _sedutaLabel = new Label();
        private ComboBox _comboBox = new ComboBox();

        public FiltroPerSedutaPresenter()
        {
            //_sedutaLabel
            this._sedutaLabel.AutoSize = true;
            this._sedutaLabel.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._sedutaLabel.Location = new System.Drawing.Point(23, 25);
            this._sedutaLabel.Size = new System.Drawing.Size(116, 16);
            this._sedutaLabel.TabIndex = 13;
            this._sedutaLabel.Text = "Seleziona seduta:";
            // 
            // _comboBox
            // 
            this._comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._comboBox.FormattingEnabled = true;
            this._comboBox.Location = new System.Drawing.Point(154, 20);
            this._comboBox.Name = "_comboBox";
            this._comboBox.Size = new System.Drawing.Size(154, 21);
            this._comboBox.TabIndex = 11;

            InizializeCombo();
        }

        private void InizializeCombo()
        {
            foreach (Scheda scheda in GestoreSchede.GetSchede())
            {
                foreach (Seduta seduta in scheda.Sedute)
                {
                    _comboBox.Items.Add(seduta);
                }
            }
        }

        public override void DrawControls(Panel panel)
        {
            panel.Controls.Add(_sedutaLabel);
            panel.Controls.Add(_comboBox);
        }

        public override object GetOpzione()
        {
            Seduta seduta = null;
            try
            {
                seduta = (Seduta)_comboBox.SelectedItem;
            }
            catch
            {

            }
            return seduta;
        }
    }
}
