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
            pesquisar();
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
                        pesquisar();
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

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (dgvMateriais.SelectedRows.Count <= 0)
            {
                MessageBox.Show("Selecione uma linha para exclusão", "A T E N Ç Ã O", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            DialogResult confirmacao = MessageBox.Show("Deseja realmente excluir o(s) registro(s) selecionado(s)?", "C O N F I R M A Ç Ã O",
                                                            MessageBoxButtons.YesNo,
                                                            MessageBoxIcon.Question
                                                        );

            if (confirmacao != DialogResult.Yes)
                return;

            foreach (DataGridViewRow row in dgvMateriais.SelectedRows)
            {
                int idMaterial = Convert.ToInt32(row.Cells["IdMaterial"].Value);
                _materialService.InativarMaterial(idMaterial);
            }

            MessageBox.Show("Registro(s) excluído(s) com sucesso", "A T E N Ç Ã O", MessageBoxButtons.OK, MessageBoxIcon.Information);

            pesquisar();
        }

        private void dgvMateriais_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var materialSelecionado = (Material)dgvMateriais.Rows[e.RowIndex].DataBoundItem;
                Material material = _materialService.ObterPorId(materialSelecionado.IdMaterial);

                using (var form = new MT0001mnIncluir(_materialService, material))
                {
                    if (form.ShowDialog() == DialogResult.OK)
                    {
                        pesquisar();
                    }
                }
            }
        }
    }
}
