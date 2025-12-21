namespace GaroliBudget
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void btnMateriais_Click(object sender, EventArgs e)
        {
            MT0001 form = new MT0001();
            form.ShowDialog();
        }
    }
}
