using System;
using System.Windows.Forms;
using Trainary.model;
using Trainary.utils;

namespace Trainary.presenter.filtri
{
    [Label("Filtro per scopo")]
    public class FiltroPerScopoPresenter : FiltroPresenter
    {
        private Label _scopoLabel = new Label();
        private ComboBox _comboBox = new ComboBox();

        public FiltroPerScopoPresenter()
        {
            //_sedutaLabel
            this._scopoLabel.AutoSize = true;
            this._scopoLabel.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._scopoLabel.Location = new System.Drawing.Point(23, 25);
            this._scopoLabel.Size = new System.Drawing.Size(116, 16);
            this._scopoLabel.TabIndex = 13;
            this._scopoLabel.Text = "Seleziona scopo:";
            // 
            // _comboBox
            // 
            this._comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._comboBox.FormattingEnabled = true;
            this._comboBox.Location = new System.Drawing.Point(154, 20);
            this._comboBox.Name = "_comboBox";
            this._comboBox.Size = new System.Drawing.Size(154, 21);
            this._comboBox.TabIndex = 11;

            _comboBox.DataSource = Enum.GetValues(typeof(ScopoDellaScheda));
        }

        public override void DrawControls(Panel panel)
        {
            panel.Controls.Add(_scopoLabel);
            panel.Controls.Add(_comboBox);
        }

        public override object GetOpzione()
        {
            return (ScopoDellaScheda)_comboBox.SelectedItem;
        }
    }
}
