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
            label1 = new Label();
            button2 = new Button();
            button1 = new Button();
            label2 = new Label();
            label3 = new Label();
            panel1.SuspendLayout();
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
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1670, 892);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Button button2;
        private Button button1;
        private Label label2;
        private Label label3;
    }
}
