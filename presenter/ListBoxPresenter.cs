﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using Trainary.view;

namespace Trainary.presenter
{
    public class ListBoxPresenter<T>
    {
        private ListBoxControl _control;
        private List<T> _items;
        private BindingList<T> bindingList;

        public ListBoxPresenter(ListBoxControl listControl, IEnumerable<T> items)
        {
            if (listControl == null)
                throw new ArgumentNullException("listControl");
            if (items == null)
                throw new ArgumentNullException("items");

            _control = listControl;
            _items = new List<T>(items);

            bindingList = new BindingList<T>(_items);
            _control.ListBox.DataSource = bindingList;

            _control.ListBox.SelectedValueChanged += SelectionHandler;
            _control.RemoveButton.Click += RemoveButtonHandler;
            SelectionHandler(null, null);
        }

        public ListBoxPresenter(ListBoxControl listControl) : this(listControl, new T[0])
        { }

        public ListBoxControl ListBoxControl
        {
            get { return _control; }
        }

        public List<T> Items
        {
            get { return _items; }
        }

        public T SelectedItem
        {
            get { return (T)(_control.ListBox.SelectedItem ?? default(T)); }
        }

        public IEnumerable<T> SelectedItems
        {
            get { return _control.ListBox.SelectedItems.Cast<T>(); }
        }

        private void SelectionHandler(object sender, EventArgs e)
        {
            _control.RemoveButton.Enabled = _control.ListBox.SelectedItems.Count == 1;
        }

        private void RemoveButtonHandler(object sender, EventArgs e)
        {
            if (_control.ListBox.SelectedItems.Count == 1)
                RemoveItem(SelectedItem);
        }

        public void AddItem(T item)
        {
            if (item == null)
                throw new ArgumentNullException("item");

            _items.Add(item);
            bindingList.ResetBindings();
        }

        public void RemoveItem(T item)
        {
            if (item == null)
                throw new ArgumentNullException("item");

            string messageBoxText = "Sicuro di voler cancellare '" + item + "'?";
            string caption = "Conferma cancellazione";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            MessageBoxIcon icon = MessageBoxIcon.Warning;

            if (MessageBox.Show(messageBoxText, caption, buttons, icon) == DialogResult.OK)
            {
                _items.Remove(item);
                bindingList.ResetBindings();
            }
        }

    }
}
