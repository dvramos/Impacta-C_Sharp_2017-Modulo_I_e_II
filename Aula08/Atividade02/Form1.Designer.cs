namespace Atividade02
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
            this.label1 = new System.Windows.Forms.Label();
            this.tabuadaTextBox = new System.Windows.Forms.TextBox();
            this.okButton = new System.Windows.Forms.Button();
            this.tabuadaListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Digite a Tabuada";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // tabuadaTextBox
            // 
            this.tabuadaTextBox.Location = new System.Drawing.Point(12, 48);
            this.tabuadaTextBox.Name = "tabuadaTextBox";
            this.tabuadaTextBox.Size = new System.Drawing.Size(50, 20);
            this.tabuadaTextBox.TabIndex = 1;
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(80, 45);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(57, 23);
            this.okButton.TabIndex = 2;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // tabuadaListBox
            // 
            this.tabuadaListBox.FormattingEnabled = true;
            this.tabuadaListBox.Location = new System.Drawing.Point(12, 89);
            this.tabuadaListBox.Name = "tabuadaListBox";
            this.tabuadaListBox.Size = new System.Drawing.Size(125, 147);
            this.tabuadaListBox.TabIndex = 3;
            this.tabuadaListBox.SelectedIndexChanged += new System.EventHandler(this.tabuadaListBox_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(149, 249);
            this.Controls.Add(this.tabuadaListBox);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.tabuadaTextBox);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tabuadaTextBox;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.ListBox tabuadaListBox;
    }
}

