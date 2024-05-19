
namespace Library
{
    public partial class FormCadastroItem : Form
    {
        // variável com escopo de classe
        List<Exemplar> exemplares;
        public FormCadastroItem(List<Exemplar> exemplares)
        {
            InitializeComponent();
            this.exemplares = exemplares;
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
    }

}
