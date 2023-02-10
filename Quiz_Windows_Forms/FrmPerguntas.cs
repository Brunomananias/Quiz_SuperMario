using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Quiz_Windows_Forms
{
    public partial class FrmPerguntas : Form
    {
        private Stopwatch stopwatch;  
        public FrmPerguntas()
        {
            InitializeComponent();
        }

        private void FrmPerguntas_Load(object sender, EventArgs e)
        {
            stopwatch = new Stopwatch();
            stopwatch.Start();
            FrmIniciar frmIniciar = new FrmIniciar();
            btnProximo.Enabled = false;
            res1.Checked = false;
            res2.Checked = false;
            res3.Checked = false;
            res4.Checked = false;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.tempo.Text = String.Format("{0:mm\\:ss}", stopwatch.Elapsed);
        }

        private void btnProximo_Click(object sender, EventArgs e)
        {
            if (res1.Checked = true)
            {
                res1.BackColor = Color.Red;
            }

            SegundaPergunta();
        }

        private void res1_CheckedChanged(object sender, EventArgs e)
        {
            btnProximo.Enabled = true;

        }

        private void res2_CheckedChanged(object sender, EventArgs e)
        {
            btnProximo.Enabled = true;
        }

        private void res3_CheckedChanged(object sender, EventArgs e)
        {
            btnProximo.Enabled = true;
        }

        private void res4_CheckedChanged(object sender, EventArgs e)
        {
            btnProximo.Enabled = true;
        }

        private void SegundaPergunta()
        {
            lblPerguntas.Text = "2) Qual cor de Yoshi recebe o \r\n" +
                "poder de voo com qualquer \r\n tipo de casco?";
            res1.Text = "Azul";
            res2.Text = "Amarelo";
            res3.Text = "Verde";
            res4.Text = "Rosa";

        }
    }
}
