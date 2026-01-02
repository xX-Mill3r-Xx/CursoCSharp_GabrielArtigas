using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace LINQ
{
    public partial class Form1 : Form
    {
        #region Coleçoes

        List<string> listaNomes;
        List<int> listaNumeros;
        Dictionary<string, double> listaProdutos;
        Dictionary<string, string> listaEstados;

        #endregion

        public Form1()
        {
            InitializeComponent();
            listaNomes = PopularNomes();
            listaNumeros = PopularNumeros();
        }

        private void btnExecutar_Click(object sender, EventArgs e)
        {
            try
            {
                //RetornarNomes();
                RetornarNumeros();
            }
            catch (Exception ex)
            {
                lista.Items.Add(ex.Message);
            }
        }

        #region Lista de nomes

        private List<string> PopularNomes()
        {
            return new List<string>
            {
                "Miller",
                "Mateus",
                "Juninho"
            };
        }

        private IEnumerable<string> ObterNomes(string txt)
        {
            IEnumerable<string> res = from nome in listaNomes
                                      where nome.StartsWith(txt)
                                      select nome;
            return res;
        }

        private void RetornarNomes()
        {
            lista.Items.Clear();
            string txt = txtConsulta.Text;
            IEnumerable<string> res = ObterNomes(txt);
            lista.Items.AddRange(res.ToArray());
        }

        #endregion

        #region Lista de numeros

        private List<int> PopularNumeros()
        {
            return new List<int>
            {
                1,2,3,4,5,6,7,8,9,0
            };
        }

        private IEnumerable<int> ObterNumeros(string txt)
        {
            IEnumerable<int> res = from num in listaNumeros
                                   where num % int.Parse(txt) == 0
                                   select num;
            return res;
        }

        private void RetornarNumeros()
        {
            lista.Items.Clear();
            string txt = txtConsulta.Text;
            IEnumerable<int> res = ObterNumeros(txt);

            foreach (var item in res)
            {
                lista.Items.Add(item);
            }
        }

        #endregion
    }
}
