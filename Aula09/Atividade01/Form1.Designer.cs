namespace Atividade01
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.imagemListBox = new System.Windows.Forms.ListBox();
            this.favoritosListBox = new System.Windows.Forms.ListBox();
            this.adicionarButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // imagemListBox
            // 
            this.imagemListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.imagemListBox.FormattingEnabled = true;
            this.imagemListBox.Location = new System.Drawing.Point(12, 19);
            this.imagemListBox.Name = "imagemListBox";
            this.imagemListBox.Size = new System.Drawing.Size(316, 108);
            this.imagemListBox.TabIndex = 0;
            this.imagemListBox.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // favoritosListBox
            // 
            this.favoritosListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.favoritosListBox.FormattingEnabled = true;
            this.favoritosListBox.Location = new System.Drawing.Point(12, 185);
            this.favoritosListBox.Name = "favoritosListBox";
            this.favoritosListBox.Size = new System.Drawing.Size(316, 108);
            this.favoritosListBox.TabIndex = 1;
            this.favoritosListBox.SelectedIndexChanged += new System.EventHandler(this.favoritosListBox_SelectedIndexChanged);
            // 
            // adicionarButton
            // 
            this.adicionarButton.Location = new System.Drawing.Point(12, 144);
            this.adicionarButton.Name = "adicionarButton";
            this.adicionarButton.Size = new System.Drawing.Size(136, 23);
            this.adicionarButton.TabIndex = 2;
            this.adicionarButton.Text = "Adicionar aos Favoritos";
            this.adicionarButton.UseVisualStyleBackColor = true;
            this.adicionarButton.Click += new System.EventHandler(this.adicionarButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(12, 299);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(316, 223);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 534);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.adicionarButton);
            this.Controls.Add(this.favoritosListBox);
            this.Controls.Add(this.imagemListBox);
            this.Name = "Form1";
            this.Text = "Visualizador de Imagens";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox imagemListBox;
        private System.Windows.Forms.ListBox favoritosListBox;
        private System.Windows.Forms.Button adicionarButton;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

