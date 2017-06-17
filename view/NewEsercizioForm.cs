using System.Windows.Forms;

namespace Trainary.view
{
    public partial class NewEsercizioForm : Form
    {
        public NewEsercizioForm()
        {
            InitializeComponent();
        }

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

        public AttributiControl AttributiControl
        {
            get { return _attributiControl; }
        }

        public Button OkButton
        {
            get { return _dialogButtonsControl.OkButton; }
        }

        public ErrorProvider ErrorProvider
        {
            get { return _errorProvider; }
        }
    }
}
