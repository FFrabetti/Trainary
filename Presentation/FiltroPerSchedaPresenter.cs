using System;
using System.Windows.Forms;
using Trainary.model;
using Trainary.utils;

namespace Trainary.presenter
{
    [Label("Filtro per scheda")]
    public class FiltroPerSchedaPresenter : FiltroPresenter
    {
        private Label _schedaLabel = new Label();
        private ComboBox _comboBox = new ComboBox();

        public FiltroPerSchedaPresenter()
        {
            //_schedaLabel
            this._schedaLabel.AutoSize = true;
            this._schedaLabel.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._schedaLabel.Location = new System.Drawing.Point(23, 25);
            this._schedaLabel.Size = new System.Drawing.Size(116, 16);
            this._schedaLabel.TabIndex = 13;
            this._schedaLabel.Text = "Seleziona scheda:";
            // 
            // _comboBox
            // 
            this._comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._comboBox.FormattingEnabled = true;
            this._comboBox.Location = new System.Drawing.Point(154, 20);
            this._comboBox.Name = "_comboBox";
            this._comboBox.Size = new System.Drawing.Size(154, 21);
            this._comboBox.TabIndex = 11;

            _comboBox.DataSource = GestoreSchede.GetSchede();
        }

        public override void DrawControls(Panel panel)
        {
            panel.Controls.Add(_schedaLabel);
            panel.Controls.Add(_comboBox);
        }

        public override object GetOpzione()
        {
            Scheda scheda = null;
            try
            {
                scheda = (Scheda)_comboBox.SelectedItem;
            }
            catch (Exception e)
            {

            }
            return scheda;
        }
    }
}
