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
    public partial class FormCadastroPessoa : Form
    {
        //Victor Rafael da Silva
        List<Funcionario> funcionarios;
        List<Leitor> leitores;
        Funcionario funcionario;
        List<Exemplar> exemplares;
        Leitor leitor;
        public FormCadastroPessoa(List<Funcionario> funcionarios, List<Leitor> leitores, List<Exemplar> exemplares)
        {
            InitializeComponent();
            this.funcionarios = funcionarios;
            this.leitores = leitores;
            this.exemplares = exemplares;
        }

        // sobrecarga de construtor, novo construtor com lista de parâmetros diferente
        public FormCadastroPessoa(List<Funcionario> funcionarios, Funcionario funcionario)
        {
            InitializeComponent();
            // atribui o objeto recebido à variável com escopo de classe
            this.funcionario = funcionario;
            this.funcionarios = funcionarios;
            // carrega os valores do Enum para o combobox
            comboBoxCargo.DataSource = Enum.GetValues(typeof(EnumFuncionarioCargo));
            comboBoxCargo.SelectedIndex = 0;
            // carrega os valores do objeto recebido
            textBoxNome.Text = funcionario.Nome;
            dateTimePickerNascimento.Value = funcionario.Nascimento;
            maskedTextBoxCpf.Text = funcionario.Cpf;
            textBoxEmail.Text = funcionario.Email;
            maskedTextBoxTelefone.Text = funcionario.Telefone;
            comboBoxCargo.Text = "" + (EnumFuncionarioCargo)Enum.Parse(typeof(EnumFuncionarioCargo), funcionario.Cargo.ToString());
            numericUpDownSalario.Value = funcionario.Salary;
            numericUpDownCargaHoraria.Value = funcionario.CargaHoraria;
            textBoxFuncao.Text = funcionario.Funcao;
            // ajusta a tab e botões
            tabControlPessoa.SelectedIndex = 1;
            tabControlPessoa.TabPages[0].Enabled = false;
            buttonSalvar.Enabled = false;
        }

        // sobrecarga de construtor, novo construtor com lista de parâmetros diferente
        public FormCadastroPessoa(List<Leitor> leitores, Leitor leitor, List<Exemplar> exemplares)
        {
            InitializeComponent();
            // atribui o objeto recebido à variável com escopo de classe
            this.leitor = leitor;
            this.leitores = leitores;
            this.exemplares = exemplares;
            // carrega os valores do objeto recebido
            textBoxNome.Text = leitor.Nome;
            dateTimePickerNascimento.Value = leitor.Nascimento;
            maskedTextBoxCpf.Text = leitor.Cpf;
            textBoxEmail.Text = leitor.Email;
            maskedTextBoxTelefone.Text = leitor.Telefone;
            listBoxTipoLeitor.Text = leitor.Tipo;
            // ajusta a tab e botões
            tabControlPessoa.SelectedIndex = 0;
            tabControlPessoa.TabPages[1].Enabled = false;
            buttonSalvar.Enabled = false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // leitura dos valores dos campos
            string auxNome = textBoxNome.Text;
            DateTime auxData = dateTimePickerNascimento.Value;
            string auxCpf = maskedTextBoxCpf.Text;
            string auxEmail = textBoxEmail.Text;
            string auxTelefone = maskedTextBoxTelefone.Text;
            if (tabControlPessoa.SelectedIndex == 0)
            {
                // leitura dos valores dos campos
                string auxTipoLeitor = listBoxTipoLeitor.SelectedItem.ToString();
                // cria o objeto leitor
                var leitor = new Leitor(auxNome, auxData, auxCpf, auxEmail, auxTelefone, auxTipoLeitor);
                // adicionar no list
                leitores.Add(leitor);
            }
            else
            {
                // leitura dos valores dos campos
                int auxCargo = (int)(EnumFuncionarioCargo)Enum.Parse(typeof(EnumFuncionarioCargo), comboBoxCargo.Text);
                decimal auxSalario = numericUpDownSalario.Value;
                int auxCargaHoraria = Convert.ToInt32(numericUpDownCargaHoraria.Value);
                string auxFuncao = textBoxFuncao.Text;
                // cria o objeto funcionário e já adiciona diretamente
                funcionarios.Add(new Funcionario(auxNome, auxData, auxCpf, auxEmail, auxTelefone, auxCargo, auxSalario, auxCargaHoraria, auxFuncao));
            }
            MessageBox.Show("Pessoa cadastrada com sucesso!");
            Close();
        }

        private void buttonEditar_Click(object sender, EventArgs e)
        {
            if (tabControlPessoa.SelectedIndex == 0)
            {
                // atualiza os dados no objeto
                // para uso futuro, edição de leitor
                // atualiza os dados no objeto
                leitor.Nome = textBoxNome.Text;
                leitor.Nascimento = dateTimePickerNascimento.Value;
                leitor.Cpf = maskedTextBoxCpf.Text;
                leitor.Email = textBoxEmail.Text;
                leitor.Telefone = maskedTextBoxTelefone.Text;
                leitor.Tipo = listBoxTipoLeitor.Text;
            }
            else
            {
                // atualiza os dados no objeto
                funcionario.Nome = textBoxNome.Text;
                funcionario.Nascimento = dateTimePickerNascimento.Value;
                funcionario.Cpf = maskedTextBoxCpf.Text;
                funcionario.Email = textBoxEmail.Text;
                funcionario.Telefone = maskedTextBoxTelefone.Text;
                funcionario.Cargo = (int)(EnumFuncionarioCargo)Enum.Parse(typeof(EnumFuncionarioCargo),
                comboBoxCargo.Text);
                funcionario.Salary = numericUpDownSalario.Value;
                funcionario.CargaHoraria = Convert.ToInt32(numericUpDownCargaHoraria.Value);
                funcionario.Funcao = textBoxFuncao.Text;
            }
            MessageBox.Show("Pessoa editada com sucesso!");
            Close();
        }

        private void buttonExcluir_Click(object sender, EventArgs e)
        {
            if (tabControlPessoa.SelectedIndex == 0)
            {
                // exclui o objeto, Leitor
                // uso futuro
                leitores.Remove(leitor);
            }
            else
            {
                // exclui o objeto
                funcionarios.Remove(funcionario);
            }
            MessageBox.Show("Pessoa excluída com sucesso!");
            Close();
        }

        private void buttonExemplares_Click(object sender, EventArgs e)
        {
            FormAdicionarExemplares cli = new FormAdicionarExemplares(exemplares, leitor);
            cli.StartPosition = FormStartPosition.CenterParent;
            cli.ShowDialog();
        }
    }
}
