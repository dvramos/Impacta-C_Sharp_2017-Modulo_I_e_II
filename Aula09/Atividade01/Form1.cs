using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Atividade01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            pictureBox1.ImageLocation = imagemListBox.Text;
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] arquivos = Directory.GetFiles(@"c:\windows\web\wallpaper","*.jpg", SearchOption.AllDirectories);
            imagemListBox.Items.AddRange(arquivos);

            //Ler do arquivo favoritos
            string path = ObterNomeArquivoConfiguracao();

            if (File.Exists(path))
            {

                var reader = new StreamReader(path);
                while (!reader.EndOfStream)
                {
                    string arquivo = reader.ReadLine();
                    favoritosListBox.Items.Add(arquivo);
                }
                reader.Close();
            }
        }

        private void adicionarButton_Click(object sender, EventArgs e)
        {
            favoritosListBox.Items.Add(imagemListBox.Text);
            GravarConfiguracao();

        }

        private string ObterNomeArquivoConfiguracao()
        {
            string pasta = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string arquivo = "imagensConfig.txt";
            string path = Path.Combine(pasta, arquivo);
            return path;
        }

        private void GravarConfiguracao()
        {
            string path = ObterNomeArquivoConfiguracao();
            var writer = new StreamWriter(path);
            foreach (string arquivo in favoritosListBox.Items)
            {
                writer.WriteLine(arquivo);
            }
            writer.Close();
        }
        private void favoritosListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            pictureBox1.ImageLocation = favoritosListBox.Text;
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void removerButton_Click(object sender, EventArgs e)
        {
            if (favoritosListBox.SelectedItem != null)
            {
                string itemSelecionado = favoritosListBox.SelectedItem.ToString();
                favoritosListBox.Items.Remove(itemSelecionado);
                GravarConfiguracao();
            }
        }
    }
}
