namespace pryNave9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnJuego_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2();
            frm2.ShowDialog();
        }
    }
}
