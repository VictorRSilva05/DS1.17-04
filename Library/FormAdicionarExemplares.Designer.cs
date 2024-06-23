namespace Library
{
    partial class FormAdicionarExemplares
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
            buttonRemoverExemplar = new Button();
            buttonAdicionarExemplar = new Button();
            label1 = new Label();
            listBoxExemplaresLeitor = new ListBox();
            listBoxExemplares = new ListBox();
            label2 = new Label();
            label3 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(buttonRemoverExemplar);
            panel1.Controls.Add(buttonAdicionarExemplar);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(listBoxExemplaresLeitor);
            panel1.Controls.Add(listBoxExemplares);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(808, 492);
            panel1.TabIndex = 0;
            // 
            // buttonRemoverExemplar
            // 
            buttonRemoverExemplar.BackColor = Color.Red;
            buttonRemoverExemplar.Location = new Point(445, 438);
            buttonRemoverExemplar.Name = "buttonRemoverExemplar";
            buttonRemoverExemplar.Size = new Size(343, 43);
            buttonRemoverExemplar.TabIndex = 4;
            buttonRemoverExemplar.Text = "Remover";
            buttonRemoverExemplar.UseVisualStyleBackColor = false;
            buttonRemoverExemplar.Click += buttonRemoverExemplar_Click;
            // 
            // buttonAdicionarExemplar
            // 
            buttonAdicionarExemplar.BackColor = Color.Green;
            buttonAdicionarExemplar.Location = new Point(12, 438);
            buttonAdicionarExemplar.Name = "buttonAdicionarExemplar";
            buttonAdicionarExemplar.Size = new Size(343, 43);
            buttonAdicionarExemplar.TabIndex = 3;
            buttonAdicionarExemplar.Text = "Adicionar";
            buttonAdicionarExemplar.UseVisualStyleBackColor = false;
            buttonAdicionarExemplar.Click += buttonAdicionarExemplar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Maplestory", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(559, 26);
            label1.Name = "label1";
            label1.Size = new Size(61, 21);
            label1.TabIndex = 2;
            label1.Text = "label1";
            // 
            // listBoxExemplaresLeitor
            // 
            listBoxExemplaresLeitor.FormattingEnabled = true;
            listBoxExemplaresLeitor.ItemHeight = 15;
            listBoxExemplaresLeitor.Location = new Point(445, 70);
            listBoxExemplaresLeitor.Name = "listBoxExemplaresLeitor";
            listBoxExemplaresLeitor.Size = new Size(343, 349);
            listBoxExemplaresLeitor.TabIndex = 1;
            // 
            // listBoxExemplares
            // 
            listBoxExemplares.FormattingEnabled = true;
            listBoxExemplares.ItemHeight = 15;
            listBoxExemplares.Location = new Point(12, 70);
            listBoxExemplares.Name = "listBoxExemplares";
            listBoxExemplares.Size = new Size(343, 349);
            listBoxExemplares.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Maplestory", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(445, 26);
            label2.Name = "label2";
            label2.Size = new Size(108, 21);
            label2.TabIndex = 5;
            label2.Text = "Coleção de";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Maplestory", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(12, 26);
            label3.Name = "label3";
            label3.Size = new Size(101, 21);
            label3.TabIndex = 6;
            label3.Text = "Biblioteca";
            // 
            // FormAdicionarExemplares
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(808, 492);
            Controls.Add(panel1);
            Name = "FormAdicionarExemplares";
            Text = "FormAdicionarExemplares";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private ListBox listBoxExemplaresLeitor;
        private ListBox listBoxExemplares;
        private Button buttonRemoverExemplar;
        private Button buttonAdicionarExemplar;
        private Label label2;
        private Label label3;
    }
}