using GaroliBudget.Models;
using GaroliBudget.Repositories;
using GaroliBudget.Repositories.Interfaces;
using GaroliBudget.Services;

namespace GaroliBudget
{
    public partial class PC0001 : Form
    {
        private readonly ProcessoService _processoService;

        public PC0001()
        {
            InitializeComponent();
            IProcessoRepository repo = new ProcessoRepository();
            _processoService = new ProcessoService(repo);
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

            dgvMateriais.DataSource = _processoService.ListarWhere(sqlWhere);
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            PC0001mnIncluir form = new PC0001mnIncluir(_processoService);
            form.ShowDialog();
            pesquisar();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvMateriais.SelectedRows.Count == 1)
            {
                var processoSelecionado = (Processo)dgvMateriais.SelectedRows[0].DataBoundItem;

                Processo processo = _processoService.ObterPorId(processoSelecionado.IdProcesso);


                using (var form = new PC0001mnIncluir(_processoService, processo))
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
                MessageBox.Show("Selecione um processo na lista para editar.", "A T E N Ç Ã O", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                int idProcesso = Convert.ToInt32(row.Cells["IdProcesso"].Value);
                _processoService.InativarProcesso(idProcesso);
            }

            MessageBox.Show("Registro(s) excluído(s) com sucesso", "A T E N Ç Ã O", MessageBoxButtons.OK, MessageBoxIcon.Information);

            pesquisar();
        }

        private void dgvMateriais_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var processoSelecionado = (Processo)dgvMateriais.Rows[e.RowIndex].DataBoundItem;
                Processo processo = _processoService.ObterPorId(processoSelecionado.IdProcesso);

                using (var form = new PC0001mnIncluir(_processoService, processo))
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
