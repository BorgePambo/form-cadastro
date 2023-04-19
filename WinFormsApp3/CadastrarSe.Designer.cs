namespace WinFormsApp3
{
    partial class CadastrarSe
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
            txtEmail = new TextBox();
            txtSenha = new TextBox();
            txtConfSenha = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(124, 131);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(166, 23);
            txtEmail.TabIndex = 0;
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(124, 199);
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(166, 23);
            txtSenha.TabIndex = 1;
            // 
            // txtConfSenha
            // 
            txtConfSenha.Location = new Point(124, 273);
            txtConfSenha.Name = "txtConfSenha";
            txtConfSenha.Size = new Size(166, 23);
            txtConfSenha.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calisto MT", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(124, 100);
            label1.Name = "label1";
            label1.Size = new Size(41, 15);
            label1.TabIndex = 3;
            label1.Text = "Email";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Calisto MT", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(124, 172);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 4;
            label2.Text = "Senha";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Calisto MT", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(125, 250);
            label3.Name = "label3";
            label3.Size = new Size(101, 15);
            label3.TabIndex = 5;
            label3.Text = "Confirmar Senha";
            // 
            // button1
            // 
            button1.Font = new Font("Calisto MT", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(166, 345);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 6;
            button1.Text = "Cadastrar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // CadastrarSe
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(393, 450);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtConfSenha);
            Controls.Add(txtSenha);
            Controls.Add(txtEmail);
            Name = "CadastrarSe";
            Text = "CadastrarSe";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtEmail;
        private TextBox txtSenha;
        private TextBox txtConfSenha;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button button1;
    }
}