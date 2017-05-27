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
using Trainary.view;

namespace Trainary.test
{
    public partial class TestForm : Form
    {
        public TestForm()
        {
            InitializeComponent();

            AttributiControl attributiControl = new AttributiControl();
            _attributiRadioButton.Tag = new AttributiPresenterWrapper(new AttributiPresenter(attributiControl));
        }

        private void _showDialogButton_Click(object sender, EventArgs e)
        {
            object result;
            foreach(RadioButton radio in _groupBox.Controls.OfType<RadioButton>())
            {
                if(radio.Checked)
                {
                    try
                    {
                        result = ShowTestDialog((IControlPresenter)radio.Tag);
                        _textBox.Text = result == null ? "result is null" : result.ToString();
                    }
                    catch(Exception ex)
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
                testDialog.LoadControl(presenter.Control);
                if(testDialog.ShowDialog() == DialogResult.OK)
                    return presenter.Item;
            }
            return null;
        }
    }
}
