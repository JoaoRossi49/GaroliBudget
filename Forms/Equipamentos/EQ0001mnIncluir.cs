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

        private MaterialService _materialService;
        private ComponenteService _componenteService;
        private ProcessoService _processoService;

        private Equipamento _equipamento = new Equipamento(); //Sempre vai ser um equipamento em branco
        private List<Modulo> _modulos = new List<Modulo>();

        public EQ0001mnIncluir(IEquipamentoService equipamentoService)
        {
            InitializeComponent();
            CarregarServices();
            _equipamentoService = equipamentoService;
            _equipamento.Materiais = new List<Material>();
            _equipamento.Processos = new List<Processo>();
            _equipamento.Componentes = new List<Componente>();

            this.Text = "Novo Equipamento";
        }

        public EQ0001mnIncluir(IEquipamentoService equipamentoService, Equipamento equipamentoParaEditar) : this(equipamentoService)
        {
            CarregarServices();
            _equipamento = equipamentoParaEditar;
            this.Text = "Editar Equipamento";
            PreencherCampos();
        }

        public void CarregarServices()
        {
            IMaterialRepository repoMaterial = new MaterialRepository();
            _materialService = new MaterialService(repoMaterial);

            IComponenteRepository repoComponente = new ComponenteRepository();
            _componenteService= new ComponenteService(repoComponente);

            IProcessoRepository repoProcesso = new ProcessoRepository();
            _processoService = new ProcessoService(repoProcesso);
        }
        private void EQ0001mnIncluir_Load(object sender, EventArgs e)
        {
            CarregarComboMateriais();
            CarregarComboComponentes();
            CarregarComboProcessos();
        }

        private void CarregarComboMateriais()
        {
            List<Material> lista = _materialService.ListarTodos();
            cbMateriais.DataSource = lista;

            cbMateriais.DataSource = lista;
            cbMateriais.DisplayMember = "Descricao";
            cbMateriais.ValueMember = "IdMaterial";
            cbMateriais.SelectedIndex = -1;
        }

        private void CarregarComboComponentes()
        {
            List<Componente> lista = _componenteService.ListarTodos();
            cbComponentes.DataSource = lista;

            cbComponentes.DataSource = lista;
            cbComponentes.DisplayMember = "Descricao";
            cbComponentes.ValueMember = "IdComponente";
            cbComponentes.SelectedIndex = -1;
        }

        private void CarregarComboProcessos()
        {
            List<Processo> lista = _processoService.ListarTodos();
            cbProcessos.DataSource = lista;

            cbProcessos.DataSource = lista;
            cbProcessos.DisplayMember = "Descricao";
            cbProcessos.ValueMember = "IdProcesso";
            cbProcessos.SelectedIndex = -1;
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

            //Acho que não pode cadastrar aqui, pois ele já tem que existir quando adiciono
            //no objeto de material, orcamento ou processo
            CadastrarModulos(_modulos, _equipamento);

            //Organiza equipamentos, componentes e processos e atributi os módulos


            //Salva itens do equipamento
            _equipamentoService.Salvar(_equipamento);

            this.Close();
        }

        #region Controles Data grid view
        private void btnIncluir_Click(object sender, EventArgs e)
        {
            if (tcItens.SelectedTab == tpMateriais)
            {
                Material materialSelecionado = cbMateriais.SelectedItem as Material;

                materialSelecionado.Quantidade = Convert.ToInt32(tbMateriaisQuantidade.Text);
                materialSelecionado.Modulo = new Modulo { Id = Convert.ToInt32(treeViewModulos.SelectedNode.Tag) };

                //Adiciona o material, já com o módulo na receita do equipamento
                _equipamento.Materiais.Add(materialSelecionado);

                //Adiciona no data grid view
                dgvMateriais.Rows.Add(materialSelecionado);
            }
            else if (tcItens.SelectedTab == tpComponentes)
            {
                dgvComponentes.Rows.Add("Motor 2400W", "1", "150.00", "150.00");
            }
            else if (tcItens.SelectedTab == tpProcessos)
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

            //Adicionar no banco e retornar ID

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
