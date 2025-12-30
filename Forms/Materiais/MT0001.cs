using GaroliBudget.Models;
using GaroliBudget.Repositories;
using GaroliBudget.Repositories.Interfaces;
using GaroliBudget.Services;

namespace GaroliBudget
{
    public partial class MT0001 : Form
    {
        private readonly MaterialService _materialService;

        public MT0001()
        {
            InitializeComponent();
            IMaterialRepository repo = new MaterialRepository();
            _materialService = new MaterialService(repo);
            pesquisar();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            pesquisar();
        }

        private void pesquisar()
        {
            dgvMateriais.AutoGenerateColumns = false;
            string sqlWhere = "WHERE ATIVO = 1\n";

            string descricao = tbDescricao.Text;

            sqlWhere += descricao.Length > 0 ? $@"AND DESCRICAO LIKE '%{descricao}%' " : "";

            dgvMateriais.DataSource = _materialService.ListarWhere(sqlWhere);
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            MT0001mnIncluir form = new MT0001mnIncluir(_materialService);
            form.ShowDialog();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvMateriais.SelectedRows.Count == 1)
            {
                var materialSelecionado = (Material)dgvMateriais.SelectedRows[0].DataBoundItem;

                Material material = _materialService.ObterPorId(materialSelecionado.IdMaterial);


                using (var form = new MT0001mnIncluir(_materialService, material))
                {
                    var resultado = form.ShowDialog();

                    if (resultado == DialogResult.OK)
                    {
                        //pesquisar();
                    }
                }
            }
            else if (dgvMateriais.SelectedRows.Count > 1)
            {
                MessageBox.Show("Selecione apenas um registro por vez.", "A T E N Ç Ã O", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show("Selecione um material na lista para editar.", "A T E N Ç Ã O", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

    }
}
