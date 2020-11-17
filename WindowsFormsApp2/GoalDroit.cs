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
    class GoalDroit: Rectangle
    {
        #region Initialisation des variables
        private Rectangle  hautG, hautD, basGauche, basDroite,LigneGaucheRect, LigneHautRect, LigneBasRect;

        private Rectangle_Tourne poteauG, poteauD, transversale, poteauG2, poteauD2, BasArriere;
        #endregion

        #region Constructeurs
        public GoalDroit(Graphics g, int xSol, int ySol, int xlongueurSol, int yhauteurSol) : base(g, xSol, ySol, xlongueurSol, yhauteurSol)
        {
            transversale = new Rectangle_Tourne(g, 832, 102, 5, 100, Color.White, Color.White,0.10);
            poteauG = new Rectangle_Tourne(g, 830, 100, 5, 88, Color.White, Color.White,-0.08);
            poteauD = new Rectangle_Tourne(g, 840, 210, 5, 80, Color.White, Color.White,-0.16);
            hautG = new Rectangle(g, 830, 92, 40, 5, Color.White, Color.White);
            hautD = new Rectangle(g, 845, 202, 45, 5, Color.White, Color.White);
            poteauG2 = new Rectangle_Tourne(g, 870, 102, 5, 85, Color.White, Color.White, 0.35);
            poteauD2 = new Rectangle_Tourne(g, 890, 210, 5, 82, Color.White, Color.White, 0.32);
            BasArriere = new Rectangle_Tourne(g, 905, 200, 5, 80, Color.White, Color.White, 0.15);
            basGauche = new Rectangle(g, 825,190, 80, 5, Color.White, Color.White);
            basDroite = new Rectangle(g, 825, 290, 96, 5, Color.White, Color.White);
            LigneGaucheRect = new Rectangle(g, 750, 195, 1, 100, Color.White, Color.White);
            LigneHautRect = new Rectangle(g, 750, 195, 72, 1, Color.White, Color.White);
            LigneBasRect = new Rectangle(g, 750, 295, 75, 1, Color.White, Color.White);
        }
        #endregion

        #region Méthodes
        public override void Afficher(Graphics g)
        {

            base.Afficher(g);
            poteauG.Afficher(g);
            poteauD.Afficher(g);
            transversale.Afficher(g);
            hautG.Afficher(g);
            hautD.Afficher(g);
            BasArriere.Afficher(g);
            poteauG2.Afficher(g);
            poteauD2.Afficher(g);
            basGauche.Afficher(g);
            basDroite.Afficher(g);
            LigneGaucheRect.Afficher(g);
            LigneHautRect.Afficher(g);
            LigneBasRect.Afficher(g);

        }
        #endregion
    }
}
