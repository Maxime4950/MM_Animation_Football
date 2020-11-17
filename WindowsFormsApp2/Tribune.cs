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
    class Tribune: Rectangle
    {
        #region Initialisation des variables
        private Rectangle tribuneBas, tribuneBas2, piquet1, piquet2, barre, piquetHautGauche, piquetHautDroit, barreHaut;
        #endregion

        #region Constructeurs
        public Tribune(Graphics g, int xSol, int ySol, int xlongueurSol, int yhauteurSol) : base(g, xSol, ySol, xlongueurSol, yhauteurSol)
        {
            tribuneBas = new Rectangle(g, 230, 98, 500, 50, Color.LightGray, Color.LightGray);
            tribuneBas2 = new Rectangle(g, 230, 96, 500, 10, Color.Gray, Color.Gray);
            piquet1 = new Rectangle(g, 230, 82, 10, 20, Color.Gray, Color.Gray);
            piquet2 = new Rectangle(g, 720, 82, 10, 20, Color.Gray, Color.Gray);
            barre = new Rectangle(g, 230, 75, 500, 10, Color.LightGray, Color.LightGray);
            piquetHautGauche = new Rectangle(g, 230, 10, 10, 100, Color.Gray, Color.Gray);
            piquetHautDroit = new Rectangle(g, 720, 10, 10, 100, Color.Gray, Color.Gray);
            barreHaut = new Rectangle(g, 230, 2, 500, 15, Color.LightGray, Color.LightGray);
        }
        #endregion

        #region Méthodes
        public override void Afficher(Graphics g)
        {

            base.Afficher(g);
            piquetHautDroit.Afficher(g);
            piquetHautGauche.Afficher(g);
            barreHaut.Afficher(g);
            tribuneBas.Afficher(g);
            tribuneBas2.Afficher(g);
            piquet1.Afficher(g);
            piquet2.Afficher(g);
            barre.Afficher(g);
           
        }

        public override void Cacher(Graphics g)
        {
            base.Cacher(g);
            piquetHautDroit.Cacher(g);
            piquetHautGauche.Cacher(g);
            barreHaut.Cacher(g);
            tribuneBas.Cacher(g);
            tribuneBas2.Cacher(g);
            piquet1.Cacher(g);
            piquet2.Cacher(g);
            barre.Cacher(g);
        }
        #endregion
    }
}
