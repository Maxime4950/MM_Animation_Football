using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using System.Threading;


namespace WindowsFormsApp2
{
    class Arbre: Rectangle
    {
        private Rectangle tronc;

        private Cercle feuille1, feuille2, feuille3;

        public Arbre(Graphics g, int xArbre, int yArbre, int xlongueurArbre, int ylargeurArbre) : base(g, xArbre, yArbre, xlongueurArbre, yArbre)
        {
            tronc = new Rectangle(g, xArbre, yArbre, xlongueurArbre, ylargeurArbre, Color.Brown, Color.Brown);
            feuille1 = new Cercle(g, xArbre - 15, yArbre+20, 40, Color.Black, Color.Green);
            feuille2 = new Cercle(g, xArbre + 10, yArbre, 40, Color.Black, Color.Green);
            feuille3 = new Cercle(g, xArbre +40, yArbre + 20, 40, Color.Black, Color.Green);

        }

        public override void Afficher(Graphics g)
        {

            base.Afficher(g);
            tronc.Afficher(g);
            feuille1.Afficher(g);
            feuille3.Afficher(g);
            feuille2.Afficher(g);

        }

        public override void Cacher(Graphics g)
        {
            base.Cacher(g);
            tronc.Cacher(g);
            feuille1.Cacher(g);
            feuille2.Cacher(g);
            feuille3.Cacher(g);

        }
    }
}
