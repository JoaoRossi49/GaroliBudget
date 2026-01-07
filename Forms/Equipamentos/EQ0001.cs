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

        private void tbNomeCliente_TextChanged(object sender, EventArgs e)
        {

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

            //dgvClientes.DataSource = _clienteService.ListarWhere(sqlWhere);
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            EQ0001mnIncluir form = new EQ0001mnIncluir(_equipamentoService);
            form.ShowDialog();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            //if (dgvClientes.SelectedRows.Count == 1)
            //{
            //    var clienteSelecionado = (Cliente)dgvClientes.SelectedRows[0].DataBoundItem;

            //    Cliente cliente = _clienteService.ObterPorId(clienteSelecionado.IdCliente);


            //    using (var form = new CL0001mnIncluir(_clienteService, cliente))
            //    {
            //        var resultado = form.ShowDialog();

            //        if (resultado == DialogResult.OK)
            //        {
            //            pesquisar();
            //        }
            //    }
            //}
            //else if (dgvClientes.SelectedRows.Count > 1)
            //{
            //    MessageBox.Show("Selecione apenas um registro por vez.", "A T E N Ç Ã O", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //}
            //else
            //{
            //    MessageBox.Show("Selecione um cliente na lista para editar.", "A T E N Ç Ã O", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //}
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (dgvClientes.SelectedRows.Count <= 0)
            { return; }

            foreach (DataRow row in dgvClientes.SelectedRows)
            {
                //_clienteService.InativarCliente(Convert.ToInt32(row["IdCliente"]));
            }
        }

        private void dgvClientes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var clienteSelecionado = (Cliente)dgvClientes.Rows[e.RowIndex].DataBoundItem;
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
