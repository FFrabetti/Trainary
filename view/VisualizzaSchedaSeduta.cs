﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trainary.view
{
    public partial class VisualizzaSchedaSeduta : UserControl
    {
        public VisualizzaSchedaSeduta()
        {
            InitializeComponent();
        }
        public TextBox Scheda
        {
            get
            {
                return textBox1;
            }
        }
        public TextBox Seduta
        {
            get
            {
                return textBox2;
            }
        }
    }
}
