using GaroliBudget.Infrastructure;
using GaroliBudget.Models;
using GaroliBudget.Repositories;
using GaroliBudget.Repositories.Interfaces;
using GaroliBudget.Services;
using Microsoft.VisualBasic;
using System.Data;
using System.Globalization;
using System.Reflection;

namespace GaroliBudget
{
    public partial class EQ0001mnIncluir : Form
    {
        private readonly IEquipamentoService _equipamentoService;
        private Equipamento _equipamento = new Equipamento(); //Sempre vai ser um equipamento em branco
        private List<Modulo> _modulos = new List<Modulo>();
        private List<Material> _materiais = new List<Material>();
        private List<Processo> _processo = new List<Processo>();
        private List<Componente> _componente = new List<Componente>();

        public EQ0001mnIncluir(IEquipamentoService equipamentoService)
        {
            InitializeComponent();
            _equipamentoService = equipamentoService;
            this.Text = "Novo Equipamento";
        }

        public EQ0001mnIncluir(IEquipamentoService equipamentoService, Equipamento equipamentoParaEditar) : this(equipamentoService)
        {
            _equipamento = equipamentoParaEditar;
            this.Text = "Editar Equipamento";
            PreencherCampos();
        }
        private void EQ0001mnIncluir_Load(object sender, EventArgs e)
        {
            CarregarComboEquipamentos();
        }

        private void CarregarComboEquipamentos()
        {
            List<Equipamento> lista = _equipamentoService.ListarTodos();
        }

        private void PreencherCampos()
        {
            //tbRazaoSocial.Text = _equipamentoExistente.RazaoSocial;
            //tbNomeFantasia.Text = _equipamentoExistente.NomeFantasia;
            //mtbCnpj.Text = _equipamentoExistente.Cnpj;
            //tbEmail.Text = _equipamentoExistente.Email;
            //mtbTelefone.Text = _equipamentoExistente.Telefone;
        }
        private void nmMargem_ValueChanged(object sender, EventArgs e)
        {
            CalcularTotalGeral();
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
            _equipamento.Descricao = "TESTE";
            _equipamento.Codigo = "002";

            //Salva os módulos criados
            CadastrarModulos(_modulos, _equipamento);

            //Organiza equipamentos, componentes e processos e atributi os módulos


            //Salva itens do equipamento
            _equipamentoService.Salvar(_equipamento);

            this.Close();
        }

        #region Controles Data grid view
        private void btnIncluir_Click(object sender, EventArgs e)
        {
            if (tcOrcamento.SelectedTab == tpMateriais)
            {
                //Pra cada um desses vai ter uma tela de controle, pra editar o preço e quantidade

                //No DGV vou alimentar com a lista de objetos relacionada _materiais no caso

                //Além de pegar os atributos da tela de manutenção, vou pegar o Módulo selecionado
                //no tree view

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

        #endregion

        #region Controles TreeView Módulos
        private void btnIncluirModulo_Click(object sender, EventArgs e)
        {
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
                IdEquipamento = 0,
                Nome = nome
            };

            AdicionarModuloTreeView(modulo);

        }

        private void CadastrarModulos(List<Modulo> modulos, Equipamento equipamento)
        {
            foreach (Modulo modulo in modulos)
            {
                using var conn = DBPostgres.GetConnection();
                conn.Open();

                using var tran = conn.BeginTransaction();
                try
                {
                    var repo = new EquipamentoModuloRepository();
                    modulo.IdEquipamento = equipamento.IdEquipamento;
                    modulo.Id = repo.Inserir(modulo, conn, tran);
                    tran.Commit();

                    //AdicionarModuloTreeView(modulo);
                }
                catch (Exception ex)
                {
                    tran.Rollback();
                    MessageBox.Show("Erro ao inserir módulo:\n" + ex.Message);
                }
            }
        }

        private void AdicionarModuloTreeView(Modulo modulo)
        {
            _modulos.Add(modulo);

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
        #endregion
    }
}
