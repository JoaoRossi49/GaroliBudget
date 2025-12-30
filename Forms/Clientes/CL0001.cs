using System.Data;
using GaroliBudget.Models;
using GaroliBudget.Repositories;
using GaroliBudget.Repositories.Interfaces;
using GaroliBudget.Services;

namespace GaroliBudget
{
    public partial class CL0001 : Form
    {
        private readonly ClienteService _clienteService;

        public CL0001()
        {
            InitializeComponent();
            IClienteRepository repo = new ClienteRepository();
            _clienteService = new ClienteService(repo);
            pesquisar();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            pesquisar();
        }

        private void pesquisar()
        {
            dgvClientes.AutoGenerateColumns = false;
            string sqlWhere = "WHERE ATIVO = 1\n";

            string nFantasia = tbNomeCliente.Text;
            string rSocial = tbRazaoSocial.Text;

            sqlWhere += nFantasia.Length > 0 ? $@"AND NOME_FANTASIA LIKE '%{nFantasia}%' " : "";
            sqlWhere += rSocial.Length > 0 ? $@"AND RAZAO_SOCIAL LIKE '%{rSocial}%' " : "";

            dgvClientes.DataSource = _clienteService.ListarWhere(sqlWhere);
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            CL0001mnIncluir form = new CL0001mnIncluir(_clienteService);
            form.ShowDialog();
            pesquisar();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvClientes.SelectedRows.Count == 1)
            {
                var clienteSelecionado = (Cliente)dgvClientes.SelectedRows[0].DataBoundItem;

                Cliente cliente = _clienteService.ObterPorId(clienteSelecionado.IdCliente);


                using (var form = new CL0001mnIncluir(_clienteService, cliente))
                {
                    var resultado = form.ShowDialog();

                    if (resultado == DialogResult.OK)
                    {
                        pesquisar();
                    }
                }
            }
            else if (dgvClientes.SelectedRows.Count > 1)
            {
                MessageBox.Show("Selecione apenas um registro por vez.", "A T E N Ç Ã O", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show("Selecione um cliente na lista para editar.", "A T E N Ç Ã O", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (dgvClientes.SelectedRows.Count <= 0)
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

            foreach (DataGridViewRow row in dgvClientes.SelectedRows)
            {
                int idCliente = Convert.ToInt32(row.Cells["IdCliente"].Value);
                _clienteService.InativarCliente(idCliente);
            }

            MessageBox.Show("Registro(s) excluído(s) com sucesso", "A T E N Ç Ã O", MessageBoxButtons.OK, MessageBoxIcon.Information);

            pesquisar();
        }


        private void dgvClientes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var clienteSelecionado = (Cliente)dgvClientes.Rows[e.RowIndex].DataBoundItem;
                Cliente cliente = _clienteService.ObterPorId(clienteSelecionado.IdCliente);

                using (var form = new CL0001mnIncluir(_clienteService, cliente))
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
