﻿using System;
using System.Windows.Forms;
using Trainary.presenter;

namespace Trainary
{
    public partial class FormDiario : Form
    {
        public FormDiario()
        {
            InitializeComponent();
            DiarioPresenter dp = new DiarioPresenter(this);
        }

        public Panel Panel
        {
            get
            {
                return _panel;
            }
        }

        public ComboBox ComboBox
        {
            get
            {
                return _comboBox;
            }
        }

        public ListView ListView
        {
            get
            {
                return _listView;
            }
        }

        public Button Ok_button
        {
            get
            {
                return _okButton;
            }
        }

        public Button AnnullaButton_button
        {
            get
            {
                return _okButton;
            }
        }

        private void _comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void _listView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void _okButton_Click(object sender, EventArgs e)
        {

        }

        private void _annullaButton_Click(object sender, EventArgs e)
        {

        }
    }
}