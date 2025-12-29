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
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            MT0001mnIncluir form = new MT0001mnIncluir(_materialService);
            form.ShowDialog();
        }

    }
}
