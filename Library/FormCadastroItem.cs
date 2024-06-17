
namespace Library
{
    public partial class FormCadastroItem : Form
    {
        // variável com escopo de classe
        List<Exemplar> exemplares;
        Exemplar exemplar;
        public FormCadastroItem(List<Exemplar> exemplares)
        {
            InitializeComponent();
            this.exemplares = exemplares;
            panelEbook.Enabled = false;
        }

        // sobrecarga de construtor, novo construtor com lista de parâmetros diferente
        public FormCadastroItem(List<Exemplar> exemplares, Exemplar exemplar)
        {
            InitializeComponent();
            // atribui a lista de exemplares recebida à variável com escopo de classe
            this.exemplares = exemplares;
            this.exemplar = exemplar;
            checkBoxEbook.Enabled = false;
            // carrega os valores do Enum para o combobox/listbox
            comboBoxStatus.DataSource = Enum.GetValues(typeof(EnumExemplarStatus));
            comboBoxStatus.SelectedIndex = 0;
            comboBoxTipo.DataSource = Enum.GetValues(typeof(EnumGenericoTipo));
            comboBoxTipo.SelectedIndex = 0;
            // verifica o tipo do exemplar, e carrega os valores nos campos da tela
            if (exemplar is Livro || exemplar is Ebook)
            {
                // livro e ebook
                textBoxTitulo.Text = exemplar.Titulo;
                textBoxSubTitulo.Text = exemplar.SubTitulo;
                textBoxEscritor.Text = exemplar.Escritor;
                textBoxEditora.Text = exemplar.Editora;
                numericUpDownAnoPublicacao.Value = exemplar.AnoPublicacao;
                comboBoxGenero.Text = exemplar.Genero;
                comboBoxStatus.Text = "" + (EnumExemplarStatus)Enum.Parse(typeof(EnumExemplarStatus), exemplar.Status.ToString());
                numericUpDownPaginasLivro.Value = ((Livro)exemplar).Paginas;
                comboBoxTipoCapa.Text = ((Livro)exemplar).TipoCapa;
                textBoxIsbn.Text = ((Livro)exemplar).Isbn;
                checkBoxEbook.Checked = false;
                if (exemplar is Ebook)
                {
                    checkBoxEbook.Checked = true;
                    comboBoxFormato.Text = ((Ebook)exemplar).Formato;
                    numericUpDownTamanho.Value = ((Ebook)exemplar).Tamanho;
                    textBoxUrl.Text = ((Ebook)exemplar).Url;
                }
            }
            else if (exemplar is Revista revista)
            {
                numericUpDownEdicaoRevista.Value = revista.Edicao;
                numericUpDownPaginasRevista.Value = revista.Paginas;
            }
            else if (exemplar is Hq hq)
            {
                numericUpDownEdicaoHq.Value = hq.Edicao;
                textBoxIlustrador.Text = hq.Ilustrador;
            }
            else if (exemplar is Generico)
            {
                comboBoxTipo.Text = "" + (EnumGenericoTipo)Enum.Parse(typeof(EnumGenericoTipo), ((Generico)exemplar).Tipo.ToString());
            }
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // leitura dos valores dos campos
            string auxTitulo = textBoxTitulo.Text;
            string auxSubTitulo = textBoxSubTitulo.Text;
            string auxEscritor = textBoxEscritor.Text;
            string auxEditora = textBoxEditora.Text;
            int auxAnoPublicacao = Convert.ToInt32(numericUpDownAnoPublicacao.Value);
            string auxGenero = comboBoxGenero.Text;
            int auxStatus = (int)(EnumExemplarStatus)Enum.Parse(typeof(EnumExemplarStatus), comboBoxStatus.Text);
            if (tabControlExemplar.SelectedIndex == 0)
            {
                // livro e ebook
                // leitura dos valores dos campos
                int auxPaginas = Convert.ToInt32(numericUpDownPaginasLivro.Value);
                string auxTipoCapa = comboBoxTipoCapa.Text;
                string auxIsbn = textBoxIsbn.Text;
                if (!checkBoxEbook.Checked)
                {
                    // livro
                    // cria o objeto e já adiciona no List
                    exemplares.Add(new Livro(auxTitulo, auxSubTitulo, auxEscritor, auxEditora, auxAnoPublicacao, auxGenero, auxStatus, auxPaginas, auxTipoCapa, auxIsbn));
                }
                else
                {
                    // ebook
                    // leitura dos valores dos campos
                    string auxFormato = comboBoxFormato.Text;
                    decimal auxTamanho = numericUpDownTamanho.Value;
                    string auxUrl = textBoxUrl.Text;
                    // cria o objeto e já adiciona no List
                    exemplares.Add(new Ebook(auxTitulo, auxSubTitulo, auxEscritor, auxEditora, auxAnoPublicacao, auxGenero, auxStatus, auxPaginas, auxTipoCapa, auxIsbn, auxFormato, auxTamanho, auxUrl));
                }
            }
            else if (tabControlExemplar.SelectedIndex == 2)
            {
                // revista
                // leitura dos valores dos campos
                int auxEdicaoRevista = Convert.ToInt32(numericUpDownEdicaoRevista.Value);
                int auxPaginasRevista = Convert.ToInt32(numericUpDownPaginasRevista.Value);
                // cria o objeto e já adiciona no List
                exemplares.Add(new Revista(auxTitulo, auxSubTitulo, auxEscritor, auxEditora, auxAnoPublicacao, auxGenero, auxStatus, auxEdicaoRevista, auxPaginasRevista));
            }
            else if (tabControlExemplar.SelectedIndex == 1)
            {
                // hq
                // leitura dos valores dos campos
                int auxEdicaoHq = Convert.ToInt32(numericUpDownEdicaoHq.Value);
                string auxIlustrador = textBoxIlustrador.Text;
                // cria o objeto e já adiciona no List
                exemplares.Add(new Hq(auxTitulo, auxSubTitulo, auxEscritor, auxEditora, auxAnoPublicacao, auxGenero, auxStatus, auxEdicaoHq, auxIlustrador));
            }
            else if (tabControlExemplar.SelectedIndex == 3)
            {
                // generico
                // leitura dos valores dos campos
                int auxTipo = (int)(EnumGenericoTipo)Enum.Parse(typeof(EnumGenericoTipo), comboBoxTipo.Text);
                // cria o objeto e já adiciona no List
                exemplares.Add(new Generico(auxTitulo, auxSubTitulo, auxEscritor, auxEditora, auxAnoPublicacao, auxGenero, auxStatus, auxTipo));
            }
            MessageBox.Show("Pessoa cadastrada com sucesso!");
            Close();
        }

