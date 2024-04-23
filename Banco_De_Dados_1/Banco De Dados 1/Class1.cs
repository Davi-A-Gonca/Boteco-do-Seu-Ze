using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lista_de_Produtos
{

    internal class DBConector
    {
        private static String database = "MDVA_Trades";
        private static String user = "root";
        private static String password = "1234";
        private static String conectionData = "server=localhost;uid=" + user + ";pwd=" + password + ";database=" + database;

        private static String genericSelectAllQuery = "SELECT * FROM ";
        private static String genericDeleteCommand = "DELETE FROM ";

        static DBConector()
        {

        }

        public static void createEntry(String table, String values)
        {
            String query = "INSERT INTO " + table + " VALUES " + values;

            try
            {
                MySqlConnection con = new MySqlConnection(conectionData);
                con.Open();

                MySqlCommand cmd = new MySqlCommand(query, con);

                cmd.ExecuteNonQuery();

                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Mensagem de Erro: " + ex.Message, "Mensagem de Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        public static String readEntry(String table)//Pega TODAS AS COLUAS da tabela selecionada
        {
            String toReturn = "";

            MySqlConnection con = new MySqlConnection(conectionData);

            con.Open();

            try
            {


                MySqlCommand command = new MySqlCommand(genericSelectAllQuery + table, con);
                var reader = command.ExecuteReader();

                while (reader.Read())
                {
                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        toReturn += reader[i].ToString();
                        toReturn += " § ";
                    }
                }

                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Mensagem de Erro: " + ex.Message, "Mensagem de Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageBox.Show("query: " + genericSelectAllQuery + table, "Mensagem de Erro");
            }


            return toReturn;
        }

        public static String readEntry(String column, String table)
        {
            String toReturn = "";
            String query = "SELECT " + column + " FROM " + table;


            MySqlConnection con = new MySqlConnection(conectionData);
            con.Open();

            try
            {
                MySqlCommand command = new MySqlCommand(query, con);
                var reader = command.ExecuteReader();

                while (reader.Read())
                {
                    toReturn += reader[0].ToString();
                    toReturn += "§";
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Mensagem de Erro: " + ex.Message, "Mensagem de Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageBox.Show("query: " + query, "Mensagem de Erro");
            }
            finally
            {
                con.Close();
            }

            return toReturn;
        }

        public static String readEntry(String column, String table, String condition)
        {
            String toReturn = "";
            String query = "SELECT " + column + " FROM " + table + " WHERE " + condition;

            MySqlConnection con = new MySqlConnection(conectionData);
            con.Open();

            try
            {
                MySqlCommand command = new MySqlCommand(query, con);
                var reader = command.ExecuteReader();

                while (reader.Read())
                {
                    toReturn += reader[0].ToString();
                    toReturn += "§";
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Mensagem de Erro: " + ex.Message, "Mensagem de Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageBox.Show("query: " + query, "Mensagem de Erro");
            }
            finally
            {
                con.Close();
            }

            return toReturn;
        }

        public static void updateEntry(String query)
        {

        }

        public static void updateEntry(String table, String column, String newValue)
        {
            String query = "UPDATE " + table + " SET " + column + " = " + newValue;
        }

        public static void updateEntry(String table, String column, String newValue, String condition)
        {
            String query = "UPDATE " + table + " SET " + column + " = " + newValue + " WHERE " + condition;
        }

        public static void deleteEntry(String table)
        {
            String query = genericDeleteCommand + table;
        }

        public static void deleteEntry(String table, String condition)
        {
            String query = genericDeleteCommand + table + " WHERE " + condition;
        }

        public static int getQuantityEntries(String table)
        {
            String query = "SELECT COUNT(*) FROM " + table;

            return 0;
        }

        public static int getQuantityEntries(String table, String condition)
        {
            String query = "SELECT COUNT(*) FROM " + table + " WHERE " + condition;

            return 0;
        }
    }
}