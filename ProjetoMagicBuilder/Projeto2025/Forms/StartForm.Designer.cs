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
            btnDeckBuilder = new Button();
            btnCartaAleatoria = new Button();
            btnSair = new Button();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(140, 32);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(343, 65);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Magic Builder";
            // 
            // btnDeckBuilder
            // 
            btnDeckBuilder.Location = new Point(211, 100);
            btnDeckBuilder.Name = "btnDeckBuilder";
            btnDeckBuilder.Size = new Size(189, 45);
            btnDeckBuilder.TabIndex = 1;
            btnDeckBuilder.Text = "Deck Builder";
            btnDeckBuilder.UseVisualStyleBackColor = true;
            btnDeckBuilder.Click += btnDeckBuilder_Click;
            // 
            // btnCartaAleatoria
            // 
            btnCartaAleatoria.Location = new Point(211, 151);
            btnCartaAleatoria.Name = "btnCartaAleatoria";
            btnCartaAleatoria.Size = new Size(189, 45);
            btnCartaAleatoria.TabIndex = 2;
            btnCartaAleatoria.Text = "Carta Aleatória";
            btnCartaAleatoria.UseVisualStyleBackColor = true;
            btnCartaAleatoria.Click += btnCartaAleatoria_Click;
            // 
            // btnSair
            // 
            btnSair.Location = new Point(211, 202);
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
            Controls.Add(btnCartaAleatoria);
            Controls.Add(btnDeckBuilder);
            Controls.Add(lblTitulo);
            Name = "StartForm";
            Text = "Magic Builder";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private Button btnDeckBuilder;
        private Button btnCartaAleatoria;
        private Button btnSair;
    }
}