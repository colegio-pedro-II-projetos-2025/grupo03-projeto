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
            // DeckBuilderForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(524, 378);
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
    }
}