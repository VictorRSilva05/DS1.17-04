﻿namespace Library
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
        private void InitializeComponent()
        {
            panel1 = new Panel();
            button1 = new Button();
            tabControl1 = new TabControl();
            Livro = new TabPage();
            comboBox1 = new ComboBox();
            textBox9 = new TextBox();
            label10 = new Label();
            label8 = new Label();
            textBox8 = new TextBox();
            label9 = new Label();
            tabPage2 = new TabPage();
            textBox11 = new TextBox();
            label13 = new Label();
            textBox7 = new TextBox();
            label11 = new Label();
            textBox10 = new TextBox();
            label12 = new Label();
            tabPage3 = new TabPage();
            textBox12 = new TextBox();
            label14 = new Label();
            textBox13 = new TextBox();
            label15 = new Label();
            tabPage4 = new TabPage();
            textBox14 = new TextBox();
            label16 = new Label();
            textBox15 = new TextBox();
            label17 = new Label();
            tabPage5 = new TabPage();
            label18 = new Label();
            label7 = new Label();
            Genêro = new Label();
            label6 = new Label();
            textBox4 = new TextBox();
            label5 = new Label();
            label4 = new Label();
            textBox3 = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            comboBox2 = new ComboBox();
            numericUpDown1 = new NumericUpDown();
            comboBox3 = new ComboBox();
            comboBox4 = new ComboBox();
            panel1.SuspendLayout();
            tabControl1.SuspendLayout();
            Livro.SuspendLayout();
            tabPage2.SuspendLayout();
            tabPage3.SuspendLayout();
            tabPage4.SuspendLayout();
            tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Control;
            panel1.Controls.Add(comboBox4);
            panel1.Controls.Add(numericUpDown1);
            panel1.Controls.Add(comboBox2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(tabControl1);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(Genêro);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(textBox4);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(textBox3);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(textBox1);
            panel1.Font = new Font("Segoe UI", 13F);
            panel1.Location = new Point(-1, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(483, 718);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // button1
            // 
            button1.Location = new Point(16, 646);
            button1.Name = "button1";
            button1.Size = new Size(75, 36);
            button1.TabIndex = 23;
            button1.Text = "Enviar";
            button1.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(Livro);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Controls.Add(tabPage4);
            tabControl1.Controls.Add(tabPage5);
            tabControl1.Font = new Font("Sans Serif Collection", 5.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tabControl1.Location = new Point(19, 447);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(412, 183);
            tabControl1.TabIndex = 1;
            // 
            // Livro
            // 
            Livro.BackColor = SystemColors.Control;
            Livro.Controls.Add(comboBox1);
            Livro.Controls.Add(textBox9);
            Livro.Controls.Add(label10);
            Livro.Controls.Add(label8);
            Livro.Controls.Add(textBox8);
            Livro.Controls.Add(label9);
            Livro.Location = new Point(4, 29);
            Livro.Name = "Livro";
            Livro.Padding = new Padding(3);
            Livro.Size = new Size(404, 150);
            Livro.TabIndex = 0;
            Livro.Text = "Livro";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Comum", "Dura" });
            comboBox1.Location = new Point(266, 26);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(108, 28);
            comboBox1.TabIndex = 18;
            // 
            // textBox9
            // 
            textBox9.Location = new Point(99, 78);
            textBox9.Name = "textBox9";
            textBox9.Size = new Size(275, 27);
            textBox9.TabIndex = 16;
            textBox9.TextChanged += textBox9_TextChanged;
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
            // textBox8
            // 
            textBox8.Location = new Point(99, 27);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(87, 27);
            textBox8.TabIndex = 16;
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
            label9.Click += label9_Click;
            // 
            // tabPage2
            // 
            tabPage2.BackColor = SystemColors.Control;
            tabPage2.Controls.Add(textBox11);
            tabPage2.Controls.Add(label13);
            tabPage2.Controls.Add(textBox7);
            tabPage2.Controls.Add(label11);
            tabPage2.Controls.Add(textBox10);
            tabPage2.Controls.Add(label12);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(404, 150);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "eBook";
            // 
            // textBox11
            // 
            textBox11.Location = new Point(288, 25);
            textBox11.Name = "textBox11";
            textBox11.Size = new Size(87, 27);
            textBox11.TabIndex = 22;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Maplestory", 11.9999981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.Location = new Point(193, 23);
            label13.Name = "label13";
            label13.Size = new Size(78, 18);
            label13.TabIndex = 21;
            label13.Text = "Tamanho";
            label13.Click += label13_Click;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(100, 76);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(275, 27);
            textBox7.TabIndex = 19;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Maplestory", 11.9999981F, FontStyle.Bold);
            label11.Location = new Point(21, 76);
            label11.Name = "label11";
            label11.Size = new Size(38, 18);
            label11.TabIndex = 17;
            label11.Text = "URL";
            // 
            // textBox10
            // 
            textBox10.Location = new Point(100, 25);
            textBox10.Name = "textBox10";
            textBox10.Size = new Size(87, 27);
            textBox10.TabIndex = 20;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Maplestory", 11.9999981F, FontStyle.Bold);
            label12.Location = new Point(21, 25);
            label12.Name = "label12";
            label12.Size = new Size(75, 18);
            label12.TabIndex = 18;
            label12.Text = "Formato";
            // 
            // tabPage3
            // 
            tabPage3.BackColor = SystemColors.Control;
            tabPage3.Controls.Add(textBox12);
            tabPage3.Controls.Add(label14);
            tabPage3.Controls.Add(textBox13);
            tabPage3.Controls.Add(label15);
            tabPage3.Location = new Point(4, 29);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(404, 150);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Hq";
            // 
            // textBox12
            // 
            textBox12.Location = new Point(287, 27);
            textBox12.Name = "textBox12";
            textBox12.Size = new Size(87, 27);
            textBox12.TabIndex = 26;
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
            // textBox13
            // 
            textBox13.Location = new Point(99, 27);
            textBox13.Name = "textBox13";
            textBox13.Size = new Size(87, 27);
            textBox13.TabIndex = 24;
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
            tabPage4.Controls.Add(textBox14);
            tabPage4.Controls.Add(label16);
            tabPage4.Controls.Add(textBox15);
            tabPage4.Controls.Add(label17);
            tabPage4.Location = new Point(4, 29);
            tabPage4.Name = "tabPage4";
            tabPage4.Padding = new Padding(3);
            tabPage4.Size = new Size(404, 150);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "Revista";
            // 
            // textBox14
            // 
            textBox14.Location = new Point(291, 27);
            textBox14.Name = "textBox14";
            textBox14.Size = new Size(87, 27);
            textBox14.TabIndex = 30;
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
            label16.Click += label16_Click;
            // 
            // textBox15
            // 
            textBox15.Location = new Point(103, 27);
            textBox15.Name = "textBox15";
            textBox15.Size = new Size(87, 27);
            textBox15.TabIndex = 28;
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
            tabPage5.Controls.Add(comboBox3);
            tabPage5.Controls.Add(label18);
            tabPage5.Location = new Point(4, 29);
            tabPage5.Name = "tabPage5";
            tabPage5.Padding = new Padding(3);
            tabPage5.Size = new Size(404, 150);
            tabPage5.TabIndex = 4;
            tabPage5.Text = "Genérico";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Maplestory", 11.9999981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label18.Location = new Point(32, 25);
            label18.Name = "label18";
            label18.Size = new Size(42, 18);
            label18.TabIndex = 29;
            label18.Text = "Tipo";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Maplestory", 11.9999981F, FontStyle.Bold);
            label7.Location = new Point(19, 392);
            label7.Name = "label7";
            label7.Size = new Size(60, 18);
            label7.TabIndex = 13;
            label7.Text = "Status";
            // 
            // Genêro
            // 
            Genêro.AutoSize = true;
            Genêro.Font = new Font("Maplestory", 11.9999981F, FontStyle.Bold);
            Genêro.Location = new Point(19, 344);
            Genêro.Name = "Genêro";
            Genêro.Size = new Size(63, 18);
            Genêro.TabIndex = 11;
            Genêro.Text = "Gênero";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Maplestory", 11.9999981F, FontStyle.Bold);
            label6.Location = new Point(16, 302);
            label6.Name = "label6";
            label6.Size = new Size(145, 18);
            label6.TabIndex = 10;
            label6.Text = "Ano de publicação";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(108, 255);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(310, 31);
            textBox4.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Maplestory", 11.9999981F, FontStyle.Bold);
            label5.Location = new Point(16, 255);
            label5.Name = "label5";
            label5.Size = new Size(66, 18);
            label5.TabIndex = 7;
            label5.Text = "Editora";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Maplestory", 11.9999981F, FontStyle.Bold);
            label4.Location = new Point(16, 218);
            label4.Name = "label4";
            label4.Size = new Size(72, 18);
            label4.TabIndex = 6;
            label4.Text = "Escritor";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(108, 218);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(310, 31);
            textBox3.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Maplestory", 11.9999981F, FontStyle.Bold);
            label3.Location = new Point(16, 178);
            label3.Name = "label3";
            label3.Size = new Size(80, 18);
            label3.TabIndex = 4;
            label3.Text = "Subtítulo";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Maplestory", 11.9999981F, FontStyle.Bold);
            label2.Location = new Point(16, 141);
            label2.Name = "label2";
            label2.Size = new Size(53, 18);
            label2.TabIndex = 3;
            label2.Text = "Título";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Maplestory", 15.7499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(16, 50);
            label1.Name = "label1";
            label1.Size = new Size(218, 24);
            label1.TabIndex = 2;
            label1.Text = "Cadastrar exemplar";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(108, 141);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(310, 31);
            textBox2.TabIndex = 1;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(108, 181);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(310, 31);
            textBox1.TabIndex = 0;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(96, 393);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(161, 31);
            comboBox2.TabIndex = 24;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(167, 302);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(120, 31);
            numericUpDown1.TabIndex = 25;
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(92, 25);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(119, 28);
            comboBox3.TabIndex = 30;
            // 
            // comboBox4
            // 
            comboBox4.FormattingEnabled = true;
            comboBox4.Location = new Point(96, 346);
            comboBox4.Name = "comboBox4";
            comboBox4.Size = new Size(161, 31);
            comboBox4.TabIndex = 26;
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
            tabControl1.ResumeLayout(false);
            Livro.ResumeLayout(false);
            Livro.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            tabPage4.ResumeLayout(false);
            tabPage4.PerformLayout();
            tabPage5.ResumeLayout(false);
            tabPage5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textBox3;
        private Label label5;
        private TextBox textBox4;
        private Label label6;
        private Label label7;
        private Label Genêro;
        private TabControl tabControl1;
        private TabPage Livro;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private TabPage tabPage4;
        private TabPage tabPage5;
        private TextBox textBox8;
        private Label label9;
        private TextBox textBox9;
        private Label label10;
        private Label label8;
        private ComboBox comboBox1;
        private TextBox textBox11;
        private Label label13;
        private TextBox textBox7;
        private Label label11;
        private TextBox textBox10;
        private Label label12;
        private TextBox textBox12;
        private Label label14;
        private TextBox textBox13;
        private Label label15;
        private TextBox textBox14;
        private Label label16;
        private TextBox textBox15;
        private Label label17;
        private Label label18;
        private Button button1;
        private NumericUpDown numericUpDown1;
        private ComboBox comboBox2;
        private ComboBox comboBox3;
        private ComboBox comboBox4;
    }
}