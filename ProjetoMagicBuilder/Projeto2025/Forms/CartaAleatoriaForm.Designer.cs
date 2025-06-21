namespace Projeto2025.Forms
{
    partial class CartaAleatoriaForm
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
            btnEnviar = new Button();
            btnComecar = new Button();
            btnParar = new Button();
            lblDescricao = new Label();
            lblPontuacao = new Label();
            txtNome = new TextBox();
            lstTentativa = new ListBox();
            lblInfo = new Label();
            SuspendLayout();
            // 
            // btnEnviar
            // 
            btnEnviar.Location = new Point(200, 36);
            btnEnviar.Name = "btnEnviar";
            btnEnviar.Size = new Size(49, 23);
            btnEnviar.TabIndex = 0;
            btnEnviar.Text = "Enviar";
            btnEnviar.UseVisualStyleBackColor = true;
            btnEnviar.Click += btnEnviar_Click;
            // 
            // btnComecar
            // 
            btnComecar.Location = new Point(12, 64);
            btnComecar.Name = "btnComecar";
            btnComecar.Size = new Size(74, 23);
            btnComecar.TabIndex = 1;
            btnComecar.Text = "Começar";
            btnComecar.UseVisualStyleBackColor = true;
            btnComecar.Click += btnComecar_Click;
            // 
            // btnParar
            // 
            btnParar.Location = new Point(92, 64);
            btnParar.Name = "btnParar";
            btnParar.Size = new Size(74, 23);
            btnParar.TabIndex = 2;
            btnParar.Text = "Parar";
            btnParar.UseVisualStyleBackColor = true;
            btnParar.Click += btnParar_Click;
            // 
            // lblDescricao
            // 
            lblDescricao.AutoSize = true;
            lblDescricao.Location = new Point(272, 17);
            lblDescricao.Name = "lblDescricao";
            lblDescricao.Size = new Size(111, 15);
            lblDescricao.TabIndex = 3;
            lblDescricao.Text = "Descrição da Carta: ";
            // 
            // lblPontuacao
            // 
            lblPontuacao.AutoSize = true;
            lblPontuacao.Location = new Point(12, 17);
            lblPontuacao.Name = "lblPontuacao";
            lblPontuacao.Size = new Size(93, 15);
            lblPontuacao.TabIndex = 4;
            lblPontuacao.Text = "Pontuação: 0 / 0";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(12, 36);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(182, 23);
            txtNome.TabIndex = 5;
            // 
            // lstTentativa
            // 
            lstTentativa.FormattingEnabled = true;
            lstTentativa.ItemHeight = 15;
            lstTentativa.Location = new Point(12, 113);
            lstTentativa.Name = "lstTentativa";
            lstTentativa.Size = new Size(410, 154);
            lstTentativa.TabIndex = 6;
            lstTentativa.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // lblInfo
            // 
            lblInfo.AutoSize = true;
            lblInfo.Location = new Point(12, 246);
            lblInfo.Name = "lblInfo";
            lblInfo.Size = new Size(0, 15);
            lblInfo.TabIndex = 7;
            // 
            // CartaAleatoriaForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(564, 279);
            Controls.Add(lblInfo);
            Controls.Add(lstTentativa);
            Controls.Add(txtNome);
            Controls.Add(lblPontuacao);
            Controls.Add(lblDescricao);
            Controls.Add(btnParar);
            Controls.Add(btnComecar);
            Controls.Add(btnEnviar);
            Name = "CartaAleatoriaForm";
            Text = "Carta Aleatória";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnEnviar;
        private Button btnComecar;
        private Button btnParar;
        private Label lblDescricao;
        private Label lblPontuacao;
        private TextBox txtNome;
        private ListBox lstTentativa;
        private Label lblInfo;
    }
}