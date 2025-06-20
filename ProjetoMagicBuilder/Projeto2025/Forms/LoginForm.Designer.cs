namespace Projeto2025
{
    partial class LoginForm
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
            txtEmail = new TextBox();
            lblEmail = new Label();
            btnEntrar = new Button();
            lnkCadastar = new LinkLabel();
            lblSenha = new Label();
            txtSenha = new TextBox();
            btnSair = new Button();
            SuspendLayout();
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Segoe UI Semilight", 9.75F);
            txtEmail.Location = new Point(78, 85);
            txtEmail.MinimumSize = new Size(0, 33);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(349, 33);
            txtEmail.TabIndex = 0;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(78, 67);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(39, 15);
            lblEmail.TabIndex = 1;
            lblEmail.Text = "Email:";
            // 
            // btnEntrar
            // 
            btnEntrar.Location = new Point(190, 178);
            btnEntrar.Name = "btnEntrar";
            btnEntrar.Size = new Size(100, 42);
            btnEntrar.TabIndex = 2;
            btnEntrar.Text = "Entrar";
            btnEntrar.UseVisualStyleBackColor = true;
            btnEntrar.Click += btnEntrar_Click;
            // 
            // lnkCadastar
            // 
            lnkCadastar.AutoSize = true;
            lnkCadastar.Location = new Point(296, 178);
            lnkCadastar.Name = "lnkCadastar";
            lnkCadastar.Size = new Size(131, 15);
            lnkCadastar.TabIndex = 3;
            lnkCadastar.TabStop = true;
            lnkCadastar.Text = "Não possui uma conta?";
            lnkCadastar.LinkClicked += lnkCadastar_LinkClicked;
            // 
            // lblSenha
            // 
            lblSenha.AutoSize = true;
            lblSenha.Location = new Point(78, 121);
            lblSenha.Name = "lblSenha";
            lblSenha.Size = new Size(42, 15);
            lblSenha.TabIndex = 5;
            lblSenha.Text = "Senha:";
            // 
            // txtSenha
            // 
            txtSenha.Font = new Font("Segoe UI Semilight", 9.75F);
            txtSenha.Location = new Point(78, 139);
            txtSenha.MinimumSize = new Size(0, 33);
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(349, 33);
            txtSenha.TabIndex = 4;
            // 
            // btnSair
            // 
            btnSair.Location = new Point(78, 178);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(100, 42);
            btnSair.TabIndex = 6;
            btnSair.Text = "Sair";
            btnSair.UseVisualStyleBackColor = true;
            btnSair.Click += btnSair_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(504, 241);
            Controls.Add(btnSair);
            Controls.Add(lblSenha);
            Controls.Add(txtSenha);
            Controls.Add(lnkCadastar);
            Controls.Add(btnEntrar);
            Controls.Add(lblEmail);
            Controls.Add(txtEmail);
            Name = "LoginForm";
            Text = "Magic Builder";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtEmail;
        private Label lblEmail;
        private Button btnEntrar;
        private LinkLabel lnkCadastar;
        private Label lblSenha;
        private TextBox txtSenha;
        private Button btnSair;
    }
}
