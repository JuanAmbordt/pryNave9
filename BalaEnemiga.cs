using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pryNave9
{
    public class BalaEnemiga
    {
        // Propiedad para la posición de la bala enemiga
        public Point Position { get; set; }

        // Constructor para inicializar la posición
        public BalaEnemiga(int x, int y)
        {
            Position = new Point(x, y);
        }

        // Método para mover la bala enemiga hacia abajo
        public void Mover()
        {
            Position = new Point(Position.X, Position.Y + 1);
        }
    }
}
