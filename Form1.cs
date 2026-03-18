using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Win3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            this.textBox1.Text = "(" + e.X + ", " + e.Y + ")";
            this.Text = "Текущая позиция: (" + e.X + ", " + e.Y + ")";
        }


        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPosition_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                MessageBox.Show("Левая кнопка мыши!");
            }
            else if (e.Button == MouseButtons.Right)
            {
                MessageBox.Show("Правая кнопка мыши!");
            }
        }
    }
}
