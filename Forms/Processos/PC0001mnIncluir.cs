using GaroliBudget.Models;
using GaroliBudget.Repositories.Interfaces;
using GaroliBudget.Services;

namespace GaroliBudget
{
    public partial class PC0001mnIncluir : Form
    {
        private readonly IProcessoService _processoService;
        private Processo _processoExistente;

        public PC0001mnIncluir(IProcessoService processoService)
        {
            InitializeComponent();
            _processoService = processoService;
            this.Text = "Novo processo";
        }

        public PC0001mnIncluir(IProcessoService processoService, Processo processoParaEditar) : this(processoService)
        {
            _processoExistente = processoParaEditar;
            this.Text = "Editar processo";
        }

        private void PreencherCampos()
        {
            if (_processoExistente == null)
                return;

            tbDescricao.Text = _processoExistente.Descricao;
            nmCustoHora.Value = _processoExistente.CustoHora;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PC0001mnIncluir_Load(object sender, EventArgs e)
        {
            PreencherCampos();
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            var obj = _processoExistente ?? new Processo();

            obj.Descricao = tbDescricao.Text;
            obj.CustoHora = nmCustoHora.Value;

            try
            {
                if (_processoExistente == null)
                {
                    _processoService.CriarProcesso(obj);
                    MessageBox.Show("Processo cadastrado com sucesso!");
                }
                else
                {
                    _processoService.AtualizarProcesso(obj);
                    MessageBox.Show("Processo atualizado com sucesso!");
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
