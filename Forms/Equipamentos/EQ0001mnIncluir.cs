using GaroliBudget.Models;
using GaroliBudget.Repositories.Interfaces;
using GaroliBudget.Services;
using System.Data;
using System.Globalization;

namespace GaroliBudget
{
    public partial class EQ0001mnIncluir : Form
    {
        private readonly IClienteService _clienteService;
        private Cliente _clienteExistente;

        public EQ0001mnIncluir(IClienteService clienteService)
        {
            InitializeComponent();
            _clienteService = clienteService;
            this.Text = "Novo Cliente";
        }

        public EQ0001mnIncluir(IClienteService clienteService, Cliente clienteParaEditar) : this(clienteService)
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

            foreach (DataGridViewRow linha in dgvMateriais.Rows)
            {
                // Verifica se a linha não está vazia (aquela linha em branco no final do grid)
                if (linha.Cells["valorTotalMaterial"].Value != null)
                {
                    string valorString = linha.Cells["valorTotalMaterial"].Value.ToString();
                    totalGeral += Convert.ToDecimal(valorString, CultureInfo.InvariantCulture);
                }
            }

            foreach (DataGridViewRow linha in dgvComponentes.Rows)
            {
                if (linha.Cells["valorTotalComponente"].Value != null)
                {
                    string valorString = linha.Cells["valorTotalComponente"].Value.ToString();
                    totalGeral += Convert.ToDecimal(valorString, CultureInfo.InvariantCulture);
                }
            }

            foreach (DataGridViewRow linha in dgvProcessos.Rows)
            {
                if (linha.Cells["valorTotalProcesso"].Value != null)
                {
                    string valorString = linha.Cells["valorTotalProcesso"].Value.ToString();
                    totalGeral += Convert.ToDecimal(valorString, CultureInfo.InvariantCulture);
                }
            }

            totalGeral = totalGeral * nmMargem.Value;

            // 3. Atualiza a tela com o símbolo de Real (C2 = Currency 2 casas decimais)
            lblValorFinal.Text = totalGeral.ToString("C2");
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Orçamento incluído com sucesso!");
            this.Close();
        }

        private void CarregarComboClientes()
        {
            List<Cliente> lista = _clienteService.ListarTodos();
        }

        private void EQ0001mnIncluir_Load(object sender, EventArgs e)
        {
            CarregarComboClientes();
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            if (tcOrcamento.SelectedTab == tpMateriais)
            {
                dgvMateriais.Rows.Add("Parafuso Sextavado", "10", "1.50", "15.00");
            }
            else if (tcOrcamento.SelectedTab == tpComponentes)
            {
                dgvComponentes.Rows.Add("Motor 2400W", "1", "150.00", "150.00");
            }
            else if (tcOrcamento.SelectedTab == tpProcessos)
            {
                dgvProcessos.Rows.Add("Montagem", "1", "20.00", "20.00");
            }

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

        private void cbClientes_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void nmMargem_ValueChanged(object sender, EventArgs e)
        {
            CalcularTotalGeral();
        }

    }
}
