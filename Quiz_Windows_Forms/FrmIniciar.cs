namespace Quiz_Windows_Forms
{
    public partial class FrmIniciar : System.Windows.Forms.Form
    {

        public FrmIniciar()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmPerguntas frmPerguntas = new FrmPerguntas();
            frmPerguntas.Closed += (s, args) => this.Close();
            frmPerguntas.Show();
            
        }

        private void FrmIniciar_Load(object sender, EventArgs e)
        {

        }
    }
}