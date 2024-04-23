using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Banco_De_Dados_1
{
    public partial class Form2 : Form
    {
        MySqlConnection Conexao2;
        private string database_source = "datasource=localhost;username=root;password=16112809;database=botecoDoSeuZe";
        private Form1 form1 = new Form1();
        public Form2()
        {
            InitializeComponent();
        }

        private void btnAdicionarConsumivel_Click(object sender, EventArgs e)
        {
            if (txtBxDescricaoConsumivel.Text == "")
            {
                MessageBox.Show("Preencha todos os campos necessários (\"Descrição\")", "Campos obrigatórios não preenchidos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtBxDescricaoConsumivel.Focus();
                return;
            }
            else if (txtBxQuantidadeConsumivel.Text == "")
            {
                MessageBox.Show("Preencha todos os campos necessários (\"Quantidade\")", "Campos obrigatórios não preenchidos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtBxQuantidadeConsumivel.Focus();
                return;
            }
            else if (txtBxValorConsumivel.Text == "")
            {
                MessageBox.Show("Preencha todos os campos necessários (\"Valor\")", "Campos obrigatórios não preenchidos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtBxValorConsumivel.Focus();
                return;
            }
            try
            {
                string descricao = txtBxDescricaoConsumivel.Text;
                int quantidade = Int32.Parse(txtBxQuantidadeConsumivel.Text);
                double valor = Double.Parse(txtBxValorConsumivel.Text);
                Conexao2 = new MySqlConnection(database_source);

                Conexao2.Open();

                MySqlCommand commandVendivel = new MySqlCommand();
                commandVendivel.Connection = Conexao2;
                commandVendivel.CommandText = "INSERT INTO consumiveis (Descricao, Quantidade, Valor) VALUES (@descricao, @quantidade, @valor);";
                commandVendivel.Parameters.Clear();
                commandVendivel.Parameters.AddWithValue("@descricao", descricao);
                commandVendivel.Parameters.AddWithValue("@quantidade", quantidade);
                commandVendivel.Parameters.AddWithValue("@valor", valor);
                commandVendivel.ExecuteNonQuery();
                form1.AtualizarVendiveis();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Conexao2.Close();
                txtBxDescricaoConsumivel.Text = "";
                txtBxQuantidadeConsumivel.Text = "";
                txtBxValorConsumivel.Text = "";
            }
        }

        private void btnAdicionarIngrediente_Click(object sender, EventArgs e)
        {
            if (txtBxNomeIngrediente.Text == "")
            {
                MessageBox.Show("Preencha todos os campos necessários (\"Nome\")", "Campos obrigatórios não preenchidos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtBxNomeIngrediente.Focus();
                return;
            }
            else if (txtBxQuantidadeIngrediente.Text == "")
            {
                MessageBox.Show("Preencha todos os campos necessários (\"Quantidade\")", "Campos obrigatórios não preenchidos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtBxQuantidadeIngrediente.Focus();
                return;
            }
            try
            {
                string descricao = txtBxNomeIngrediente.Text;
                int quantidade = Int32.Parse(txtBxQuantidadeIngrediente.Text);
                Conexao2 = new MySqlConnection(database_source);

                Conexao2.Open();

                MySqlCommand commandIngredientes = new MySqlCommand();
                commandIngredientes.Connection = Conexao2;
                commandIngredientes.CommandText = "INSERT INTO consumiveis (Descricao, Quantidade, Valor) VALUES (@descricao, @quantidade, @valor);";
                commandIngredientes.Parameters.Clear();
                commandIngredientes.Parameters.AddWithValue("@descricao", descricao);
                commandIngredientes.Parameters.AddWithValue("@quantidade", quantidade);
                commandIngredientes.Parameters.AddWithValue("@valor", 0);
                commandIngredientes.ExecuteNonQuery();
                form1.AtualizarVendiveis();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Conexao2.Close();
                txtBxNomeIngrediente.Text = "";
                txtBxQuantidadeIngrediente.Text = "";
            }
        }

        private void btnAdicionarReceita_Click(object sender, EventArgs e)
        {
            if (txtBxNomeReceita.Text == "")
            {
                MessageBox.Show("Preencha todos os campos necessários (\"Nome\")", "Campos obrigatórios não preenchidos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtBxNomeReceita.Focus();
                return;
            }
            else if (txtBxValorReceita.Text == "")
            {
                MessageBox.Show("Preencha todos os campos necessários (\"Valor\")", "Campos obrigatórios não preenchidos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtBxValorReceita.Focus();
                return;
            }
            else if (lstVwIngredientes.Items.Count == 0)
            {
                MessageBox.Show("Ingredientes para a receita não encontrados", "Campos obrigatórios não preenchidos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                int idIngrediente;
                string nome = txtBxNomeReceita.Text;
                string ingredientes = "Deu ruim";
                for (int i = 0; i < lstVwIngredientes.Items.Count; i++)
                {
                    idIngrediente = codigoIngrediente(lstVwIngredientes.Items[i].SubItems[0].Text);
                    if (idIngrediente >= 0)
                    {
                        ingredientes += lstVwIngredientes.Items[i].SubItems[0].Text;
                        ingredientes += "§";
                        ingredientes += lstVwIngredientes.Items[i].SubItems[1].Text;
                        ingredientes += "§";
                        ingredientes += idIngrediente;
                        ingredientes += "§";
                    }
                    else if (idIngrediente < 0)
                    {
                        MessageBox.Show("Você não possui esse ingrediente no seu estoque", "Ingrediente inexistente", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }

                double valor = Double.Parse(txtBxValorReceita.Text);
                Conexao2 = new MySqlConnection(database_source);

                Conexao2.Open();

                MySqlCommand commandReceita = new MySqlCommand();
                commandReceita.Connection = Conexao2;
                commandReceita.CommandText = "INSERT INTO receitas (Nome, Ingredientes, Valor) VALUES (@nome, @ingredientes, @valor);";
                commandReceita.Parameters.Clear();
                commandReceita.Parameters.AddWithValue("@nome", nome);
                commandReceita.Parameters.AddWithValue("@ingredientes", ingredientes);
                commandReceita.Parameters.AddWithValue("@valor", valor);
                commandReceita.ExecuteNonQuery();
                form1.AtualizarVendiveis();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Conexao2.Close();
                txtBxNomeReceita.Text = "";
                txtBxValorReceita.Text = "";
                lstVwIngredientes.Items.Clear();
            }
        }

        private void btnAdicionarIngredienteALista_Click(object sender, EventArgs e)
        {
            if (txtBxIngredientesReceita.Text == "")
            {
                MessageBox.Show("Preencha todos os campos necessários (\"Ingrediente\")", "Campos obrigatórios não preenchidos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtBxIngredientesReceita.Focus();
                return;
            }else if(txtBxQuantidade.Text == "")
            {
                MessageBox.Show("Preencha todos os campos necessários (\"Quantidade\")", "Campos obrigatórios não preenchidos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtBxQuantidade.Focus();
                return;
            }
            string[] row =
            {
                txtBxIngredientesReceita.Text,
                txtBxQuantidade.Text,
            };
            var linha_lstVw = new ListViewItem(row);
            lstVwIngredientes.Items.Add(linha_lstVw);
            txtBxIngredientesReceita.Text = "";
            txtBxQuantidade.Text = "";
        }

        private int codigoIngrediente(string nomeIngrediente)
        {
            try
            {
                int quantosTem = 0;
                int codigoIngrediente = 0;

                Conexao2 = new MySqlConnection(database_source);

                Conexao2.Open();

                MySqlCommand commandChecar = new MySqlCommand();
                commandChecar.Connection = Conexao2;
                commandChecar.CommandText = "SELECT COUNT(Descricao) FROM consumiveis WHERE Descricao=@nome;";
                commandChecar.Parameters.Clear();
                commandChecar.Parameters.AddWithValue("@nome", nomeIngrediente);
                MySqlDataReader readerChecar = commandChecar.ExecuteReader();

                while (readerChecar.Read())
                {
                    quantosTem = Int32.Parse(readerChecar.GetValue(0).ToString());
                }

                if (quantosTem > 0)
                {

                    Conexao2 = new MySqlConnection(database_source);

                    Conexao2.Open();

                    MySqlCommand commandCodigo = new MySqlCommand();
                    commandCodigo.Connection = Conexao2;
                    commandCodigo.CommandText = "SELECT * FROM consumiveis WHERE Descricao=@nome;";
                    commandCodigo.Parameters.Clear();
                    commandCodigo.Parameters.AddWithValue("@nome", nomeIngrediente);
                    MySqlDataReader readerCodigo = commandCodigo.ExecuteReader();

                    while (readerCodigo.Read())
                    {
                        codigoIngrediente = Int32.Parse(readerCodigo.GetValue(0).ToString());
                    }
                    return codigoIngrediente;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Conexao2.Close();
            }
            return -1;
        }
    }
}
