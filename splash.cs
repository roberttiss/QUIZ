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
    public partial class splash : Form
    {
        public splash()
        {
            InitializeComponent();
        }

        private void splash_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(barra.Value < 100)
            {//aparece o progresso da barra
                barra.Value = barra.Value + 2;
            }
            else//se a barra completou 100%
            {
                timer1.Enabled = false;//desativa o timer
                this.Hide();//tela a tela ativa
                Quiz abre = new Quiz();//tela do quiz
                abre.ShowDialog();//abre a tela do quiz

            }
        }
    }
}
