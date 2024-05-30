namespace Library
{
    public partial class Form1 : Form
    {
        List<Funcionario> funcionarios;
        List<Leitor> leitores;
        List<Exemplar> exemplares;
        public Form1()
        {
            InitializeComponent();
            funcionarios = new List<Funcionario>();
            leitores = new List<Leitor>();
            exemplares = new List<Exemplar>();
            CargaInicial();
            AtualizarDataGridView();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormCadastroPessoa cli = new FormCadastroPessoa(funcionarios, leitores);
            cli.StartPosition = FormStartPosition.CenterParent;
            cli.ShowDialog();
            AtualizarDataGridView();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormCadastroItem cli = new FormCadastroItem(exemplares);
            cli.StartPosition = FormStartPosition.CenterParent;
            cli.ShowDialog();
            AtualizarDataGridView();
        }


        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void CargaInicial()
        {
            leitores.Add(new Leitor("leitor 1", DateTime.Today, "cpf1", "email1", "tel1", "tipo1"));
            leitores.Add(new Leitor("leitor 2", DateTime.Today, "cpf2", "email2", "tel2", "tipo2"));
            leitores.Add(new Leitor("leitor 3", DateTime.Today, "cpf3", "email3", "tel3", "tipo3"));
            leitores.Add(new Leitor("leitor 4", DateTime.Today, "cpf3", "email4", "tel4", "tipo4"));
            leitores.Add(new Leitor("leitor 5", DateTime.Today, "cpf3", "email5", "tel5", "tipo5"));
            funcionarios.Add(new Funcionario("funcionário 1", DateTime.Today, "cpf1", "email1", "tel1", 0, 9999.99M, 8, "fun1"));
            funcionarios.Add(new Funcionario("funcionário 2", DateTime.Today, "cpf2", "email2", "tel2", 1, 3333.33M, 8, "fun1"));
            funcionarios.Add(new Funcionario("funcionário 3", DateTime.Today, "cpf3", "email3", "tel3", 3, 1024.00M, 6, "fun1"));
            funcionarios.Add(new Funcionario("funcionário 4", DateTime.Today, "cpf3", "email4", "tel4", 3, 1024.00M, 6, "fun1"));
            funcionarios.Add(new Funcionario("funcionário 5", DateTime.Today, "cpf3", "email5", "tel5", 2, 2222.22M, 8, "fun1"));
            exemplares.Add(new Livro("livro 1", "subtitulo1", "escritor1", "editora1", 2021, "genero1", 1, 100, "tipoCapa1", "isbn1"));
            exemplares.Add(new Livro("livro 2", "subtitulo2", "escritor2", "editora2", 2021, "genero2", 2, 112, "tipoCapa2", "isbn2"));
            exemplares.Add(new Livro("livro 3", "subtitulo3", "escritor3", "editora3", 2021, "genero3", 3, 132, "tipoCapa3", "isbn3"));
            exemplares.Add(new Livro("livro 4", "subtitulo4", "escritor4", "editora4", 2021, "genero4", 4, 234, "tipoCapa4", "isbn4"));
            exemplares.Add(new Livro("livro 5", "subtitulo5", "escritor5", "editora5", 2021, "genero5", 5, 432, "tipoCapa5", "isbn5"));
            exemplares.Add(new Ebook("ebook 1", "subtitulo1", "escritor1", "editora1", 2021, "genero1", 1, 123, "tipoCapa1", "isbn1", "formato1", 1, "url1"));
            exemplares.Add(new Ebook("ebook 2", "subtitulo2", "escritor2", "editora2", 2021, "genero2", 2, 321, "tipoCapa2", "isbn2", "formato2", 1, "url2"));
            exemplares.Add(new Ebook("ebook 3", "subtitulo3", "escritor3", "editora3", 2021, "genero3", 3, 987, "tipoCapa3", "isbn3", "formato3", 1, "url3"));
            exemplares.Add(new Ebook("ebook 4", "subtitulo4", "escritor4", "editora4", 2021, "genero4", 4, 31, "tipoCapa4", "isbn4", "formato4", 1, "url4"));
            exemplares.Add(new Ebook("ebook 5", "subtitulo5", "escritor5", "editora5", 2021, "genero5", 5, 909, "tipoCapa5", "isbn5", "formato5", 1, "url5"));
            exemplares.Add(new Revista("revista 1", "subtitulo1", "escritor1", "editora1", 2021, "genero1", 1, 324, 1));
            exemplares.Add(new Revista("revista 2", "subtitulo2", "escritor2", "editora2", 2021, "genero2", 2, 123, 1));
            exemplares.Add(new Revista("revista 3", "subtitulo3", "escritor3", "editora3", 2021, "genero3", 3, 654, 1));
            exemplares.Add(new Revista("revista 4", "subtitulo4", "escritor4", "editora4", 2021, "genero4", 4, 764, 1));
            exemplares.Add(new Revista("revista 5", "subtitulo5", "escritor5", "editora5", 2021, "genero5", 5, 234, 1));
            exemplares.Add(new Hq("hq 1", "subtitulo1", "escritor1", "editora1", 2021, "genero1", 1, 432, "ilustrador1"));
            exemplares.Add(new Hq("hq 2", "subtitulo2", "escritor2", "editora2", 2021, "genero2", 2, 542, "ilustrador2"));
            exemplares.Add(new Hq("hq 3", "subtitulo3", "escritor3", "editora3", 2021, "genero3", 3, 298, "ilustrador3"));
            exemplares.Add(new Hq("hq 4", "subtitulo4", "escritor4", "editora4", 2021, "genero4", 4, 342, "ilustrador4"));
            exemplares.Add(new Hq("hq 5", "subtitulo5", "escritor5", "editora5", 2021, "genero5", 5, 98, "ilustrador5"));
            exemplares.Add(new Generico("genérico 1", "subtitulo1", "escritor1", "editora1", 2021, "genero1", 1, 0));
            exemplares.Add(new Generico("genérico 2", "subtitulo2", "escritor2", "editora2", 2021, "genero2", 2, 1));
            exemplares.Add(new Generico("genérico 3", "subtitulo3", "escritor3", "editora3", 2021, "genero3", 3, 2));
            exemplares.Add(new Generico("genérico 4", "subtitulo4", "escritor4", "editora4", 2021, "genero4", 4, 3));
            exemplares.Add(new Generico("genérico 5", "subtitulo5", "escritor5", "editora5", 2021, "genero5", 5, 4));
        }

        private void AtualizarDataGridView()
        {
            // listar funcionarios no datagridview
            dataGridViewFuncionarios.DataSource = null;
            dataGridViewFuncionarios.DataSource = funcionarios;
            // listar leitores no datagridview
            dataGridViewLeitores.DataSource = null;
            dataGridViewLeitores.DataSource = leitores;
            // listar exemplares no datagridview
            dataGridViewExemplares.DataSource = null;
            dataGridViewExemplares.DataSource = exemplares;
        }

        private void dataGridViewFuncionarios_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            // armazena o objeto selecionado
            var funcionario = dataGridViewFuncionarios.CurrentRow.DataBoundItem as Funcionario;
            // como teste, mostra o tipo do objeto e o nome do funcionário
            MessageBox.Show($"{funcionario.GetType().Name}, {funcionario.Nome}");
            // continuaremos a implementação aqui...
            // abre a tela de funcionário, utilizando o construtor criado para edição
            var form = new FormCadastroPessoa(funcionarios, funcionario);
            form.StartPosition = FormStartPosition.CenterParent;
            form.ShowDialog();
            // atualiza a tela, ao fechar a tela de edição
            AtualizarDataGridView();
        }

        private void dataGridViewLeitores_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            var leitor = dataGridViewLeitores.CurrentRow.DataBoundItem as Leitor;
            MessageBox.Show($"{leitor.GetType().Name}, {leitor.Nome}");
            var form = new FormCadastroPessoa(leitores, leitor);
            form.StartPosition = FormStartPosition.CenterParent;
            form.ShowDialog();
            // atualiza a tela, ao fechar a tela de edição
            AtualizarDataGridView();
        }
    }
}
