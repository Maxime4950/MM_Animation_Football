using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public class Point
    {
        #region Initialisation des variables
        private int _X = 0;
        private int _Y = 0;
        private bool _Visible = true;
        private Graphics _Graph;
        private Color fond = Color.Silver;
        private Color crayon = Color.Yellow; //crayon -> couleur du point
        private int xy;
        #endregion

        #region Constructeurs

        //Constructeurs Ecran

        public Point()
        {
            this._Graph = null;
        }

        public Point(Graphics g)
        {
            this._Graph = g;
        }

        public Point(Graphics g, int xy) : this(g)
        {
            this.xy = xy;
        }

        public Point(Graphics g, int x, int y) : this(g)
        {
            X = x;
            Y = y;
        }


        public Point(Graphics g, int xy, Color crayon) : this(g, xy)
        {
            Crayon = crayon;
        }

        public Point(Graphics g, int x, int y, Color crayon)
        {
            this._Graph = g;
            this.X = x;
            this.Y = y;
            this.Crayon = crayon;
        }

        #endregion

        #region Accesseur

        public Graphics Graph
        {
            get { return _Graph; }
            set { _Graph = value; }
        }

        public int X
        {
            get { return _X; }
            set { _X = value; }
        }
        public int Y
        {
            get { return _Y; }
            set { _Y = value; }
        }


        public Color Fond
        {
            get { return fond; }
            set
            {
                try { fond = value; }
                catch (Exception) { }
            }
        }

        public bool Visible
        {
            get { return _Visible; }
            set { _Visible = value; }
        }

        public Color Crayon
        {
            get { return crayon; }
            set
            {
                try { crayon = value; }
                catch (Exception) { }
            }
        }


      

        #endregion

        #region Méthodes
        public virtual void Bouger(int deplX, int deplY)
        {
            X += deplX;
            Y += deplY;
        }

        public virtual void Afficher(IntPtr handle)
        {
            //MessageBox.Show(handle.ToString());
            if (this._Visible)
            {
                Graphics gr = Graphics.FromHwnd(handle);
                gr.FillEllipse(new SolidBrush(Color.Red), this.X + 40, this.Y, 10, 10);
                gr.DrawEllipse(new Pen(this.Fond, 3), this.X + 40, this.Y, 10, 10);
            }
        }

        public virtual void Cacher(IntPtr handle)
        {
            if (this._Visible)
            {
                Graphics gr = Graphics.FromHwnd(handle);
                gr.FillEllipse(new SolidBrush(this.Fond), this.X + 40, this.Y, 10, 10);
                gr.DrawEllipse(new Pen(this.Fond, 3), this.X + 40, this.Y, 10, 10);
            }
        }

        public virtual void Cacher(Graphics gr)
        {
            if (this._Visible)
            {
                gr.FillEllipse(new SolidBrush(this.Fond), this.X + 40, this.Y, 10, 10);
                gr.DrawEllipse(new Pen(this.Fond, 3), this.X + 40, this.Y, 10, 10);
            }
        }

        public virtual void Afficher(Graphics gr)
        {
            //MessageBox.Show(handle.ToString());
            if (this._Visible)
            {
                gr.FillEllipse(new SolidBrush(Color.Red), this.X + 40, this.Y, 10, 10);
                gr.DrawEllipse(new Pen(this.Fond, 3), this.X + 40, this.Y, 10, 10);
            }
        }
        #endregion
    }
}
