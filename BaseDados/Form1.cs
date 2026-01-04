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
            DataSQLServerCE.CriarConecxao();
            lbResultado.Text = "base de dados criada!";
        }
    }
}
