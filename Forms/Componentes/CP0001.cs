using GaroliBudget.Models;
using GaroliBudget.Repositories;
using GaroliBudget.Repositories.Interfaces;
using GaroliBudget.Services;

namespace GaroliBudget
{
    public partial class CP0001 : Form
    {
        private readonly ComponenteService _componenteService;

        public CP0001()
        {
            InitializeComponent();
            IComponenteRepository repo = new ComponenteRepository();
            _componenteService = new ComponenteService(repo);
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

            dgvMateriais.DataSource = _componenteService.ListarWhere(sqlWhere);
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            CP0001mnIncluir form = new CP0001mnIncluir(_componenteService);
            form.ShowDialog();
            pesquisar();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvMateriais.SelectedRows.Count == 1)
            {
                var componenteSelecionado = (Componente)dgvMateriais.SelectedRows[0].DataBoundItem;

                Componente componente = _componenteService.ObterPorId(componenteSelecionado.IdComponente);


                using (var form = new CP0001mnIncluir(_componenteService, componente))
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
                MessageBox.Show("Selecione um componente na lista para editar.", "A T E N Ç Ã O", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                int idComponente = Convert.ToInt32(row.Cells["IdComponente"].Value);
                _componenteService.InativarComponente(idComponente);
            }

            MessageBox.Show("Registro(s) excluído(s) com sucesso", "A T E N Ç Ã O", MessageBoxButtons.OK, MessageBoxIcon.Information);

            pesquisar();
        }

        private void dgvMateriais_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var componenteSelecionado = (Componente)dgvMateriais.Rows[e.RowIndex].DataBoundItem;
                Componente componente = _componenteService.ObterPorId(componenteSelecionado.IdComponente);

                using (var form = new CP0001mnIncluir(_componenteService, componente))
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
