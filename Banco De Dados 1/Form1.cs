using MySql.Data.MySqlClient;
using System.Data;
using System.Linq;
using System.Runtime.ConstrainedExecution;

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

                string Mostrar = "SELECT pedido.ID_Pedido, pedido.Pedido, cliente.Identificador FROM pedido INNER JOIN cliente on pedido.Cliente = cliente.ID_Cliente";

                Conexao.Open();

                MySqlCommand command = new MySqlCommand(Mostrar, Conexao);
                MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    string[] pedido = reader.GetString(1).Split("@");
                    string[] row =
                    {
                        reader.GetValue(0).ToString(),
                        pedido[0],
                        pedido[1],
                        reader.GetString(2),
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
                lstBxVendiveis.Items.Clear();
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
            int idVendivel = 0;
            for (int i = 0; i < lstVw2.Items.Count; i++)
            {
                if (lstVw2.Items[i].SubItems[1].Text.Equals(txtBxPedido.Text))
                {
                    idVendivel = Int32.Parse(lstVw2.Items[i].SubItems[0].Text);
                    if (lstVw2.Items[i].SubItems[2].Text.Equals("N/A"))
                    {
                        if (!updateQuantidadeEstoqueReceitas(idVendivel, Int32.Parse(txtBxQuantidadeDePedido.Text)))
                        {
                            MessageBox.Show("Nao possui produtos o suficiente para esse pedido", "Quantidade acima do possivel", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }
                    else
                    {
                        int novaQuantidade = quantidadeNova(Int32.Parse(txtBxQuantidadeDePedido.Text), idVendivel);
                        if (novaQuantidade >= 0)
                        {
                            updateQuantidadeEstoqueConsumivel(idVendivel, novaQuantidade);
                        }
                        else
                        {
                            MessageBox.Show("Nao possui produtos o suficiente para esse pedido", "Quantidade acima do possivel", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }
                }
            }
            string pedido = txtBxPedido.Text + "@" + txtBxQuantidadeDePedido.Text + "@" + idVendivel + "@";
            int ID_cliente = CodigoCliente(txtBxIdentificadorCliente.Text);
            try
            {
                Conexao = new MySqlConnection(database_source);

                Conexao.Open();

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
            if (ConsumivelAtualizar.Text == "")
            {
                MessageBox.Show("Nenhum consumível escolhido, selecione o consumível clicando na tabela na tela", "Erro em \"Consumível\"", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (QuantNova.Text == "")
            {
                MessageBox.Show("Nenhuma quantidade para ser atualizada", "Erro em \"Quantidade Nova\"", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (lstVw2.FocusedItem.SubItems[2].Text.Equals("N/A"))
            {
                MessageBox.Show("Impossivél de atualizar a quantidade de receitas no estoque", "Erro em \"Receitas\"", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int quantNova = Int32.Parse(QuantNova.Text);
            int id_atualizar = -1;
            for (int i = 0; i < lstVw2.Items.Count; i++)
            {
                if (lstVw2.Items[i].SubItems[1].Text.Equals(ConsumivelAtualizar.Text))
                {
                    id_atualizar = Int32.Parse(lstVw2.Items[i].SubItems[0].Text);
                    break;
                }
            }
            if (id_atualizar < 0)
            {
                MessageBox.Show("Não foi possível atualizar consumível, verifique se consumível existe no banco de dados", "Erro em \"Consumível\"", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            updateQuantidadeEstoqueConsumivel(id_atualizar, quantNova);
            AtualizarVendiveis();
            QuantAntiga.Text = "";
            QuantNova.Text = "";
            ConsumivelAtualizar.Text = "";
            nmrcUpDwnAtualizar.Value = 0;
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
                command.CommandText = "SELECT pedido.ID_Pedido, pedido.Pedido, cliente.Identificador FROM pedido INNER JOIN cliente on pedido.Cliente = cliente.ID_Cliente WHERE cliente.ID_Cliente=@idCliente";
                command.Parameters.Clear();
                command.Parameters.AddWithValue("@idCliente", idCliente);


                MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    string[] pedido = reader.GetString(1).Split("@");
                    string[] row =
                    {
                        reader.GetValue(0).ToString(),
                        pedido[0],
                        pedido[1],
                        reader.GetString(2),
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

                Conexao.Close();

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
                else
                {
                    MySqlCommand commandCliente = new MySqlCommand();

                    Conexao.Open();

                    commandCliente.Connection = Conexao;
                    commandCliente.CommandText = "INSERT INTO cliente (Identificador) VALUES (@identificador);";
                    commandCliente.Parameters.Clear();
                    commandCliente.Parameters.AddWithValue("@identificador", identificadorCliente);
                    commandCliente.ExecuteNonQuery();

                    Conexao.Close();

                    return CodigoCliente(identificadorCliente);
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
            for (int i = 0; i < lstVw2.Items.Count; i++)
            {
                if (lstVw2.Items[i].SubItems[1].Text.Equals(lstBxVendiveis.SelectedItem.ToString()))
                {
                    txtBxPedido.Text = lstVw2.Items[i].SubItems[1].Text;
                    lblValorPedido.Text = lstVw2.Items[i].SubItems[3].Text;
                    break;
                }
            }
        }

        private void updateQuantidadeEstoqueConsumivel(int idVendivel, int novaQuantidade)
        {
            try
            {
                Conexao = new MySqlConnection(database_source);

                Conexao.Open();

                MySqlCommand commandUpdateConsumivel = new MySqlCommand();
                commandUpdateConsumivel.Connection = Conexao;
                commandUpdateConsumivel.CommandText = "UPDATE consumiveis SET Quantidade = @novaQuantidade WHERE ID_Consumivel = @idMudar;";
                commandUpdateConsumivel.Parameters.Clear();
                commandUpdateConsumivel.Parameters.AddWithValue("@novaQuantidade", novaQuantidade);
                commandUpdateConsumivel.Parameters.AddWithValue("@idMudar", idVendivel);
                commandUpdateConsumivel.ExecuteNonQuery();
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

        private int quantidadeNova(int quantidadePedida, int idConsumivel)
        {
            try
            {
                int quantidadeAntiga = 0;
                Conexao = new MySqlConnection(database_source);

                Conexao.Open();

                MySqlCommand commandCodigo = new MySqlCommand();
                commandCodigo.Connection = Conexao;
                commandCodigo.CommandText = "SELECT * FROM consumiveis WHERE ID_Consumivel=@id;";
                commandCodigo.Parameters.Clear();
                commandCodigo.Parameters.AddWithValue("@id", idConsumivel);
                MySqlDataReader readerCodigo = commandCodigo.ExecuteReader();

                while (readerCodigo.Read())
                {
                    quantidadeAntiga = Int32.Parse(readerCodigo.GetValue(2).ToString());
                }

                return quantidadeAntiga - quantidadePedida;
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

        private bool updateQuantidadeEstoqueReceitas(int idReceita, int quantidadePedida)
        {
            int[] quantidadesNovas = null;
            string[] ingredientes = null;
            int[] idsIngredientes = null;
            try
            {
                Conexao = new MySqlConnection(database_source);

                Conexao.Open();

                MySqlCommand commandCodigo = new MySqlCommand();
                commandCodigo.Connection = Conexao;
                commandCodigo.CommandText = "SELECT * FROM receitas WHERE ID_Receitas=@id;";
                commandCodigo.Parameters.Clear();
                commandCodigo.Parameters.AddWithValue("@id", idReceita);
                MySqlDataReader readerCodigo = commandCodigo.ExecuteReader();

                while (readerCodigo.Read())
                {
                    ingredientes = readerCodigo[2].ToString().Split("§");
                }

                for (int i = 1; i < ingredientes.Length; i += 3)
                {
                    int quantidadeARetirar = quantidadePedida * Int32.Parse(ingredientes[i]);
                    quantidadesNovas.Append(quantidadeNova(quantidadeARetirar, Int32.Parse(ingredientes[i + 1])));
                    idsIngredientes.Append(Int32.Parse(ingredientes[i + 1]));
                    if (quantidadeNova(quantidadeARetirar, Int32.Parse(ingredientes[i + 1])) < 0)
                    {
                        return false;
                    }
                }

                for (int i = 0; i < quantidadesNovas.Length; i++)
                {
                    updateQuantidadeEstoqueConsumivel(idsIngredientes[i], quantidadesNovas[i]);
                }

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Conexao.Close();
            }
            return false;
        }

        private void lstVw2_Click(object sender, EventArgs e)
        {
            if (lstVw2.FocusedItem.SubItems[2].Text.Equals("N/A"))
            {
                return;
            }
            ConsumivelAtualizar.Text = lstVw2.FocusedItem.SubItems[1].Text;
            QuantAntiga.Text = lstVw2.FocusedItem.SubItems[2].Text;
            if (nmrcUpDwnAtualizar.Value != null)
            {
                int quantidadeNova = Int32.Parse(lstVw2.FocusedItem.SubItems[2].Text) + Int32.Parse(nmrcUpDwnAtualizar.Value.ToString());
                QuantNova.Text = quantidadeNova.ToString();
            }
            else if (nmrcUpDwnAtualizar.Value == 0 || nmrcUpDwnAtualizar.Value == null)
            {
                nmrcUpDwnAtualizar.Focus();
            }
        }

        private void nmrcUpDwnAtualizar_ValueChanged(object sender, EventArgs e)
        {
            if (QuantAntiga.Text != "" && nmrcUpDwnAtualizar.Value != null)
            {
                if (rdBtnRemover.Checked)
                {
                    int quantidadeNova = Int32.Parse(lstVw2.FocusedItem.SubItems[2].Text) - Int32.Parse(nmrcUpDwnAtualizar.Value.ToString());
                    QuantNova.Text = quantidadeNova.ToString();
                }
                else if (rdBtnAdicionar.Checked)
                {
                    int quantidadeNova = Int32.Parse(lstVw2.FocusedItem.SubItems[2].Text) + Int32.Parse(nmrcUpDwnAtualizar.Value.ToString());
                    QuantNova.Text = quantidadeNova.ToString();
                }
                else
                {
                    MessageBox.Show("Nenhuma opção sobre adicionar ou remover foi escolhida, escolha antes de mudar a qualidade", "Nenhuma opção escolhida", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void rdBtnAdicionar_CheckedChanged(object sender, EventArgs e)
        {
            label8.Text = "Quantidade a adicionar:";
        }

        private void rdBtnRemover_CheckedChanged(object sender, EventArgs e)
        {
            label8.Text = "Quantidade a remover:";
        }

        private void btnRemoverEstoque_Click(object sender, EventArgs e)
        {
            if(lstVw2.FocusedItem == null)
            {
                MessageBox.Show("Nenhum vendível escolhido para ser removido do sistema", "Nenhuma opção escolhida", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                if (MessageBox.Show("Você tem certeza que quer remover " + lstVw2.FocusedItem.SubItems[1].Text + "?", "Você tem certeza?", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    int idRemover = Int32.Parse(lstVw2.SelectedItems[0].Text);
                    string consumivelOuReceita = lstVw2.FocusedItem.SubItems[2].Text;
                    if (consumivelOuReceita == "N/A") {
                        try
                        {
                            Conexao = new MySqlConnection(database_source);

                            Conexao.Open();
                            MySqlCommand command = new MySqlCommand();
                            command.Connection = Conexao;
                            command.CommandText = "DELETE FROM receitas WHERE ID_Receitas=@id;";
                            command.Parameters.Clear();
                            command.Parameters.AddWithValue("@id", idRemover);
                            command.ExecuteNonQuery();
                            AtualizarVendiveis();
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
                    else
                    {
                        try
                        {
                            Conexao = new MySqlConnection(database_source);

                            Conexao.Open();
                            MySqlCommand command = new MySqlCommand();
                            command.Connection = Conexao;
                            command.CommandText = "DELETE FROM consumiveis WHERE ID_Consumivel=@id;";
                            command.Parameters.Clear();
                            command.Parameters.AddWithValue("@id", idRemover);
                            command.ExecuteNonQuery();
                            AtualizarVendiveis();
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
                }else{
                    lstVw2.FocusedItem = null;
                }
            }
        }
    }
}
