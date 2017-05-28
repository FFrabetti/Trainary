using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Trainary.test.view
{
    public partial class TestForm : Form
    {
        private List<Type> _list = new List<Type>();

        public TestForm()
        {
            InitializeComponent();

            // ------------------------ Inizializzazione del dizionario ------------------------
            _list.Add(typeof(AttributiPresenterWrapper));
            _list.Add(typeof(AttributiPresenterWrapper));
            // ------------------------ Inizializzazione del dizionario ------------------------

            RadioButton radio;
            int i = 0;
            foreach (Type tipo in _list)
            {
                radio = new RadioButton();
                radio.Location = new Point(7, 10 + (i++)*20);
                radio.Text = tipo.Name;
                radio.Tag = tipo;
                _groupBox.Controls.Add(radio);
            }
        }

        private void _showDialogButton_Click(object sender, EventArgs e)
        {
            object result;
            IControlPresenter presenter;
            foreach (RadioButton radio in _groupBox.Controls.OfType<RadioButton>())
            {
                if (radio.Checked)
                {
                    try
                    {
                        presenter = (IControlPresenter) Activator.CreateInstance((Type)radio.Tag);
                        result = ShowTestDialog(presenter);
                        _textBox.Text = result == null ? "result is null" : result.ToString();
                    }
                    catch (Exception ex)
                    {
                        _textBox.Text = ex.ToString();
                    }
                }
            }

        }

        private object ShowTestDialog(IControlPresenter presenter)
        {
            using (TestDialog testDialog = new TestDialog())
            {
                testDialog.LoadControl(presenter.UserControl);

                if (testDialog.ShowDialog() == DialogResult.OK)
                    return presenter.Item;
            }
            return null;
        }
    }
}
