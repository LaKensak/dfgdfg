using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tennis
{
    public partial class Raquette : UserControl
    {
        private int deplacementX = 0;

        public Raquette()
        {
            InitializeComponent();
        }

        public void SetDirection(Keys touche)
        {
            if (touche == Keys.Q)
            {
                deplacementX = -3; // Déplacement à gauche
            }
            else if (touche == Keys.M)
            {
                deplacementX = 3; // Déplacement à droite
            }
        }

        public void Stopper()
        {
            deplacementX = 0;
        }

        public void DeplacerD()
        {
            if (this.Parent != null)
            {
                int nouvellePositionX = Location.X + deplacementX;

                // Vérifier les limites
                if (nouvellePositionX < 0) // Bord gauche
                {
                    nouvellePositionX = 0;
                }
                else if (nouvellePositionX + Width > Parent.Width) // Bord droit
                {
                    nouvellePositionX = Parent.Width - Width;
                }

                Location = new Point(nouvellePositionX, Location.Y);
            }
        }

        public void Init()
        {
            // Définir la position de la raquette
            int positionX = 255; // Position X par défaut
            int positionY = 248; // Position Y par défaut

            if (this.Parent != null)
            {
                this.Location = new Point(positionX, positionY);
            }

        }


        private void Raquette_Load(object sender, EventArgs e)
        {

        }
    }
}
