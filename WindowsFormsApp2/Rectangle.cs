using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace WindowsFormsApp2
{
    public class Rectangle : Point
    {
        #region Initialisation des variables
        private Color _Pot = Color.Red;
        private int _Longueur = 1, _Hauteur = 1;
        private bool _Visible = true;
        private Graphics g;
        private int xcorps;
        private int ycorps;
        private int xlongueur;
        private int yhauteur;


        #endregion

        #region Constructeurs

        public Rectangle(Graphics g, int xcorps, int ycorps, int xlongueur, int yhauteur)
        {
            this.g = g;
            this.xcorps = xcorps;
            this.ycorps = ycorps;
            this.xlongueur = xlongueur;
            this.yhauteur = yhauteur;
        }

        public Rectangle(Graphics g, int xsg, int ysg, int longueur, int hauteur, Color crayon, Color pot)
             : base(g, xsg, ysg, crayon)
        {
            Longueur = longueur;
            Hauteur = hauteur;
            Pot = pot;
        }

        #endregion

        #region Accesseurs
        public int Longueur
        {
            get { return this._Longueur; }
            set
            {
                if (value <= 0) this._Longueur = 1;
                else this._Longueur = value;
            }
        }
        public int Hauteur
        {
            get { return this._Hauteur; }
            set
            {
                if (value <= 0) this._Hauteur = 1;
                else this._Hauteur = value;
            }
        }

        public Color Pot
        {
            get { return this._Pot; }
            set
            {
                try { this._Pot = value; }
                catch { }
            }
        }
        #endregion

        #region Méthodes
        public override void Afficher(IntPtr handle)
        {
            if (this._Visible)
            {
                Graphics gr = Graphics.FromHwnd(handle);
                gr.FillRectangle(new SolidBrush(this.Pot), this.X, this.Y, this.Longueur, this.Hauteur);
                gr.DrawRectangle(new Pen(this.Crayon), this.X, this.Y, this.Longueur, this.Hauteur);
            }
        }

        public override void Afficher(Graphics gr)
        {
            if (this._Visible)
            {
                gr.FillRectangle(new SolidBrush(this.Pot), this.X, this.Y, this.Longueur, this.Hauteur);
                gr.DrawRectangle(new Pen(this.Crayon), this.X, this.Y, this.Longueur, this.Hauteur);
            }
        }

        #region Modification contre le scintillement
        public override void Cacher(IntPtr handle)
        {
            if (this._Visible)
            {
                Graphics gr = Graphics.FromHwnd(handle);
                gr.FillRectangle(new SolidBrush(this.Fond), this.X, this.Y, this.Longueur, this.Hauteur);
                gr.DrawRectangle(new Pen(this.Fond), this.X, this.Y, this.Longueur, this.Hauteur);
            }
        }

        public override void Cacher(Graphics gr)
        {
            if (this._Visible)
            {
                gr.FillRectangle(new SolidBrush(this.Fond), this.X, this.Y, this.Longueur, this.Hauteur);
                gr.DrawRectangle(new Pen(this.Fond), this.X, this.Y, this.Longueur, this.Hauteur);
            }
        }
        #endregion

        #endregion

    }
}
