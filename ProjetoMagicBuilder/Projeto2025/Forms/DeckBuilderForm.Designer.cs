namespace Projeto2025.Forms
{
    partial class DeckBuilderForm
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
            btnProximoDeck = new Button();
            lblNomeDeck = new Label();
            lstDeck = new ListBox();
            btnAnteriorDeck = new Button();
            btnSair = new Button();
            btnAdicionarDeck = new Button();
            lblNumeroDeck = new Label();
            btnAdicionarCarta = new Button();
            txtAdicionarDeck = new TextBox();
            lblAdicionarDeck = new Label();
            btnExcluirDeck = new Button();
            btnColapsarDuplicatas = new Button();
            lblTxt = new Label();
            lblSlash2 = new Label();
            lblSlash1 = new Label();
            lblResistenciaValue = new Label();
            lblPoderValue = new Label();
            lblManaValue = new Label();
            lblResistenciaText = new Label();
            lblPoderText = new Label();
            lblManaText = new Label();
            lblNome = new Label();
            lblQuantidade = new Label();
            SuspendLayout();
            // 
            // btnProximoDeck
            // 
            btnProximoDeck.Location = new Point(12, 336);
            btnProximoDeck.Name = "btnProximoDeck";
            btnProximoDeck.Size = new Size(60, 30);
            btnProximoDeck.TabIndex = 1;
            btnProximoDeck.Text = "<<";
            btnProximoDeck.UseVisualStyleBackColor = true;
            btnProximoDeck.Click += btnProximoDeck_Click;
            // 
            // lblNomeDeck
            // 
            lblNomeDeck.AutoSize = true;
            lblNomeDeck.Location = new Point(12, 17);
            lblNomeDeck.Name = "lblNomeDeck";
            lblNomeDeck.Size = new Size(93, 15);
            lblNomeDeck.TabIndex = 1;
            lblNomeDeck.Text = "(Nome do deck)";
            // 
            // lstDeck
            // 
            lstDeck.FormattingEnabled = true;
            lstDeck.ItemHeight = 15;
            lstDeck.Location = new Point(12, 35);
            lstDeck.Name = "lstDeck";
            lstDeck.Size = new Size(265, 289);
            lstDeck.TabIndex = 0;
            lstDeck.SelectedIndexChanged += lstDeck_SelectedIndexChanged;
            // 
            // btnAnteriorDeck
            // 
            btnAnteriorDeck.Location = new Point(151, 336);
            btnAnteriorDeck.Name = "btnAnteriorDeck";
            btnAnteriorDeck.Size = new Size(60, 30);
            btnAnteriorDeck.TabIndex = 3;
            btnAnteriorDeck.Text = ">>";
            btnAnteriorDeck.UseVisualStyleBackColor = true;
            btnAnteriorDeck.Click += btnAnteriorDeck_Click;
            // 
            // btnSair
            // 
            btnSair.Location = new Point(400, 324);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(100, 42);
            btnSair.TabIndex = 4;
            btnSair.Text = "Sair";
            btnSair.UseVisualStyleBackColor = true;
            btnSair.Click += btnSair_Click;
            // 
            // btnAdicionarDeck
            // 
            btnAdicionarDeck.Location = new Point(294, 324);
            btnAdicionarDeck.Name = "btnAdicionarDeck";
            btnAdicionarDeck.Size = new Size(100, 42);
            btnAdicionarDeck.TabIndex = 5;
            btnAdicionarDeck.Text = "Adicionar Deck";
            btnAdicionarDeck.UseVisualStyleBackColor = true;
            btnAdicionarDeck.Click += btnAdicionarDeck_Click;
            // 
            // lblNumeroDeck
            // 
            lblNumeroDeck.AutoSize = true;
            lblNumeroDeck.Location = new Point(78, 344);
            lblNumeroDeck.Name = "lblNumeroDeck";
            lblNumeroDeck.Size = new Size(67, 15);
            lblNumeroDeck.TabIndex = 6;
            lblNumeroDeck.Text = "Deck 0 de 0";
            // 
            // btnAdicionarCarta
            // 
            btnAdicionarCarta.Location = new Point(187, 292);
            btnAdicionarCarta.Name = "btnAdicionarCarta";
            btnAdicionarCarta.Size = new Size(85, 27);
            btnAdicionarCarta.TabIndex = 7;
            btnAdicionarCarta.Text = "Adicionar...";
            btnAdicionarCarta.UseVisualStyleBackColor = true;
            btnAdicionarCarta.Click += btnAdicionarCarta_Click;
            // 
            // txtAdicionarDeck
            // 
            txtAdicionarDeck.Location = new Point(294, 293);
            txtAdicionarDeck.Name = "txtAdicionarDeck";
            txtAdicionarDeck.Size = new Size(206, 23);
            txtAdicionarDeck.TabIndex = 8;
            // 
            // lblAdicionarDeck
            // 
            lblAdicionarDeck.AutoSize = true;
            lblAdicionarDeck.Location = new Point(294, 275);
            lblAdicionarDeck.Name = "lblAdicionarDeck";
            lblAdicionarDeck.Size = new Size(89, 15);
            lblAdicionarDeck.TabIndex = 9;
            lblAdicionarDeck.Text = "Nome do Deck:";
            // 
            // btnExcluirDeck
            // 
            btnExcluirDeck.Location = new Point(217, 336);
            btnExcluirDeck.Name = "btnExcluirDeck";
            btnExcluirDeck.Size = new Size(60, 30);
            btnExcluirDeck.TabIndex = 10;
            btnExcluirDeck.Text = "Excluir";
            btnExcluirDeck.UseVisualStyleBackColor = true;
            btnExcluirDeck.Click += btnExcluirDeck_Click;
            // 
            // btnColapsarDuplicatas
            // 
            btnColapsarDuplicatas.Location = new Point(151, 259);
            btnColapsarDuplicatas.Name = "btnColapsarDuplicatas";
            btnColapsarDuplicatas.Size = new Size(121, 27);
            btnColapsarDuplicatas.TabIndex = 11;
            btnColapsarDuplicatas.Text = "Colapsar Duplicatas";
            btnColapsarDuplicatas.UseVisualStyleBackColor = true;
            btnColapsarDuplicatas.Click += btnColapsarDuplicatas_Click;
            // 
            // lblTxt
            // 
            lblTxt.AutoSize = true;
            lblTxt.Location = new Point(286, 51);
            lblTxt.MaximumSize = new Size(230, 165);
            lblTxt.Name = "lblTxt";
            lblTxt.Size = new Size(90, 15);
            lblTxt.TabIndex = 28;
            lblTxt.Text = "(Texto da Carta)";
            // 
            // lblSlash2
            // 
            lblSlash2.AutoSize = true;
            lblSlash2.Location = new Point(431, 228);
            lblSlash2.Name = "lblSlash2";
            lblSlash2.Size = new Size(12, 15);
            lblSlash2.TabIndex = 27;
            lblSlash2.Text = "/";
            // 
            // lblSlash1
            // 
            lblSlash1.AutoSize = true;
            lblSlash1.Location = new Point(431, 213);
            lblSlash1.Name = "lblSlash1";
            lblSlash1.Size = new Size(12, 15);
            lblSlash1.TabIndex = 26;
            lblSlash1.Text = "/";
            // 
            // lblResistenciaValue
            // 
            lblResistenciaValue.AutoSize = true;
            lblResistenciaValue.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblResistenciaValue.ForeColor = Color.ForestGreen;
            lblResistenciaValue.Location = new Point(420, 213);
            lblResistenciaValue.Name = "lblResistenciaValue";
            lblResistenciaValue.Size = new Size(14, 15);
            lblResistenciaValue.TabIndex = 25;
            lblResistenciaValue.Text = "0";
            // 
            // lblPoderValue
            // 
            lblPoderValue.AutoSize = true;
            lblPoderValue.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPoderValue.ForeColor = Color.Red;
            lblPoderValue.Location = new Point(440, 213);
            lblPoderValue.Name = "lblPoderValue";
            lblPoderValue.Size = new Size(14, 15);
            lblPoderValue.TabIndex = 24;
            lblPoderValue.Text = "0";
            // 
            // lblManaValue
            // 
            lblManaValue.AutoSize = true;
            lblManaValue.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblManaValue.ForeColor = Color.RoyalBlue;
            lblManaValue.Location = new Point(508, 36);
            lblManaValue.Name = "lblManaValue";
            lblManaValue.Size = new Size(14, 15);
            lblManaValue.TabIndex = 23;
            lblManaValue.Text = "0";
            // 
            // lblResistenciaText
            // 
            lblResistenciaText.AutoSize = true;
            lblResistenciaText.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold);
            lblResistenciaText.ForeColor = Color.Red;
            lblResistenciaText.Location = new Point(440, 228);
            lblResistenciaText.Name = "lblResistenciaText";
            lblResistenciaText.Size = new Size(82, 15);
            lblResistenciaText.TabIndex = 22;
            lblResistenciaText.Text = "Resistência: ";
            // 
            // lblPoderText
            // 
            lblPoderText.AutoSize = true;
            lblPoderText.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold);
            lblPoderText.ForeColor = Color.ForestGreen;
            lblPoderText.Location = new Point(390, 228);
            lblPoderText.Name = "lblPoderText";
            lblPoderText.Size = new Size(50, 15);
            lblPoderText.TabIndex = 21;
            lblPoderText.Text = "Poder: ";
            // 
            // lblManaText
            // 
            lblManaText.AutoSize = true;
            lblManaText.Location = new Point(468, 36);
            lblManaText.Name = "lblManaText";
            lblManaText.Size = new Size(43, 15);
            lblManaText.TabIndex = 20;
            lblManaText.Text = "Mana: ";
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Location = new Point(286, 36);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(95, 15);
            lblNome.TabIndex = 19;
            lblNome.Text = "(Nome da Carta)";
            // 
            // lblQuantidade
            // 
            lblQuantidade.AutoSize = true;
            lblQuantidade.Location = new Point(283, 213);
            lblQuantidade.Name = "lblQuantidade";
            lblQuantidade.Size = new Size(72, 15);
            lblQuantidade.TabIndex = 29;
            lblQuantidade.Text = "Quantidade:";
            // 
            // DeckBuilderForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(524, 378);
            Controls.Add(lblQuantidade);
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
            Controls.Add(btnColapsarDuplicatas);
            Controls.Add(btnExcluirDeck);
            Controls.Add(lblAdicionarDeck);
            Controls.Add(txtAdicionarDeck);
            Controls.Add(btnAdicionarCarta);
            Controls.Add(lblNumeroDeck);
            Controls.Add(btnAdicionarDeck);
            Controls.Add(btnProximoDeck);
            Controls.Add(btnSair);
            Controls.Add(btnAnteriorDeck);
            Controls.Add(lstDeck);
            Controls.Add(lblNomeDeck);
            Name = "DeckBuilderForm";
            Text = "Deck Builder";
            Load += DeckBuilderForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnProximoDeck;
        private Label lblNomeDeck;
        private ListBox lstDeck;
        private Button btnAnteriorDeck;
        private Button btnSair;
        private Button btnAdicionarDeck;
        private Label lblNumeroDeck;
        private Button btnAdicionarCarta;
        private TextBox txtAdicionarDeck;
        private Label lblAdicionarDeck;
        private Button btnExcluirDeck;
        private Button btnColapsarDuplicatas;
        private Label lblTxt;
        private Label lblSlash2;
        private Label lblSlash1;
        private Label lblResistenciaValue;
        private Label lblPoderValue;
        private Label lblManaValue;
        private Label lblResistenciaText;
        private Label lblPoderText;
        private Label lblManaText;
        private Label lblNome;
        private Label lblQuantidade;
    }
}