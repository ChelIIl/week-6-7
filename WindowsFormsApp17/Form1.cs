using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp17
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Color color;
        string name;

        private void button1_Click(object sender, EventArgs e)
        {
            color = Color.MediumPurple;
            name = "Ivan";
            Invalidate();

            Properties.Settings.Default.Color = color;
            Properties.Settings.Default.Name = name;
            Properties.Settings.Default.Save();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            color = Color.Firebrick;
            name = "Roman";
            Invalidate();

            Properties.Settings.Default.Color = Color.Firebrick;
            Properties.Settings.Default.Name = name;
            Properties.Settings.Default.Save();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                color = Properties.Settings.Default.Color;
                name = Properties.Settings.Default.Name;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Font font = new Font("Arial", 10);
            g.DrawString(name, font, new SolidBrush(color), 100, 100);
        }
    }
}
