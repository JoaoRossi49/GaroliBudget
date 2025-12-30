using GaroliBudget.Models;
using GaroliBudget.Repositories.Interfaces;
using GaroliBudget.Services;

namespace GaroliBudget
{
    public partial class CP0001mnIncluir : Form
    {
        private readonly IComponenteService _componenteService;
        private Componente _componenteExistente;

        public CP0001mnIncluir(IComponenteService componenteService)
        {
            InitializeComponent();
            _componenteService = componenteService;
            this.Text = "Novo componente";
        }

        public CP0001mnIncluir(IComponenteService componenteService, Componente componenteParaEditar) : this(componenteService)
        {
            _componenteExistente = componenteParaEditar;
            this.Text = "Editar componente";
        }

        private void PreencherCampos()
        {
            if(_componenteExistente == null)
                return;

            tbCodigo.Text = _componenteExistente.Codigo;
            tbDescricao.Text = _componenteExistente.Descricao;
            nmCustoUnitario.Value = _componenteExistente.CustoUnitario;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CP0001mnIncluir_Load(object sender, EventArgs e)
        {
            PreencherCampos();
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            var obj = _componenteExistente ?? new Componente();

            obj.Codigo = tbCodigo.Text;
            obj.Descricao = tbDescricao.Text;
            obj.CustoUnitario = nmCustoUnitario.Value;

            try
            {
                if (_componenteExistente == null)
                {
                    _componenteService.CriarComponente(obj);
                    MessageBox.Show("Componente cadastrado com sucesso!");
                }
                else
                {
                    _componenteService.AtualizarComponente(obj);
                    MessageBox.Show("Componente atualizado com sucesso!");
                }

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao salvar: {ex.Message}");
            }
        }
    }
}
