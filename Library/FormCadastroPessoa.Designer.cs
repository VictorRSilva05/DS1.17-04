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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCadastroPessoa));
            panel1 = new Panel();
            label4 = new Label();
            textBox2 = new TextBox();
            label3 = new Label();
            monthCalendar1 = new MonthCalendar();
            label2 = new Label();
            textBox1 = new TextBox();
            label1 = new Label();
            label5 = new Label();
            textBox3 = new TextBox();
            label6 = new Label();
            textBox4 = new TextBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(label6);
            panel1.Controls.Add(textBox4);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(textBox3);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(monthCalendar1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(12, 91);
            panel1.Name = "panel1";
            panel1.Size = new Size(466, 712);
            panel1.TabIndex = 0;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Sans Serif Collection", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(16, 169);
            label4.Name = "label4";
            label4.Size = new Size(57, 29);
            label4.TabIndex = 7;
            label4.Text = "Email";
            label4.Click += this.label4_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(102, 169);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(328, 23);
            textBox2.TabIndex = 6;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Sans Serif Collection", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(16, 204);
            label3.Name = "label3";
            label3.Size = new Size(168, 29);
            label3.TabIndex = 5;
            label3.Text = "Data de nascimento";
            // 
            // monthCalendar1
            // 
            monthCalendar1.Location = new Point(203, 204);
            monthCalendar1.Name = "monthCalendar1";
            monthCalendar1.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Sans Serif Collection", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(16, 128);
            label2.Name = "label2";
            label2.Size = new Size(60, 29);
            label2.TabIndex = 3;
            label2.Text = "Nome";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(102, 128);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(328, 23);
            textBox1.TabIndex = 2;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sans Serif Collection", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(16, 41);
            label1.Name = "label1";
            label1.Size = new Size(352, 52);
            label1.TabIndex = 1;
            label1.Text = "Cadastro de pessoas";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Sans Serif Collection", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(16, 378);
            label5.Name = "label5";
            label5.Size = new Size(49, 29);
            label5.TabIndex = 9;
            label5.Text = "CPF";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(102, 378);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(177, 23);
            textBox3.TabIndex = 8;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Sans Serif Collection", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(16, 417);
            label6.Name = "label6";
            label6.Size = new Size(84, 29);
            label6.TabIndex = 11;
            label6.Text = "Telefone";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(102, 417);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(177, 23);
            textBox4.TabIndex = 10;
            // 
            // FormCadastroPessoa
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveCaption;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1669, 919);
            Controls.Add(panel1);
            Name = "FormCadastroPessoa";
            Text = "FormCadastroPessoa";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private TextBox textBox1;
        private MonthCalendar monthCalendar1;
        private Label label2;
        private Label label4;
        private TextBox textBox2;
        private Label label3;
        private Label label6;
        private TextBox textBox4;
        private Label label5;
        private TextBox textBox3;
    }
}