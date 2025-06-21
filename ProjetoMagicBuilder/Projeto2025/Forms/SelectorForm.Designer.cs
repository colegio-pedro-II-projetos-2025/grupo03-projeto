﻿namespace Projeto2025.Forms
{
    partial class SelectorForm
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
            lblInfo = new Label();
            btnDeckBuilder = new Button();
            btnCartaAleatoria = new Button();
            SuspendLayout();
            // 
            // lblInfo
            // 
            lblInfo.AutoSize = true;
            lblInfo.Location = new Point(12, 9);
            lblInfo.Name = "lblInfo";
            lblInfo.Size = new Size(149, 15);
            lblInfo.TabIndex = 0;
            lblInfo.Text = "Selecione o Modo de Jogo.";
            // 
            // btnDeckBuilder
            // 
            btnDeckBuilder.Location = new Point(125, 124);
            btnDeckBuilder.Name = "btnDeckBuilder";
            btnDeckBuilder.Size = new Size(189, 45);
            btnDeckBuilder.TabIndex = 5;
            btnDeckBuilder.Text = "Deck Builder";
            btnDeckBuilder.UseVisualStyleBackColor = true;
            btnDeckBuilder.Click += btnDeckBuilder_Click;
            // 
            // btnCartaAleatoria
            // 
            btnCartaAleatoria.Location = new Point(125, 73);
            btnCartaAleatoria.Name = "btnCartaAleatoria";
            btnCartaAleatoria.Size = new Size(189, 45);
            btnCartaAleatoria.TabIndex = 4;
            btnCartaAleatoria.Text = "Carta Aleatória";
            btnCartaAleatoria.UseVisualStyleBackColor = true;
            btnCartaAleatoria.Click += btnCartaAleatoria_Click;
            // 
            // SelectorForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(439, 243);
            Controls.Add(btnDeckBuilder);
            Controls.Add(btnCartaAleatoria);
            Controls.Add(lblInfo);
            Name = "SelectorForm";
            Text = "Magic Builder";
            Load += SelectorForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblInfo;
        private Button btnDeckBuilder;
        private Button btnCartaAleatoria;
    }
}