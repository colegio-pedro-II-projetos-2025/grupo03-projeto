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
            lblResistenciaText = new Label();
            lblManaValue = new Label();
            lblPoderText = new Label();
            lblPoderValue = new Label();
            lblResistenciaValue = new Label();
            lblSlash1 = new Label();
            lblSlash2 = new Label();
            lblTxt = new Label();
            numQuant = new NumericUpDown();
            lblQuant = new Label();
            ((System.ComponentModel.ISupportInitialize)numQuant).BeginInit();
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
            btnAdicionarCarta.Location = new Point(342, 274);
            btnAdicionarCarta.Name = "btnAdicionarCarta";
            btnAdicionarCarta.Size = new Size(86, 42);
            btnAdicionarCarta.TabIndex = 6;
            btnAdicionarCarta.Text = "Adicionar ao Deck";
            btnAdicionarCarta.UseVisualStyleBackColor = true;
            btnAdicionarCarta.Click += btnAdicionarCarta_Click;
            // 
            // btnVoltar
            // 
            btnVoltar.Location = new Point(429, 274);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(86, 42);
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
            lblNome.Location = new Point(284, 27);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(95, 15);
            lblNome.TabIndex = 9;
            lblNome.Text = "(Nome da Carta)";
            // 
            // lblManaText
            // 
            lblManaText.AutoSize = true;
            lblManaText.Location = new Point(466, 27);
            lblManaText.Name = "lblManaText";
            lblManaText.Size = new Size(43, 15);
            lblManaText.TabIndex = 10;
            lblManaText.Text = "Mana: ";
            lblManaText.Click += lblManaText_Click;
            // 
            // lblResistenciaText
            // 
            lblResistenciaText.AutoSize = true;
            lblResistenciaText.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold);
            lblResistenciaText.ForeColor = Color.Red;
            lblResistenciaText.Location = new Point(438, 219);
            lblResistenciaText.Name = "lblResistenciaText";
            lblResistenciaText.Size = new Size(82, 15);
            lblResistenciaText.TabIndex = 12;
            lblResistenciaText.Text = "Resistência: ";
            lblResistenciaText.Click += lblResistenciaText_Click;
            // 
            // lblManaValue
            // 
            lblManaValue.AutoSize = true;
            lblManaValue.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblManaValue.ForeColor = Color.RoyalBlue;
            lblManaValue.Location = new Point(506, 27);
            lblManaValue.Name = "lblManaValue";
            lblManaValue.Size = new Size(14, 15);
            lblManaValue.TabIndex = 13;
            lblManaValue.Text = "0";
            lblManaValue.Click += lblManaValue_Click;
            // 
            // lblPoderText
            // 
            lblPoderText.AutoSize = true;
            lblPoderText.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold);
            lblPoderText.ForeColor = Color.ForestGreen;
            lblPoderText.Location = new Point(388, 219);
            lblPoderText.Name = "lblPoderText";
            lblPoderText.Size = new Size(50, 15);
            lblPoderText.TabIndex = 11;
            lblPoderText.Text = "Poder: ";
            lblPoderText.Click += lblPoderText_Click;
            // 
            // lblPoderValue
            // 
            lblPoderValue.AutoSize = true;
            lblPoderValue.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPoderValue.ForeColor = Color.Red;
            lblPoderValue.Location = new Point(438, 204);
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
            lblResistenciaValue.Location = new Point(418, 204);
            lblResistenciaValue.Name = "lblResistenciaValue";
            lblResistenciaValue.Size = new Size(14, 15);
            lblResistenciaValue.TabIndex = 15;
            lblResistenciaValue.Text = "0";
            // 
            // lblSlash1
            // 
            lblSlash1.AutoSize = true;
            lblSlash1.Location = new Point(429, 204);
            lblSlash1.Name = "lblSlash1";
            lblSlash1.Size = new Size(12, 15);
            lblSlash1.TabIndex = 16;
            lblSlash1.Text = "/";
            lblSlash1.Click += label1_Click;
            // 
            // lblSlash2
            // 
            lblSlash2.AutoSize = true;
            lblSlash2.Location = new Point(429, 219);
            lblSlash2.Name = "lblSlash2";
            lblSlash2.Size = new Size(12, 15);
            lblSlash2.TabIndex = 17;
            lblSlash2.Text = "/";
            lblSlash2.Click += lblSlash2_Click;
            // 
            // lblTxt
            // 
            lblTxt.AutoSize = true;
            lblTxt.Location = new Point(284, 42);
            lblTxt.MaximumSize = new Size(230, 165);
            lblTxt.Name = "lblTxt";
            lblTxt.Size = new Size(90, 15);
            lblTxt.TabIndex = 18;
            lblTxt.Text = "(Texto da Carta)";
            // 
            // numQuant
            // 
            numQuant.Location = new Point(284, 293);
            numQuant.Maximum = new decimal(new int[] { 99, 0, 0, 0 });
            numQuant.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numQuant.Name = "numQuant";
            numQuant.Size = new Size(56, 23);
            numQuant.TabIndex = 19;
            numQuant.Value = new decimal(new int[] { 1, 0, 0, 0 });
            numQuant.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // lblQuant
            // 
            lblQuant.AutoSize = true;
            lblQuant.Location = new Point(284, 275);
            lblQuant.Name = "lblQuant";
            lblQuant.Size = new Size(56, 15);
            lblQuant.TabIndex = 20;
            lblQuant.Text = "Quantas?";
            lblQuant.Click += lblQuant_Click;
            // 
            // AdicionarCartaForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(521, 330);
            Controls.Add(lblQuant);
            Controls.Add(numQuant);
            Controls.Add(lblTxt);
            Controls.Add(lblSlash2);
            Controls.Add(lblSlash1);
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
            ((System.ComponentModel.ISupportInitialize)numQuant).EndInit();
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
        private Label lblResistenciaText;
        private Label lblManaValue;
        private Label lblPoderText;
        private Label lblPoderValue;
        private Label lblResistenciaValue;
        private Label lblSlash1;
        private Label lblSlash2;
        private Label lblTxt;
        private NumericUpDown numQuant;
        private Label lblQuant;
    }
}