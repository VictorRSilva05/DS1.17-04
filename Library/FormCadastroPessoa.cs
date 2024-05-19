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
        List<Funcionario> funcionarios;
        List<Leitor> leitores;
        public FormCadastroPessoa(List<Funcionario> funcionarios, List<Leitor> leitores)
        {
            InitializeComponent();
            this.funcionarios = funcionarios;
            this.leitores = leitores;
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
    }
}
