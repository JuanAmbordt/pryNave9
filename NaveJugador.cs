using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryNave9
{
    public class NaveJugador
    {
        private PictureBox pictureBox;
        private List<Bala> balasJugador = new List<Bala>();

        public NaveJugador(PictureBox pictureBox)
        {
            this.pictureBox = pictureBox;
        }

        public void Arriba()
        {
            pictureBox.Top -= 10;
        }

        public void Abajo()
        {
            pictureBox.Top += 10;
        }

        public void Izquierda()
        {
            pictureBox.Left -= 10;
        }

        public void Derecha()
        {
            pictureBox.Left += 10;
        }

        public void Disparar()
        {
            balasJugador.Add(new Bala(pictureBox.Left + pictureBox.Width / 2, pictureBox.Top));
        }

        public List<Bala> GetBalasJugador()
        {
            return balasJugador;
        }

        public PictureBox GetPictureBox()
        {
            return pictureBox;
        }
    }
}
