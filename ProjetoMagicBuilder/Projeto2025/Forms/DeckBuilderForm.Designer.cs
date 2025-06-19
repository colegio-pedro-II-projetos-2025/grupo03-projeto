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
            btnRetornarDeck = new Button();
            btnSair = new Button();
            SuspendLayout();
            // 
            // btnProximoDeck
            // 
            btnProximoDeck.Location = new Point(110, 289);
            btnProximoDeck.Name = "btnProximoDeck";
            btnProximoDeck.Size = new Size(60, 60);
            btnProximoDeck.TabIndex = 1;
            btnProximoDeck.Text = "button1";
            btnProximoDeck.UseVisualStyleBackColor = true;
            // 
            // lblNomeDeck
            // 
            lblNomeDeck.AutoSize = true;
            lblNomeDeck.Location = new Point(12, 9);
            lblNomeDeck.Name = "lblNomeDeck";
            lblNomeDeck.Size = new Size(93, 15);
            lblNomeDeck.TabIndex = 1;
            lblNomeDeck.Text = "(Nome do deck)";
            // 
            // lstDeck
            // 
            lstDeck.FormattingEnabled = true;
            lstDeck.ItemHeight = 15;
            lstDeck.Location = new Point(12, 27);
            lstDeck.Name = "lstDeck";
            lstDeck.Size = new Size(234, 334);
            lstDeck.TabIndex = 0;
            // 
            // btnRetornarDeck
            // 
            btnRetornarDeck.Location = new Point(176, 289);
            btnRetornarDeck.Name = "btnRetornarDeck";
            btnRetornarDeck.Size = new Size(60, 60);
            btnRetornarDeck.TabIndex = 3;
            btnRetornarDeck.Text = "button2";
            btnRetornarDeck.UseVisualStyleBackColor = true;
            // 
            // btnSair
            // 
            btnSair.Location = new Point(507, 319);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(100, 42);
            btnSair.TabIndex = 4;
            btnSair.Text = "Sair";
            btnSair.UseVisualStyleBackColor = true;
            btnSair.Click += btnSair_Click;
            // 
            // DeckBuilderForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(623, 378);
            Controls.Add(btnProximoDeck);
            Controls.Add(btnSair);
            Controls.Add(btnRetornarDeck);
            Controls.Add(lstDeck);
            Controls.Add(lblNomeDeck);
            Name = "DeckBuilderForm";
            Text = "DeckBuilderForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnProximoDeck;
        private Label lblNomeDeck;
        private ListBox lstDeck;
        private Button btnRetornarDeck;
        private Button btnSair;
    }
}