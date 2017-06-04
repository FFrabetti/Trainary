using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Trainary.model;
using Trainary.view;

namespace Trainary.presenter
{
    public class EserciziListPresenter : ListBoxPresenter<Esercizio>
    {
        Button _circuitoButton;

        public EserciziListPresenter(ListBoxControl listControl, IEnumerable<Esercizio> items)
            : base(listControl, items)
        {
            ListBoxControl.TitleLabel.Text = "Esercizi";

            // aggiungo il bottone per creare un circuito
            _circuitoButton = new Button();
            ListBoxControl.ButtonsPanel.Controls.Add(_circuitoButton);

            _circuitoButton.Anchor = (AnchorStyles.Bottom | AnchorStyles.Right);
            _circuitoButton.Location = new System.Drawing.Point(212, 12);
            _circuitoButton.Size = new System.Drawing.Size(75, 23);
            _circuitoButton.Text = "Crea circuito";

            _circuitoButton.Click += CircuitoHandler;
            ListBoxControl.AddButton.Click += AddButtonHandler;
            ListBoxControl.ListBox.SelectedValueChanged += SelectionHandler;
            SelectionHandler(null, null);
        }

        private void SelectionHandler(object sender, EventArgs e)
        {
            _circuitoButton.Enabled = SelectedItems.Count >= 2;
        }

        private void AddButtonHandler(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void CircuitoHandler(object sender, EventArgs e)
        {
            if(SelectedItems.Count >= 2)
            {
                throw new NotImplementedException();
            }
        }
    }
}
