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
    class Decor
    {
        #region Initialisation des variables
        private Ballon balle;

        private Sol terrain;

        private GoalDroit goalD;

        private GoalGauche goalG;

        private Tribune tribune;

        private Spectateur spect1, spect2, spect3, spect4;

        private GardienGauche gardienG;

        private Drapeau drapeauBelge;

        private Escalier escalier;

        private Arbre arbre;
        #endregion

        #region Constructeurs
        public Decor(Graphics g)
        {
            balle = new Ballon(g, 100, 100, 100, 100);
            terrain = new Sol(g, 300, 300, 300, 100);
            goalD = new GoalDroit(g, 100, 100, 100, 100);
            goalG = new GoalGauche(g, 100, 100, 100, 100);
            tribune = new Tribune(g, 100, 100, 100, 100);
            spect1 = new Spectateur(g, 300, 50, 30, 60, Color.Yellow, Color.Yellow);
            spect2 = new Spectateur(g, 400, 50, 30, 60, Color.Red, Color.Red);
            spect3 = new Spectateur(g, 500, 50, 30, 60, Color.Blue, Color.Blue);
            spect4 = new Spectateur(g, 600, 50, 30, 60, Color.Purple, Color.Purple);
            drapeauBelge = new Drapeau(g, 80, 10, 5, 100);
            escalier = new Escalier(g, 179, 120, 10, 10);
            gardienG = new GardienGauche(g, 135, 140, 30, 85, Color.Black, Color.Yellow);
            arbre = new Arbre(g, 830, 30, 30, 120);
        }
        #endregion

        #region Accesseurs
        public Ballon Balle //Pour utilisation dans scène
        {
            get { return balle; }
            set { balle = value; }
        }
        #endregion

        #region Méthodes
        public virtual void Afficher(Graphics g)
        {
            escalier.Afficher(g);
            terrain.Afficher(g);
            spect1.Afficher(g);
            spect2.Afficher(g);
            spect3.Afficher(g);
            spect4.Afficher(g);
            drapeauBelge.Afficher(g);
            goalG.Afficher(g);
            balle.Afficher(g);
            arbre.Afficher(g);
            goalD.Afficher(g);
            gardienG.Afficher(g);
            tribune.Afficher(g);      
        }

        public virtual void Cacher(Graphics g)
        {
            balle.Cacher(g);
            escalier.Cacher(g);
            terrain.Cacher(g);
            tribune.Cacher(g);
            spect1.Cacher(g);
            spect2.Cacher(g);
            spect3.Cacher(g);
            spect4.Cacher(g);
            gardienG.Cacher(g);
            drapeauBelge.Cacher(g);
            goalD.Cacher(g);
            arbre.Cacher(g);
            goalG.Cacher(g);
        }

        public virtual void Bouger(int deplX, int deplY)
        {
            balle.Bouger(deplX, deplY);
        }

        #endregion
    }
}
