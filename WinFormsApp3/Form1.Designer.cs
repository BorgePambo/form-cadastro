namespace WinFormsApp3
{
    partial class Form1
    {
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
            label1 = new Label();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            txtEmail = new TextBox();
            txtSenha = new TextBox();
            button1 = new Button();
            button2 = new Button();
            btnCadastrar = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calisto MT", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(197, 108);
            label1.Name = "label1";
            label1.Size = new Size(41, 15);
            label1.TabIndex = 0;
            label1.Text = "Email";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Calisto MT", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(197, 188);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 1;
            label2.Text = "Senha";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.ActiveBorder;
            pictureBox1.Location = new Point(46, 91);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(117, 133);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(261, 105);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(165, 23);
            txtEmail.TabIndex = 3;
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(261, 180);
            txtSenha.Name = "txtSenha";
            txtSenha.PasswordChar = '*';
            txtSenha.Size = new Size(165, 23);
            txtSenha.TabIndex = 4;
            // 
            // button1
            // 
            button1.Font = new Font("Calisto MT", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(261, 232);
            button1.Name = "button1";
            button1.Size = new Size(63, 23);
            button1.TabIndex = 5;
            button1.Text = "Entrar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Calisto MT", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(362, 232);
            button2.Name = "button2";
            button2.Size = new Size(64, 23);
            button2.TabIndex = 6;
            button2.Text = "Sair";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // btnCadastrar
            // 
            btnCadastrar.Font = new Font("Calisto MT", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnCadastrar.Location = new Point(308, 271);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(75, 23);
            btnCadastrar.TabIndex = 7;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.UseVisualStyleBackColor = true;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(488, 353);
            Controls.Add(btnCadastrar);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(txtSenha);
            Controls.Add(txtEmail);
            Controls.Add(pictureBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private PictureBox pictureBox1;
        private TextBox txtEmail;
        private TextBox txtSenha;
        private Button button1;
        private Button button2;
        private Button btnCadastrar;
    }
}