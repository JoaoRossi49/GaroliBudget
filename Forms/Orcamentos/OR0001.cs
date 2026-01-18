using System.Data;
using GaroliBudget.Models;
using GaroliBudget.Repositories;
using GaroliBudget.Repositories.Interfaces;
using GaroliBudget.Services;

namespace GaroliBudget
{
    public partial class OR0001 : Form
    {
        private readonly OrcamentoService _orcamentoService;

        public OR0001()
        {
            InitializeComponent();
            IOrcamentoRepository repo = new OrcamentoRepository();
            _orcamentoService = new OrcamentoService(repo);
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            pesquisar();
        }

        private void pesquisar()
        {
            dgvOrcamentos.AutoGenerateColumns = false;
            string sqlWhere = "";

            string descricao = tbDescricao.Text;
            string numero = tbNumeroOrcamento.Text;

            sqlWhere += descricao.Length > 0 ? $@"AND DESCRICAO_PROJETO LIKE '%{descricao}%' " : "";
            sqlWhere += numero.Length > 0 ? $@"AND NUMERO LIKE '%{numero}%' " : "";

            dgvOrcamentos.DataSource = _orcamentoService.ListarWhere(sqlWhere);
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            OR0001mnIncluir form = new OR0001mnIncluir(_orcamentoService);
            form.ShowDialog();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvOrcamentos.SelectedRows.Count == 1)
            {
                var orcamentoSelecionado = (Orcamento)dgvOrcamentos.SelectedRows[0].DataBoundItem;

                Orcamento orcamento = _orcamentoService.ObterPorId(orcamentoSelecionado.IdOrcamento);


                using (var form = new OR0001mnIncluir(_orcamentoService, orcamento))
                {
                    var resultado = form.ShowDialog();

                    if (resultado == DialogResult.OK)
                    {
                        pesquisar();
                    }
                }
            }
            else if (dgvOrcamentos.SelectedRows.Count > 1)
            {
                MessageBox.Show("Selecione apenas um registro por vez.", "A T E N Ç Ã O", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show("Selecione um orcamento na lista para editar.", "A T E N Ç Ã O", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (dgvOrcamentos.SelectedRows.Count <= 0)
            { return; }

            foreach (DataRow row in dgvOrcamentos.SelectedRows)
            {
                _orcamentoService.InativarOrcamento(Convert.ToInt32(row["IdOrcamento"]));
            }
        }

        private void dgvOrcamentos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var orcamentoSelecionado = (Orcamento)dgvOrcamentos.Rows[e.RowIndex].DataBoundItem;
                Orcamento orcamento = _orcamentoService.ObterPorId(orcamentoSelecionado.IdOrcamento);

                using (var form = new OR0001mnIncluir(_orcamentoService, orcamento))
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
