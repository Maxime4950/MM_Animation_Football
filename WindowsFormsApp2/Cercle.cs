using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace WindowsFormsApp2
{
    public class Cercle : Point
    {
        #region Initialisation des variables
        private bool _Visible = true;
        private int _Rayon = 1;
        private Graphics g;
        private int xSol;
        private int ySol;
        private int xlongueurSol;
        private int yhauteurSol;
        private Color Pot;
        #endregion

        #region Constructeurs
        public Cercle(Graphics g, int xc, int yc, int rayon, Color crayon, Color pot)
        : base(g, xc, yc, crayon)
        {
            Rayon = rayon; //On utilise les accesseurs
            Pot = pot;
        }

        public Cercle(Graphics g, int xSol, int ySol, int xlongueurSol, int yhauteurSol)
        {
            this.g = g;
            this.xSol = xSol;
            this.ySol = ySol;
            this.xlongueurSol = xlongueurSol;
            this.yhauteurSol = yhauteurSol;
        }
        #endregion

        #region Accesseurs
        public int Rayon
        {
            get { return this._Rayon; }
            set
            {
                if (value <= 0) this._Rayon = 1;
                else this._Rayon = value;
            }
        }

        #endregion

        #region Méthodes
        public override void Afficher(IntPtr handle)
        {
            if(this._Visible)
            {
                Graphics gr = Graphics.FromHwnd(handle);
                gr.DrawEllipse(new Pen(this.Pot), this.X - this.Rayon, this.Y - this.Rayon, 2 * this.Rayon, 2 * this.Rayon);
                gr.FillEllipse(new SolidBrush(this.Crayon), this.X - this.Rayon, this.Y - this.Rayon, 2 * this.Rayon, 2 * this.Rayon);
            }
        }

        public override void Cacher(IntPtr handle)
        {
            if (this._Visible)
            {
                Graphics gr = Graphics.FromHwnd(handle);
                gr.FillEllipse(new SolidBrush(this.Fond), this.X - this.Rayon, this.Y - this.Rayon, 2 * this.Rayon, 2 * this.Rayon);
                gr.DrawEllipse(new Pen(this.Fond), this.X - this.Rayon, this.Y - this.Rayon, 2 * this.Rayon, 2 * this.Rayon);
            }
        }
        

        #region Modification contre le scintillement
        public override void Afficher(Graphics gr)
        {
            if (this._Visible)
            {
                gr.FillEllipse(new SolidBrush(this.Pot), this.X - this.Rayon, this.Y - this.Rayon, 2 * this.Rayon, 2 * this.Rayon);
                gr.DrawEllipse(new Pen(this.Crayon), this.X - this.Rayon, this.Y - this.Rayon, 2 * this.Rayon, 2 * this.Rayon);
            }
        }

        public override void Cacher(Graphics gr)
        {
            if (this._Visible)
            {
                gr.FillEllipse(new SolidBrush(this.Fond), this.X - this.Rayon, this.Y - this.Rayon, 2 * this.Rayon, 2 * this.Rayon);
                gr.DrawEllipse(new Pen(this.Fond), this.X - this.Rayon, this.Y - this.Rayon, 2 * this.Rayon, 2 * this.Rayon);
            }
        }

        #endregion
        #endregion

    }
}
