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
    class Escalier:Rectangle
    {
        private Rectangle marche1,marche2,marche3;

        public Escalier(Graphics g, int xEscalier, int yEscalier, int xlongueurEscalier, int ylargeurEscalier) : base(g, xEscalier, yEscalier, xlongueurEscalier, ylargeurEscalier)
        {
            marche1 = new Rectangle(g, xEscalier-10, yEscalier+15, 20, 20, Color.Gray, Color.Gray);
            marche2 = new Rectangle(g, xEscalier + 10, yEscalier+2, 20, 30, Color.Gray, Color.Gray);
            marche3 = new Rectangle(g, xEscalier + 30, yEscalier-10, 20, 40, Color.Gray, Color.Gray);
        }

        public override void Afficher(Graphics g)
        {
            base.Afficher(g);
            marche1.Afficher(g);
            marche2.Afficher(g);
            marche3.Afficher(g);
        }

        public override void Cacher(Graphics g)
        {
            base.Cacher(g);
            marche1.Cacher(g);
            marche2.Cacher(g);
            marche3.Cacher(g);
        }
    }
}
