namespace Tennis
{
    public partial class Form1 : Form
    {
        private Balle laBalle;
        private Raquette laRaquette;
        private bool perdu;

        public Form1()
        {
            InitializeComponent();
            laBalle = new Balle();
            laRaquette = new Raquette();
            panel1.Controls.Add(laBalle);
            panel1.Controls.Add(laRaquette);
            timer1.Interval = 10;
            laRaquette.KeyDown += new KeyEventHandler(laRaquette_KeyDown);
            laRaquette.KeyUp += new KeyEventHandler(laRaquette_KeyUp);
            this.TabStop = true;
            perdu = false;
        }

        private bool CollisionAvecRaquette()
        {
            Rectangle balleRect = new Rectangle(laBalle.Location.X, laBalle.Location.Y, laBalle.Width, laBalle.Height);
            Rectangle raquetteRect = new Rectangle(laRaquette.Location.X, laRaquette.Location.Y, laRaquette.Width, laRaquette.Height);
            return raquetteRect.IntersectsWith(balleRect);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (perdu) return;

            laBalle.Deplacer();
            laRaquette.DeplacerD();

            if (CollisionAvecRaquette())
            {
                laBalle.InverserDirection();

            }

            // Vérification si la balle touche le bas de l'écran
            if (laBalle.Location.Y + laBalle.Height > panel1.Height)
            {
                timer1.Stop();  // Arrêter le timer AVANT d'afficher le message
                perdu = true;
                MessageBox.Show("Vous avez perdu !");
            }
        }

        private void btn_jouer_Click(object sender, EventArgs e)
        {
            laRaquette.Init();
            laBalle.Init();
            perdu = false;
            timer1.Start();
            laRaquette.Focus();
        }

        private void btn_quitter_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void laRaquette_KeyDown(object sender, KeyEventArgs e)
        {
            laRaquette.SetDirection(e.KeyCode);
        }

        private void laRaquette_KeyUp(object sender, KeyEventArgs e)
        {
            laRaquette.Stopper();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            laBalle.Reset();
        }
    }
}