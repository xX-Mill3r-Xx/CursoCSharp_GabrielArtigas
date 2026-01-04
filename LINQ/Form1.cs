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

        private void btnAgregacao_Click(object sender, EventArgs e)
        {
            try
            {
                lista.Items.Clear();
                //OpCount();
                //OpAVG();
                //OpSum();
                //OpMin();
                OpMax();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #region Op de Agregação

        private void OpCount()
        {
            string txt = txtConsulta.Text.Trim();

            int cont1 = listaNomes.Count();
            int cont2 = (from nomes in listaNomes where nomes.StartsWith(txt) select nomes).Count();

            lista.Items.Add($"{cont1} Nomes");
            lista.Items.Add($"{cont2} Nomes começados com a letra {txt}");
        }

        private void OpAVG()
        {
            double media1 = listaNumeros.Average();
            lista.Items.Add($"{media1:N2} Média dos valores na lista numeros");

            var consulta = from numeros in listaNumeros
                           where numeros < 10
                           select numeros;

            double media2 = consulta.Average();
            lista.Items.Add($"{media2:N2} Média dos valores menores que 10");
        }

        private void OpSum()
        {
            int sum = listaNumeros.Sum((numeros) => numeros);
            lista.Items.Add($"Soma dos numeros: {sum}");

            var res = from num in listaNumeros
                      where num < 10
                      select num;
            int soma = res.Sum();

            lista.Items.Add($"Soma dos numeros menores que 10: {soma}");
        }

        private void OpMin()
        {
            int minimo = listaNumeros.Min();
            lista.Items.Add($"Menor numero é: {minimo}");
        }

        private void OpMax()
        {
            int maximo = listaNumeros.Max();
            lista.Items.Add($"Maior numero é: {maximo}");
        }

        #endregion

        private void btnOpElemento_Click(object sender, EventArgs e)
        {
            try
            {
                lista.Items.Clear();
                OpElemento();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #region Op de Elemento

        private void OpElemento()
        {
            string posicao = txtConsulta.Text;

            //tambem aplicados a consultas

            int primeiro = listaNumeros.FirstOrDefault();
            lista.Items.Add(primeiro);

            int elemento = listaNumeros.ElementAt(int.Parse(posicao));
            lista.Items.Add(elemento);

            var consulta = from num in listaNumeros where num > int.Parse(posicao) select num;
            int numero = consulta.FirstOrDefault();
            lista.Items.Add(numero);
        }

        #endregion

        private void btnLinqLambda_Click(object sender, EventArgs e)
        {
            try
            {
                lista.Items.Clear();
                LinqLambda();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #region LINQ - Lambda

        private void LinqLambda()
        {
            lista.Items.Add("### Usando uma consulta normal ###");
            var consulta = from nome in listaNomes select nome; // metodo comum
            lista.Items.AddRange(consulta.ToArray());

            lista.Items.Add("### Usando o método lambda ###");
            var select = listaNomes.Select(x => x); // metodo lambda normal
            lista.Items.AddRange(select.ToArray());

            lista.Items.Add("### Usando o operador where ###");
            string comecaCom = txtConsulta.Text;
            var where = listaNomes.Where(x => x.StartsWith(comecaCom)); 
            lista.Items.AddRange(where.ToArray());

            lista.Items.Add("### Usando o order by ###");
            var orderBy = listaNomes.OrderBy(x => x);
            lista.Items.AddRange(orderBy.ToArray());

            lista.Items.Add("### Usando o group by ###");
            var groupBy = listaEstados.GroupBy(x => x.Key);
            foreach ( var grupo in groupBy)
            {
                lista.Items.Add($"{grupo.Key}");
                foreach (var item in grupo)
                {
                    lista.Items.Add($"   {item.Value}");
                }
            }
        }

        #endregion
    }
}
