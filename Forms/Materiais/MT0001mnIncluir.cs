using GaroliBudget.Models;
using GaroliBudget.Repositories.Interfaces;
using GaroliBudget.Services;

namespace GaroliBudget
{
    public partial class MT0001mnIncluir : Form
    {
        private readonly IMaterialService _materialService;
        private Material _materialExistente;

        public MT0001mnIncluir(IMaterialService materialService)
        {
            InitializeComponent();
            _materialService = materialService;
            this.Text = "Novo material";
        }

        public MT0001mnIncluir(IMaterialService materialService, Material materialParaEditar) : this(materialService)
        {
            _materialExistente = materialParaEditar;
            this.Text = "Editar material";
        }

        private void PreencherCampos()
        {
            if(_materialExistente == null)
                return;

            tbCodigo.Text = _materialExistente.Codigo;
            tbDescricao.Text = _materialExistente.Descricao;
            cbUnidadeMedida.SelectedItem = _materialExistente.Unidade;
            nmCustoUnitario.Value = _materialExistente.CustoUnitario;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MT0001mnIncluir_Load(object sender, EventArgs e)
        {
            cbUnidadeMedida.Items.AddRange(new string[]
            {
                "UN",
                "KG",
                "G",
                "MG",
                "L",
                "ML",
                "CX",
                "PC"
            });

            PreencherCampos();
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            var obj = _materialExistente ?? new Material();

            obj.Codigo = tbCodigo.Text;
            obj.Descricao = tbDescricao.Text;
            obj.Unidade = cbUnidadeMedida.SelectedItem?.ToString();
            obj.CustoUnitario = nmCustoUnitario.Value;

            try
            {
                if (_materialExistente == null)
                {
                    _materialService.CriarMaterial(obj);
                    MessageBox.Show("Material cadastrado com sucesso!");
                }
                else
                {
                    _materialService.AtualizarMaterial(obj);
                    MessageBox.Show("Material atualizado com sucesso!");
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
