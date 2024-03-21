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
            try
            {
                string descricao = txtBxDescricaoConsumivel.Text;
                int quantidade = Int32.Parse(txtBxQuantidadeConsumivel.Text);
                double valor = Double.Parse(txtBxValorConsumivel.Text);
                Conexao2 = new MySqlConnection(database_source);

                Conexao2.Open();

                MySqlCommand commandVendivel = new MySqlCommand();
                commandVendivel.Connection = Conexao2;
                commandVendivel.CommandText = "INSERT INTO consumiveis (ID_Consumivel, Descricao, Quantidade, Valor) VALUES (@id, @descricao, @quantidade, @valor);";
                commandVendivel.Parameters.Clear();
                commandVendivel.Parameters.AddWithValue("@id", 1);
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
            try
            {
                string descricao = txtBxNomeIngrediente.Text;
                int quantidade = Int32.Parse(txtBxQuantidadeIngrediente.Text);
                Conexao2 = new MySqlConnection(database_source);

                Conexao2.Open();

                MySqlCommand commandIngredientes = new MySqlCommand();
                commandIngredientes.Connection = Conexao2;
                commandIngredientes.CommandText = "INSERT INTO consumiveis (ID_Consumivel, Descricao, Quantidade, Valor) VALUES (@id, @descricao, @quantidade, @valor);";
                commandIngredientes.Parameters.Clear();
                commandIngredientes.Parameters.AddWithValue("@id", 2);
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
            try
            {
                string nome = txtBxNomeReceita.Text;
                string temp = "";
                for (int i = 0; i < lstVwIngredientes.Items.Count; i++)
                {
                    temp += lstVwIngredientes.Items[i].SubItems[0].Text;
                    temp += "§";
                    temp += lstVwIngredientes.Items[i].SubItems[1].Text;
                    temp += "§";
                }
                string ingredientes = txtBxIngredientesReceita.Text;
                double valor = Double.Parse(txtBxValorReceita.Text);
                Conexao2 = new MySqlConnection(database_source);

                Conexao2.Open();

                MySqlCommand commandReceita = new MySqlCommand();
                commandReceita.Connection = Conexao2;
                commandReceita.CommandText = "INSERT INTO receitas (ID_Receitas, Nome, Ingredientes, Valor) VALUES (@id, @nome, @ingredientes, @valor);";
                commandReceita.Parameters.Clear();
                commandReceita.Parameters.AddWithValue("@id", 3);
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
            string[] row =
            {
                txtBxIngredientesReceita.Text,
                txtBxQuantidade.Text,
            };
            var linha_lstVw = new ListViewItem(row);
            lstVwIngredientes.Items.Add(linha_lstVw);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string temp = "";
            for (int i = 0; i < lstVwIngredientes.Items.Count; i++)
            {
                temp += lstVwIngredientes.Items[i].SubItems[0].Text;
                temp += "§";
                temp += lstVwIngredientes.Items[i].SubItems[1].Text;
                temp += "§";
            }
            MessageBox.Show(temp);
        }
    }
}
