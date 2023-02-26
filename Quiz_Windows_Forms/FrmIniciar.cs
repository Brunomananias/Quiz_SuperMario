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
            SoundPlayer som = new SoundPlayer("C:/Users/Bruno/OneDrive/Documentos/Projetos/Quiz_Windows_Forms/Quiz_Windows_Forms/bin/Debug/net6.0-windows/Title.wav");
            som.Play();
        }

        //private void ConexaoSQL()
        //{
        //    SqlConnection conn = new SqlConnection(@"Server=DESKTOP-05IP2B2\SQLEXPRESS ;Database=Cadastro;User Id=sa;Password=Pardini2021!;");
        //               string sql = "INSERT INTO NomesJogo(Id, Nome) VALUES (@id, @nome)";
        //    Random numeroID = new Random();
        //    numeroID.Next();

        //    try
        //    {
        //        SqlCommand command = new SqlCommand(sql, conn);
        //        command.Parameters.Add(new SqlParameter("@id", numeroID.Next()));
        //        command.Parameters.Add(new SqlParameter("@nome", txtNome.Text));
        //    }
        //    catch (SqlException ex)
        //    {
        //        MessageBox.Show("Ocorreu um erro:" + ex);
        //    }




        //}


    }
}