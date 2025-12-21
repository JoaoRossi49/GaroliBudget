namespace GaroliBudget
{
    public partial class MT0001 : Form
    {
        public MT0001()
        {
            InitializeComponent();
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            MT0001mnIncluir form = new MT0001mnIncluir();
            form.ShowDialog();
        }
    }
}
