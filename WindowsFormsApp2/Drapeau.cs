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
    class Drapeau : Rectangle
    {
        private Rectangle mat,noir,jaune,rouge;

        public Drapeau(Graphics g, int xDrapeau, int yDrapeau, int xlongueurDrapeau, int ylargeurDrapeau) : base(g, xDrapeau, yDrapeau, xlongueurDrapeau, ylargeurDrapeau)
        {
            mat = new Rectangle(g, xDrapeau-15, yDrapeau, 5, 140,Color.Gray,Color.Gray);
            noir = new Rectangle(g, xDrapeau-10, yDrapeau, 15, 30,Color.Black,Color.Black);
            jaune = new Rectangle(g, xDrapeau + 5, yDrapeau, 15, 30,Color.Yellow,Color.Yellow);
            rouge = new Rectangle(g, xDrapeau + 20, yDrapeau, 15, 30,Color.Red,Color.Red);
        }

        public override void Afficher(Graphics g)
        {

            base.Afficher(g);
            mat.Afficher(g);
            noir.Afficher(g);
            jaune.Afficher(g);
            rouge.Afficher(g);

        }

        public override void Cacher(Graphics g)
        {
            base.Cacher(g);
            mat.Cacher(g);
            noir.Cacher(g);
            jaune.Cacher(g);
            rouge.Cacher(g);

        }
    }
}
