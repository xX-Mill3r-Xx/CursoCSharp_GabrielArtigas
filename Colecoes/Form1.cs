using System;
using System.Collections.Generic;
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

            #region usando um foreach para percorrer a lista e add os elementos

            foreach (string nome in nomesLista)
            {
                lista.Items.Add(nome);
            }

            #endregion
        }
    }
}
