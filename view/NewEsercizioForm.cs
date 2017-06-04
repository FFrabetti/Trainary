using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        public Label AttivitaLabel
        {
            get { return _nameValueLabel; }
        }

        public Label DescrizioneLabel
        {
            get { return _descValueLabel; }
        }

        public Label AttrezziLabel
        {
            get { return _toolsValueLabel; }
        }

        public ListBoxControl ListBoxControl
        {
            get { return _listBoxControl; }
        }

        public Button OkButton
        {
            get { return _okButton; }
        }

        public Button CancelButton
        {
            get { return _cancelButton; }
        }
    }
}
