using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Colecoes
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            lista.Items.Clear(); // sempre limpa o listbox antes de exibir os elementos

            #region exemplo de um array

            //Array - Tipo Primitivo
            string[] nomes = new string[] { "Miller", "Mateus", "Juninho" };

            #endregion

            #region para criar e iniciar uma lista

            // podemos tambem criar uma lista vazia, sem iniciar.

            List<string> nomesLista = new List<string>
            {
                "nome 1",
                "nome 2",
                "nome 3",
                "nome 4",
                "etc..."
            };

            #endregion

            #region para adicionar nomes a lista

            nomesLista.Add("Lucas");
            nomesLista.Add("nome 5");

            #endregion

            #region para exibir os nomes na lista

            // podemos exibor apenas os nomes selecionados com o metodo .Add()

            //lista.Items.Add(nomesLista[0]);
            //lista.Items.Add(nomesLista[1]);
            //lista.Items.Add(nomesLista[2]);
            //lista.Items.Add(nomesLista[3]);
            //lista.Items.Add(nomesLista[4]);
            //lista.Items.Add(nomesLista[5]);
            //lista.Items.Add(nomesLista[6]);

            #endregion

            #region adicionando elementos usando o AddRange()

            //lista.Items.AddRange(nomesLista.ToArray());

            #endregion

            #region removendo elementos da lista

            //if (nomesLista.Remove("Lucas"))
            //    MessageBox.Show("Lucas removido", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //else
            //    MessageBox.Show("não foi possivel remover", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);

            #endregion

            #region metodo Contains()

            //if(nomesLista.Contains("nome 1"))
            //    MessageBox.Show("Contem o nome 1", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //else
            //    MessageBox.Show("não contem o nome 1", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);

            #endregion

            #region metodo Count()

            //MessageBox.Show($"Numero de elementos desta lista: {nomesLista.Count}");

            #endregion

            #region metodo Sort

            //nomesLista.Sort(); // organiza em ordem alfabetica

            #endregion

            #region para saber o indice de um elemento da lista

            //MessageBox.Show($"Lucas está no indice: {nomesLista.IndexOf("Lucas")}");

            #endregion

            #region metodo Insert

            nomesLista.Insert(2, "Miller");

            #endregion

            #region metodo RemoveAt()

            nomesLista.RemoveAt(3);

            #endregion

            #region metodo Clear()

            //nomesLista.Clear();

            #endregion

            #region usando um foreach para percorrer a lista e add os elementos

            foreach (string nome in nomesLista)
            {
                lista.Items.Add(nome);
            }

            #endregion
        }

        private void btnHashSet_Click(object sender, EventArgs e)
        {
            lista.Items.Clear();

            #region criar e instanciar listas do tipo hashSet

            // obs, listas do tipo hashSet não aceitam elementos repetidos

            HashSet<string> veiculos = new HashSet<string>
            {
                "Carros",
                "Motos",
                "Avião"
            };

            if (veiculos.Add("Cavalo"))
                MessageBox.Show("Cavalo adicionado", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("Não foi possivel adicionar", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);

            #endregion

            #region metodo Contais()

            if (veiculos.Contains("Carros"))
                MessageBox.Show("Contem Carros");
            else
                MessageBox.Show("Não Contem");

            #endregion

            #region metodo Remove()

            if (veiculos.Remove("Carros"))
                MessageBox.Show("Carros Removido");
            else
                MessageBox.Show("Não Removido");

            #endregion

            #region propiedade Count

            int num = veiculos.Count;

            MessageBox.Show($"Elementos nesta lista: {num}");

            #endregion

            #region metodo Clear()

            //veiculos.Clear();

            #endregion

            #region para acessar um elemento da lista

            MessageBox.Show(veiculos.ElementAt(1));

            #endregion

            #region metodo First()

            MessageBox.Show($"O primeiro elemento é: {veiculos.First()}");

            #endregion

            #region metodo Last()

            MessageBox.Show($"O ultimo elemento é: {veiculos.Last()}");
            #endregion

            #region percorrer e add os elementos a lista

            foreach (string veiculo in veiculos)
            {
                lista.Items.Add(veiculo);
            }

            #endregion

        }

        private void btnDictionary_Click(object sender, EventArgs e)
        {
            lista.Items.Clear();

            #region criar e instanciar uma lista do tipo Dictionary

            Dictionary<int, string> alunos = new Dictionary<int, string>
            {
                { 150, "Danny" },
                { 200, "Artur" },
                { 80, "Gabriel" }
            };

            #endregion

            #region add valores a uma lista dictionary

            alunos.Add(100, "Miller");

            #endregion

            #region metodos e propiedades das dictionary

            lista.Items.Add($"Quantidade total de alunos: {alunos.Count}");
            lista.Items.Add("-------------------------------------------");
            //alunos.Remove(100);
            //alunos.Clear();
            //alunos.ContainsKey(100);
            //alunos.ContainsValue("Gabriel");
            //alunos.First();
            //alunos.Last();

            #endregion

            #region percorrer uma dictionary

            foreach (KeyValuePair<int, string> item in alunos)
            {
                lista.Items.Add($"Chave: {item.Key} - Aluno: {item.Value}");
                lista.Items.Add("-------------------------------------------");
            }

            #endregion
        }
    }
}
