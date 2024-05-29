namespace Library
{
    partial class FormCadastroPessoa
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            buttonEditar = new Button();
            buttonExcluir = new Button();
            tabControlPessoa = new TabControl();
            Leitor = new TabPage();
            label11 = new Label();
            listBoxTipoLeitor = new ListBox();
            tabPage2 = new TabPage();
            label7 = new Label();
            numericUpDownSalario = new NumericUpDown();
            label10 = new Label();
            comboBoxCargo = new ComboBox();
            numericUpDownCargaHoraria = new NumericUpDown();
            label9 = new Label();
            label8 = new Label();
            textBoxFuncao = new TextBox();
            dateTimePickerNascimento = new DateTimePicker();
            maskedTextBoxTelefone = new MaskedTextBox();
            maskedTextBoxCpf = new MaskedTextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            buttonSalvar = new Button();
            textBoxEmail = new TextBox();
            label3 = new Label();
            label2 = new Label();
            textBoxNome = new TextBox();
            label1 = new Label();
            panel1.SuspendLayout();
            tabControlPessoa.SuspendLayout();
            Leitor.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownSalario).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownCargaHoraria).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Control;
            panel1.Controls.Add(buttonEditar);
            panel1.Controls.Add(buttonExcluir);
            panel1.Controls.Add(tabControlPessoa);
            panel1.Controls.Add(dateTimePickerNascimento);
            panel1.Controls.Add(maskedTextBoxTelefone);
            panel1.Controls.Add(maskedTextBoxCpf);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(buttonSalvar);
            panel1.Controls.Add(textBoxEmail);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(textBoxNome);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(-3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(511, 699);
            panel1.TabIndex = 0;
            // 
            // buttonEditar
            // 
            buttonEditar.BackColor = Color.Yellow;
            buttonEditar.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonEditar.Location = new Point(304, 634);
            buttonEditar.Name = "buttonEditar";
            buttonEditar.Size = new Size(75, 41);
            buttonEditar.TabIndex = 28;
            buttonEditar.Text = "Editar";
            buttonEditar.UseVisualStyleBackColor = false;
            buttonEditar.Click += buttonEditar_Click;
            // 
            // buttonExcluir
            // 
            buttonExcluir.BackColor = Color.Red;
            buttonExcluir.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonExcluir.Location = new Point(385, 634);
            buttonExcluir.Name = "buttonExcluir";
            buttonExcluir.Size = new Size(89, 41);
            buttonExcluir.TabIndex = 27;
            buttonExcluir.Text = "Excluir";
            buttonExcluir.UseVisualStyleBackColor = false;
            buttonExcluir.Click += buttonExcluir_Click;
            // 
            // tabControlPessoa
            // 
            tabControlPessoa.Controls.Add(Leitor);
            tabControlPessoa.Controls.Add(tabPage2);
            tabControlPessoa.Location = new Point(23, 305);
            tabControlPessoa.Name = "tabControlPessoa";
            tabControlPessoa.SelectedIndex = 0;
            tabControlPessoa.Size = new Size(466, 310);
            tabControlPessoa.TabIndex = 26;
            // 
            // Leitor
            // 
            Leitor.Controls.Add(label11);
            Leitor.Controls.Add(listBoxTipoLeitor);
            Leitor.Location = new Point(4, 24);
            Leitor.Name = "Leitor";
            Leitor.Padding = new Padding(3);
            Leitor.Size = new Size(458, 282);
            Leitor.TabIndex = 0;
            Leitor.Text = "Leitor";
            Leitor.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Maplestory", 11.9999981F, FontStyle.Bold);
            label11.Location = new Point(9, 25);
            label11.Name = "label11";
            label11.Size = new Size(112, 18);
            label11.TabIndex = 27;
            label11.Text = "Tipo de leitor";
            // 
            // listBoxTipoLeitor
            // 
            listBoxTipoLeitor.FormattingEnabled = true;
            listBoxTipoLeitor.ItemHeight = 15;
            listBoxTipoLeitor.Items.AddRange(new object[] { "Leitor voraz", "Leitor de fim de semana", "Leitor casual", "Leitor de um gênero específico", "Leitor de e-books", "Leitor de audiolivros", "Leitor crítico", "Leitor acadêmico", "Leitor nostálgico", "Leitor de bestsellers", "Leitor de clássicos", "Leitor de não-ficção", "Leitor multitarefa", "Leitor de ficção científica", "Leitor de fantasia", "Leitor de mistério", "Leitor de romance", "Leitor de biografias", "Leitor de poesia", "Leitor de autoajuda" });
            listBoxTipoLeitor.Location = new Point(9, 56);
            listBoxTipoLeitor.Name = "listBoxTipoLeitor";
            listBoxTipoLeitor.Size = new Size(427, 214);
            listBoxTipoLeitor.TabIndex = 0;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(label7);
            tabPage2.Controls.Add(numericUpDownSalario);
            tabPage2.Controls.Add(label10);
            tabPage2.Controls.Add(comboBoxCargo);
            tabPage2.Controls.Add(numericUpDownCargaHoraria);
            tabPage2.Controls.Add(label9);
            tabPage2.Controls.Add(label8);
            tabPage2.Controls.Add(textBoxFuncao);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(458, 282);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Funcionário";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Maplestory", 11.9999981F, FontStyle.Bold);
            label7.Location = new Point(9, 63);
            label7.Name = "label7";
            label7.Size = new Size(62, 18);
            label7.TabIndex = 13;
            label7.Text = "Salário";
            // 
            // numericUpDownSalario
            // 
            numericUpDownSalario.Location = new Point(182, 63);
            numericUpDownSalario.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            numericUpDownSalario.Name = "numericUpDownSalario";
            numericUpDownSalario.Size = new Size(120, 23);
            numericUpDownSalario.TabIndex = 20;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Maplestory", 11.9999981F, FontStyle.Bold);
            label10.Location = new Point(9, 183);
            label10.Name = "label10";
            label10.Size = new Size(118, 18);
            label10.TabIndex = 19;
            label10.Text = "Carga horária";
            label10.Click += label10_Click;
            // 
            // comboBoxCargo
            // 
            comboBoxCargo.DataSource = new EnumFuncionarioCargo[]
    {
    EnumFuncionarioCargo.Gerente,
    EnumFuncionarioCargo.Atendente,
    EnumFuncionarioCargo.Caixa,
    EnumFuncionarioCargo.Estagiário
    };
            comboBoxCargo.FormattingEnabled = true;
            comboBoxCargo.Location = new Point(182, 105);
            comboBoxCargo.Name = "comboBoxCargo";
            comboBoxCargo.Size = new Size(120, 23);
            comboBoxCargo.TabIndex = 21;
            comboBoxCargo.DataSource = Enum.GetValues(typeof(EnumFuncionarioCargo));
            // 
            // numericUpDownCargaHoraria
            // 
            numericUpDownCargaHoraria.Location = new Point(182, 183);
            numericUpDownCargaHoraria.Maximum = new decimal(new int[] { 12, 0, 0, 0 });
            numericUpDownCargaHoraria.Name = "numericUpDownCargaHoraria";
            numericUpDownCargaHoraria.Size = new Size(120, 23);
            numericUpDownCargaHoraria.TabIndex = 23;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Maplestory", 11.9999981F, FontStyle.Bold);
            label9.Location = new Point(9, 105);
            label9.Name = "label9";
            label9.Size = new Size(56, 18);
            label9.TabIndex = 17;
            label9.Text = "Cargo";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Maplestory", 11.9999981F, FontStyle.Bold);
            label8.Location = new Point(11, 144);
            label8.Name = "label8";
            label8.Size = new Size(60, 18);
            label8.TabIndex = 15;
            label8.Text = "Função";
            // 
            // textBoxFuncao
            // 
            textBoxFuncao.Location = new Point(182, 144);
            textBoxFuncao.Name = "textBoxFuncao";
            textBoxFuncao.Size = new Size(120, 23);
            textBoxFuncao.TabIndex = 22;
            // 
            // dateTimePickerNascimento
            // 
            dateTimePickerNascimento.Location = new Point(250, 164);
            dateTimePickerNascimento.Name = "dateTimePickerNascimento";
            dateTimePickerNascimento.Size = new Size(200, 23);
            dateTimePickerNascimento.TabIndex = 25;
            // 
            // maskedTextBoxTelefone
            // 
            maskedTextBoxTelefone.Location = new Point(123, 235);
            maskedTextBoxTelefone.Mask = "(00) 00000-0000";
            maskedTextBoxTelefone.Name = "maskedTextBoxTelefone";
            maskedTextBoxTelefone.Size = new Size(100, 23);
            maskedTextBoxTelefone.TabIndex = 24;
            // 
            // maskedTextBoxCpf
            // 
            maskedTextBoxCpf.Location = new Point(122, 201);
            maskedTextBoxCpf.Mask = "000.000.000-00";
            maskedTextBoxCpf.Name = "maskedTextBoxCpf";
            maskedTextBoxCpf.Size = new Size(101, 23);
            maskedTextBoxCpf.TabIndex = 23;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Maplestory", 11.9999981F, FontStyle.Bold);
            label6.Location = new Point(36, 234);
            label6.Name = "label6";
            label6.Size = new Size(73, 18);
            label6.TabIndex = 11;
            label6.Text = "Telefone";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Maplestory", 11.9999981F, FontStyle.Bold);
            label5.Location = new Point(36, 195);
            label5.Name = "label5";
            label5.Size = new Size(38, 18);
            label5.TabIndex = 9;
            label5.Text = "CPF";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Maplestory", 11.9999981F, FontStyle.Bold);
            label4.Location = new Point(36, 129);
            label4.Name = "label4";
            label4.Size = new Size(48, 18);
            label4.TabIndex = 7;
            label4.Text = "Email";
            // 
            // buttonSalvar
            // 
            buttonSalvar.BackColor = Color.Green;
            buttonSalvar.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonSalvar.Location = new Point(23, 634);
            buttonSalvar.Name = "buttonSalvar";
            buttonSalvar.Size = new Size(75, 41);
            buttonSalvar.TabIndex = 22;
            buttonSalvar.Text = "Salvar";
            buttonSalvar.UseVisualStyleBackColor = false;
            buttonSalvar.Click += button1_Click;
            // 
            // textBoxEmail
            // 
            textBoxEmail.Location = new Point(122, 129);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(328, 23);
            textBoxEmail.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Maplestory", 11.9999981F, FontStyle.Bold);
            label3.Location = new Point(36, 164);
            label3.Name = "label3";
            label3.Size = new Size(162, 18);
            label3.TabIndex = 5;
            label3.Text = "Data de nascimento";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Maplestory", 11.9999981F, FontStyle.Bold);
            label2.Location = new Point(36, 88);
            label2.Name = "label2";
            label2.Size = new Size(51, 18);
            label2.TabIndex = 3;
            label2.Text = "Nome";
            // 
            // textBoxNome
            // 
            textBoxNome.Location = new Point(122, 88);
            textBoxNome.Name = "textBoxNome";
            textBoxNome.Size = new Size(328, 23);
            textBoxNome.TabIndex = 2;
            textBoxNome.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Maplestory", 15.7499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(16, 41);
            label1.Name = "label1";
            label1.Size = new Size(375, 24);
            label1.TabIndex = 1;
            label1.Text = "Cadastro de clientes e funcionários";
            // 
            // FormCadastroPessoa
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveCaption;
            ClientSize = new Size(508, 704);
            Controls.Add(panel1);
            Name = "FormCadastroPessoa";
            Text = "FormCadastroPessoa";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tabControlPessoa.ResumeLayout(false);
            Leitor.ResumeLayout(false);
            Leitor.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownSalario).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownCargaHoraria).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private TextBox textBoxNome;
        private Label label2;
        private Label label4;
        private TextBox textBoxEmail;
        private Label label3;
        private Label label6;
        private Label label5;
        private Label label7;
        private Label label10;
        private Button buttonSalvar;
        private DateTimePicker dateTimePickerNascimento;
        private MaskedTextBox maskedTextBoxTelefone;
        private MaskedTextBox maskedTextBoxCpf;
        private TabControl tabControlPessoa;
        private TabPage Leitor;
        private TabPage tabPage2;
        private Label label8;
        private Label label9;
        private Label label11;
        private ListBox listBoxTipoLeitor;
        private NumericUpDown numericUpDownSalario;
        private ComboBox comboBoxCargo;
        private NumericUpDown numericUpDownCargaHoraria;
        private TextBox textBoxFuncao;
        private Button buttonEditar;
        private Button buttonExcluir;
    }
}