using System.Data.SqlClient;
using System.Media;

namespace Quiz_Windows_Forms
{
    public partial class FrmIniciar : System.Windows.Forms.Form
    {
        ConexaoSQL conexao = new ConexaoSQL();
         public FrmIniciar()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            conexao.nome = txtNome.Text;
            conexao.InserirNome();
            this.Hide();
            FrmPerguntas frmPerguntas = new FrmPerguntas();
            frmPerguntas.Closed += (s, args) => this.Close();
            frmPerguntas.Show();
            
        }

        private void FrmIniciar_Load(object sender, EventArgs e)
        {
            string currentApplicationPath = Application.StartupPath;
            SoundPlayer som = new SoundPlayer(currentApplicationPath + "/Title.wav");
            som.Play();
        }
    }
}