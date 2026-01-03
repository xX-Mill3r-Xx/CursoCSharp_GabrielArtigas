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

        #region Constructors

        public Form1()
        {
            InitializeComponent();
            listaNomes = PopularNomes();
            listaNumeros = PopularNumeros();
            listaProdutos = PopularProdutos();

            listaEstados = new Dictionary<string, string>
            {
                { "Minas", "Brasil" },
                { "São Paulo", "Brasil" },
                { "Nova York", "Estados Unidos" },
                { "Paris", "França" }
            };
        }

        #endregion

        private void btnExecutar_Click(object sender, EventArgs e)
        {
            try
            {
                lista.Items.Clear();

                string txt = txtConsulta.Text;

                if (int.TryParse(txt, out int numero))
                    RetornarNumeros();
                else
                    RetornarNomes();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                1,2,3,4,5,6,7,8,9,0,
                20,30,40,50,60,70,80,90
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
            string txt = txtConsulta.Text;
            IEnumerable<int> res = ObterNumeros(txt);

            foreach (var item in res)
            {
                lista.Items.Add(item);
            }
        }

        #endregion

        #region Lista de produtos

        private Dictionary<string, double> PopularProdutos()
        {
            return new Dictionary<string, double>
            {
                { "Arroz", 1.99 },
                { "Feijão", 2.50 },
                { "Acucar", 5.99 }
            };
        }

        private IEnumerable<KeyValuePair<string, double>> ObterProdutos(string txt)
        {
            IEnumerable<KeyValuePair<string, double>> res = from p in listaProdutos
                                                          where p.Key.ToLower().Contains(txt.ToLower())
                                                          select p;

            return res;
        }

        private void RetornarProdutos()
        {
            string txt = txtConsulta.Text;
            IEnumerable<KeyValuePair<string, double>> res = ObterProdutos(txt);

            foreach (var item in res)
            {
                lista.Items.Add($"[{item.Key}] - R$ {item.Value}");
            }
        }

        #endregion

        private void btnWhere_Click(object sender, EventArgs e)
        {
            try
            {
                lista.Items.Clear();
                ClausulaWhere();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #region Clausula Where

        private void ClausulaWhere()
        {
            string txt = txtConsulta.Text;
            var res = from nome in listaNomes
                      where nome.ToLower().Contains(txt)
                      select nome;

            lista.Items.AddRange(res.ToArray());
        }

        #endregion

        private void btnOrderBy_Click(object sender, EventArgs e)
        {
            try
            {
                lista.Items.Clear();
                OrderBy();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #region Order By

        private void OrderBy()
        {
            string txt = txtConsulta.Text;
            TipoConsulta(txt);
        }

        private void TipoConsulta(string txt)
        {
            if (int.TryParse(txt, out int numeros))
            {
                var res = from n in listaNumeros
                          orderby n descending
                          where n <= int.Parse(txt)
                          select n;

                foreach (var item in res)
                {
                    lista.Items.Add(item);
                }
            }
            else
            {
                var res = from nome in listaNomes
                          orderby nome descending
                          where nome.Contains(txt)
                          select nome;

                lista.Items.AddRange(res.ToArray());
            }
        }

        #endregion

        private void btnObterProdutos_Click(object sender, EventArgs e)
        {
            try
            {
                lista.Items.Clear();
                RetornarProdutos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGroupBy_Click(object sender, EventArgs e)
        {
            try
            {
                lista.Items.Clear();
                GroupBy();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #region GroupBy

        private void GroupBy()
        {
            string txt = txtConsulta.Text;
            var res = from estado in listaEstados
                      group estado by estado.Value;

            foreach (var item in res)
            {
                lista.Items.Add($"🟢 {item.Key}");
                foreach (var estado in item)
                {
                    lista.Items.Add($" Estado ---> {estado.Key}");
                }
            }     
        }

        #endregion
    }
}
