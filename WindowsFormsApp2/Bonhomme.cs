using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;


namespace WindowsFormsApp2
{
    class Bonhomme : Rectangle
    {
        #region Données membres
        private Cercle _Tete;
        private Rectangle _Bras_Droit, _Bras_Gauche, _Jambe_Droite, _Jambe_Gauche;
        #endregion

        #region Accesseurs
        public Cercle Tete
        {
            get { return _Tete; }
            set { _Tete = value; }
        }

        public Rectangle Bras_Droit
        {
            get { return _Bras_Droit; }
            set { _Bras_Droit = value; }
        }
        public Rectangle Bras_Gauche
        {
            get { return _Bras_Gauche; }
            set { _Bras_Gauche = value; }
        }

        public Rectangle Jambe_Droite
        {
            get { return _Jambe_Droite; }
            set { _Jambe_Droite = value; }
        }

        public Rectangle Jambe_Gauche
        {
            get { return _Jambe_Gauche; }
            set { _Jambe_Gauche = value; }
        }


        #endregion

        #region Constructeurs
        public Bonhomme(Graphics g, int xsg, int ysg, int longueur, int hauteur, Color crayon, Color pot) : base(g, xsg, ysg, longueur, hauteur, crayon, pot)
        {
            this.Tete = new Cercle(g, xsg + longueur / 2, ysg - hauteur / 3, hauteur / 3, Color.Brown, Color.Brown);
            this.Bras_Droit = new Rectangle(g, longueur / 2 - 5 + xsg, hauteur / 6 + ysg, longueur / 4, hauteur / 3 * 2, Color.Black, Color.Red);
            this.Bras_Gauche = new Rectangle(g, longueur / 2 - 5 + xsg, hauteur / 6 + ysg, longueur / 4, hauteur / 3 * 2, Color.Black, Color.Red);
            this.Jambe_Droite = new Rectangle(g, longueur / 2 - 5 + xsg, hauteur + ysg - 10, longueur / 4, hauteur / 5 * 5, Color.Black, Color.Red);
            this.Jambe_Gauche = new Rectangle(g, longueur / 2 - 5 + xsg, hauteur + ysg - 10, longueur / 4, hauteur / 5 * 5, Color.Black, Color.Red);

        }
        #endregion

        #region Méthodes
        public override void Afficher(Graphics g)
        {
            base.Afficher(g);

            this.Tete.Afficher(g);
            this.Bras_Droit.Afficher(g);
            this.Bras_Gauche.Afficher(g);
            this.Jambe_Droite.Afficher(g);
            this.Jambe_Gauche.Afficher(g);
        }
        public override void Cacher(Graphics g)
        {
            base.Cacher(g);

            this.Tete.Cacher(g);
            this.Bras_Droit.Cacher(g);
            this.Bras_Gauche.Cacher(g);
            this.Jambe_Droite.Cacher(g);
            this.Jambe_Gauche.Cacher(g);
        }
        public override void Bouger(int deplX, int deplY)
        {
            base.Bouger(deplX, deplY);

            this.Tete.Bouger(deplX, deplY);
            this.Bras_Droit.Bouger(deplX, deplY);
            this.Bras_Gauche.Bouger(deplX, deplY);
            this.Jambe_Gauche.Bouger(deplX, deplY);
            this._Jambe_Droite.Bouger(deplX, deplY);
        }

        #endregion
    }
}
