﻿using System;
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
    public partial class SelezionaEserciziSeduta : Form
    {
        public SelezionaEserciziSeduta()
        {
            InitializeComponent();
        }
        

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
        public TreeView TreeView
        {
            get
            {
                return _treeView;
            }
        }
        public DialogButtonsControl Buttons
        {
            get
            {
                return dialogButtonsControl1;
            }
        }
    }
}
