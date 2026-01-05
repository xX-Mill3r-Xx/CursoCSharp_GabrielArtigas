using System;
using System.Data.SqlServerCe;
using System.IO;
using System.Windows.Forms;

namespace BaseDados.SQLServerCEConection
{
    public static class DataSQLServerCE
    {
        private static string RetornaBaseDados()
        {
            string baseDados = Application.StartupPath + @"\db\dbSqlServer.sdf";
            return baseDados;
        }

        private static string RetornaConexao(string baseDados)
        {
            string strConnection = $@"DataSource = {baseDados}; Password = '1234'";
            return strConnection;
        }

        public static void CriarConecxaoSQLServerCE()
        {
            string baseDados = RetornaBaseDados();
            string strConnection = RetornaConexao(baseDados);

            SqlCeEngine db = new SqlCeEngine(strConnection);

            if (!File.Exists(baseDados))
                db.CreateDatabase();

            db.Dispose();

            SqlCeConnection connection = new SqlCeConnection(strConnection);

            try
            {
                connection.Open();

                MessageBox.Show("Conectado SQL Server CE");

                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        public static void CriarTabela()
        {
            string baseDados = RetornaBaseDados();
            string strConnection = RetornaConexao(baseDados);

            SqlCeConnection connection = new SqlCeConnection(strConnection);

            try
            {
                connection.Open();
                SqlCeCommand cmd = new SqlCeCommand();
                cmd.Connection = connection;

                cmd.CommandText = "CREATE TABLE PESSOAS (ID INT NOT NULL PRIMARY KEY, NOME NVARCHAR(50), EMAIL NVARCHAR(50))";
                cmd.ExecuteNonQuery();

                MessageBox.Show("Tabela criada: SQL Server CE");
                cmd.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }
    }
}
