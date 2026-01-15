using GaroliBudget.Infrastructure;
using GaroliBudget.Models;
using GaroliBudget.Repositories;
using GaroliBudget.Repositories.Interfaces;
using GaroliBudget.Services;
using Microsoft.VisualBasic;
using System.Data;
using System.Globalization;
using System.Reflection;
using System.Windows.Forms;

namespace GaroliBudget
{
    public partial class EQ0001mnIncluir : Form
    {
        private readonly IEquipamentoService _equipamentoService;


        private MaterialService _materialService;
        private ComponenteService _componenteService;
        private ProcessoService _processoService;

        private Equipamento _equipamento = new Equipamento();

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
            _equipamento.Materiais = _equipamentoService.ListarMateriais(_equipamento.IdEquipamento);
            _equipamento.Processos = _equipamentoService.ListarProcessos(_equipamento.IdEquipamento);
            _equipamento.Componentes = _equipamentoService.ListarComponentes(_equipamento.IdEquipamento);

            this.Text = "Editar Equipamento";
            PreencherCampos();
            CarregarModulos();
        }

        public void CarregarServices()
        {
            IMaterialRepository repoMaterial = new MaterialRepository();
            _materialService = new MaterialService(repoMaterial);

            IComponenteRepository repoComponente = new ComponenteRepository();
            _componenteService = new ComponenteService(repoComponente);

            IProcessoRepository repoProcesso = new ProcessoRepository();
            _processoService = new ProcessoService(repoProcesso);
        }
        private void EQ0001mnIncluir_Load(object sender, EventArgs e)
        {
            CarregarDataGrid();
            CarregarComboMateriais();
            CarregarComboComponentes();
            CarregarComboProcessos();
            CalcularTotalGeral();
        }

        private void CarregarDataGrid()
        {
            int idModulo = GetModuloSelecionado();

            //dgvMateriais.DataSource = null;
            //dgvMateriais.Columns.Clear();
            dgvMateriais.AutoGenerateColumns = false;
            dgvMateriais.DataSource = _equipamentoService.ListarMateriais(_equipamento.IdEquipamento, idModulo); ;

            //dgvComponentes.DataSource = null;
            //dgvMateriais.Columns.Clear();
            dgvComponentes.AutoGenerateColumns = false;
            dgvComponentes.DataSource = _equipamentoService.ListarComponentes(_equipamento.IdEquipamento, idModulo);

            //dgvProcessos.DataSource = null;
            //dgvProcessos.Columns.Clear();
            dgvProcessos.AutoGenerateColumns = false;
            dgvProcessos.DataSource = _equipamentoService.ListarProcessos(_equipamento.IdEquipamento, idModulo);
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
            tbDescricaoEquipamento.Text = _equipamento.Descricao;
            tbCodigoEquipamento.Text = _equipamento.Codigo;
            tbObservacaoEquipamento.Text = _equipamento.Observacao;
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
            AtualizaObjeto();

            //Salva itens do equipamento
            _equipamentoService.Salvar(_equipamento);

            this.Close();
        }

        private void AtualizaObjeto()
        {
            if (!ValidaFormularioPai())
            { return; }

            _equipamento.Descricao = tbDescricaoEquipamento.Text;
            _equipamento.Codigo = tbCodigoEquipamento.Text;
            _equipamento.Observacao = tbObservacaoEquipamento.Text;
        }

        private bool ValidaFormularioPai()
        {
            if (tbDescricaoEquipamento.Text.Length == 0)
            {
                MessageBox.Show("Informe uma DESCRICAO válida para o equipamento", "A T E N Ç Ã O");
                tbDescricaoEquipamento.Focus();
                return false;
            }

            if (tbCodigoEquipamento.Text.Length == 0)
            {
                MessageBox.Show("Informe um CÓDIGO válido para o equipamento", "A T E N Ç Ã O");
                tbCodigoEquipamento.Focus();
                return false;
            }

            return true;
        }

