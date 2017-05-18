using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eleicao
{
    public partial class Form1 : Form
    {
        double x, y;
        int op;
        bool res = false;
        int voto_tiri = 0;
        int voto_dona = 0;
        int voto_dilma = 0;
        int voto_russo = 0;
        int voto_jorg = 0;
        int voto_soni = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.Tiririca_Federal;
            voto_tiri += 1;
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.xAkXA8V8;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.russomano;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.soninha;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.donairene;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.jorginho;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (res)
                txtresul.Text = "";
            res = false;
            if (res == false)
            {
                txtresul.Text += Convert.ToString(2);
                if (x != 0)
                    y = 2;
                else
                    x = 2;
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (res)
                txtresul.Text = "";
            res = false;
            if (res == false)
            {
                txtresul.Text += Convert.ToString(3);
                if (x != 0)
                    y = 3;
                else
                    x = 3;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (res)
                txtresul.Text = "";
            res = false;
            if (res == false)
            {
                txtresul.Text += Convert.ToString(4);
                if (x != 0)
                    y = 4;
                else
                    x = 4;
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (res)
                txtresul.Text = "";
            res = false;
            if (res == false)
            {
                txtresul.Text += Convert.ToString(5);
                if (x != 0)
                    y = 5;
                else
                    x = 5;
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (res)
                txtresul.Text = "";
            res = false;
            if (res == false)
            {
                txtresul.Text += Convert.ToString(6);
                if (x != 0)
                    y = 6;
                else
                    x = 6;
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (res)
                txtresul.Text = "";
            res = false;
            if (res == false)
            {
                txtresul.Text += Convert.ToString(7);
                if (x != 0)
                    y = 7;
                else
                    x = 7;
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (res)
                txtresul.Text = "";
            res = false;
            if (res == false)
            {
                txtresul.Text += Convert.ToString(8);
                if (x != 0)
                    y = 8;
                else
                    x = 8;
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (res)
                txtresul.Text = "";
            res = false;
            if (res == false)
            {
                txtresul.Text += Convert.ToString(9);
                if (x != 0)
                    y = 9;
                else
                    x = 9;
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (res)
                txtresul.Text = "";
            res = false;
            if (res == false)
            {
                txtresul.Text += Convert.ToString(0);
                if (x != 0)
                    y = 0;
                else
                    x = 0;
            }
        }

        private void btncorrige_Click(object sender, EventArgs e)
        {
            txtresul.Clear();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (res)
                txtresul.Text = "";
            res = false;
            if (res == false)
            {
                txtresul.Text += Convert.ToString(1);
                if (x != 0)
                    y = 1;
                else
                    x = 1;
            }
        }
    }
}
