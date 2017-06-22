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
    public partial class AllenamentoForm: Form
    {
        public AllenamentoForm()
        {
            InitializeComponent();
            
        }

        private void _salvaButton_Click(object sender, EventArgs e)
        {
                    }

        private void button1_Click(object sender, EventArgs e)
        {

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
        //public TextBox Nome
        //{
        //    get
        //    {
        //        return textBox3;
    
        //    }
        //}
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

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
