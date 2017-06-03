using System;
using System.Collections.Generic;
using System.Reflection;
using System.Windows.Forms;
using Trainary.model;
using Trainary.utils;

namespace Trainary.presenter
{
    [Label("Filtro per tipo")]
    public class FiltroPerTipoPresenter : FiltroPresenter
    {
        private Label _tipoLabel = new Label();
        private ComboBox _comboBox = new ComboBox();

        private List<Type> _types = new List<Type>();   

        public FiltroPerTipoPresenter()
        {
            //_tipoLabel
            this._tipoLabel.AutoSize = true;
            this._tipoLabel.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._tipoLabel.Location = new System.Drawing.Point(23, 25);
            this._tipoLabel.Size = new System.Drawing.Size(116, 16);
            this._tipoLabel.TabIndex = 13;
            this._tipoLabel.Text = "Seleziona tipo:";
            // 
            // _comboBox
            // 
            this._comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._comboBox.FormattingEnabled = true;
            this._comboBox.Location = new System.Drawing.Point(154, 20);
            this._comboBox.Size = new System.Drawing.Size(154, 21);
            this._comboBox.TabIndex = 11;
            this._comboBox.DisplayMember = "Name";

            InizializeCombo();
        }

        private void InizializeCombo()
        {
            foreach (Type tipo in Assembly.GetExecutingAssembly().GetTypes())
            {
                if (tipo.IsSubclassOf(typeof(Allenamento))
                    && !tipo.IsAbstract)
                    try
                    {
                        if (tipo != null)
                            _types.Add(tipo);
                    }
                    catch (Exception e)
                    { }
            }
            _comboBox.DataSource = _types;
        }

        public override void DrawControls(Panel panel)
        {
            panel.Controls.Add(_tipoLabel);
            panel.Controls.Add(_comboBox);
        }

        public override object GetOpzione()
        {
            Type tipo = null;
            try
            {
                tipo = (Type)_comboBox.SelectedItem;
            }
            catch (Exception e)
            {

            }
            return tipo;
        }
    }
}
