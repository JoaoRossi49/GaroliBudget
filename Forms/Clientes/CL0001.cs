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
        }

        private void tbNomeCliente_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            dgvClientes.AutoGenerateColumns = false;
            dgvClientes.DataSource = _clienteService.ListarAtivos();
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            CL0001mnIncluir form = new CL0001mnIncluir(_clienteService);
            form.ShowDialog();
        }
    }
}