        #region Controles Data grid view
        private void btnIncluir_Click(object sender, EventArgs e)
        {
            if (tcItens.SelectedTab == tpMateriais)
            {
                IncluirItem<Material>(
                    cbMateriais,
                    tbMateriaisQuantidade,
                    dgvMateriais,
                    _equipamento.Materiais
                );
            }
            else if (tcItens.SelectedTab == tpComponentes)
            {
                IncluirItem<Componente>(
                    cbComponentes,
                    tbComponentesQuantidade,
                    dgvComponentes,
                    _equipamento.Componentes
                );
            }
            else if (tcItens.SelectedTab == tpProcessos)
            {
                IncluirItem<Processo>(
                    cbProcessos,
                    tbProcessosQuantidade,
                    dgvProcessos,
                    _equipamento.Processos
                );
            }

            CalcularTotalGeral();
        }

        private void IncluirItem<T>(
                ComboBox combo,
                TextBox quantidade,
                DataGridView grid,
                List<T> lista
            ) where T : class, new()
        {
            var node = treeViewModulos.SelectedNode;

            if (!ValidarInclusao(combo, quantidade, node))
                return;

            int idModulo = GetModuloSelecionado();
            int qtd = Convert.ToInt32(quantidade.Text);

            var original = combo.SelectedItem as dynamic;

            var item = new T();

            // Copia as propriedades relevantes manualmente
            foreach (var prop in original.GetType().GetProperties())
            {
                if (prop.CanRead && prop.CanWrite && prop.Name != "Modulo")
                {
                    prop.SetValue(item, prop.GetValue(original));
                }
            }

            ((dynamic)item).Quantidade = qtd;
            ((dynamic)item).Modulo = new Modulo { Id = idModulo };

            lista.Add(item);

            grid.DataSource = null;
            grid.DataSource = lista
                .Where(m => ((dynamic)m).Modulo != null && ((dynamic)m).Modulo.Id == idModulo)
                .ToList();
        }

        private bool ValidarInclusao(ComboBox combo, TextBox quantidade, TreeNode node)
        {
            if (combo.SelectedIndex == -1)
            {
                MessageBox.Show("Selecione um item a ser adicionado", "A T E N Ç Ã O");
                return false;
            }

            if (quantidade.Text.Length == 0)
            {
                MessageBox.Show("Informe a quantidade a ser adicionada", "A T E N Ç Ã O");
                return false;
            }

            if (node == null)
            {
                MessageBox.Show("Selecione ou crie um novo módulo", "A T E N Ç Ã O");
                return false;
            }

            int idModulo = GetModuloSelecionado();
            var selecionado = combo.SelectedItem;

            if (selecionado is Componente componente)
            {
                bool jaExiste = _equipamento.Componentes.Any(c =>
                    c.IdComponente == componente.IdComponente &&
                    c.Modulo != null &&
                    c.Modulo.Id == idModulo
                );

                if (jaExiste)
                {
                    MessageBox.Show(
                        "Este componente já foi adicionado para este módulo.",
                        "Aviso",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );
                    return false;
                }
            }
            else if (selecionado is Material material)
            {
                bool jaExiste = _equipamento.Materiais.Any(m =>
                    m.IdMaterial == material.IdMaterial &&
                    m.Modulo != null &&
                    m.Modulo.Id == idModulo
                );

                if (jaExiste)
                {
                    MessageBox.Show(
                        "Este material já foi adicionado para este módulo.",
                        "Aviso",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );
                    return false;
                }
            }
            else if (selecionado is Processo processo)
            {
                bool jaExiste = _equipamento.Processos.Any(m =>
                    m.IdProcesso == processo.IdProcesso &&
                    m.Modulo != null &&
                    m.Modulo.Id == idModulo
                );

                if (jaExiste)
                {
                    MessageBox.Show(
                        "Essa mão de obra já foi adicionado para este módulo.",
                        "Aviso",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );
                    return false;
                }
            }


            return true;
        }
       

        private void btnExcluir_Click(object sender, EventArgs e)
        {

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

            if (_equipamento.IdEquipamento == 0)
            {
                if (!PreCadastroEquipamento())
                    return;
            }

            var modulo = new Modulo
            {
                IdEquipamento = _equipamento.IdEquipamento,
                Nome = nome
            };

            //Cadastra módulo no banco
            CadastrarModulo(modulo, _equipamento);

            //Adicionar no banco e retornar ID
            AdicionarModuloTreeView(modulo);

        }

