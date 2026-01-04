using GaroliBudget.Infrastructure;
using GaroliBudget.Models;
using GaroliBudget.Repositories;
using GaroliBudget.Repositories.Interfaces;
using GaroliBudget.Services;
using Microsoft.VisualBasic;
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

        private void btnIncluirModulo_Click(object sender, EventArgs e)
        {
            //if (_equipamentoAtual == null)
            //{
            //    MessageBox.Show("Selecione um equipamento.");
            //    return;
            //}

            string nome = Interaction.InputBox(
                "Informe o nome do módulo:",
                "Novo módulo",
                ""
            ).Trim();

            if (string.IsNullOrEmpty(nome))
            {
                MessageBox.Show("Informe o nome do módulo.");
                return;
            }

            var modulo = new Modulo
            {
                IdEquipamento = 1, //_equipamentoAtual.IdEquipamento,
                Nome = nome
            };

            using var conn = DBPostgres.GetConnection();
            conn.Open();

            using var tran = conn.BeginTransaction();
            try
            {
                var repo = new EquipamentoModuloRepository();
                modulo.Id = repo.Inserir(modulo, conn, tran);

                tran.Commit();

                AdicionarModuloTreeView(modulo);
            }
            catch (Exception ex)
            {
                tran.Rollback();
                MessageBox.Show("Erro ao inserir módulo:\n" + ex.Message);
            }
        }

        private void AdicionarModuloTreeView(Modulo modulo)
        {
            var node = new TreeNode(modulo.Nome)
            {
                Tag = modulo.Id
            };

            treeViewModulos.Nodes.Add(node);
            treeViewModulos.SelectedNode = node;
        }

        private void treeViewModulos_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e.Node == null || e.Node.Tag == null)
            {
                treeViewModulos.Enabled = false;
                LimparGridsModulo();
                return;
            }

            int idModulo = Convert.ToInt32(e.Node.Tag);

            treeViewModulos.Enabled = true;

            //CarregarMateriaisModulo(idModulo);
            //CarregarComponentesModulo(idModulo);
            //CarregarProcessosModulo(idModulo);
        }

        private void LimparGridsModulo()
        {
            dgvMateriais.DataSource = null;
            dgvComponentes.DataSource = null;
            dgvProcessos.DataSource = null;
        }
    }
}
