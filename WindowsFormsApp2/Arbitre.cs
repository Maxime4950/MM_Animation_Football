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
    class Arbitre : Personnage
    {
        #region Initialisation des variables
        private Bras brasG, brasD;
        private Jambe JambeG, JambeD;
        private Cercle Tete, Oeil;
        private Rectangle Corps,CasquetteP1,Penne;
        #endregion

        #region Constructeurs
        public Arbitre(Graphics g, int xcorps, int ycorps, int xlongueur, int yhauteur,
            Color crayon, Color centercolor) : base(g, xcorps, ycorps, xlongueur, yhauteur, crayon, centercolor)
        {
            Tete = new Cercle(g, xcorps + xlongueur / 2, (ycorps - xlongueur / 2), xlongueur / 2, Color.Black, Color.LightPink);

            Oeil = new Cercle(g, xcorps + xlongueur - 10, (ycorps - xlongueur / 2 - 5), xlongueur / 10, Color.Black, Color.Black);

            brasG = new Bras(g, xcorps + xlongueur / 4, ycorps + 2, xlongueur / 3, yhauteur / 3, Color.Yellow, Color.Black, 0);
            brasD = new Bras(g, xcorps + xlongueur / 4, ycorps + 2, xlongueur / 3, yhauteur / 3, Color.Yellow, Color.Black, 0);

            Corps = new Rectangle(g, xcorps, ycorps, xlongueur, yhauteur, Color.Black, Color.White);

            JambeG = new Jambe(g, xcorps + xlongueur / 4, ycorps + yhauteur + yhauteur / 3 - 40, xlongueur / 3, yhauteur / 3, Color.Black, Color.LightPink, 0);
            JambeD = new Jambe(g, xcorps + xlongueur / 4, ycorps + yhauteur + yhauteur / 3 - 40, xlongueur / 3, yhauteur / 3, Color.Black, Color.LightPink, 0);

            //Casquette

            CasquetteP1 = new Rectangle(g, 450, 45, 25, 10, Color.Black, Color.Black);
            Penne = new Rectangle(g, 475, 50, 10, 5, Color.Black, Color.Black);

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
            CasquetteP1.Afficher(g);
            Penne.Afficher(g);
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
            CasquetteP1.Cacher(g);
            Penne.Cacher(g);
        }

        public override void Bouger(int deplX, int deplY, double ASBG, double AIBG, double ASJG, double AIJG, double ASBD, double AIBD, double ASJD, double AIJD)
        {
            brasG.Bouger(deplX, deplY, ASBG, AIBG);
            JambeG.Bouger(deplX, deplY, ASJG, AIJG);
            Corps.Bouger(deplX, deplY);
            base.Bouger(deplX, deplY);
            Oeil.Bouger(deplX, deplY);
            Tete.Bouger(deplX, deplY);
            brasD.Bouger(deplX, deplY, ASBD, AIBD);
            JambeD.Bouger(deplX, deplY, ASJD, AIJD);
        }

        public override void Marcher(int deplX, int deplY, Graphics g)
        {
            Bouger(0, 0, Math.PI / 15, Math.PI / 15, -Math.PI / 15, -Math.PI / 10, -Math.PI / 20, Math.PI / 15, Math.PI / 20, Math.PI / 20);
            Thread.Sleep(50);

            Bouger(0, 0, Math.PI / 15, Math.PI / 15, -Math.PI / 15, -Math.PI / 10, -Math.PI / 20, Math.PI / 15, Math.PI / 20, Math.PI / 20);
            Thread.Sleep(50);

            Bouger(0, 0, Math.PI / 15, Math.PI / 15, -Math.PI / 15, -Math.PI / 10, -Math.PI / 20, Math.PI / 15, Math.PI / 20, Math.PI / 20);
            Thread.Sleep(50);

            Bouger(0, 0, Math.PI / 15, Math.PI / 15, -Math.PI / 15, -Math.PI / 10, -Math.PI / 20, Math.PI / 15, Math.PI / 20, Math.PI / 20);
            Thread.Sleep(50);

            //////////////////////////////////////////


            Bouger(deplX / 15, deplY / 15, -Math.PI / 15, -Math.PI / 15, Math.PI / 15, Math.PI / 10, Math.PI / 20, -Math.PI / 15, -Math.PI / 20, -Math.PI / 20);
            Thread.Sleep(50);

            Bouger(deplX / 15, deplY / 15, -Math.PI / 15, -Math.PI / 15, Math.PI / 15, Math.PI / 10, Math.PI / 20, -Math.PI / 15, -Math.PI / 20, -Math.PI / 20);
            Thread.Sleep(50);

            Bouger(deplX / 15, deplY / 15, -Math.PI / 15, -Math.PI / 15, Math.PI / 15, Math.PI / 10, Math.PI / 20, -Math.PI / 15, -Math.PI / 20, -Math.PI / 20);
            Thread.Sleep(50);

            Bouger(deplX / 15, deplY / 15, -Math.PI / 15, -Math.PI / 15, Math.PI / 15, Math.PI / 10, Math.PI / 20, -Math.PI / 15, -Math.PI / 20, -Math.PI / 20);
            Thread.Sleep(50);


            //////////////////////////////////////////

            Bouger(deplX / 15, deplY / 15, -Math.PI / 20, Math.PI / 15, Math.PI / 20, Math.PI / 20, Math.PI / 15, Math.PI / 15, -Math.PI / 10, -Math.PI / 10);
            Thread.Sleep(50);

            Bouger(deplX / 15, deplY / 15, -Math.PI / 20, Math.PI / 15, Math.PI / 20, Math.PI / 20, Math.PI / 15, Math.PI / 15, -Math.PI / 10, -Math.PI / 10);
            Thread.Sleep(50);

            Bouger(deplX / 15, deplY / 15, -Math.PI / 20, Math.PI / 15, Math.PI / 20, Math.PI / 20, Math.PI / 15, Math.PI / 15, -Math.PI / 10, -Math.PI / 10);
            Thread.Sleep(50);

            Bouger(deplX / 15, deplY / 15, -Math.PI / 20, Math.PI / 15, Math.PI / 20, Math.PI / 20, Math.PI / 15, Math.PI / 15, -Math.PI / 10, -Math.PI / 10);
            Thread.Sleep(50);


            //////////////////////////////////////////

            Bouger(deplX / 15, deplY / 15, Math.PI / 20, -Math.PI / 15, -Math.PI / 20, -Math.PI / 20, -Math.PI / 15, -Math.PI / 15, Math.PI / 10, Math.PI / 10);
            Thread.Sleep(50);

            Bouger(deplX / 15, deplY / 15, Math.PI / 20, -Math.PI / 15, -Math.PI / 20, -Math.PI / 20, -Math.PI / 15, -Math.PI / 15, Math.PI / 10, Math.PI / 10);

            Thread.Sleep(50);



            Bouger(deplX / 15, deplY / 15, Math.PI / 20, -Math.PI / 15, -Math.PI / 20, -Math.PI / 20, -Math.PI / 15, -Math.PI / 15, Math.PI / 10, Math.PI / 10);
            Thread.Sleep(50);

            Bouger(deplX / 15, deplY / 15, Math.PI / 20, -Math.PI / 15, -Math.PI / 20, -Math.PI / 20, -Math.PI / 15, -Math.PI / 15, Math.PI / 10, Math.PI / 10);
            Thread.Sleep(50);

            //////////////////////////////////////////

        }

        #endregion
    }
}
