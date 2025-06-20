namespace Projeto2025.Forms
{
    partial class AdicionarCartaForm
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
            lstCartas = new ListBox();
            lblCartas = new Label();
            btnAdicionarCarta = new Button();
            btnVoltar = new Button();
            lblAdicionado = new Label();
            lblNome = new Label();
            lblManaText = new Label();
            lblPoderText = new Label();
            lblResistenciaText = new Label();
            lblManaValue = new Label();
            lblPoderValue = new Label();
            lblResistenciaValue = new Label();
            SuspendLayout();
            // 
            // lstCartas
            // 
            lstCartas.FormattingEnabled = true;
            lstCartas.ItemHeight = 15;
            lstCartas.Location = new Point(12, 27);
            lstCartas.Name = "lstCartas";
            lstCartas.Size = new Size(265, 289);
            lstCartas.TabIndex = 1;
            lstCartas.SelectedIndexChanged += lstCartas_SelectedIndexChanged;
            // 
            // lblCartas
            // 
            lblCartas.AutoSize = true;
            lblCartas.Location = new Point(12, 9);
            lblCartas.Name = "lblCartas";
            lblCartas.Size = new Size(43, 15);
            lblCartas.TabIndex = 2;
            lblCartas.Text = "Cartas:";
            // 
            // btnAdicionarCarta
            // 
            btnAdicionarCarta.Location = new Point(283, 276);
            btnAdicionarCarta.Name = "btnAdicionarCarta";
            btnAdicionarCarta.Size = new Size(100, 42);
            btnAdicionarCarta.TabIndex = 6;
            btnAdicionarCarta.Text = "Adicionar ao Deck";
            btnAdicionarCarta.UseVisualStyleBackColor = true;
            btnAdicionarCarta.Click += btnAdicionarCarta_Click;
            // 
            // btnVoltar
            // 
            btnVoltar.Location = new Point(389, 276);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(100, 42);
            btnVoltar.TabIndex = 7;
            btnVoltar.Text = "Voltar";
            btnVoltar.UseCompatibleTextRendering = true;
            btnVoltar.UseVisualStyleBackColor = true;
            btnVoltar.Click += btnVoltar_Click;
            // 
            // lblAdicionado
            // 
            lblAdicionado.AutoSize = true;
            lblAdicionado.Location = new Point(283, 258);
            lblAdicionado.Name = "lblAdicionado";
            lblAdicionado.Size = new Size(0, 15);
            lblAdicionado.TabIndex = 8;
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Location = new Point(284, 159);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(95, 15);
            lblNome.TabIndex = 9;
            lblNome.Text = "(Nome da Carta)";
            // 
            // lblManaText
            // 
            lblManaText.AutoSize = true;
            lblManaText.Location = new Point(284, 174);
            lblManaText.Name = "lblManaText";
            lblManaText.Size = new Size(43, 15);
            lblManaText.TabIndex = 10;
            lblManaText.Text = "Mana: ";
            // 
            // lblPoderText
            // 
            lblPoderText.AutoSize = true;
            lblPoderText.Location = new Point(284, 189);
            lblPoderText.Name = "lblPoderText";
            lblPoderText.Size = new Size(44, 15);
            lblPoderText.TabIndex = 11;
            lblPoderText.Text = "Poder: ";
            // 
            // lblResistenciaText
            // 
            lblResistenciaText.AutoSize = true;
            lblResistenciaText.Location = new Point(284, 204);
            lblResistenciaText.Name = "lblResistenciaText";
            lblResistenciaText.Size = new Size(71, 15);
            lblResistenciaText.TabIndex = 12;
            lblResistenciaText.Text = "Resistência: ";
            // 
            // lblManaValue
            // 
            lblManaValue.AutoSize = true;
            lblManaValue.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblManaValue.ForeColor = Color.RoyalBlue;
            lblManaValue.Location = new Point(353, 174);
            lblManaValue.Name = "lblManaValue";
            lblManaValue.Size = new Size(14, 15);
            lblManaValue.TabIndex = 13;
            lblManaValue.Text = "0";
            // 
            // lblPoderValue
            // 
            lblPoderValue.AutoSize = true;
            lblPoderValue.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPoderValue.ForeColor = Color.Red;
            lblPoderValue.Location = new Point(353, 189);
            lblPoderValue.Name = "lblPoderValue";
            lblPoderValue.Size = new Size(14, 15);
            lblPoderValue.TabIndex = 14;
            lblPoderValue.Text = "0";
            // 
            // lblResistenciaValue
            // 
            lblResistenciaValue.AutoSize = true;
            lblResistenciaValue.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblResistenciaValue.ForeColor = Color.ForestGreen;
            lblResistenciaValue.Location = new Point(353, 204);
            lblResistenciaValue.Name = "lblResistenciaValue";
            lblResistenciaValue.Size = new Size(14, 15);
            lblResistenciaValue.TabIndex = 15;
            lblResistenciaValue.Text = "0";
            // 
            // AdicionarCartaForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(497, 330);
            Controls.Add(lblResistenciaValue);
            Controls.Add(lblPoderValue);
            Controls.Add(lblManaValue);
            Controls.Add(lblResistenciaText);
            Controls.Add(lblPoderText);
            Controls.Add(lblManaText);
            Controls.Add(lblNome);
            Controls.Add(lblAdicionado);
            Controls.Add(btnVoltar);
            Controls.Add(btnAdicionarCarta);
            Controls.Add(lblCartas);
            Controls.Add(lstCartas);
            Name = "AdicionarCartaForm";
            Text = "Adicionar Carta";
            Load += AdicionarCartaForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lstCartas;
        private Label lblCartas;
        private Button btnAdicionarCarta;
        private Button btnVoltar;
        private Label lblAdicionado;
        private Label lblNome;
        private Label lblManaText;
        private Label lblPoderText;
        private Label lblResistenciaText;
        private Label lblManaValue;
        private Label lblPoderValue;
        private Label lblResistenciaValue;
    }
}