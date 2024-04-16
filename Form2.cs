using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace pryNave9
{
    public partial class Form2 : Form
    {

        private bool upKeyDown;
        private bool downKeyDown;
        private bool leftKeyDown;
        private bool rightKeyDown;

        private const int conteoEnemigos = 10;
        private NaveJugador naveJugador;
        private List<NaveEnemiga> naveEnemiga;
        private List<BalaEnemiga> balasEnemigas = new List<BalaEnemiga>();
        private List<Bala> balasJugador = new List<Bala>();


        public Form2()
        {
            InitializeComponent();
            inicializarJuego();

            KeyDown += Form2_KeyDown;
            KeyUp += Form2_KeyUp;

            naveJugador = new NaveJugador(pctNavePrincipal);
        }

        private void inicializarJuego()
        {
            balasJugador = new List<Bala>();

            Random rand = new Random();
            naveEnemiga = new List<NaveEnemiga>();
            for (int i = 0; i < conteoEnemigos; i++)
            {
                PictureBox pictureBoxEnemigo = new PictureBox();
                pictureBoxEnemigo.Image = Properties.Resources.naveEnemiga;
                pictureBoxEnemigo.Size = new Size(50, 50);
                pictureBoxEnemigo.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBoxEnemigo.BackColor = Color.Transparent;
                pictureBoxEnemigo.Location = new Point(rand.Next(ClientSize.Width - pictureBoxEnemigo.Width), rand.Next(50, 200));
                Controls.Add(pictureBoxEnemigo);

                NaveEnemiga nave = new NaveEnemiga(pictureBoxEnemigo, balasEnemigas);
                naveEnemiga.Add(nave);
            }

            timer1.Interval = 50; // Intervalo de tiempo en milisegundos
            timer1.Tick += timer1_Tick;
            timer1.Start();
        }

        private void Form2_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.W:
                    upKeyDown = true;
                    break;
                case Keys.A:
                    leftKeyDown = true;
                    break;
                case Keys.S:
                    downKeyDown = true;
                    break;
                case Keys.D:
                    rightKeyDown = true;
                    break;
            }
        }

        private void Form2_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.W:
                    upKeyDown = false;
                    break;
                case Keys.A:
                    leftKeyDown = false;
                    break;
                case Keys.S:
                    downKeyDown = false;
                    break;
                case Keys.D:
                    rightKeyDown = false;
                    break;
            }
        }

        private void MoverBalasEnemigas()
        {
            for (int i = balasEnemigas.Count - 1; i >= 0; i--)
            {
                balasEnemigas[i].Mover();
            }
        }

        private Random rand = new Random();
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (upKeyDown) naveJugador.Arriba();
            if (downKeyDown) naveJugador.Abajo();
            if (leftKeyDown) naveJugador.Izquierda();
            if (rightKeyDown) naveJugador.Derecha();



            foreach (var nave in naveEnemiga)
            {
                nave.Mover();
                if (new Random().Next(0, 100) < 5)
                {
                    nave.Disparar();
                }
            }

            MoverBalasEnemigas();

            Refresh();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
