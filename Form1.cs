using MySql.Data.MySqlClient;
using System.Data;

namespace Banco_De_Dados_1
{
    public partial class Form1 : Form
    {
        MySqlConnection Conexao;
        private string database_source = "datasource=localhost;username=root;password=16112809;database=botecoDoSeuZe";

        public Form1()
        {
            InitializeComponent();

            AtualizarPedidos();
            AtualizarVendiveis();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void AtualizarPedidos()
        {
            lstVw1.Items.Clear();
            try
            {
                Conexao = new MySqlConnection(database_source);

                string Mostrar = "SELECT * FROM pedido";

                Conexao.Open();

                MySqlCommand command = new MySqlCommand(Mostrar, Conexao);
                MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    string[] pedido = reader.GetString(1).Split("@");
                    string[] row = {
                        reader.GetValue(0).ToString(),
                        pedido[0],
                        pedido[1],
                        reader.GetValue(2).ToString(),
                    };
                    var linha_lstVw1 = new ListViewItem(row);
                    lstVw1.Items.Add(linha_lstVw1);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Conexao.Close();
            }
        }

        public void AtualizarVendiveis()
        {
            try
            {
                lstVw2.Items.Clear();
                Conexao = new MySqlConnection(database_source);

                Conexao.Open();

                string MostrarConsumiveis = "SELECT * FROM consumiveis";

                MySqlCommand commandConsumiveis = new MySqlCommand(MostrarConsumiveis, Conexao);
                MySqlDataReader readerConsumiveis = commandConsumiveis.ExecuteReader();

                while (readerConsumiveis.Read())
                {
                    string[] row = {
                        readerConsumiveis.GetValue(0).ToString(),
                        readerConsumiveis.GetString(1),
                        readerConsumiveis.GetValue(2).ToString(),
                        readerConsumiveis.GetValue(3).ToString(),
                    };
                    var linha_lstVw2 = new ListViewItem(row);
                    lstVw2.Items.Add(linha_lstVw2);
                    if (Int16.Parse(readerConsumiveis.GetValue(3).ToString()) > 0)
                    {
                        lstBxVendiveis.Items.Add(readerConsumiveis.GetString(1));
                    }
                }

                Conexao.Close();
                Conexao.Open();

                string MostrarReceitas = "SELECT * FROM receitas";

                MySqlCommand commandReceitas = new MySqlCommand(MostrarReceitas, Conexao);
                MySqlDataReader readerReceitas = commandReceitas.ExecuteReader();

                while (readerReceitas.Read())
                {
                    string[] row = {
                        readerReceitas.GetValue(0).ToString(),
                        readerReceitas.GetString(1),
                        "N/A",
                        readerReceitas.GetValue(3).ToString(),
                    };
                    var linha_lstVw2 = new ListViewItem(row);
                    lstVw2.Items.Add(linha_lstVw2);
                    lstBxVendiveis.Items.Add(readerReceitas.GetString(1));
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Conexao.Close();
            }
        }

        private void btnAdicionarPedido_Click(object sender, EventArgs e)
        {
            if (txtBxIdentificadorCliente.Text == "")
            {
                MessageBox.Show("Preencha todos os campos necessarios\n(\"Cliente\")", "Erro de preenchimento", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (txtBxPedido.Text == "")
            {
                MessageBox.Show("Preencha todos os campos necessarios\n(\"Pedido\")", "Erro de preenchimento", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (txtBxQuantidadeDePedido.Text == "")
            {
                MessageBox.Show("Preencha todos os campos necessarios\n(\"Quantidade\")", "Erro de preenchimento", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string idVendivel = "";
            string consumivelOuReceita = "-1";
            for (int i = 0; i < lstVw2.Items.Count; i++)
            {
                if (lstVw2.Items[i].SubItems[1].Text.Equals(txtBxPedido.Text))
                {
                    idVendivel = lstVw2.Items[i].SubItems[0].Text;
                    if (lstVw2.Items[i].SubItems[2].Text.Equals("N/A"))
                    {
                        consumivelOuReceita = "0";
                    }
                    else {
                        consumivelOuReceita = "1";
                    }
                }
            }
            updateQuantidadeEstoque(idVendivel, consumivelOuReceita);
            string pedido = txtBxPedido.Text + "@" + txtBxQuantidadeDePedido.Text + "@" + idVendivel + "@" + consumivelOuReceita + "@";
            int ID_cliente = CodigoCliente(txtBxIdentificadorCliente.Text);
            try
            {
                Conexao = new MySqlConnection(database_source);

                Conexao.Open();

                if (ID_cliente < 0)
                {
                    MySqlCommand commandCliente = new MySqlCommand();
                    commandCliente.Connection = Conexao;
                    commandCliente.CommandText = "INSERT INTO cliente (Identificador) VALUES (@identificador);";
                    commandCliente.Parameters.Clear();
                    commandCliente.Parameters.AddWithValue("@identificador", txtBxIdentificadorCliente.Text);
                    commandCliente.ExecuteNonQuery();
                    ID_cliente = CodigoCliente(txtBxIdentificadorCliente.Text);
                }

                MySqlCommand command = new MySqlCommand();
                command.Connection = Conexao;
                command.CommandText = "INSERT INTO pedido (Pedido, Cliente) VALUES (@pedido, @cliente);";
                command.Parameters.Clear();
                command.Parameters.AddWithValue("@pedido", pedido);
                command.Parameters.AddWithValue("@cliente", ID_cliente);

                command.ExecuteNonQuery();
                AtualizarPedidos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Conexao.Close();
                txtBxQuantidadeDePedido.Text = "";
                txtBxPedido.Text = "";
                txtBxIdentificadorCliente.Text = "";
            }
        }

        private void btnAdicionarVendivel_Click(object sender, EventArgs e)
        {
            Form2 newform = new Form2();
            newform.Show();
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            AtualizarVendiveis();
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            int idRemover = Int32.Parse(lstVw1.SelectedItems[0].Text);
            try
            {
                Conexao = new MySqlConnection(database_source);

                Conexao.Open();
                MySqlCommand command = new MySqlCommand();
                command.Connection = Conexao;
                command.CommandText = "DELETE FROM pedido WHERE ID_Pedido=@id;";
                command.Parameters.Clear();
                command.Parameters.AddWithValue("@id", idRemover);
                command.ExecuteNonQuery();
                AtualizarPedidos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Conexao.Close();
            }

        }

        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            lstVw1.Items.Clear();
            if (txtBxIdentificadorCliente.Text == "")
            {
                MessageBox.Show("Preencha todos os campos necessarios\n(\"Cliente\")", "Erro de preenchimento", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                int idCliente = CodigoCliente(txtBxIdentificadorCliente.Text);
                Conexao = new MySqlConnection(database_source);
                Conexao.Open();

                MySqlCommand command = new MySqlCommand();
                command.Connection = Conexao;
                command.CommandText = "SELECT * FROM pedido WHERE Cliente=@idCliente;";
                command.Parameters.Clear();
                command.Parameters.AddWithValue("@idCliente", idCliente);
                MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    string[] pedido = reader.GetString(1).Split("@");
                    string[] row = {
                        reader.GetValue(0).ToString(),
                        pedido[0],
                        pedido[1],
                        reader.GetValue(2).ToString(),
                    };
                    var linha_lstVw1 = new ListViewItem(row);
                    lstVw1.Items.Add(linha_lstVw1);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Conexao.Close();
            }
        }

        private int CodigoCliente(string identificadorCliente)
        {
            try
            {
                int quantosTem = 0;
                int codigoCliente = 0;

                Conexao = new MySqlConnection(database_source);

                Conexao.Open();

                MySqlCommand commandChecar = new MySqlCommand();
                commandChecar.Connection = Conexao;
                commandChecar.CommandText = "SELECT COUNT(Identificador) FROM cliente WHERE Identificador=@identificador;";
                commandChecar.Parameters.Clear();
                commandChecar.Parameters.AddWithValue("@identificador", identificadorCliente);
                MySqlDataReader readerChecar = commandChecar.ExecuteReader();

                while (readerChecar.Read())
                {
                    quantosTem = Int32.Parse(readerChecar.GetValue(0).ToString());
                }

                if (quantosTem > 0)
                {

                    Conexao = new MySqlConnection(database_source);

                    Conexao.Open();

                    MySqlCommand commandCodigo = new MySqlCommand();
                    commandCodigo.Connection = Conexao;
                    commandCodigo.CommandText = "SELECT * FROM cliente WHERE Identificador=@identificador;";
                    commandCodigo.Parameters.Clear();
                    commandCodigo.Parameters.AddWithValue("@identificador", identificadorCliente);
                    MySqlDataReader readerCodigo = commandCodigo.ExecuteReader();

                    while (readerCodigo.Read())
                    {
                        codigoCliente = Int32.Parse(readerCodigo.GetValue(0).ToString());
                    }
                    return codigoCliente;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Conexao.Close();
            }
            return -1;
        }

        private void lstBxVendiveis_Click(object sender, EventArgs e)
        {
            for(int i=0; i < lstVw2.Items.Count; i++)
            {
                if (lstVw2.Items[i].SubItems[1].Text.Equals(lstBxVendiveis.SelectedItem.ToString()))
                {
                    txtBxPedido.Text = lstVw2.Items[i].SubItems[1].Text;
                    lblValorPedido.Text = lstVw2.Items[i].SubItems[3].Text;
                    break;
                }
            }
        }

        private void updateQuantidadeEstoque(string idVendivel, string consumivelOuReceita)
        {
            try
            {
                Conexao = new MySqlConnection(database_source);

                Conexao.Open();

                MySqlCommand commandVendivel = new MySqlCommand(); //Não deu tempo de concertar esse, mas depois eu concerto
                commandVendivel.Connection = Conexao;
                commandVendivel.CommandText = "INSERT INTO consumiveis (Descricao, Quantidade, Valor) VALUES (@descricao, @quantidade, @valor);";
                commandVendivel.Parameters.Clear();
                commandVendivel.Parameters.AddWithValue("@descricao", descricao);
                commandVendivel.Parameters.AddWithValue("@quantidade", quantidade);
                commandVendivel.Parameters.AddWithValue("@valor", valor);
                commandVendivel.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Conexao.Close();
            }
        }
    }
}
