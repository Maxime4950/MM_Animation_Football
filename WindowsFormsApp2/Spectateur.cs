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
    class Spectateur: Rectangle
    {
        #region Initialisation des variables
        private Bras brasG, brasD;
        private Cercle Tete, OeilD,OeilG, bouche;
        #endregion

        #region Constructeurs
        public Spectateur(Graphics g, int xcorps, int ycorps, int xlongueur, int yhauteur,
            Color crayon, Color centercolor) : base(g, xcorps, ycorps, xlongueur, yhauteur, crayon, centercolor)
        {
            Tete = new Cercle(g, xcorps + xlongueur / 2, (ycorps - xlongueur / 2), xlongueur / 2, Color.Black, Color.LightPink);

            OeilD = new Cercle(g, xcorps + xlongueur - 7, (ycorps - (xlongueur / 2) -3), xlongueur / 10, Color.Black, Color.Black);

            OeilG = new Cercle(g, xcorps + xlongueur - 15, (ycorps - xlongueur / 2 - 3), xlongueur / 10, Color.Black, Color.Black);

            bouche = new Cercle(g, xcorps + xlongueur - 11, (ycorps - xlongueur / 3), xlongueur / 8, Color.Black, Color.Transparent);
           
            brasD = new Bras(g, xcorps + xlongueur, ycorps + 2, xlongueur / 3, yhauteur / 3 , Color.Black, Color.White, 0);

            brasG = new Bras(g, xcorps + xlongueur / 6 - 10, ycorps + 2, xlongueur / 3, yhauteur / 3, Color.Black, Color.White, 0);
        }
        #endregion

        #region Méthodes
        public override void Afficher(Graphics g)
        {

            base.Afficher(g);
            Tete.Afficher(g);
            OeilD.Afficher(g);
            OeilG.Afficher(g);
            bouche.Afficher(g);
            brasD.Afficher(g);
            brasG.Afficher(g);
        }
        #endregion
    }
}
