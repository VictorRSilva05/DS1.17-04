namespace Library
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormCadastroPessoa cli = new FormCadastroPessoa();
            cli.StartPosition = FormStartPosition.CenterParent;
            cli.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormCadastroItem cli = new FormCadastroItem();
            cli.StartPosition = FormStartPosition.CenterParent;
            cli.ShowDialog();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