        private int GetModuloSelecionado()
        {
            var node = treeViewModulos.SelectedNode;

            if (node == null || node.Tag == null)
                return 0;

            if (!int.TryParse(node.Tag.ToString(), out int idModulo))
                return 0;

            return idModulo;
        }

        private void btnExcluirModulo_Click(object sender, EventArgs e)
        {
            int idModulo = GetModuloSelecionado();

            if (idModulo == 0)
                return;

            var result = MessageBox.Show(
                "Deseja realmente exluir este módulo?",
                "A T E N Ç Ã O",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.No)
                return;

            excluirItensModulo(_equipamento.Materiais, _equipamento.Componentes, _equipamento.Processos, idModulo);

            var repo = new EquipamentoModuloRepository();
            repo.RemoverPorId(idModulo);

            treeViewModulos.Nodes.Remove(treeViewModulos.SelectedNode);
            MessageBox.Show("Módulo excluído com sucesso!");
        }

        private void excluirItensModulo(List<Material> listaMaterial, List<Componente> listaComponente, List<Processo> listaProcesso, int idModulo)
        {
            var materiaisParaRemover = listaMaterial.Where(i => i.Modulo != null && i.Modulo.Id == idModulo).ToList();

            foreach (var item in materiaisParaRemover)
                listaMaterial.Remove(item);

            var componentesParaRemover = listaComponente.Where(i => i.Modulo != null && i.Modulo.Id == idModulo).ToList();

            foreach (var item in componentesParaRemover)
                listaComponente.Remove(item);

            var processosParaRemover = listaProcesso.Where(i => i.Modulo != null && i.Modulo.Id == idModulo).ToList();

            foreach (var item in processosParaRemover)
                listaProcesso.Remove(item);
        }

        private void CadastrarModulo(Modulo modulo, Equipamento equipamento)
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

        private bool PreCadastroEquipamento()
        {
            if (!ValidarEquipamento())
                return false;

            _equipamento.Codigo = tbCodigoEquipamento.Text;
            _equipamento.Descricao = tbDescricaoEquipamento.Text;
            _equipamento.Observacao = tbObservacaoEquipamento.Text;

            _equipamento.IdEquipamento = _equipamentoService.CriarEquipamento(_equipamento);

            tbCodigoEquipamento.ReadOnly = true;
            tbObservacaoEquipamento.ReadOnly = true;
            tbDescricaoEquipamento.ReadOnly = true;

            return (_equipamento.IdEquipamento > 0);
        }

        private bool ValidarEquipamento()
        {
            if (tbCodigoEquipamento.Text.Length == 0)
            {
                MessageBox.Show("Informe um código para o equipamento", "A T E N Ç Ã O");
                return false;
            }

            if (tbDescricaoEquipamento.Text.Length == 0)
            {
                MessageBox.Show("Informe uma descrição para o equipamento", "A T E N Ç Ã O");
                return false;
            }

            return true;
        }

        private void CarregarModulos()
        {
            EquipamentoModuloRepository _moduloRepository = new EquipamentoModuloRepository();

            List<Modulo> modulos = _moduloRepository.ObterPorEquipamentoId(_equipamento.IdEquipamento);

            foreach (Modulo modulo in modulos)
            {
                AdicionarModuloTreeView(modulo);
            }

            var firstNode = treeViewModulos.Nodes[0];
            treeViewModulos.SelectedNode = firstNode;
            firstNode.EnsureVisible();
            treeViewModulos.Focus();
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

            dgvMateriais.AutoGenerateColumns = false;
            dgvProcessos.AutoGenerateColumns = false;
            dgvComponentes.AutoGenerateColumns = false;

            dgvMateriais.DataSource = null;
            dgvProcessos.DataSource = null;
            dgvComponentes.DataSource = null;
            dgvMateriais.DataSource = _equipamento.Materiais.Where(m => m.Modulo != null && m.Modulo.Id == idModulo).ToList();
            dgvProcessos.DataSource = _equipamento.Processos.Where(m => m.Modulo != null && m.Modulo.Id == idModulo).ToList();
            dgvComponentes.DataSource = _equipamento.Componentes.Where(m => m.Modulo != null && m.Modulo.Id == idModulo).ToList();
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
