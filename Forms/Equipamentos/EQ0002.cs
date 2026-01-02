using GaroliBudget.Models;
using GaroliBudget.Repositories.Interfaces;
using GaroliBudget.Services;

namespace GaroliBudget
{
    public partial class EQ0002 : Form
    {
        private readonly IMaterialService _materialService;
        private Material _materialExistente;

        public EQ0002(IMaterialService materialService)
        {
            InitializeComponent();
            _materialService = materialService;
            this.Text = "Novo material";
        }

        public EQ0002(IMaterialService materialService, Material materialParaEditar) : this(materialService)
        {
            _materialExistente = materialParaEditar;
            this.Text = "Editar material";
        }

        private void PreencherCampos()
        {
            if(_materialExistente == null)
                return;

            tbDescricao.Text = _materialExistente.Descricao;
            cbUnidadeMedida.SelectedItem = _materialExistente.Unidade;
            nmCustoUnitario.Value = _materialExistente.CustoUnitario;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EQ0002_Load(object sender, EventArgs e)
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
