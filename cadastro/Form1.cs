using MySql.Data.MySqlClient;

namespace cadastro
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string conexao = "server = 127.0.0.1; port = 3306; UID = root; database = clientes; pwd = 30334212Rt#;";

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_Adicionar_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection conn = new MySqlConnection(conexao);
                conn.Open();

                MySqlCommand comando = new MySqlCommand(
                    "insert into dados (nome, email ,telefone, sexo) values ('" + txt_Nome.Text + "','" + txt_Email.Text + "'," +
                    "'" + txt_Telefone.Text + "','" + txt_Sexo.Text + "' );" , conn);
                comando.ExecuteNonQuery();

                conn.Close();

            } catch (Exception erro)
            {
                MessageBox.Show(erro.Message);

            } 
        }

        private void btn_Remover_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection conn = new MySqlConnection(conexao);
                conn.Open();

                MySqlCommand comando = new MySqlCommand(
                    "delete from dados where id ='"+ txt_Id.Text +"'", conn);
                comando.ExecuteNonQuery();

                conn.Close();

            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);

            }
        }

        private void btn_Atualizar_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection conn = new MySqlConnection(conexao);
                conn.Open();

                MySqlCommand comando = new MySqlCommand(
                    "update dados set nome = '" + txt_Nome.Text + "', email = '" + txt_Email.Text + "'" +
                    " where id = '" +txt_Id.Text + "';", conn);
                comando.ExecuteNonQuery();

                conn.Close();

            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);

            }
        }

        private void bnt_Mostrar_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection conn = new MySqlConnection(conexao);
                conn.Open();

                MySqlCommand comando = new MySqlCommand("select * from Dados where id='" + txt_Id.Text + "';", conn);
                MySqlDataReader ler = comando.ExecuteReader();
                
                while (ler.Read())
                {
                    txt_Nome.Text = ler.GetString("nome");
                    txt_Email.Text = ler.GetString("Email");
                    txt_Telefone.Text= ler.GetString("Telefone");
                    txt_Sexo.Text=ler.GetString("Sexo");
                }

                

            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);

            }
        }
    }
}