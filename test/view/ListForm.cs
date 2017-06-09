using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Trainary.presenter;

namespace Trainary.test.view
{
    public partial class ListForm : Form
    {
        private ListBoxPresenter<String> presenter;

        public ListForm()
        {
            InitializeComponent();

            String[] elements = new String[]
            {
                "Testo di prova1",
                "Testo di prova2",
                "Testo di prova3",
                "Testo di prova4"
            };

            presenter = new ListBoxPresenter<String>(_listBoxControl, elements);

            presenter.ListBoxControl.AddButton.Click += AddButtonHandler;
        }

        private void AddButtonHandler(object sender, EventArgs e)
        {
            _textBox.Text = "Count = " + presenter.SelectedItems.Count() + Environment.NewLine;
            foreach (String s in presenter.SelectedItems)
            {
                _textBox.AppendText(s + Environment.NewLine);
            }

            presenter.AddItem("New string");
        }
    }
}
