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
    class Ballon : Cercle
    {
        #region Initialisation des variables
        private Cercle structure;
        #endregion

        #region Constructeurs
        public Ballon(Graphics g, int xSol, int ySol, int xlongueurSol, int yhauteurSol) : base(g, xSol, ySol, xlongueurSol, yhauteurSol)
        {

            structure = new Cercle(g, 280, 205, 15, Color.Black, Color.Orange);
        }
        #endregion

        #region Méthodes
        public override void Afficher(Graphics g)
        {
            structure.Afficher(g);
            base.Afficher(g);
        }

        public override void Bouger(int deplX, int deplY)
        {
            structure.Bouger(deplX, deplY);
        }
        #endregion
    }
}
