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
    class FootballeurAdverse : Personnage
    {
        #region Initialisation des variables
        private Bras brasG, brasD;
        private JambeAdverse JambeG, JambeD;
        private Cercle Tete, Oeil;
        private Rectangle Corps;
        #endregion

        #region Constructeurs
        public FootballeurAdverse(Graphics g, int xcorps, int ycorps, int xlongueur, int yhauteur,
            Color crayon, Color centercolor) : base(g, xcorps, ycorps, xlongueur, yhauteur, crayon, centercolor)
        {
            Tete = new Cercle(g, xcorps + xlongueur / 2, (ycorps - xlongueur / 2), xlongueur / 2, Color.Black, Color.LightPink);

            Oeil = new Cercle(g, xcorps + xlongueur -20, (ycorps - xlongueur / 2 - 5), xlongueur / 10, Color.Black, Color.Black);

            brasG = new Bras(g, xcorps + xlongueur / 4, ycorps + 2, xlongueur / 3, yhauteur / 3, Color.Yellow, Color.White, 0);

            brasD = new Bras(g, xcorps + xlongueur / 4, ycorps + 2, xlongueur / 3, yhauteur / 3, Color.Yellow, Color.White, 0);

            Corps = new Rectangle(g, xcorps, ycorps, xlongueur, yhauteur, Color.Blue, Color.Blue);

            JambeG = new JambeAdverse(g, xcorps + xlongueur / 4, ycorps + yhauteur + yhauteur / 3 - 40, xlongueur / 3, yhauteur / 3, Color.Black, Color.LightPink, 0);

            JambeD = new JambeAdverse(g, xcorps + xlongueur / 4, ycorps + yhauteur + yhauteur / 3 - 40, xlongueur / 3, yhauteur / 3, Color.Black, Color.LightPink, 0);
        }
        #endregion

        #region Méthodes
        public override void Afficher(Graphics g)
        {
            JambeG.Afficher(g);
            brasG.Afficher(g);
            Corps.Afficher(g);
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
            brasG.Cacher(g);
            brasD.Cacher(g);
            JambeG.Cacher(g);
            JambeD.Cacher(g);
        }

        public override void Bouger(int deplX, int deplY, double ASBG, double AIBG, double ASJG, double AIJG, double ASBD, double AIBD, double ASJD, double AIJD)
        {
            brasG.Bouger(deplX, deplY, ASBG, AIBG);
            JambeD.Bouger(deplX, deplY, ASJG, AIJG);
            Corps.Bouger(deplX, deplY);
            Oeil.Bouger(deplX, deplY);
            Tete.Bouger(deplX, deplY);
            brasD.Bouger(deplX, deplY, ASBD, AIBD);
            JambeG.Bouger(deplX, deplY, ASJD, AIJD);
        }
        #endregion
    }
}
