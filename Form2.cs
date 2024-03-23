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
                string nome = txtBxNomeReceita.Text;
                string ingredientes = "";
                for (int i = 0; i < lstVwIngredientes.Items.Count; i++)
                {
                    ingredientes += lstVwIngredientes.Items[i].SubItems[0].Text;
                    ingredientes += "§";
                    ingredientes += lstVwIngredientes.Items[i].SubItems[1].Text;
                    ingredientes += "§";
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
        }
    }
}
