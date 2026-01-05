using System;
using System.IO;
using System.Windows.Forms;

namespace BaseDados.SQLiteConnection
{
    public static class DataSQLiteConnection
    {
        public static void CriarConecxaoSQLite()
        {
            string baseDados = Application.StartupPath + @"\db\dbSqlite.db";
            string strConnection = $@"Data Source = {baseDados}; Version = 3";

            if (!File.Exists(baseDados))
                System.Data.SQLite.SQLiteConnection.CreateFile(baseDados);

            System.Data.SQLite.SQLiteConnection conection = new System.Data.SQLite.SQLiteConnection(strConnection);

            try
            {
                conection.Open();

                MessageBox.Show("Conectado SQLite");

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
