using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using static System.Math;

namespace WindowsFormsApp2
{
    class Rectangle_Tourne : Point
    {
        #region Données membres
        public Color _Pot;
        private int _Longueur, _Hauteur, _X, _Y;
        private double _Angle;
        #endregion

        #region Constructeur
        public Rectangle_Tourne(Graphics g, int x, int y, int longueur, int hauteur, Color crayon, Color pot, double Angle) : base(g, x, y,crayon)
        {
            this.Angle = Angle;
            this.Longueur = longueur;
            this.Hauteur = hauteur;
            this._X = x;
            this._Y = y;
            this._Pot = pot;
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
            get { return _Pot; }
            set
            {
                try { _Pot = value; }
                catch (Exception) { }
            }
        }


        public System.Drawing.Point HautG
        {
            get
            {
                return new System.Drawing.Point(X,Y);
            }
            set
            {

            }
        }

        public System.Drawing.Point HautD
        {
            get
            {
                return new System.Drawing.Point((int)(X + Longueur * Cos(Angle)), (int)(Y - Longueur * Sin(Angle)));
            }

        }

        public System.Drawing.Point BasG
        {
            get
            {
                return new System.Drawing.Point((int)(X + Hauteur * Cos(3 * PI / 2 + Angle)), (int)(Y - Hauteur * Sin(3 * PI / 2 + Angle)));
            }
        }

        public System.Drawing.Point BasD
        {
            get
            {
                return new System.Drawing.Point((int)(X + Longueur * Cos(Angle) + Hauteur * Cos(3 * PI / 2 + Angle)), (int)(Y - Longueur * Sin(Angle) - Hauteur * Sin(3 * PI / 2 + Angle)));
            }
        }

        public System.Drawing.Point MI
        {
            get
            {
                return new System.Drawing.Point((BasG.X + BasD.X) / 2, (BasG.Y + BasD.Y) / 2);
            }
        }

        public System.Drawing.Point MS
        {
            get
            {
                return new System.Drawing.Point((HautG.X + HautD.X) / 2, (HautG.Y + HautD.Y) / 2);
            }
        }

        public double Angle
        {
            get => _Angle; set => _Angle = value;
        }


        #endregion

        #region Méthodes
        public override void Afficher(Graphics g)
        {
            System.Drawing.Point[] p = new System.Drawing.Point[4];
            p[0] = HautG;
            p[1] = HautD;
            p[2] = BasD;
            p[3] = BasG;

            if(this.Visible)
            {
                g.FillClosedCurve(new SolidBrush(this.Pot), p);
                g.DrawClosedCurve(new Pen(this.Pot), p);
            }
        }

        public override void Cacher(IntPtr handle)
        {
            System.Drawing.Point[] p = new System.Drawing.Point[4];
            p[0] = HautG;
            p[1] = HautD;
            p[2] = BasD;
            p[3] = BasG;

            if (this.Visible)
            {
                Graphics gr = Graphics.FromHwnd(handle);
                gr.FillClosedCurve(new SolidBrush(this.Fond), p);
                gr.DrawClosedCurve(new Pen(this.Fond), p);
            }

        }


        public override void Cacher(Graphics g)
        {
            System.Drawing.Point[] p = new System.Drawing.Point[4];
            p[0] = HautG;
            p[1] = HautD;
            p[2] = BasD;
            p[3] = BasG;

            if (this.Visible)
            {
                g.FillClosedCurve(new SolidBrush(this.Fond), p);
                g.DrawClosedCurve(new Pen(this.Fond), p);
            }

        }

        public void Bouger(int deplX, int deplY, double diffangle)
        {
            base.Bouger(deplX, deplY);
            Angle += diffangle;

        }


        #endregion 
    }
}
