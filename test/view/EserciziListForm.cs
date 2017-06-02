using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Trainary.model;
using Trainary.presenter;

namespace Trainary.test.view
{
    public partial class EserciziListForm : Form
    {
        EserciziListPresenter _presenter;

        public EserciziListForm()
        {
            InitializeComponent();

            List<Esercizio> list = new List<Esercizio>();
            list.Add(new EsercizioSingolo(new Attivita("corsa1")));
            list.Add(new EsercizioSingolo(new Attivita("corsa2")));
            list.Add(new EsercizioSingolo(new Attivita("corsa3")));
            list.Add(new EsercizioSingolo(new Attivita("corsa4")));

            _presenter = new EserciziListPresenter(_listBoxControl, list);
        }
    }
}
