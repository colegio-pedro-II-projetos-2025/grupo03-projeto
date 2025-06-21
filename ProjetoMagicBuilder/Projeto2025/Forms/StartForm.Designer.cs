namespace Projeto2025.Forms
{
    partial class StartForm
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
            lblTitulo = new Label();
            btnLogin = new Button();
            btnSair = new Button();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(139, 39);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(343, 65);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Magic Builder";
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(211, 138);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(189, 45);
            btnLogin.TabIndex = 1;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnDeckBuilder_Click;
            // 
            // btnSair
            // 
            btnSair.Location = new Point(211, 189);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(189, 45);
            btnSair.TabIndex = 3;
            btnSair.Text = "Sair";
            btnSair.UseVisualStyleBackColor = true;
            btnSair.Click += btnSair_Click;
            // 
            // StartForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(609, 312);
            Controls.Add(btnSair);
            Controls.Add(btnLogin);
            Controls.Add(lblTitulo);
            Name = "StartForm";
            Text = "Magic Builder";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private Button btnLogin;
        private Button btnSair;
    }
}