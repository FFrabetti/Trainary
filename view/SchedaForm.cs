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

namespace Trainary.Presentation
{
    public partial class SchedaForm : Form
    {
        public SchedaForm()
        {
            InitializeComponent();
        }

        public TextBox Nome
        {
            get
            {
                return _nome;
            }
        }
        public Panel Scopo
        {
            get
            {
                return _scopo;
            }
        }
        public TextBox Descrizione
        {
            get
            {
                return _descrizione;
            }
        }
        public TextBox Durata
        {
            get
            {
                return _durata;
            }
        }
        public DateTimePicker DataInizio
        {
            get
            {
                return _dataInizio;
            }
        }
        public DateTimePicker DataFine
        {
            get
            {
                return _dataFine;
            }
        }
        public DialogButtonsControl Buttons
        {
            get
            {
                return dialogButtonsControl1;
            }
        }
        public RadioButton DataFineRadioButton
        {
            get
            {
                return _dataFineRadioButton;
            }
        }
        public RadioButton DurataRadioButton
        {
            get
            {
                return _durataRadioButton;
            }
        }
        public Button NuovaSedutaButton
        {
            get
            {
                return _nuovaSedutaButton;
            }
        }

        public TreeView TreeView
        {
            get
            {
                return _seduteTreeView;
            }
        }
    }
}