        private void checkBoxEbook_CheckedChanged(object sender, EventArgs e)
        {
            panelEbook.Enabled = checkBoxEbook.Checked;
        }

        private void buttonEditar_Click(object sender, EventArgs e)
        {
            // leitura dos valores dos campos
            exemplar.Titulo = textBoxTitulo.Text;
            exemplar.SubTitulo = textBoxSubTitulo.Text;
            exemplar.Escritor = textBoxEscritor.Text;
            exemplar.Editora = textBoxEditora.Text;
            exemplar.AnoPublicacao = Convert.ToInt32(numericUpDownAnoPublicacao.Value);
            exemplar.Genero = comboBoxGenero.Text;
            exemplar.Status = (int)(EnumExemplarStatus)Enum.Parse(typeof(EnumExemplarStatus), comboBoxStatus.Text);
            if (exemplar is Livro livro)
            {
                livro.Paginas = Convert.ToInt32(numericUpDownPaginasLivro.Value);
                livro.TipoCapa = comboBoxTipoCapa.Text;
                livro.Isbn = textBoxIsbn.Text;
            }
            else if (exemplar is Ebook ebook)
            {
                ebook.Paginas = Convert.ToInt32(numericUpDownPaginasLivro.Value);
                ebook.TipoCapa = comboBoxTipoCapa.Text;
                ebook.Isbn = textBoxIsbn.Text;
                ebook.Formato = comboBoxFormato.Text;
                ebook.Tamanho = numericUpDownTamanho.Value;
                ebook.Url = textBoxUrl.Text;
            }
            else if (exemplar is Revista revista)
            {
                revista.Edicao = Convert.ToInt32(numericUpDownEdicaoRevista.Value);
                revista.Paginas = Convert.ToInt32(numericUpDownPaginasRevista.Value);
            }
            else if (exemplar is Hq hq)
            {
                hq.Edicao = Convert.ToInt32(numericUpDownEdicaoHq.Value);
                hq.Ilustrador = textBoxIlustrador.Text;
            }
            else if (exemplar is Generico generico)
            {
                generico.Tipo = (int)(EnumGenericoTipo)Enum.Parse(typeof(EnumGenericoTipo), comboBoxTipo.Text);
            }
            MessageBox.Show("Exemplar editado com sucesso!");
            Close();
        }

        private void buttonExcluir_Click(object sender, EventArgs e)
        {
            exemplares.Remove(exemplar);
            MessageBox.Show("Exemplar excluído com sucesso!");
            Close();
        }

        private void numericUpDownPaginasRevista_ValueChanged(object sender, EventArgs e)
        {

        }
    }

}
