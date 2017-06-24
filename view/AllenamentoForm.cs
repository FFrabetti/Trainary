﻿using System.Windows.Forms;
using Trainary.view;

namespace Trainary.Presentation
{
    public partial class AllenamentoForm : Form
    {
        public AllenamentoForm()
        {
            InitializeComponent();

        }

        public Button AggiungiEsercizioButton
        {
            get
            {
                return _aggiungiEsercizioButton;
            }
        }

        public Button AggiungiCircuitoButton
        {
            get
            {
                return _aggiungiCircuitoButton;
            }
        }

        public Button AnnullaSelezioneButton
        {
            get
            {
                return _annselbutton;
            }
        }

        public Button EliminaEsercizioButton
        {
            get
            {
                return _eliminaEsercizioButton;
            }
        }

        public Button AggiungiDatiButton
        {
            get
            {
                return _aggiungiDatiButton;
            }
        }

        public DialogButtonsControl Buttons
        {
            get
            {
                return dialogButtonsControl1;
            }
        }

        public Panel Panel
        {
            get
            {
                return panel1;
            }
        }

        public Label AllenamentoLabel
        {
            get
            {
                return _allenamentoLabel;
            }
        }

        public DateTimePicker Data
        {
            get
            {
                return dateTimePicker1;
            }
        }

        public TreeView TreeView
        {
            get
            {
                return treeView1;
            }
        }

    }
}
