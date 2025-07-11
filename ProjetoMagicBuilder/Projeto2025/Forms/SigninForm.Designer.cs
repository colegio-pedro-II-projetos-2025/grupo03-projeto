﻿namespace Projeto2025.Forms
{
    partial class SigninForm
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
            lblSenha = new Label();
            txtSenha = new TextBox();
            lblEmail = new Label();
            txtEmail = new TextBox();
            lblConfirmarSenha = new Label();
            txtConfirmarSenha = new TextBox();
            lblNome = new Label();
            txtNome = new TextBox();
            btnVoltar = new Button();
            btnCadastrar = new Button();
            lblErro = new Label();
            SuspendLayout();
            // 
            // lblSenha
            // 
            lblSenha.AutoSize = true;
            lblSenha.Location = new Point(80, 147);
            lblSenha.Name = "lblSenha";
            lblSenha.Size = new Size(42, 15);
            lblSenha.TabIndex = 9;
            lblSenha.Text = "Senha:";
            // 
            // txtSenha
            // 
            txtSenha.Font = new Font("Segoe UI Semilight", 9.75F);
            txtSenha.Location = new Point(80, 165);
            txtSenha.MinimumSize = new Size(0, 33);
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(349, 33);
            txtSenha.TabIndex = 8;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(80, 93);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(39, 15);
            lblEmail.TabIndex = 7;
            lblEmail.Text = "Email:";
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Segoe UI Semilight", 9.75F);
            txtEmail.Location = new Point(80, 111);
            txtEmail.MinimumSize = new Size(0, 33);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(349, 33);
            txtEmail.TabIndex = 10;
            // 
            // lblConfirmarSenha
            // 
            lblConfirmarSenha.AutoSize = true;
            lblConfirmarSenha.Location = new Point(81, 201);
            lblConfirmarSenha.Name = "lblConfirmarSenha";
            lblConfirmarSenha.Size = new Size(99, 15);
            lblConfirmarSenha.TabIndex = 13;
            lblConfirmarSenha.Text = "Confirmar Senha:";
            // 
            // txtConfirmarSenha
            // 
            txtConfirmarSenha.Font = new Font("Segoe UI Semilight", 9.75F);
            txtConfirmarSenha.Location = new Point(81, 219);
            txtConfirmarSenha.MinimumSize = new Size(0, 33);
            txtConfirmarSenha.Name = "txtConfirmarSenha";
            txtConfirmarSenha.Size = new Size(349, 33);
            txtConfirmarSenha.TabIndex = 12;
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Location = new Point(80, 39);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(102, 15);
            lblNome.TabIndex = 11;
            lblNome.Text = "Nome de Usuário:";
            // 
            // txtNome
            // 
            txtNome.Font = new Font("Segoe UI Semilight", 9.75F);
            txtNome.Location = new Point(80, 57);
            txtNome.MinimumSize = new Size(0, 33);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(349, 33);
            txtNome.TabIndex = 6;
            // 
            // btnVoltar
            // 
            btnVoltar.Location = new Point(82, 258);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(100, 42);
            btnVoltar.TabIndex = 15;
            btnVoltar.Text = "Voltar";
            btnVoltar.UseVisualStyleBackColor = true;
            btnVoltar.Click += btnVoltar_Click;
            // 
            // btnCadastrar
            // 
            btnCadastrar.Location = new Point(188, 258);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(100, 42);
            btnCadastrar.TabIndex = 14;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.UseVisualStyleBackColor = true;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // lblErro
            // 
            lblErro.AutoSize = true;
            lblErro.ForeColor = Color.Red;
            lblErro.Location = new Point(292, 258);
            lblErro.Name = "lblErro";
            lblErro.Size = new Size(0, 15);
            lblErro.TabIndex = 16;
            // 
            // SigninForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(504, 337);
            Controls.Add(lblErro);
            Controls.Add(btnVoltar);
            Controls.Add(btnCadastrar);
            Controls.Add(lblConfirmarSenha);
            Controls.Add(txtConfirmarSenha);
            Controls.Add(lblNome);
            Controls.Add(txtNome);
            Controls.Add(lblSenha);
            Controls.Add(txtSenha);
            Controls.Add(lblEmail);
            Controls.Add(txtEmail);
            ForeColor = SystemColors.ControlText;
            Name = "SigninForm";
            Text = "Cadastrar";
            Load += SigninForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblSenha;
        private TextBox txtSenha;
        private Label lblEmail;
        private TextBox txtEmail;
        private Label lblConfirmarSenha;
        private TextBox txtConfirmarSenha;
        private Label lblNome;
        private TextBox txtNome;
        private Button btnVoltar;
        private Button btnCadastrar;
        private Label lblErro;
    }
}