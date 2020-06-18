using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (Control c in Controls)
            {
                c.ContextMenuStrip = contextMenuStrip1;
                c.MouseDown += new MouseEventHandler(this.ShowPopupMenu);
            }
        }

        private void ShowPopupMenu(object sender, MouseEventArgs e)
        {
            // Если нажата правая кнопка мыши.
            if (e.Button == MouseButtons.Right)
            {
                Control c = (Control)sender;
                // Если контекстное меню у элемента существует,
                if (c.ContextMenuStrip != null)
                {
                    // то показываем его.
                    c.ContextMenuStrip.Show(c, new Point(e.X, e.Y));
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
