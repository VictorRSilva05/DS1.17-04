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
            panel3 = new Panel();
            label11 = new Label();
            comboBox1 = new ComboBox();
            dateTimePicker1 = new DateTimePicker();
            maskedTextBox2 = new MaskedTextBox();
            maskedTextBox1 = new MaskedTextBox();
            button1 = new Button();
            label10 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            textBox2 = new TextBox();
            label3 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            label1 = new Label();
            panel2 = new Panel();
            numericUpDown2 = new NumericUpDown();
            comboBox2 = new ComboBox();
            numericUpDown1 = new NumericUpDown();
            label9 = new Label();
            label8 = new Label();
            textBox7 = new TextBox();
            checkBox1 = new CheckBox();
            checkBox2 = new CheckBox();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Control;
            panel1.Controls.Add(checkBox2);
            panel1.Controls.Add(checkBox1);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(dateTimePicker1);
            panel1.Controls.Add(maskedTextBox2);
            panel1.Controls.Add(maskedTextBox1);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(-3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(511, 699);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // panel3
            // 
            panel3.Controls.Add(label11);
            panel3.Controls.Add(comboBox1);
            panel3.Location = new Point(36, 510);
            panel3.Name = "panel3";
            panel3.Size = new Size(414, 123);
            panel3.TabIndex = 27;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Maplestory", 11.9999981F, FontStyle.Bold);
            label11.Location = new Point(12, 31);
            label11.Name = "label11";
            label11.Size = new Size(42, 18);
            label11.TabIndex = 28;
            label11.Text = "Tipo";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(66, 30);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 0;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(250, 164);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 25;
            // 
            // maskedTextBox2
            // 
            maskedTextBox2.Location = new Point(123, 235);
            maskedTextBox2.Mask = "(00) 00000-0000";
            maskedTextBox2.Name = "maskedTextBox2";
            maskedTextBox2.Size = new Size(100, 23);
            maskedTextBox2.TabIndex = 24;
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Location = new Point(122, 201);
            maskedTextBox1.Mask = "000.000.000-00";
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(101, 23);
            maskedTextBox1.TabIndex = 23;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(29, 639);
            button1.Name = "button1";
            button1.Size = new Size(75, 41);
            button1.TabIndex = 22;
            button1.Text = "Enviar";
            button1.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Maplestory", 11.9999981F, FontStyle.Bold);
            label10.Location = new Point(48, 430);
            label10.Name = "label10";
            label10.Size = new Size(118, 18);
            label10.TabIndex = 19;
            label10.Text = "Carga horária";
            label10.Click += label10_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Maplestory", 11.9999981F, FontStyle.Bold);
            label7.Location = new Point(48, 310);
            label7.Name = "label7";
            label7.Size = new Size(62, 18);
            label7.TabIndex = 13;
            label7.Text = "Salário";
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
            // textBox2
            // 
            textBox2.Location = new Point(122, 129);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(328, 23);
            textBox2.TabIndex = 6;
            textBox2.TextChanged += textBox2_TextChanged;
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
            // textBox1
            // 
            textBox1.Location = new Point(122, 88);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(328, 23);
            textBox1.TabIndex = 2;
            textBox1.TextChanged += textBox1_TextChanged;
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
            label1.Click += label1_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(numericUpDown2);
            panel2.Controls.Add(comboBox2);
            panel2.Controls.Add(numericUpDown1);
            panel2.Controls.Add(label9);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(textBox7);
            panel2.Location = new Point(36, 299);
            panel2.Name = "panel2";
            panel2.Size = new Size(414, 166);
            panel2.TabIndex = 20;
            // 
            // numericUpDown2
            // 
            numericUpDown2.Location = new Point(178, 92);
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.Size = new Size(120, 23);
            numericUpDown2.TabIndex = 18;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(178, 48);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(120, 23);
            comboBox2.TabIndex = 1;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(178, 11);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(120, 23);
            numericUpDown1.TabIndex = 0;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Maplestory", 11.9999981F, FontStyle.Bold);
            label9.Location = new Point(12, 53);
            label9.Name = "label9";
            label9.Size = new Size(56, 18);
            label9.TabIndex = 17;
            label9.Text = "Cargo";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Maplestory", 11.9999981F, FontStyle.Bold);
            label8.Location = new Point(14, 92);
            label8.Name = "label8";
            label8.Size = new Size(60, 18);
            label8.TabIndex = 15;
            label8.Text = "Função";
            // 
            // textBox7
            // 
            textBox7.Location = new Point(178, 131);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(177, 23);
            textBox7.TabIndex = 16;
            textBox7.TextChanged += textBox7_TextChanged;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Font = new Font("Maplestory", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            checkBox1.Location = new Point(36, 274);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(134, 25);
            checkBox1.TabIndex = 28;
            checkBox1.Text = "Funcionário";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Font = new Font("Maplestory", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            checkBox2.Location = new Point(36, 479);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(93, 25);
            checkBox2.TabIndex = 29;
            checkBox2.Text = "Cliente";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // FormCadastroPessoa
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveCaption;
            ClientSize = new Size(507, 714);
            Controls.Add(panel1);
            Name = "FormCadastroPessoa";
            Text = "FormCadastroPessoa";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private TextBox textBox1;
        private Label label2;
        private Label label4;
        private TextBox textBox2;
        private Label label3;
        private Label label6;
        private Label label5;
        private Label label7;
        private Label label10;
        private Label label9;
        private TextBox textBox7;
        private Label label8;
        private Panel panel2;
        private Button button1;
        private DateTimePicker dateTimePicker1;
        private MaskedTextBox maskedTextBox2;
        private MaskedTextBox maskedTextBox1;
        private Panel panel3;
        private Label label11;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private NumericUpDown numericUpDown1;
        private NumericUpDown numericUpDown2;
        private CheckBox checkBox1;
        private CheckBox checkBox2;
    }
}