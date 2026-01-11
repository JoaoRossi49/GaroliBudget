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
            CarregarDataGrid();
            CarregarComboMateriais();
            CarregarComboComponentes();
            CarregarComboProcessos();
        }

        private void CarregarDataGrid()
        {
            dgvMateriais.AutoGenerateColumns = false;
            dgvMateriais.DataSource = _equipamentoService.ListarMateriais(_equipamento.IdEquipamento);

            dgvComponentes.AutoGenerateColumns = false;
            dgvComponentes.DataSource = _equipamentoService.ListarComponentes(_equipamento.IdEquipamento);

            dgvProcessos.AutoGenerateColumns = false;
            dgvProcessos.DataSource = _equipamentoService.ListarProcessos(_equipamento.IdEquipamento);
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
            AtualizaObjeto();

            //Salva itens do equipamento
            _equipamentoService.Salvar(_equipamento);

            this.Close();
        }

        private void AtualizaObjeto()
        {
            if(!ValidaFormularioPai())
                { return; }

            _equipamento.Descricao = tbDescricaoEquipamento.Text;
            _equipamento.Codigo = tbCodigoEquipamento.Text;
            _equipamento.Observacao = tbObservacaoEquipamento.Text;
        }

        private bool ValidaFormularioPai()
        {
            if(tbDescricaoEquipamento.Text.Length == 0)
            {
                MessageBox.Show("Informe uma DESCRICAO válida para o equipamento", "A T E N Ç Ã O");
                tbDescricaoEquipamento.Focus();
                return false;
            }

            if(tbCodigoEquipamento.Text.Length == 0)
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
                if (!ValidarInclusao(cbMateriais, tbMateriaisQuantidade, treeViewModulos.SelectedNode))
                    return;

                Material materialSelecionado = cbMateriais.SelectedItem as Material;

                materialSelecionado.Quantidade = Convert.ToInt32(tbMateriaisQuantidade.Text);
                materialSelecionado.Modulo = new Modulo { Id = Convert.ToInt32(treeViewModulos.SelectedNode.Tag) };

                _equipamento.Materiais.Add(materialSelecionado);

                dgvMateriais.DataSource = null;
                dgvMateriais.DataSource = _equipamento.Materiais;
            }
            else if (tcItens.SelectedTab == tpComponentes)
            {
                if (!ValidarInclusao(cbComponentes, tbComponentesQuantidade, treeViewModulos.SelectedNode))
                    return;

                Componente componenteSelecionado = cbComponentes.SelectedItem as Componente;

                componenteSelecionado.Quantidade = Convert.ToInt32(tbMateriaisQuantidade.Text);
                componenteSelecionado.Modulo = new Modulo { Id = Convert.ToInt32(treeViewModulos.SelectedNode.Tag) };

                _equipamento.Componentes.Add(componenteSelecionado);

                dgvComponentes.DataSource = null;
                dgvComponentes.DataSource = _equipamento.Componentes;
            }
            else if (tcItens.SelectedTab == tpProcessos)
            {
                if (!ValidarInclusao(cbProcessos, tbProcessosQuantidade, treeViewModulos.SelectedNode))
                    return;

                Processo processoSelecionado = cbProcessos.SelectedItem as Processo;

                processoSelecionado.Quantidade = Convert.ToInt32(tbProcessosQuantidade.Text);
                processoSelecionado.Modulo = new Modulo { Id = Convert.ToInt32(treeViewModulos.SelectedNode.Tag) };

                _equipamento.Processos.Add(processoSelecionado);

                dgvProcessos.DataSource = null;
                dgvProcessos.DataSource = _equipamento.Processos;
            }

            CalcularTotalGeral();
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

            if (node == null) {
                MessageBox.Show("Selecione ou crie um novo módulo", "A T E N Ç Ã O");
                return false;
            }

            return true;
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
        #endregion
    }
}
