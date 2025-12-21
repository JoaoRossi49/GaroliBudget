using GaroliBudget.Models;
using GaroliBudget.Repositories.Interfaces;
using GaroliBudget.Services;

namespace GaroliBudget
{
    public partial class CL0001mnIncluir : Form
    {
        private readonly IClienteService _clienteService;
        private Cliente _clienteExistente;

        public CL0001mnIncluir(IClienteService clienteService)
        {
            InitializeComponent();
            _clienteService = clienteService;
            this.Text = "Novo Cliente";
        }

        public CL0001mnIncluir(IClienteService clienteService, Cliente clienteParaEditar) : this(clienteService)
        {
            _clienteExistente = clienteParaEditar;
            this.Text = "Editar Cliente";
            PreencherCampos();
        }

        private void PreencherCampos()
        {
            tbRazaoSocial.Text = _clienteExistente.RazaoSocial;
            tbNomeFantasia.Text = _clienteExistente.NomeFantasia;
            mtbCnpj.Text = _clienteExistente.Cnpj;
            tbEmail.Text = _clienteExistente.Email;
            mtbTelefone.Text = _clienteExistente.Telefone;
        }

        private void CL0001mnIncluir_Load(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            var clienteParaSalvar = _clienteExistente ?? new Cliente();

            clienteParaSalvar.RazaoSocial = tbRazaoSocial.Text;
            clienteParaSalvar.NomeFantasia = tbNomeFantasia.Text;
            clienteParaSalvar.Cnpj = mtbCnpj.Text;
            clienteParaSalvar.Telefone = mtbTelefone.Text;
            clienteParaSalvar.Email = tbEmail.Text;

            try
            {
                if (_clienteExistente == null)
                {
                    _clienteService.CriarCliente(clienteParaSalvar);
                    MessageBox.Show("Cliente cadastrado com sucesso!");
                }
                else
                {
                    _clienteService.AtualizarCliente(clienteParaSalvar);
                    MessageBox.Show("Cliente atualizado com sucesso!");
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
