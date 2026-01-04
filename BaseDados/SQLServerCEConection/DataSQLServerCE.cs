using System;
using System.Data.SqlServerCe;
using System.IO;
using System.Windows.Forms;

namespace BaseDados.SQLServerCEConection
{
    public static class DataSQLServerCE
    {
        public static void CriarConecxao()
        {
            string baseDados = Application.StartupPath + @"\db\dbSqlServer.sdf";
            string strConnection = $@"DataSource = {baseDados}; Password = '1234'";

            SqlCeEngine db = new SqlCeEngine(strConnection);

            if (!File.Exists(baseDados))
                db.CreateDatabase();

            db.Dispose();

            SqlCeConnection conection = new SqlCeConnection(strConnection);

            try
            {
                conection.Open();

                MessageBox.Show("Conectado SQL Server CE");

                conection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conection.Close();
            }
        }
    }
}
