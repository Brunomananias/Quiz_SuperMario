
using System.Data.SqlClient;

namespace Quiz_Windows_Forms
{
    public partial class FrmResultados : Form
    {
        public int ScoreFinal;
      
        public FrmResultados(int score)
        {
            ScoreFinal = score;
            InitializeComponent();
        }

        private void FrmResultados_Load(object sender, EventArgs e)
        {
          
            lblResultado.Text = "   " + ScoreFinal + "/ 6";
        }

       
    }
}
