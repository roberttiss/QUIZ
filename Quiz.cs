using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quiz
{
    public partial class Quiz : Form
    {

        game gm = new game();
        int certas = 0;


        public Quiz()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Quiz_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            certas = 0;
            gm.certas = certas;

            gm.calculartotaldepontosincorretos();
            txtpontos.Text = Convert.ToString(gm.pontostotal);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            certas = 0;
            gm.certas = certas;

            gm.calculartotaldepontosincorretos();
            txtpontos.Text = Convert.ToString(gm.pontostotal);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            certas = certas + 1;
            gm.certas = certas;

            gm.calculartotaldepontoscertos();
            txtpontos.Text = Convert.ToString(gm.pontostotal);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;
            certas = certas + 1;
            gm.certas = certas;

            gm.calculartotaldepontoscertos();
            txtpontos.Text = Convert.ToString(gm.pontostotal);

        }

        private void button5_Click(object sender, EventArgs e)
        {
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;
            certas = certas - 0;
            gm.certas = certas;

            gm.calculartotaldepontosincorretos();
            txtpontos.Text = Convert.ToString(gm.pontostotal);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;
            certas = certas -0;
            gm.certas = certas;

            gm.calculartotaldepontosincorretos();
            txtpontos.Text = Convert.ToString(gm.pontostotal);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            button7.Enabled = false;
            button8.Enabled = false;
            button9.Enabled = false;
            certas = certas + 1;
            gm.certas = certas;

            gm.calculartotaldepontoscertos();
            txtpontos.Text = Convert.ToString(gm.pontostotal);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            button7.Enabled = false;
            button8.Enabled = false;
            button9.Enabled = false;
            certas = certas -0;
            gm.certas = certas;

            gm.calculartotaldepontosincorretos();
            txtpontos.Text = Convert.ToString(gm.pontostotal);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            button7.Enabled = false;
            button8.Enabled = false;
            button9.Enabled = false;
            certas = certas -0;
            gm.certas = certas;

            gm.calculartotaldepontosincorretos();
            txtpontos.Text = Convert.ToString(gm.pontostotal);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            button10.Enabled = false;
            button11.Enabled = false;
            button12.Enabled = false;
            certas = certas + 1;
            gm.certas = certas;

            gm.calculartotaldepontoscertos();
            txtpontos.Text = Convert.ToString(gm.pontostotal);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            button10.Enabled = false;
            button11.Enabled = false;
            button12.Enabled = false;
            certas = certas -0;
            gm.certas = certas;

            gm.calculartotaldepontosincorretos();
            txtpontos.Text = Convert.ToString(gm.pontostotal);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            button10.Enabled = false;
            button11.Enabled = false;
            button12.Enabled = false;
            certas = certas -0;
            gm.certas = certas;

            gm.calculartotaldepontosincorretos();
            txtpontos.Text = Convert.ToString(gm.pontostotal);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            button13.Enabled = false;
            button14.Enabled = false;
            button15.Enabled = false;
            certas = certas + 1;
            gm.certas = certas;

            gm.calculartotaldepontoscertos();
            txtpontos.Text = Convert.ToString(gm.pontostotal);
        }

        private void button14_Click(object sender, EventArgs e)
        {
            button13.Enabled = false;
            button14.Enabled = false;
            button15.Enabled = false;
            certas = certas -0;
            gm.certas = certas;

            gm.calculartotaldepontosincorretos();
            txtpontos.Text = Convert.ToString(gm.pontostotal);
        }

        private void button15_Click(object sender, EventArgs e)
        {
            button13.Enabled = false;
            button14.Enabled = false;
            button15.Enabled = false;
            certas = certas -0;
            gm.certas = certas;

            gm.calculartotaldepontosincorretos();
            txtpontos.Text = Convert.ToString(gm.pontostotal);
        }

        private void button16_Click(object sender, EventArgs e)
        {
            certas = 0;
            txtpontos.Clear();
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
            button7.Enabled = true;
            button8.Enabled = true;
            button9.Enabled = true;
            button10.Enabled = true;
            button11.Enabled = true;
            button12.Enabled = true;
            button13.Enabled = true;
            button14.Enabled = true;
            button15.Enabled = true;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
