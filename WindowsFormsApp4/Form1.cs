﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ContextMenuStrip cms = new ContextMenuStrip();

            cms.Items.AddRange(new ToolStripItem[]
            {
                this.cutToolStripMenuItem,
                this.copyToolStripMenuItem,
                this.pasteToolStripMenuItem
            });

            this.ContextMenuStrip = cms;
        }

        private void toolStripTextBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
