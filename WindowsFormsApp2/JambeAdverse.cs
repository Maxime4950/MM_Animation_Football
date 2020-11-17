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
    class JambeAdverse : Rectangle_Tourne
    {
        #region Initialisation des variables
        private Rectangle_Tourne Tibia, Pied;
        int i = 0;
        #endregion

        #region Constructeurs
        public JambeAdverse(Graphics g, int xjambes, int yjambes, int xlongueur, int yhauteur, Color crayon, Color centercolor, double angle) : base(g, xjambes, yjambes, xlongueur, yhauteur, crayon, centercolor, angle)
        {
            Tibia = new Rectangle_Tourne(g, xjambes, yjambes + yhauteur, xlongueur,
                (yhauteur * 3) / 4, Color.White, Color.White, 0);

            Pied = new Rectangle_Tourne(g, xjambes-5, yjambes + yhauteur + (yhauteur * 3) / 4,
                (xlongueur * 3) / 2, yhauteur / 4, Color.Black, Color.Black, 0);
        }
        #endregion

        #region Méthodes
        public override void Afficher(Graphics g)
        {
            base.Afficher(g);
            Pied.Afficher(g);
            Tibia.Afficher(g);
        }

        public override void Cacher(Graphics g)
        {
            base.Cacher(g);
            Pied.Cacher(g);
            Tibia.Cacher(g);
        }

        public void Bouger(int deplX, int deplY, double JambeAngle, double GenouAngle)
        {
            Angle = Angle + JambeAngle;
            base.Bouger(deplX, deplY);
            Tibia.X = BasG.X;
            Tibia.Y = BasD.Y;
            int[] vecteur = { base.MI.X - Tibia.MS.X, base.MI.Y - Tibia.MS.Y };
            Tibia.X = BasG.X + vecteur[0];
            Tibia.Y = BasD.Y + vecteur[1];
            Pied.Angle = Pied.Angle + GenouAngle;
            Pied.X = Tibia.BasG.X-5;
            Pied.Y = Tibia.BasG.Y;
            i++;

        }

        #endregion
    }
}
