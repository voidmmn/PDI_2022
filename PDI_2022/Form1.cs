﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PDI_2022
{
    public partial class Form1 : Form
    {
        public Bitmap imgOriginal;
        public Bitmap imgDestino;

        public Form1()
        {
            InitializeComponent();
            imgDestino = new Bitmap(origemPictureBox.Width, origemPictureBox.Height);
        }

        private void copiarButton_Click(object sender, EventArgs e)
        {
        }

        private void Media()
        {
            Bitmap origem = new Bitmap(origemPictureBox.Image);

            if (destinoCheckBox.Checked)
                origem = new Bitmap(destinoPictureBox.Image);

            Bitmap destino = new Bitmap(origemPictureBox.Image.Width, origemPictureBox.Image.Height);
            Color pixel;

            for (int x = 0; x < origemPictureBox.Image.Width; x++)
            {
                for (int y = 0; y < origemPictureBox.Image.Height; y++)
                {
                    pixel = origem.GetPixel(x, y);
                    // Calculo para o cinza (media)
                    int media = (pixel.R + pixel.G + pixel.B) / 3;
                    destino.SetPixel(x, y, Color.FromArgb(media, media, media));
                }
            }
            destinoPictureBox.Image = destino;
        }

        private void lightnessButton_Click(object sender, EventArgs e)
        {
        }

        private void Lightness()
        {
            Bitmap origem = new Bitmap(origemPictureBox.Image);

            if (destinoCheckBox.Checked)
                origem = new Bitmap(destinoPictureBox.Image);

            Bitmap destino = new Bitmap(origemPictureBox.Image.Width, origemPictureBox.Image.Height);
            Color pixel;

            for (int y = 0; y < origemPictureBox.Image.Height; y++)
            {
                for (int x = 0; x < origemPictureBox.Image.Width; x++)
                {
                    pixel = origem.GetPixel(x, y);
                    // Calculo para o cinza
                    int lightness = (Max(pixel.R, pixel.G, pixel.B) + Min(pixel.R, pixel.G, pixel.B)) / 2;
                    destino.SetPixel(x, y, Color.FromArgb(lightness, lightness, lightness));
                }
            }

            destinoPictureBox.Image = destino;
        }

        private void luminosidadeButton_Click(object sender, EventArgs e)
        {
        }

        private void Luminosidade()
        {
            Bitmap origem = new Bitmap(origemPictureBox.Image);

            if (destinoCheckBox.Checked)
                origem = new Bitmap(destinoPictureBox.Image);

            Bitmap destino = new Bitmap(origemPictureBox.Image.Width, origemPictureBox.Image.Height);
            Color pixel;

            for (int y = 0; y < origemPictureBox.Image.Height; y++)
            {
                for (int x = 0; x < origemPictureBox.Image.Width; x++)
                {
                    pixel = origem.GetPixel(x, y);
                    // Calculo para o cinza
                    int luminosidade = (int)((pixel.R * 0.21) + (pixel.G * 0.72) + (pixel.B * 0.07));
                    destino.SetPixel(x, y, Color.FromArgb(luminosidade, luminosidade, luminosidade));
                }
            }

            destinoPictureBox.Image = destino;
        }

        private int Max(int R, int G, int B)
        {
            int valorRetorno = R;

            if (G > R)
                valorRetorno = G;

            if (B > G)
                valorRetorno = B;

            return valorRetorno;
        }

        private int Min(int R, int G, int B)
        {
            int valorRetorno = R;

            if (G < R)
                valorRetorno = G;

            if (B < G)
                valorRetorno = B;

            return valorRetorno;
        }

        private void yTrackBar_Scroll(object sender, EventArgs e)
        {
            AtualizaPaineis();
        }

        private void xTrackBar_Scroll(object sender, EventArgs e)
        {
            AtualizaPaineis();
        }

        private void AtualizaPaineis()
        {
            // Atualiza os labels e os valores
            yLabel.Text = (255 - yTrackBar.Value).ToString();
            xLabel.Text = xTrackBar.Value.ToString();
            pixelLabel.Text = "Pixel: " + xLabel.Text + ";" + yLabel.Text;

            // Obtem a coordenada x
            int x = int.Parse(xLabel.Text);

            // Obtem a coordenada y
            int y = int.Parse(yLabel.Text);

            Color pixel = imgOriginal.GetPixel(x, y);
            Color R = Color.FromArgb(pixel.R, 0, 0);
            Color G = Color.FromArgb(0, pixel.G, 0);
            Color B = Color.FromArgb(0, 0, pixel.B);

            // Atualiza o destino
            imgDestino.SetPixel(x, y, pixel);
            destinoPictureBox.Image = imgDestino;
            destinoPictureBox.Refresh();

            rgbPanel.BackColor = pixel;
            rPanel.BackColor = R;
            gPanel.BackColor = G;
            bPanel.BackColor = B;
            rgbLabel.Text = "R: " + pixel.R.ToString() + "; G: " + pixel.G.ToString() + "; B: " + pixel.B.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            imgOriginal = new Bitmap(origemPictureBox.Image);
        }

        private void copiaButton_Click(object sender, EventArgs e)
        {
            Bitmap origem = new Bitmap(origemPictureBox.Image);
            Bitmap destino = new Bitmap(origemPictureBox.Image.Width, origemPictureBox.Image.Height);
            Color pixel;

            for (int y = 0; y < origemPictureBox.Image.Height; y++)
            {
                for (int x = 0; x < origemPictureBox.Image.Width; x++)
                {
                    pixel = origem.GetPixel(x, y);
                    Color daltonico = Color.FromArgb(127, pixel.G, pixel.B);

                    destino.SetPixel(x, y, daltonico);
                }
            }

            destinoPictureBox.Image = destino;
        }

        private void luminosityToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Luminosidade();
        }

        private void lightnessToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Lightness();
        }

        private void averageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Media();
        }

        private void negativoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bitmap origem = new Bitmap(origemPictureBox.Image);

            if (destinoCheckBox.Checked)
                origem = new Bitmap(destinoPictureBox.Image);

            Bitmap destino = new Bitmap(origemPictureBox.Image.Width, origemPictureBox.Image.Height);
            Color pixel;
            Color pixelDestino;

            for (int y = 0; y < origemPictureBox.Image.Height; y++)
            {
                for (int x = 0; x < origemPictureBox.Image.Width; x++)
                {
                    pixel = origem.GetPixel(x, y);
                    pixelDestino = Color.FromArgb(255 - pixel.R, 255 - pixel.G, 255 - pixel.B);
                    destino.SetPixel(x, y, pixelDestino);
                }
            }

            destinoPictureBox.Image = destino;
        }

        private void horizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Pega a imagem original
            Bitmap origem = new Bitmap(origemPictureBox.Image);

            // Se o usuário quiser, podemos utilizar a imagem destino como a imagem de origem
            if (destinoCheckBox.Checked)
                origem = new Bitmap(destinoPictureBox.Image);


            Bitmap destino = new Bitmap(origemPictureBox.Image.Width, origemPictureBox.Image.Height);
            Color pixel;

            for (int y = 0; y < origemPictureBox.Image.Height; y++)
            {
                for (int x = 0; x < origemPictureBox.Image.Width; x++)
                {
                    pixel = origem.GetPixel(x, y);
                    destino.SetPixel(origem.Width - 1 - x, y, pixel);
                }
            }

            destinoPictureBox.Image = destino;
        }

        private void verticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bitmap origem = new Bitmap(origemPictureBox.Image);

            if (destinoCheckBox.Checked)
                origem = new Bitmap(destinoPictureBox.Image);

            Bitmap destino = new Bitmap(origemPictureBox.Image.Width, origemPictureBox.Image.Height);
            Color pixel;

            for (int y = 0; y < origemPictureBox.Image.Height; y++)
            {
                for (int x = 0; x < origemPictureBox.Image.Width; x++)
                {
                    pixel = origem.GetPixel(x, y);
                    destino.SetPixel(x, origem.Height - 1 - y, pixel);
                }
            }

            destinoPictureBox.Image = destino;
        }
    }
}
