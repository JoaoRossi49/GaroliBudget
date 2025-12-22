using GaroliBudget.Models;
using GaroliBudget.Repositories.Interfaces;
using GaroliBudget.Services;
using System.Data;
using System.Globalization;

namespace GaroliBudget
{
    public partial class OR0001mnIncluir : Form
    {
        private readonly IClienteService _clienteService;
        private Cliente _clienteExistente;

        public OR0001mnIncluir(IClienteService clienteService)
        {
            InitializeComponent();
            _clienteService = clienteService;
            this.Text = "Novo Cliente";
        }

        public OR0001mnIncluir(IClienteService clienteService, Cliente clienteParaEditar) : this(clienteService)
        {
            _clienteExistente = clienteParaEditar;
            this.Text = "Editar Cliente";
            PreencherCampos();
        }

        private void PreencherCampos()
        {
            //tbRazaoSocial.Text = _clienteExistente.RazaoSocial;
            //tbNomeFantasia.Text = _clienteExistente.NomeFantasia;
            //mtbCnpj.Text = _clienteExistente.Cnpj;
            //tbEmail.Text = _clienteExistente.Email;
            //mtbTelefone.Text = _clienteExistente.Telefone;
        }

        private void CalcularTotalGeral()
        {
            decimal totalGeral = 0;

            // 1. Somar Materiais
            foreach (DataGridViewRow linha in dgvMateriais.Rows)
            {
                // Verifica se a linha não está vazia (aquela linha em branco no final do grid)
                if (linha.Cells["valorTotal"].Value != null)
                {
                    string valorString = linha.Cells["valorTotal"].Value.ToString();
                    totalGeral += Convert.ToDecimal(valorString, CultureInfo.InvariantCulture);
                }
            }

            //// 2. Somar Processos (Mão de obra)
            //foreach (DataGridViewRow linha in dgvProcessos.Rows)
            //{
            //    if (linha.Cells["colCustoProcesso"].Value != null)
            //    {
            //        totalGeral += Convert.ToDecimal(linha.Cells["colCustoProcesso"].Value);
            //    }
            //}

            // 3. Atualiza a tela com o símbolo de Real (C2 = Currency 2 casas decimais)
            lblValorFinal.Text = totalGeral.ToString("C2");
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Cliente cadastrado com sucesso!");
            //var clienteParaSalvar = _clienteExistente ?? new Cliente();

            //clienteParaSalvar.RazaoSocial = tbRazaoSocial.Text;
            //clienteParaSalvar.NomeFantasia = tbNomeFantasia.Text;
            //clienteParaSalvar.Cnpj = mtbCnpj.Text;
            //clienteParaSalvar.Telefone = mtbTelefone.Text;
            //clienteParaSalvar.Email = tbEmail.Text;

            //try
            //{
            //    if (_clienteExistente == null)
            //    {
            //        _clienteService.CriarCliente(clienteParaSalvar);
            //        MessageBox.Show("Cliente cadastrado com sucesso!");
            //    }
            //    else
            //    {
            //        _clienteService.AtualizarCliente(clienteParaSalvar);
            //        MessageBox.Show("Cliente atualizado com sucesso!");
            //    }

            //    this.DialogResult = DialogResult.OK;
            //    this.Close();
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show($"Erro ao salvar: {ex.Message}");
            //}
        }

        private void CarregarComboClientes()
        {
            List<Cliente> lista = _clienteService.ListarTodos();

            cbClientes.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbClientes.AutoCompleteSource = AutoCompleteSource.ListItems;
            cbClientes.DropDownStyle = ComboBoxStyle.DropDownList;
            cbClientes.DisplayMember = "RazaoSocial";
            cbClientes.ValueMember = "IdCliente";
            cbClientes.DataSource = lista;
            cbClientes.SelectedIndex = -1;
        }

        private void OR0001mnIncluir_Load(object sender, EventArgs e)
        {
            CarregarComboClientes();
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            dgvMateriais.Rows.Add("Parafuso Sextavado", "10", "1.50", "15.00");
            CalcularTotalGeral();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (dgvMateriais.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in dgvMateriais.SelectedRows)
                {
                    {
                        dgvMateriais.Rows.Remove(row);
                    }
                }

                CalcularTotalGeral();
            }
            else
            {
                MessageBox.Show("Selecione uma linha inteira clicando na barra lateral esquerda do Grid.");
            }
        }
    }
}
