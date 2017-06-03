using System;
using System.Windows.Forms;
using Trainary.model;
using Trainary.utils;

namespace Trainary.presenter
{
    [Label("Filtro per periodo")]
    public class FiltroPerPeriodoPresenter : FiltroPresenter
    {
        private Label _selezionareLabel = new Label();
        private Label _dataInizioLabel = new Label();
        private Label _dataFineLabel = new Label();
        private DateTimePicker _dataInizio = new DateTimePicker();
        private DateTimePicker _dataFine = new DateTimePicker();

        public FiltroPerPeriodoPresenter()
        {
            // _selezionareLabel
            this._selezionareLabel.AutoSize = true;
            this._selezionareLabel.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._selezionareLabel.Location = new System.Drawing.Point(11, 9);
            this._selezionareLabel.Size = new System.Drawing.Size(122, 16);
            this._selezionareLabel.TabIndex = 11;
            this._selezionareLabel.Text = "Seleziona periodo:";
            // 
            // _dataInizioLabel
            // 
            this._dataInizioLabel.AutoSize = true;
            this._dataInizioLabel.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._dataInizioLabel.Location = new System.Drawing.Point(12, 40);
            this._dataInizioLabel.Size = new System.Drawing.Size(73, 15);
            this._dataInizioLabel.TabIndex = 12;
            this._dataInizioLabel.Text = "Data inizio";
            // 
            // _dataFineLabel
            // 
            this._dataFineLabel.AutoSize = true;
            this._dataFineLabel.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._dataFineLabel.Location = new System.Drawing.Point(12, 71);
            this._dataFineLabel.Size = new System.Drawing.Size(64, 15);
            this._dataFineLabel.TabIndex = 13;
            this._dataFineLabel.Text = "Data fine";
            // 
            // _dataInizio
            // 
            this._dataInizio.Location = new System.Drawing.Point(97, 35);
            this._dataInizio.Size = new System.Drawing.Size(198, 20);
            this._dataInizio.TabIndex = 14;
            // 
            // _dataFine
            // 
            this._dataFine.Location = new System.Drawing.Point(97, 66);
            this._dataFine.Size = new System.Drawing.Size(198, 20);
            this._dataFine.TabIndex = 15;
        }

        public override void DrawControls(Panel panel)
        {
            panel.Controls.Add(_selezionareLabel);
            panel.Controls.Add(_dataInizioLabel);
            panel.Controls.Add(_dataFineLabel);
            panel.Controls.Add(_dataInizio);
            panel.Controls.Add(_dataFine);
        }

        //public override IFiltroAllenamenti GetNewFiltro()
        //{
        //    return FiltroFactory.GetFiltroAllenamento(LabelAttribute);
        //}

        public override object GetOpzione()
        {
            Periodo periodo = default(Periodo);
            try
            {
                DateTime dataInizio = _dataInizio.Value;
                DateTime dataFine = _dataFine.Value;

                periodo = new Periodo(dataInizio, dataFine);
            } 
            catch
            {

            }
            return periodo;
        }
    }
}
