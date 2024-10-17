using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Tennis
{
    public partial class Balle : UserControl
    {
        private int deplacementX = 1;
        private int deplacementY = 1;
        private Raquette laRaquette; // Assurez-vous que cela est bien assigné ailleurs
        public event EventHandler Perdu;

        public Balle()
        {
            InitializeComponent();
            GraphicsPath gp = new GraphicsPath();
            gp.AddEllipse(0, 0, 20, 20);
            Region = new Region(gp);
        }

        public void Init()
        {

            // Placer la balle au centre du contrôle parent
            if (this.Parent != null)
            {
                this.Location = new Point((this.Parent.Width - this.Width) / 2, (this.Parent.Height - this.Height) / 2);
            }
        }

        public void Deplacer()
        {
            // Vérifier les rebonds sur les bords gauche et droit
            if (Location.X < 0 || Location.X + Width > Parent.Width)
            {
                deplacementX = -deplacementX;
            }

            // Vérifier les rebonds sur le bord supérieur
            if (Location.Y < 0)
            {
                deplacementY = -deplacementY;
            }

            // Vérifier si la balle touche la raquette
            if (laRaquette != null && Bounds.IntersectsWith(laRaquette.Bounds))
            {
                InverserDirection(); // Inverser la direction lorsqu'elle touche la raquette
            }

            // Mettre à jour la position de la balle
            Location = new Point(Location.X + deplacementX, Location.Y + deplacementY);
        }

        public void InverserDirection()
        {
            // Inverser la direction verticale (Y)
            deplacementY = -deplacementY;

            // Augmenter la vitesse progressivement
            if (deplacementX > 0)
                deplacementX = (int)(deplacementX + 0.5);
            else
                deplacementX -= 3; 

            if (deplacementY > 0)
                deplacementY = (int)(deplacementY + 0.5);
            else
                deplacementY -= 3;

            deplacementX = Math.Clamp(deplacementX, -10, 10);
            deplacementY = Math.Clamp(deplacementY, -10, 10);
        }

        public void Reset()
        {
            deplacementX = 1; 
            deplacementY = 1;
        }

    }
}
