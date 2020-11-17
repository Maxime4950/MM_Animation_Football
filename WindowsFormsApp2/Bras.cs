using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    class Bras: Rectangle_Tourne
    {
        #region Initialisation des variables
        private Rectangle_Tourne Abras, Main;
        #endregion

        #region Constructeurs
        public Bras(Graphics g, int xbras, int ybras, int xlongueur, int yhauteur, Color crayon, Color centercolor, double angle)
            : base(g,xbras,ybras,xlongueur,yhauteur,crayon,centercolor,angle)
        {
            Abras = new Rectangle_Tourne(g, xbras, ybras + yhauteur, xlongueur, (yhauteur / 4) * 3,
                Color.Black,Color.LightPink, 0);

            Main = new Rectangle_Tourne(g, xbras, ybras + yhauteur + (yhauteur / 4) * 3, xlongueur,
                yhauteur / 3, Color.Black, Color.Black, 0);
        }
        #endregion

        #region Méthodes
        public override void Afficher(Graphics g)
        {
            base.Afficher(g);
            Abras.Afficher(g);
            Main.Afficher(g);
        }

        public override void Cacher(Graphics g)
        {
            base.Cacher(g);
            Main.Cacher(g);
            Abras.Cacher(g);
        }

        public void Bouger(int deplX, int deplY, double BrasAngle, double CoudeAngle)
        {
            Angle = Angle + BrasAngle;
            base.Bouger(deplX, deplY);
            Abras.X = BasG.X;
            Abras.Y = BasG.Y;
            int[] vecteur = { base.MI.X - Abras.MS.X, base.MI.Y - Abras.MS.Y };
            Abras.X = BasG.X + vecteur[0];
            Abras.Y = BasG.Y + vecteur[1];
            Main.Angle = Main.Angle + CoudeAngle;
            Main.X = Abras.BasG.X;
            Main.Y = Abras.BasG.Y;
        }
        #endregion
    }
}
