namespace GaroliBudget
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }
        private void AbrirFormNoPainel(Form formFilho)
        {
            // 1. Se já houver algo no painel, remove para liberar memória
            if (this.pnlConteudo.Controls.Count > 0)
                this.pnlConteudo.Controls.RemoveAt(0);

            // 2. Configura o Form para se comportar como um controle "embutido"
            formFilho.TopLevel = false;          // Permite colocar dentro de outro form
            formFilho.FormBorderStyle = FormBorderStyle.None; // Tira a barra de título
            formFilho.Dock = DockStyle.Fill;     // Faz ele preencher o painel inteiro

            // 3. Adiciona ao painel e exibe
            this.pnlConteudo.Controls.Add(formFilho);
            this.pnlConteudo.Tag = formFilho;
            formFilho.Show();
        }

        private void btnMateriais_Click(object sender, EventArgs e)
        {
            AbrirFormNoPainel(new MT0001());
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            AbrirFormNoPainel(new CL0001());
        }
    }
}
