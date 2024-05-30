namespace Library
{
    partial class Form1
    {
        //Victor Rafael da Silva
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panel1 = new Panel();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            button2 = new Button();
            button1 = new Button();
            panel2 = new Panel();
            Funcionarios = new TabControl();
            tabPage1 = new TabPage();
            dataGridViewFuncionarios = new DataGridView();
            tabPage2 = new TabPage();
            dataGridViewLeitores = new DataGridView();
            tabPage3 = new TabPage();
            dataGridViewExemplares = new DataGridView();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            Funcionarios.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewFuncionarios).BeginInit();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewLeitores).BeginInit();
            tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewExemplares).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Location = new Point(40, 46);
            panel1.Name = "panel1";
            panel1.Size = new Size(475, 302);
            panel1.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Maplestory", 27.7499962F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(28, 57);
            label3.Name = "label3";
            label3.Size = new Size(199, 41);
            label3.TabIndex = 4;
            label3.Text = "Pergamun";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Maplestory", 15.7499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(28, 21);
            label2.Name = "label2";
            label2.Size = new Size(145, 24);
            label2.TabIndex = 3;
            label2.Text = "Bem vindo ao";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Maplestory", 15.7499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(28, 141);
            label1.Name = "label1";
            label1.Size = new Size(108, 24);
            label1.TabIndex = 2;
            label1.Text = "Cadastro";
            // 
            // button2
            // 
            button2.Font = new Font("Maplestory", 11.2499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(289, 211);
            button2.Name = "button2";
            button2.Size = new Size(137, 46);
            button2.TabIndex = 1;
            button2.Text = "Exemplar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Maplestory", 11.2499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(28, 211);
            button1.Name = "button1";
            button1.Size = new Size(137, 46);
            button1.TabIndex = 0;
            button1.Text = "Pessoa";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(Funcionarios);
            panel2.Location = new Point(40, 409);
            panel2.Name = "panel2";
            panel2.Size = new Size(712, 393);
            panel2.TabIndex = 1;
            // 
            // Funcionarios
            // 
            Funcionarios.Controls.Add(tabPage1);
            Funcionarios.Controls.Add(tabPage2);
            Funcionarios.Controls.Add(tabPage3);
            Funcionarios.Location = new Point(17, 20);
            Funcionarios.Name = "Funcionarios";
            Funcionarios.SelectedIndex = 0;
            Funcionarios.Size = new Size(674, 357);
            Funcionarios.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(dataGridViewFuncionarios);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(666, 329);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Funcionários";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // dataGridViewFuncionarios
            // 
            dataGridViewFuncionarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewFuncionarios.Dock = DockStyle.Fill;
            dataGridViewFuncionarios.Location = new Point(3, 3);
            dataGridViewFuncionarios.Name = "dataGridViewFuncionarios";
            dataGridViewFuncionarios.Size = new Size(660, 323);
            dataGridViewFuncionarios.TabIndex = 0;
            dataGridViewFuncionarios.MouseDoubleClick += dataGridViewFuncionarios_MouseDoubleClick;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(dataGridViewLeitores);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(666, 329);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Leitores";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridViewLeitores
            // 
            dataGridViewLeitores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewLeitores.Dock = DockStyle.Fill;
            dataGridViewLeitores.Location = new Point(3, 3);
            dataGridViewLeitores.Name = "dataGridViewLeitores";
            dataGridViewLeitores.Size = new Size(660, 323);
            dataGridViewLeitores.TabIndex = 0;
            dataGridViewLeitores.MouseDoubleClick += dataGridViewLeitores_MouseDoubleClick;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(dataGridViewExemplares);
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(666, 329);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Exemplares";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // dataGridViewExemplares
            // 
            dataGridViewExemplares.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewExemplares.Dock = DockStyle.Fill;
            dataGridViewExemplares.Location = new Point(3, 3);
            dataGridViewExemplares.Name = "dataGridViewExemplares";
            dataGridViewExemplares.Size = new Size(660, 323);
            dataGridViewExemplares.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1670, 892);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            Funcionarios.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewFuncionarios).EndInit();
            tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewLeitores).EndInit();
            tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewExemplares).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Button button2;
        private Button button1;
        private Label label2;
        private Label label3;
        private Panel panel2;
        private TabControl Funcionarios;
        private TabPage tabPage1;
        private DataGridView dataGridViewFuncionarios;
        private TabPage tabPage2;
        private DataGridView dataGridViewLeitores;
        private TabPage tabPage3;
        private DataGridView dataGridViewExemplares;
    }
}
