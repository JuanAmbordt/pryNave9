using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pryNave9
{
    public class Bala
    {
        private PictureBox pictureBox;

        public Bala(int x, int y)
        {
            pictureBox = new PictureBox();
            pictureBox.Image = Properties.Resources.bala; // Asegúrate de que la imagen de la bala esté cargada en los recursos
            pictureBox.Size = new System.Drawing.Size(5, 10); // Tamaño de la bala
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox.Location = new System.Drawing.Point(x, y);
        }

        public void Move()
        {
            // Implementa el movimiento de la bala aquí
            pictureBox.Top -= 5; // Ejemplo de movimiento hacia arriba
        }

        public PictureBox RecibirPictureBox()
        {
            return pictureBox;
        }

        public Rectangle Bounds => pictureBox.Bounds;
    }
}

