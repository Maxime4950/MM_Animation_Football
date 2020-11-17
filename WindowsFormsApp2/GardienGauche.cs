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
    class GardienGauche : Personnage
    {
        #region Initialisation des variables
        private Bras brasG, brasD;
        private Jambe JambeG, JambeD;
        private Cercle Tete, Oeil;
        private Rectangle Corps;
        #endregion

        #region Constructeurs
        public GardienGauche(Graphics g, int xcorps, int ycorps, int xlongueur, int yhauteur,
            Color crayon, Color centercolor) : base(g, xcorps, ycorps, xlongueur, yhauteur, crayon, centercolor)
        {
            Tete = new Cercle(g, xcorps + xlongueur / 2, (ycorps - xlongueur / 2), xlongueur / 2, Color.Black, Color.LightPink);

            Oeil = new Cercle(g, xcorps + xlongueur - 10, (ycorps - xlongueur / 2 - 5), xlongueur / 10, Color.Black, Color.Black);

            brasG = new Bras(g, xcorps + xlongueur / 4, ycorps + 2, xlongueur / 3, yhauteur / 3, Color.Yellow, Color.White, 0);
            brasD = new Bras(g, xcorps + xlongueur / 4, ycorps + 2, xlongueur / 3, yhauteur / 3, Color.Yellow, Color.White, 0);

            Corps = new Rectangle(g, xcorps, ycorps, xlongueur, yhauteur, Color.Black, Color.Black);

            JambeG = new Jambe(g, xcorps + xlongueur / 4, ycorps + yhauteur + yhauteur / 3 - 40, xlongueur / 3, yhauteur / 3, Color.Black, Color.LightPink, 0);
            JambeD = new Jambe(g, xcorps + xlongueur / 4, ycorps + yhauteur + yhauteur / 3 - 40, xlongueur / 3, yhauteur / 3, Color.Black, Color.LightPink, 0);
        }
        #endregion

        #region Méthodes
        public override void Afficher(Graphics g)
        {
            JambeG.Afficher(g);
            brasG.Afficher(g);
            Corps.Afficher(g);
            base.Afficher(g);
            Tete.Afficher(g);
            Oeil.Afficher(g);
            brasD.Afficher(g);
            JambeD.Afficher(g);
        }

        public override void Cacher(Graphics g)
        {
            Corps.Cacher(g);
            Tete.Cacher(g);
            Oeil.Cacher(g);
            base.Cacher(g);
            brasG.Cacher(g);
            brasD.Cacher(g);
            JambeG.Cacher(g);
            JambeD.Cacher(g);
        }
        #endregion
    }
}
