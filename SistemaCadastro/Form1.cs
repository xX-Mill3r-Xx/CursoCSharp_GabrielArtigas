using SistemaCadastro.Entidades;
using SistemaCadastro.Enums;
using SistemaCadastro.Extensoes;
using SistemaCadastro.Helpers;
using SistemaCadastro.Util;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace SistemaCadastro
{
    public partial class Form1 : Form
    {
        #region Properties

        List<Pessoa> _pessoas;

        private BotaoSair _botaoSair;

        #endregion

        #region Constructors

        public Form1()
        {
            InitializeComponent();
            _pessoas = new List<Pessoa>();
            _botaoSair = new BotaoSair();
        }

        #endregion

        private void Form1_Load(object sender, EventArgs e)
        {
            ComboBoxHelpers.PopularComEnum<EEstadoCivil>(cbEstadoCivil);
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnFechar_MouseEnter(object sender, EventArgs e)
        {
            _botaoSair.ComportamentoBotaoEntrar(btnFechar, Color.Red);
        }

        private void btnFechar_MouseLeave(object sender, EventArgs e)
        {
            _botaoSair.ComportamentoBotaoSair(btnFechar, SystemColors.Control);
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                Cadastrar();
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao cadastrar - {ex.Message}");
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                Excluir();
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao excluir - {ex.Message}");
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            try
            {
                LimparCampos();
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao limpar caompos - {ex.Message}");
            }
        }

        private void listResult_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            btnCadastrar.Text = "Atualizar";
            tcPrincipal.SelectedTab = tpCadastro;

            int indice = listResult.SelectedIndex;
            Pessoa pessoa = _pessoas[indice];
            txtNome.Text = pessoa.Nome;
            dtDataNascimento.Value = pessoa.DataNascimento;
            cbEstadoCivil.SelectedItem = pessoa.EstadoCivil;
            mktTelefone.Text = pessoa.Telefone;
            ckbCasaPropia.Checked = pessoa.CasaPropia;
            ckbVeiculo.Checked = pessoa.Veiculo;
            if (pessoa.Sexo == 'M')
                rbMasculino.Checked = true;
            else
                rbFeminino.Checked = true;

            txtNome.Enabled = false;
        }

        #region Métodos

        private void LimparCampos()
        {
            txtNome.Clear();
            dtDataNascimento.Value = DateTime.Now;
            cbEstadoCivil.SelectedIndex = 0;
            mktTelefone.Clear();
            ckbCasaPropia.Checked = false;
            ckbVeiculo.Checked = false;
            rbMasculino.Checked = true;
            txtNome.Focus();
        }

        private void Listar()
        {
            listResult.Items.Clear();

            foreach (Pessoa pessoa in _pessoas)
            {
                listResult.Items.Add($"{pessoa.Nome} - {pessoa.Telefone}");
            }
        }

        private void Cadastrar()
        {
            int index = -1;
            foreach (Pessoa pessoa in _pessoas)
            {
                if (pessoa.Nome == txtNome.Text)
                {
                    index = _pessoas.IndexOf(pessoa);
                }
            }

            if (!ValidarCampoNomeVazio())
            {
                return;
            }

            if (!ValidarCampoTelefoneVazio())
            {
                return;
            }

            AdicionarPessoa(index);
            btnLimpar_Click(btnLimpar, EventArgs.Empty);
            tcPrincipal.SelectedTab = tpConsulta;
            Listar();
        }

        private Pessoa AdicionarPessoa(int index)
        {
            Pessoa p = new Pessoa
            {
                Nome = txtNome.Text,
                DataNascimento = dtDataNascimento.Value,
                EstadoCivil = cbEstadoCivil.SelectedItem.ToString(),
                Telefone = mktTelefone.Text,
                CasaPropia = ckbCasaPropia.Checked,
                Veiculo = ckbVeiculo.Checked,
                Sexo = RetornaSexoSelecionado()
            };

            if (index < 0)
                _pessoas.Add(p);
            else
                _pessoas[index] = p;

            return p;
        }

        private bool ValidarCampoNomeVazio()
        {
            if (string.IsNullOrWhiteSpace(txtNome.Text))
            {
                MessageBox.Show(Mensagens.CampoNomeVazio, Mensagens.Atencao, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNome.Focus();
                return false;
            }

            return true;
        }

        private bool ValidarCampoTelefoneVazio()
        {
            if (string.IsNullOrWhiteSpace(mktTelefone.Text) || 
                mktTelefone.Text == Formatacao.MascaraTelefone())
            {
                MessageBox.Show(Mensagens.CampoTelefoneVazio, Mensagens.Atencao, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                mktTelefone.Focus();
                return false;
            }

            return true;
        }

        private char RetornaSexoSelecionado()
        {
            if (rbMasculino.Checked)
                return 'M';

            return 'F';
        }

        public void Excluir()
        {
            int indice = listResult.SelectedIndex;
            _pessoas.RemoveAt(indice);
            Listar();

            tcPrincipal.SelectedTab = tpCadastro;
        }

        #endregion
    }
}
