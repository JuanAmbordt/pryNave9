using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryNave9
{
    public class NaveEnemiga
    {
        public PictureBox PictureBox { get; private set; }
        private List<BalaEnemiga> balasEnemigas;

        public NaveEnemiga(PictureBox pictureBox, List<BalaEnemiga> balasEnemigas)
        {
            PictureBox = pictureBox;
            this.balasEnemigas = balasEnemigas;
        }

        public void Mover()
        {
            PictureBox.Top += 1; // Movimiento hacia abajo
        }

        public void Disparar()
        {
            balasEnemigas.Add(new BalaEnemiga(PictureBox.Left + PictureBox.Width / 2, PictureBox.Bottom));
        }

        

        public List<BalaEnemiga> GetBalasEnemigas()
        {
            return balasEnemigas;
        }
    }
}
