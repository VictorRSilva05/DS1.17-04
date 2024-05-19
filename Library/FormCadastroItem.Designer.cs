namespace Library
{
    partial class FormCadastroItem
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
        /// 

        private void InitializeComponent()
        {
            panel1 = new Panel();
            comboBoxGenero = new ComboBox();
            numericUpDownAnoPublicacao = new NumericUpDown();
            comboBoxStatus = new ComboBox();
            button1 = new Button();
            tabControlExemplar = new TabControl();
            Livro = new TabPage();
            checkBoxEbook = new CheckBox();
            numericUpDownPaginasLivro = new NumericUpDown();
            numericUpDownTamanho = new NumericUpDown();
            comboBoxFormato = new ComboBox();
            label13 = new Label();
            label12 = new Label();
            textBoxUrl = new TextBox();
            label11 = new Label();
            comboBoxTipoCapa = new ComboBox();
            textBoxIsbn = new TextBox();
            label10 = new Label();
            label8 = new Label();
            label9 = new Label();
            tabPage3 = new TabPage();
            numericUpDownEdicaoHq = new NumericUpDown();
            textBoxIlustrador = new TextBox();
            label14 = new Label();
            label15 = new Label();
            tabPage4 = new TabPage();
            numericUpDownEdicaoRevista = new NumericUpDown();
            numericUpDownPaginasRevista = new NumericUpDown();
            label16 = new Label();
            label17 = new Label();
            tabPage5 = new TabPage();
            comboBoxTipo = new ComboBox();
            label18 = new Label();
            label7 = new Label();
            Genêro = new Label();
            label6 = new Label();
            textBoxEditora = new TextBox();
            label5 = new Label();
            label4 = new Label();
            textBoxEscritor = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            textBoxTitulo = new TextBox();
            textBoxSubTitulo = new TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownAnoPublicacao).BeginInit();
            tabControlExemplar.SuspendLayout();
            Livro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownPaginasLivro).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownTamanho).BeginInit();
            tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownEdicaoHq).BeginInit();
            tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownEdicaoRevista).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownPaginasRevista).BeginInit();
            tabPage5.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Control;
            panel1.Controls.Add(comboBoxGenero);
            panel1.Controls.Add(numericUpDownAnoPublicacao);
            panel1.Controls.Add(comboBoxStatus);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(tabControlExemplar);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(Genêro);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(textBoxEditora);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(textBoxEscritor);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(textBoxTitulo);
            panel1.Controls.Add(textBoxSubTitulo);
            panel1.Font = new Font("Segoe UI", 13F);
            panel1.Location = new Point(-1, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(483, 718);
            panel1.TabIndex = 0;
            // 
            // comboBoxGenero
            // 
            comboBoxGenero.FormattingEnabled = true;
            comboBoxGenero.Items.AddRange(new object[] { "Romance", "Novela", "Conto", "Crônica", "Poema", "Canção", "Drama histórico", "Teatro de vanguarda", "" });
            comboBoxGenero.Location = new Point(105, 250);
            comboBoxGenero.Name = "comboBoxGenero";
            comboBoxGenero.Size = new Size(161, 31);
            comboBoxGenero.TabIndex = 26;
            // 
            // numericUpDownAnoPublicacao
            // 
            numericUpDownAnoPublicacao.Location = new Point(176, 206);
            numericUpDownAnoPublicacao.Name = "numericUpDownAnoPublicacao";
            numericUpDownAnoPublicacao.Size = new Size(120, 31);
            numericUpDownAnoPublicacao.TabIndex = 25;
            // 
            // comboBoxStatus
            // 
            comboBoxStatus.DataSource = new EnumExemplarStatus[]
    {
    EnumExemplarStatus.Pendente,
    EnumExemplarStatus.Lido,
    EnumExemplarStatus.Emprestado,
    EnumExemplarStatus.Devolvido,
    EnumExemplarStatus.Perdido
    };
            comboBoxStatus.FormattingEnabled = true;
            comboBoxStatus.Items.AddRange(new object[] { EnumExemplarStatus.Pendente, EnumExemplarStatus.Lido, EnumExemplarStatus.Emprestado, EnumExemplarStatus.Devolvido, EnumExemplarStatus.Perdido });
            comboBoxStatus.Location = new Point(105, 297);
            comboBoxStatus.Name = "comboBoxStatus";
            comboBoxStatus.Size = new Size(161, 31);
            comboBoxStatus.TabIndex = 24;
            // 
            // button1
            // 
            button1.Location = new Point(16, 646);
            button1.Name = "button1";
            button1.Size = new Size(75, 36);
            button1.TabIndex = 23;
            button1.Text = "Enviar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // tabControlExemplar
            // 
            tabControlExemplar.Controls.Add(Livro);
            tabControlExemplar.Controls.Add(tabPage3);
            tabControlExemplar.Controls.Add(tabPage4);
            tabControlExemplar.Controls.Add(tabPage5);
            tabControlExemplar.Font = new Font("Sans Serif Collection", 5.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tabControlExemplar.Location = new Point(19, 350);
            tabControlExemplar.Name = "tabControlExemplar";
            tabControlExemplar.SelectedIndex = 0;
            tabControlExemplar.Size = new Size(412, 280);
            tabControlExemplar.TabIndex = 1;
            // 
            // Livro
            // 
            Livro.BackColor = SystemColors.Control;
            Livro.Controls.Add(checkBoxEbook);
            Livro.Controls.Add(numericUpDownPaginasLivro);
            Livro.Controls.Add(numericUpDownTamanho);
            Livro.Controls.Add(comboBoxFormato);
            Livro.Controls.Add(label13);
            Livro.Controls.Add(label12);
            Livro.Controls.Add(textBoxUrl);
            Livro.Controls.Add(label11);
            Livro.Controls.Add(comboBoxTipoCapa);
            Livro.Controls.Add(textBoxIsbn);
            Livro.Controls.Add(label10);
            Livro.Controls.Add(label8);
            Livro.Controls.Add(label9);
            Livro.Location = new Point(4, 29);
            Livro.Name = "Livro";
            Livro.Padding = new Padding(3);
            Livro.Size = new Size(404, 247);
            Livro.TabIndex = 0;
            Livro.Text = "Livro";
            // 
            // checkBoxEbook
            // 
            checkBoxEbook.AutoSize = true;
            checkBoxEbook.Font = new Font("Maplestory", 11.9999981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            checkBoxEbook.Location = new Point(20, 123);
            checkBoxEbook.Name = "checkBoxEbook";
            checkBoxEbook.Size = new Size(76, 22);
            checkBoxEbook.TabIndex = 30;
            checkBoxEbook.Text = "Ebook";
            checkBoxEbook.UseVisualStyleBackColor = true;
            // 
            // numericUpDownPaginasLivro
            // 
            numericUpDownPaginasLivro.Location = new Point(99, 27);
            numericUpDownPaginasLivro.Name = "numericUpDownPaginasLivro";
            numericUpDownPaginasLivro.Size = new Size(99, 27);
            numericUpDownPaginasLivro.TabIndex = 29;
            // 
            // numericUpDownTamanho
            // 
            numericUpDownTamanho.Location = new Point(287, 162);
            numericUpDownTamanho.Name = "numericUpDownTamanho";
            numericUpDownTamanho.Size = new Size(87, 27);
            numericUpDownTamanho.TabIndex = 27;
            // 
            // comboBoxFormato
            // 
            comboBoxFormato.FormattingEnabled = true;
            comboBoxFormato.Items.AddRange(new object[] { "Portable Document Format (PDF)", "Eletronic Publication (ePUB)", "Mobipocket (MOBI)", "Kindle Package Format (KPF)", "Outros" });
            comboBoxFormato.Location = new Point(99, 163);
            comboBoxFormato.Name = "comboBoxFormato";
            comboBoxFormato.Size = new Size(98, 28);
            comboBoxFormato.TabIndex = 26;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Maplestory", 11.9999981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.Location = new Point(203, 165);
            label13.Name = "label13";
            label13.Size = new Size(78, 18);
            label13.TabIndex = 25;
            label13.Text = "Tamanho";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Maplestory", 11.9999981F, FontStyle.Bold);
            label12.Location = new Point(20, 163);
            label12.Name = "label12";
            label12.Size = new Size(75, 18);
            label12.TabIndex = 24;
            label12.Text = "Formato";
            // 
            // textBoxUrl
            // 
            textBoxUrl.Location = new Point(99, 204);
            textBoxUrl.Name = "textBoxUrl";
            textBoxUrl.Size = new Size(275, 27);
            textBoxUrl.TabIndex = 21;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Maplestory", 11.9999981F, FontStyle.Bold);
            label11.Location = new Point(20, 206);
            label11.Name = "label11";
            label11.Size = new Size(38, 18);
            label11.TabIndex = 20;
            label11.Text = "URL";
            // 
            // comboBoxTipoCapa
            // 
            comboBoxTipoCapa.FormattingEnabled = true;
            comboBoxTipoCapa.Items.AddRange(new object[] { "Capa Dura", "Capa Flexível ou Brochura", "Capa de Papel Cartão", "Capa com Sobrecapa (Jacket) • Capa com Relevo", "Capa com Verniz UV", "Capa Metalizada", "Capa de Tecido", "Capa com Janela", "Capa Transparente" });
            comboBoxTipoCapa.Location = new Point(266, 26);
            comboBoxTipoCapa.Name = "comboBoxTipoCapa";
            comboBoxTipoCapa.Size = new Size(108, 28);
            comboBoxTipoCapa.TabIndex = 18;
            comboBoxTipoCapa.Text = "Comum";
            // 
            // textBoxIsbn
            // 
            textBoxIsbn.Location = new Point(99, 78);
            textBoxIsbn.Name = "textBoxIsbn";
            textBoxIsbn.Size = new Size(275, 27);
            textBoxIsbn.TabIndex = 16;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Maplestory", 11.9999981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(20, 78);
            label10.Name = "label10";
            label10.Size = new Size(46, 18);
            label10.TabIndex = 15;
            label10.Text = "ISBN";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Maplestory", 11.9999981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(204, 27);
            label8.Name = "label8";
            label8.Size = new Size(49, 18);
            label8.TabIndex = 17;
            label8.Text = "Capa";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Maplestory", 11.9999981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(20, 27);
            label9.Name = "label9";
            label9.Size = new Size(67, 18);
            label9.TabIndex = 15;
            label9.Text = "Páginas";
            // 
            // tabPage3
            // 
            tabPage3.BackColor = SystemColors.Control;
            tabPage3.Controls.Add(numericUpDownEdicaoHq);
            tabPage3.Controls.Add(textBoxIlustrador);
            tabPage3.Controls.Add(label14);
            tabPage3.Controls.Add(label15);
            tabPage3.Location = new Point(4, 29);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(404, 247);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Hq";
            // 
            // numericUpDownEdicaoHq
            // 
            numericUpDownEdicaoHq.Location = new Point(82, 24);
            numericUpDownEdicaoHq.Name = "numericUpDownEdicaoHq";
            numericUpDownEdicaoHq.Size = new Size(104, 27);
            numericUpDownEdicaoHq.TabIndex = 27;
            // 
            // textBoxIlustrador
            // 
            textBoxIlustrador.Location = new Point(287, 24);
            textBoxIlustrador.Name = "textBoxIlustrador";
            textBoxIlustrador.Size = new Size(111, 27);
            textBoxIlustrador.TabIndex = 26;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Maplestory", 11.9999981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label14.Location = new Point(192, 25);
            label14.Name = "label14";
            label14.Size = new Size(89, 18);
            label14.TabIndex = 25;
            label14.Text = "Ilustrador";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Maplestory", 11.9999981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label15.Location = new Point(20, 27);
            label15.Name = "label15";
            label15.Size = new Size(56, 18);
            label15.TabIndex = 23;
            label15.Text = "Edição";
            // 
            // tabPage4
            // 
            tabPage4.BackColor = SystemColors.Control;
            tabPage4.Controls.Add(numericUpDownEdicaoRevista);
            tabPage4.Controls.Add(numericUpDownPaginasRevista);
            tabPage4.Controls.Add(label16);
            tabPage4.Controls.Add(label17);
            tabPage4.Location = new Point(4, 29);
            tabPage4.Name = "tabPage4";
            tabPage4.Padding = new Padding(3);
            tabPage4.Size = new Size(404, 247);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "Revista";
            // 
            // numericUpDownEdicaoRevista
            // 
            numericUpDownEdicaoRevista.Location = new Point(270, 26);
            numericUpDownEdicaoRevista.Name = "numericUpDownEdicaoRevista";
            numericUpDownEdicaoRevista.Size = new Size(99, 27);
            numericUpDownEdicaoRevista.TabIndex = 31;
            // 
            // numericUpDownPaginasRevista
            // 
            numericUpDownPaginasRevista.Location = new Point(97, 26);
            numericUpDownPaginasRevista.Name = "numericUpDownPaginasRevista";
            numericUpDownPaginasRevista.Size = new Size(99, 27);
            numericUpDownPaginasRevista.TabIndex = 30;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Maplestory", 11.9999981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label16.Location = new Point(208, 27);
            label16.Name = "label16";
            label16.Size = new Size(56, 18);
            label16.TabIndex = 29;
            label16.Text = "Edição";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Maplestory", 11.9999981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label17.Location = new Point(24, 27);
            label17.Name = "label17";
            label17.Size = new Size(67, 18);
            label17.TabIndex = 27;
            label17.Text = "Páginas";
            // 
            // tabPage5
            // 
            tabPage5.BackColor = SystemColors.Control;
            tabPage5.Controls.Add(comboBoxTipo);
            tabPage5.Controls.Add(label18);
            tabPage5.Location = new Point(4, 29);
            tabPage5.Name = "tabPage5";
            tabPage5.Padding = new Padding(3);
            tabPage5.Size = new Size(404, 247);
            tabPage5.TabIndex = 4;
            tabPage5.Text = "Genérico";
            // 
            // comboBoxTipo
            // 
            comboBoxTipo.DataSource = new EnumGenericoTipo[]
    {
    EnumGenericoTipo.Jornais,
    EnumGenericoTipo.CalendariosAgendas,
    EnumGenericoTipo.MapasAtlas,
    EnumGenericoTipo.PostaisCartoesSaudacao,
    EnumGenericoTipo.PapeisPresenteMaterialEmbalagem,
    EnumGenericoTipo.DVDsBlurays,
    EnumGenericoTipo.CDsVinis,
    EnumGenericoTipo.K7,
    EnumGenericoTipo.JogosTabuleiroQuebraCabecas,
    EnumGenericoTipo.MaterialPapelariaEscritorio,
    EnumGenericoTipo.ProdutosRelacionadosCulturaPop,
    EnumGenericoTipo.Audiolivros,
    EnumGenericoTipo.Outros
    };
            comboBoxTipo.FormattingEnabled = true;
            comboBoxTipo.Items.AddRange(new object[] { EnumGenericoTipo.Jornais, EnumGenericoTipo.CalendariosAgendas, EnumGenericoTipo.MapasAtlas, EnumGenericoTipo.PostaisCartoesSaudacao, EnumGenericoTipo.PapeisPresenteMaterialEmbalagem, EnumGenericoTipo.DVDsBlurays, EnumGenericoTipo.CDsVinis, EnumGenericoTipo.K7, EnumGenericoTipo.JogosTabuleiroQuebraCabecas, EnumGenericoTipo.MaterialPapelariaEscritorio, EnumGenericoTipo.ProdutosRelacionadosCulturaPop, EnumGenericoTipo.Audiolivros, EnumGenericoTipo.Outros });
            comboBoxTipo.Location = new Point(73, 28);
            comboBoxTipo.Name = "comboBoxTipo";
            comboBoxTipo.Size = new Size(119, 28);
            comboBoxTipo.TabIndex = 30;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Maplestory", 11.9999981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label18.Location = new Point(13, 28);
            label18.Name = "label18";
            label18.Size = new Size(42, 18);
            label18.TabIndex = 29;
            label18.Text = "Tipo";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Maplestory", 11.9999981F, FontStyle.Bold);
            label7.Location = new Point(28, 296);
            label7.Name = "label7";
            label7.Size = new Size(60, 18);
            label7.TabIndex = 13;
            label7.Text = "Status";
            // 
            // Genêro
            // 
            Genêro.AutoSize = true;
            Genêro.Font = new Font("Maplestory", 11.9999981F, FontStyle.Bold);
            Genêro.Location = new Point(28, 248);
            Genêro.Name = "Genêro";
            Genêro.Size = new Size(63, 18);
            Genêro.TabIndex = 11;
            Genêro.Text = "Gênero";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Maplestory", 11.9999981F, FontStyle.Bold);
            label6.Location = new Point(25, 206);
            label6.Name = "label6";
            label6.Size = new Size(145, 18);
            label6.TabIndex = 10;
            label6.Text = "Ano de publicação";
            // 
            // textBoxEditora
            // 
            textBoxEditora.Location = new Point(117, 159);
            textBoxEditora.Name = "textBoxEditora";
            textBoxEditora.Size = new Size(310, 31);
            textBoxEditora.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Maplestory", 11.9999981F, FontStyle.Bold);
            label5.Location = new Point(25, 159);
            label5.Name = "label5";
            label5.Size = new Size(66, 18);
            label5.TabIndex = 7;
            label5.Text = "Editora";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Maplestory", 11.9999981F, FontStyle.Bold);
            label4.Location = new Point(25, 122);
            label4.Name = "label4";
            label4.Size = new Size(72, 18);
            label4.TabIndex = 6;
            label4.Text = "Escritor";
            // 
            // textBoxEscritor
            // 
            textBoxEscritor.Location = new Point(117, 122);
            textBoxEscritor.Name = "textBoxEscritor";
            textBoxEscritor.Size = new Size(310, 31);
            textBoxEscritor.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Maplestory", 11.9999981F, FontStyle.Bold);
            label3.Location = new Point(25, 82);
            label3.Name = "label3";
            label3.Size = new Size(80, 18);
            label3.TabIndex = 4;
            label3.Text = "Subtítulo";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Maplestory", 11.9999981F, FontStyle.Bold);
            label2.Location = new Point(25, 45);
            label2.Name = "label2";
            label2.Size = new Size(53, 18);
            label2.TabIndex = 3;
            label2.Text = "Título";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Maplestory", 15.7499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(13, 8);
            label1.Name = "label1";
            label1.Size = new Size(218, 24);
            label1.TabIndex = 2;
            label1.Text = "Cadastrar exemplar";
            // 
            // textBoxTitulo
            // 
            textBoxTitulo.Location = new Point(117, 45);
            textBoxTitulo.Name = "textBoxTitulo";
            textBoxTitulo.Size = new Size(310, 31);
            textBoxTitulo.TabIndex = 1;
            // 
            // textBoxSubTitulo
            // 
            textBoxSubTitulo.Location = new Point(117, 85);
            textBoxSubTitulo.Name = "textBoxSubTitulo";
            textBoxSubTitulo.Size = new Size(310, 31);
            textBoxSubTitulo.TabIndex = 0;
            // 
            // FormCadastroItem
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonFace;
            ClientSize = new Size(481, 716);
            Controls.Add(panel1);
            Name = "FormCadastroItem";
            Text = "FormCadastroItem";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownAnoPublicacao).EndInit();
            tabControlExemplar.ResumeLayout(false);
            Livro.ResumeLayout(false);
            Livro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownPaginasLivro).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownTamanho).EndInit();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownEdicaoHq).EndInit();
            tabPage4.ResumeLayout(false);
            tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownEdicaoRevista).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownPaginasRevista).EndInit();
            tabPage5.ResumeLayout(false);
            tabPage5.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TextBox textBoxTitulo;
        private TextBox textBoxSubTitulo;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textBoxEscritor;
        private Label label5;
        private TextBox textBoxEditora;
        private Label label6;
        private Label label7;
        private Label Genêro;
        private TabControl tabControlExemplar;
        private TabPage Livro;
        private TabPage tabPage3;
        private TabPage tabPage4;
        private TabPage tabPage5;
        private Label label9;
        private TextBox textBoxIsbn;
        private Label label10;
        private Label label8;
        private ComboBox comboBoxTipoCapa;
        private TextBox textBoxIlustrador;
        private Label label14;
        private Label label15;
        private Label label16;
        private Label label17;
        private Label label18;
        private Button button1;
        private NumericUpDown numericUpDownAnoPublicacao;
        private ComboBox comboBoxStatus;
        private ComboBox comboBoxTipo;
        private ComboBox comboBoxGenero;
        private NumericUpDown numericUpDownTamanho;
        private ComboBox comboBoxFormato;
        private Label label13;
        private Label label12;
        private TextBox textBoxUrl;
        private Label label11;
        private NumericUpDown numericUpDownPaginasLivro;
        private CheckBox checkBoxEbook;
        private NumericUpDown numericUpDownEdicaoRevista;
        private NumericUpDown numericUpDownPaginasRevista;
        private NumericUpDown numericUpDownEdicaoHq;
    }
}