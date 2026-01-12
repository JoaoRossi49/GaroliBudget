using System.Data;
using GaroliBudget.Models;
using GaroliBudget.Repositories;
using GaroliBudget.Repositories.Interfaces;
using GaroliBudget.Services;

namespace GaroliBudget
{
    public partial class EQ0001 : Form
    {
        private readonly EquipamentoService _equipamentoService;

        public EQ0001()
        {
            InitializeComponent();
            IEquipamentoRepository repo = new EquipamentoRepository();
            _equipamentoService = new EquipamentoService(repo);
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            pesquisar();
        }

        private void pesquisar()
        {
            dgvEquipamentos.AutoGenerateColumns = false;
            string sqlWhere = "WHERE ATIVO = 1\n";

            string descricao = tbDescricao.Text;
            string codigo = tbCodigo.Text;

            sqlWhere += descricao.Length > 0 ? $@"AND DESCRICAO LIKE '%{descricao}%' " : "";
            sqlWhere += codigo.Length > 0 ? $@"AND CODIGO LIKE '%{codigo}%' " : "";

            dgvEquipamentos.DataSource = _equipamentoService.ListarWhere(sqlWhere);
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            EQ0001mnIncluir form = new EQ0001mnIncluir(_equipamentoService);
            form.ShowDialog();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvEquipamentos.SelectedRows.Count == 1)
            {
                var equipamentoSelecionado = (Equipamento)dgvEquipamentos.SelectedRows[0].DataBoundItem;

                Equipamento equipamento = _equipamentoService.ObterPorId(equipamentoSelecionado.IdEquipamento);


                using (var form = new EQ0001mnIncluir(_equipamentoService, equipamento))
                {
                    var resultado = form.ShowDialog();

                    if (resultado == DialogResult.OK)
                    {
                        pesquisar();
                    }
                }
            }
            else if (dgvEquipamentos.SelectedRows.Count > 1)
            {
                MessageBox.Show("Selecione apenas um registro por vez.", "A T E N Ç Ã O", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show("Selecione um equipamento na lista para editar.", "A T E N Ç Ã O", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (dgvEquipamentos.SelectedRows.Count <= 0)
            { return; }

            foreach (DataRow row in dgvEquipamentos.SelectedRows)
            {
                //_clienteService.InativarCliente(Convert.ToInt32(row["IdCliente"]));
            }
        }

        private void dgvClientes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var clienteSelecionado = (Cliente)dgvEquipamentos.Rows[e.RowIndex].DataBoundItem;
                //Cliente cliente = _clienteService.ObterPorId(clienteSelecionado.IdCliente);

                //using (var form = new CL0001mnIncluir(_clienteService, cliente))
                //{
                //    if (form.ShowDialog() == DialogResult.OK)
                //    {
                //        pesquisar();
                //    }
               // }
            }
        }

    }
}
