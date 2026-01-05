using BaseDados.SQLiteConnection;
using BaseDados.SQLServerCEConection;
using System;
using System.Windows.Forms;

namespace BaseDados
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConectar_Click(object sender, EventArgs e)
        {
            if (rbSQLServerCE.Checked)
            {
                DataSQLServerCE.CriarConecxaoSQLServerCE();
                lbResultado.Text = "Base de dados SQL Server CE criada!";
            }

            if (rbSQLite.Checked)
            {
                DataSQLiteConnection.CriarConecxaoSQLite();
                lbResultado.Text = "Base de dados SQLite criada!";
            }

            if (rbMySQL.Checked)
            {
                MessageBox.Show("Não Implementado!");
            }
        }

        private void btnCriarTabela_Click(object sender, EventArgs e)
        {
            if (rbSQLServerCE.Checked)
            {
                DataSQLServerCE.CriarTabela();
                lbResultado.Text = "Tabela criada: SQL Server CE";
            }

            if (rbSQLite.Checked)
            {
                MessageBox.Show("Não Implementado!");
            }

            if (rbMySQL.Checked)
            {
                MessageBox.Show("Não Implementado!");
            }
        }
    }
}
