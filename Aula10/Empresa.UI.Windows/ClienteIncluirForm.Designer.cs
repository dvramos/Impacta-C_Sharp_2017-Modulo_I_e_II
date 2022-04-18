namespace Empresa.UI.Windows
{
    partial class ClienteIncluirForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.nomeTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.telefoneTextBox = new System.Windows.Forms.TextBox();
            this.incluirButton = new System.Windows.Forms.Button();
            this.voltarButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // idTextBox
            // 
            this.idTextBox.Location = new System.Drawing.Point(88, 22);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(57, 20);
            this.idTextBox.TabIndex = 1;
            this.idTextBox.TextChanged += new System.EventHandler(this.idTextBox_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nome";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "E-mail";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Telefone";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // nomeTextBox
            // 
            this.nomeTextBox.Location = new System.Drawing.Point(88, 62);
            this.nomeTextBox.Name = "nomeTextBox";
            this.nomeTextBox.Size = new System.Drawing.Size(190, 20);
            this.nomeTextBox.TabIndex = 5;
            this.nomeTextBox.TextChanged += new System.EventHandler(this.nomeTextBox_TextChanged);
            // 
            // emailTextBox
            // 
            this.emailTextBox.Location = new System.Drawing.Point(88, 103);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(190, 20);
            this.emailTextBox.TabIndex = 6;
            this.emailTextBox.TextChanged += new System.EventHandler(this.emailTextBox_TextChanged);
            // 
            // telefoneTextBox
            // 
            this.telefoneTextBox.Location = new System.Drawing.Point(88, 138);
            this.telefoneTextBox.Name = "telefoneTextBox";
            this.telefoneTextBox.Size = new System.Drawing.Size(190, 20);
            this.telefoneTextBox.TabIndex = 7;
            this.telefoneTextBox.TextChanged += new System.EventHandler(this.telefoneTextBox_TextChanged);
            // 
            // incluirButton
            // 
            this.incluirButton.Location = new System.Drawing.Point(88, 184);
            this.incluirButton.Name = "incluirButton";
            this.incluirButton.Size = new System.Drawing.Size(75, 23);
            this.incluirButton.TabIndex = 8;
            this.incluirButton.Text = "Incluir";
            this.incluirButton.UseVisualStyleBackColor = true;
            this.incluirButton.Click += new System.EventHandler(this.incluirButton_Click);
            // 
            // voltarButton
            // 
            this.voltarButton.Location = new System.Drawing.Point(203, 184);
            this.voltarButton.Name = "voltarButton";
            this.voltarButton.Size = new System.Drawing.Size(75, 23);
            this.voltarButton.TabIndex = 9;
            this.voltarButton.Text = "Voltar";
            this.voltarButton.UseVisualStyleBackColor = true;
            this.voltarButton.Click += new System.EventHandler(this.voltarButton_Click);
            // 
            // ClienteIncluirForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(313, 222);
            this.Controls.Add(this.voltarButton);
            this.Controls.Add(this.incluirButton);
            this.Controls.Add(this.telefoneTextBox);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(this.nomeTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(this.label1);
            this.Name = "ClienteIncluirForm";
            this.Text = "ClienteIncluirForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox nomeTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox telefoneTextBox;
        private System.Windows.Forms.Button incluirButton;
        private System.Windows.Forms.Button voltarButton;
    }
}