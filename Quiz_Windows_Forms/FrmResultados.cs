using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Quiz_Windows_Forms;

namespace Quiz_Windows_Forms
{
    public partial class FrmResultados : Form
    {
        public FrmResultados()
        {
            InitializeComponent();
        }

        private void FrmResultados_Load(object sender, EventArgs e)
        {
            FrmPerguntas frmPerguntas = new FrmPerguntas();
            
            lblResultado.Text = frmPerguntas.score + "/ 6";
        }
    }
}
