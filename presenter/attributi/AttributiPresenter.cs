using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Trainary.model.attributi;
using Trainary.utils;
using Trainary.view;

namespace Trainary.presenter.attributi
{
    public class AttributiPresenter
    {
        private NewAttributoPresenter _newAttributoPresenter;
        private ListBoxPresenter<Attributo> _listBoxPresenter;

        private AttributiControl _control;

        public AttributiPresenter(AttributiControl control)
        {
            if (control == null)
                throw new ArgumentNullException("control");
            _control = control;

            _newAttributoPresenter = new NewAttributoPresenter(_control.NewAttributoControl);
            _listBoxPresenter = new ListBoxPresenter<Attributo>(_control.ListBoxControl);

            _control.ListBoxControl.ListBox.SelectionMode = SelectionMode.One;

            _control.AddButton.Click += AddTargetHandler;
            Application.Idle += EnableButtonsHandler;
            _newAttributoPresenter.Refreshed += OnNewAttributoRefreshed;
        }

        public AttributiControl AttributiControl
        {
            get { return _control; }
        }

        public List<Attributo> Attributi
        {
            get { return _listBoxPresenter.Items; }
        }

        private Control ErrorControl
        {
            get { return _control.NewAttributoControl.ValoreLabel; }
        }

        private void EnableButtonsHandler(object sender, EventArgs e)
        {
            _control.AddButton.Enabled = _control.NewAttributoControl.NomeTextBox.Text.Length > 0;
            // RemoveButton gestito da ListBoxPresenter   
        }

        private void OnNewAttributoRefreshed(object sender, EventArgs e)
        {
            _control.ErrorProvider.UnsetError(ErrorControl);
        }

        private void AddTargetHandler(object sender, EventArgs e)
        {
            try
            {
                Attributo attributo = _newAttributoPresenter.NewAttributo();
                _listBoxPresenter.AddItem(attributo);

                _newAttributoPresenter.Refresh();
            }
            catch (Exception ex)
            {
                _control.ErrorProvider.SetError(ErrorControl, ex.Message);
            }
        }
    }
}
