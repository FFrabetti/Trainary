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

namespace Trainary.view
{
    public partial class NewEsercizioForm : Form
    {
        public NewEsercizioForm()
        {
            InitializeComponent();
            NewEsercizioPresenter nep = new NewEsercizioPresenter(this);
        }

        //public SplitContainer SplitContainer
        //{
        //    get { return _splitContainer; }
        //}

        public TreeView TreeView
        {
            get { return _treeView; }
        }

        #region TableLayoutPanel

        public TableLayoutPanel TableLayoutPanel
        {
            get { return _tableLayoutPanel; }
        }

        public Label AttivitaLabel
        {
            get { return _attivitaLabel; }
        }

        public Label DescrizioneLabel
        {
            get { return _descLabel; }
        }

        public Label AttrezziLabel
        {
            get { return _attrezziLabel; }
        }

        public Label AttivitaValue
        {
            get { return _attivitaValueLabel; }
        }

        public Label DescrizioneValue
        {
            get { return _descValueLabel; }
        }

        public Label AttrezziValue
        {
            get { return _attrezziValueLabel; }
        }

        #endregion

        #region Nuovo target

        //public Panel CentrePanel
        //{
        //    get { return _centrePanel; }
        //}

        public Label CentreLabel
        {
            get { return _centreTitleLabel; }
        }

        public AttributiControl AttributiControl
        {
            get { return _attributiControl; }
        }

        #endregion

        public ListBoxControl ListBoxControl
        {
            get { return _listBoxControl; }
        }

        //public Panel BottomPanel
        //{
        //    get { return _bottomPanel; }
        //}

        public DialogButtonsControl DialogButtonsControl
        {
            get { return _dialogButtonsControl; }
        }

        public ErrorProvider ErrorProvider
        {
            get { return _errorProvider; }
        }
    }
}
