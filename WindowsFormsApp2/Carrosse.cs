using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace WindowsFormsApp2
{
    public class Carrosse : Rectangle
    {
        #region Initialisation des variables
        private Cercle _RoueG, _RoueD;
        private Rectangle _Porte, _FenD, _FenG, _Poignee;
        #endregion

        #region Accesseurs
        public Cercle RoueG
        {
            get { return _RoueG; }
            set { _RoueG = value; }
        }
        public Cercle RoueD
        {
            get { return _RoueD; }
            set { _RoueD = value; }
        }
        public Rectangle Porte
        {
            get { return _Porte; }
            set { _Porte = value; }
        }
        public Rectangle Poignee
        {
            get { return _Poignee; }
            set { _Poignee = value; }
        }

        public Rectangle FenG
        {
            get { return _FenG; }
            set { _FenG = value; }
        }

        public Rectangle FenD
        {
            get { return _FenD; }
            set { _FenD = value; }
        }

        #endregion

        #region Constructeur
        public Carrosse(Graphics g, int xsg, int ysg, int longueur, int hauteur, Color crayon, Color pot) : base(g, xsg, ysg, longueur, hauteur, crayon, pot)
        {
            this.RoueG = new Cercle(g, xsg, ysg + hauteur, hauteur / 2, Color.Brown, Color.Brown);
            this.RoueD = new Cercle(g, xsg + longueur, ysg + hauteur, hauteur / 2, Color.Brown, Color.Brown);
            this.FenG = new Rectangle(g, longueur / 10 + xsg, hauteur / 6 + ysg, longueur / 5, hauteur / 3, Color.Yellow, Color.Brown);
            this.FenD = new Rectangle(g, xsg + longueur - 3 * longueur / 10, hauteur / 6 + ysg, longueur / 5, hauteur / 3, Color.Yellow, Color.Brown);
            this.Porte = new Rectangle(g, xsg + longueur / 2 - 2 * longueur / 15, ysg + hauteur - 3 * hauteur / 4 - 1, 4 * longueur / 15, 3 * hauteur / 4, Color.Yellow, Color.Brown);
            this.Poignee = new Rectangle(g, xsg + longueur / 2 + longueur / 30, hauteur / 2 + ysg, longueur / 15, hauteur / 15, Color.Yellow, Color.Brown);
            this.Crayon = Color.Red;
            this.Pot = Color.Gold;
            this.FenG.Pot = this.FenD.Pot = Color.Navy;
            this.Porte.Pot = Color.Red;
            this.Poignee.Pot = this.Poignee.Crayon = Color.Yellow;
        }
        #endregion

        #region Méthodes
        /*public override void AfficherCarrosse(IntPtr handle)
        {
            base.Afficher(handle);

            this.RoueG.Afficher(handle);
            this.RoueD.Afficher(handle);
            this.FenD.Afficher(handle);
            this.FenG.Afficher(handle);
            this.Porte.Afficher(handle);
            this.Poignee.Afficher(handle);
        }
        public override void CacherCarosse(IntPtr handle)
        {
            base.Cacher(handle);

            this.RoueG.Cacher(handle);
            this.RoueD.Cacher(handle);
            this.FenD.Cacher(handle);
            this.FenG.Cacher(handle);
            this.Porte.Cacher(handle);
            this.Poignee.Cacher(handle);
        }
        public override void BougerCarrosse(int deplX, int deplY)
        {
            base.Bouger(deplX, deplY);

            /*this.RoueG.Bouger(deplX, deplY);
            this.RoueD.Bouger(deplX, deplY);
            this.FenD.Bouger(deplX, deplY);
            this.FenG.Bouger(deplX, deplY);
            this.Porte.Bouger(deplX, deplY);
            this.Poignee.Bouger(deplX, deplY);
        }
        */

        #endregion

    }


}
