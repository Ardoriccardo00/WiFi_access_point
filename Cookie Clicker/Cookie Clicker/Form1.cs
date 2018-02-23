using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cookie_Clicker
{
    public partial class Form1 : Form
    {
        int Biscotti = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Biscotti = Biscotti + 1;
            biscotti.Text = Convert.ToString(Biscotti);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void potenziamento1ToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if (Biscotti >= 200)
            {
                PrimoTimer.Enabled = true;
                Biscotti = Biscotti - 200;
            }
            else {
                debug.Text = "Biscotti insufficienti";
            }
            
        }

        private void PrimoTimer_Tick(object sender, EventArgs e)
        {

            Biscotti = Biscotti + 5;
            biscotti.Text = Convert.ToString(Biscotti);
        }

        private void potenziamento2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Biscotti >= 750)
            {
                SecondoTimer.Enabled = true;
                Biscotti = Biscotti - 750;
            }
            else
            {
                debug.Text = "Biscotti insufficienti";
            }


        }

        private void biscottiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Biscotti = Biscotti + 200;
        }

        private void biscottiToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Biscotti = Biscotti + 750;
        }

        private void biscottiToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Biscotti = Biscotti + 1200;
        }

        private void SecondoTimer_Tick(object sender, EventArgs e)
        {
            Biscotti = Biscotti + 30;
            biscotti.Text = Convert.ToString(Biscotti);
        }

        private void aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaddddddddddddddddddddffffffffffffffffffffgggggggggggggggggghhhhhhhhhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Biscotti >= 1250)
            {
                SecondoTimer.Enabled = true;
                Biscotti = Biscotti - 1250;
            }
            else
            {
                debug.Text = "Biscotti insufficienti";
            }
        }

        private void TerzoTimer_Tick(object sender, EventArgs e)
        {
            Biscotti = Biscotti*2;
            biscotti.Text = Convert.ToString(Biscotti);
        }
    }
}
