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
    class GoalGauche : Rectangle
    {
        #region Initialisation des variables
        private Rectangle hautG, hautD, basGauche, basDroite, LigneDroiteRect, LigneHautRect, LigneBasRect;

        private Rectangle_Tourne poteauG, poteauD, transversale, poteauG2, poteauD2, BasArriere;
        #endregion

        #region Constructeurs
        public GoalGauche(Graphics g, int xSol, int ySol, int xlongueurSol, int yhauteurSol) : base(g, xSol, ySol, xlongueurSol, yhauteurSol)
        {
            transversale = new Rectangle_Tourne(g, 100, 102, 5, 98, Color.White, Color.White, -0.08);

            poteauG2 = new Rectangle_Tourne(g, 55, 100, 5, 88, Color.White, Color.White, -0.32);
            poteauD2 = new Rectangle_Tourne(g, 45, 210, 5, 80, Color.White, Color.White, -0.28);

            basGauche = new Rectangle(g, 25, 190, 88, 5, Color.White, Color.White);
            basDroite = new Rectangle(g, 20, 290, 95, 5, Color.White, Color.White);
            BasArriere = new Rectangle_Tourne(g, 25, 200, 5, 80, Color.White, Color.White, -0.05);

            hautG = new Rectangle(g, 60, 92, 40, 5, Color.White, Color.White);
            hautD = new Rectangle(g, 45, 202, 50, 5, Color.White, Color.White);

            poteauG = new Rectangle_Tourne(g, 100, 102, 5, 85, Color.White, Color.White, 0.12);
            poteauD = new Rectangle_Tourne(g, 95, 210, 5, 80, Color.White, Color.White, 0.18);

            LigneDroiteRect = new Rectangle(g, 190, 195, 1, 100, Color.White, Color.White);
            LigneHautRect = new Rectangle(g, 115, 195, 75, 1, Color.White, Color.White);
            LigneBasRect = new Rectangle(g, 115, 295, 75, 1, Color.White, Color.White);
        }
        #endregion

        #region Méthodes
        public override void Afficher(Graphics g)
        {

            base.Afficher(g);
            poteauG2.Afficher(g);
            poteauD2.Afficher(g);
            hautG.Afficher(g);
            hautD.Afficher(g);
            poteauG.Afficher(g);
            poteauD.Afficher(g);
            transversale.Afficher(g);
            BasArriere.Afficher(g);
            basGauche.Afficher(g);
            basDroite.Afficher(g);
            LigneDroiteRect.Afficher(g);
            LigneHautRect.Afficher(g);
            LigneBasRect.Afficher(g);

        }
        #endregion
    }
}
