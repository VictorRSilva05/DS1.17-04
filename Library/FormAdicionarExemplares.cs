using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library
{
    public partial class FormAdicionarExemplares : Form
    {
        //Victor Rafael da Silva
        List<Exemplar> exemplares;
        Leitor leitor;
        public FormAdicionarExemplares(List<Exemplar> exemplares, Leitor leitor)
        {
            InitializeComponent();
            this.exemplares = exemplares;
            listBoxExemplares.DataSource = exemplares;
            this.leitor = leitor;
            listBoxExemplaresLeitor.DataSource = leitor.ExemplaresLeitor;
            label1.Text = leitor.Nome;
        }

        private void buttonAdicionarExemplar_Click(object sender, EventArgs e)
        {
            var exemplarSelecionado = listBoxExemplares.SelectedItem as Exemplar;
            if (exemplarSelecionado != null)
            {
                leitor.ExemplaresLeitor.Add(exemplarSelecionado);
                listBoxExemplaresLeitor.DataSource = null;
                listBoxExemplaresLeitor.DataSource = leitor.ExemplaresLeitor;
            }
            else
            {
                MessageBox.Show("Nenhum exemplar selecionado.");
            }
        }

        private void buttonRemoverExemplar_Click(object sender, EventArgs e)
        {
            var exemplarSelecionado = listBoxExemplaresLeitor.SelectedItem as Exemplar;
            if (exemplarSelecionado != null)
            {
                leitor.ExemplaresLeitor.Remove(exemplarSelecionado);
                listBoxExemplaresLeitor.DataSource = null;
                listBoxExemplaresLeitor.DataSource = leitor.ExemplaresLeitor;
            }
            else
            {
                MessageBox.Show("Nenhum exemplar selecionado.");
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}

