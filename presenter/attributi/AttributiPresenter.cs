﻿using System;
using System.Collections.Generic;
using System.Reflection;
using System.Windows.Forms;
using Trainary.model.attributi;
using Trainary.view;

namespace Trainary.presenter.attributi
{
    public class AttributiPresenter
    {
        private AttributiControl _control;

        private QuantitaPresenter _currentQPresenter;
        private List<QuantitaPresenter> _presenters;

        public AttributiPresenter(AttributiControl control)
        {
            if (control == null)
                throw new ArgumentNullException("attributi control");
            _control = control;

            _presenters = new List<QuantitaPresenter>();
            InizializeQuantitaPresenters();
            InizializeComboBox();
        }

        public AttributiControl AttributiControl
        {
            get { return _control; }
        }

        private void InizializeComboBox()
        {
            _control.TipoComboBox.DataSource = _presenters;
            _control.TipoComboBox.DisplayMember = "LabelAttribute";

            _control.TipoComboBox.SelectedValueChanged += ComboChangedHandler;
            ComboChangedHandler(_control.TipoComboBox, null);
        }

        private void InizializeQuantitaPresenters()
        {
            QuantitaPresenter presenter = null;
            ConstructorInfo constructor = null;

            foreach(Type tipo in Assembly.GetExecutingAssembly().GetTypes())
            {
                if(
                    tipo.IsSubclassOf(typeof(QuantitaPresenter)) &&
                    !tipo.IsAbstract &&
                    (constructor = tipo.GetConstructor(Type.EmptyTypes)) != null
                )
                {
                    try
                    {
                        presenter = (QuantitaPresenter) constructor.Invoke(null);
                        if (presenter != null)
                            _presenters.Add(presenter);
                    }
                    catch
                    {
                        // skip
                    }
                }
            }
        }

        private void ComboChangedHandler(object sender, EventArgs e)
        {
            ComboBox combo = ((ComboBox)sender);
            _currentQPresenter = (QuantitaPresenter)combo.SelectedValue;

            _control.QuantitaPanel.Controls.Clear();
            _currentQPresenter.DrawControls(_control.QuantitaPanel);
        }

        public Attributo NewAttributo()
        {
            string nome = _control.NomeTextBox.Text;
            Quantita quantita = _currentQPresenter.GetNewQuantita();
            return new Attributo(nome, quantita);
        }

    }
}
