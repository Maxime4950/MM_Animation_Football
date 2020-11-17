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
    class Sol : Cercle
    {

        #region Initialisation des variables
        private Cercle Centre;

        private Rectangle Terrain, LigneCentre, ExterieurHaut, ExterieurBas, LigneExterieureHaut, LigneExterieureBas, LigneGoalD,ligneGoalG;
        #endregion

        #region Constructeurs
        public Sol(Graphics g, int xSol, int ySol, int xlongueurSol, int yhauteurSol) : base(g, xSol, ySol, xlongueurSol, yhauteurSol)
        {
            Terrain = new Rectangle(g, 1, 160, 941, 170,Color.Green,Color.Green);
            LigneCentre = new Rectangle(g, 468, 160, 1, 175,Color.White,Color.White);
            Centre = new Cercle(g, 470, 240,40, Color.White, Color.Transparent);
            ExterieurHaut = new Rectangle(g, 1, 149, 941, 10, Color.Green, Color.Green);
            ExterieurBas = new Rectangle(g, 1, 330, 941, 30, Color.Green, Color.Green);
            LigneExterieureHaut = new Rectangle(g, 115, 160, 715, 1, Color.White, Color.White);
            LigneExterieureBas = new Rectangle(g, 115, 335, 710, 1, Color.White, Color.White);
            LigneGoalD = new Rectangle(g, 825, 160, 1, 175, Color.White, Color.White);
            ligneGoalG = new Rectangle(g, 115, 160, 1, 175, Color.White, Color.White);
        }
        #endregion

        #region Méthodes
        public override void Afficher(Graphics g)
        {  
            base.Afficher(g);
            Terrain.Afficher(g);
            ExterieurHaut.Afficher(g);
            ExterieurBas.Afficher(g);
            LigneExterieureHaut.Afficher(g);
            LigneExterieureBas.Afficher(g);
            Centre.Afficher(g);
            LigneCentre.Afficher(g);
            LigneGoalD.Afficher(g);
            ligneGoalG.Afficher(g);
        }
        
        public override void Cacher(Graphics g)
        {
            base.Cacher(g);;
            Terrain.Cacher(g);
            ExterieurHaut.Cacher(g);
            ExterieurBas.Cacher(g);
            LigneExterieureHaut.Cacher(g);
            LigneExterieureBas.Cacher(g);
            Centre.Cacher(g);
            LigneCentre.Cacher(g);
            LigneGoalD.Afficher(g);
            ligneGoalG.Afficher(g);

        }
        #endregion
    }
}


