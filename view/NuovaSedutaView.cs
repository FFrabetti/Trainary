﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Trainary.view;

namespace Trainary.Presentation
{
    public partial class NuovaSedutaView : Form
    {
        public NuovaSedutaView()
        {
            InitializeComponent();
        }
        public Panel Panel
        {
            get
            {
                return panel1;
            }
        }
        public DialogButtonsControl Buttons{
            get
            {
                return dialogButtonsControl1;
            }
           }
    }
}
