using System;
using System.Collections.Generic;using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using System.Threading;

// C'est dans cette classe que je créer la scène c'est à dire:
// - Affichage du décor
// - Affichage du perso
// - Déplacement perso, balle, etc

namespace WindowsFormsApp2
{
    class Scene:Footballeur
    {
        #region Initialisation des variables
        private Footballeur foot,passeur;
        private FootballeurAdverse joueurAdverse1;
        private GardienDroit gardienD;
        private Arbitre arbitre;

        private Decor decor;
        #endregion

        #region Constructeurs
        public Scene(Graphics g): base(g,100,100,100,100,Color.Red,Color.Red)
        {
            foot = new Footballeur(g, 370, 150, 30, 80, Color.Red, Color.Red);
            passeur = new Footballeur(g, 230, 100, 30, 80, Color.Red, Color.Red);
            joueurAdverse1 = new FootballeurAdverse(g, 700, 100, 30, 80, Color.Blue, Color.Blue);
            gardienD = new GardienDroit(g, 800, 160, 30, 85, Color.Green, Color.Green);
            decor = new Decor(g);
            arbitre = new Arbitre(g, 450, 80, 30, 80, Color.White, Color.White);
        }
        #endregion

        #region Méthodes

        //LANCEMENT DU DESSIN ANIME
        public void lancerScene(PictureBox pict, Graphics g, BufferedGraphics bufferG)
        {
            int i = 0;


            bufferG = BufferedGraphicsManager.Current.Allocate(pict.CreateGraphics(), pict.DisplayRectangle); 
            g = bufferG.Graphics;
            if (i == 0)
            {
                g.Clear(pict.BackColor);
                Afficher(g);
                i++;
            }

            while (i < 8)
            {
                Marcher(50, 0, g, pict, bufferG);
                i++;
            }

            Passer(50, 0, g, pict, bufferG);

            while (i < 15)
            {
                MarcherGardienAdverse(-20, 0, g, pict, bufferG);
                i++;
            }

            if (i == 15)
            {

                Tirer(60, 0, g, pict, bufferG);
            }

            bufferG.Render(); // permet l'affichage
            System.Threading.Thread.Sleep(500);

        }
        //AFFICHAGE DES ELEMENTS
        public override void Afficher(Graphics g)
        {
            decor.Afficher(g);
            arbitre.Afficher(g);
            joueurAdverse1.Afficher(g);
            gardienD.Afficher(g);
            passeur.Afficher(g);
            foot.Afficher(g);
            
        }

        //CACHER LES ELEMENTS
        public override void Cacher(Graphics g)
        {
            decor.Cacher(g);
            arbitre.Cacher(g);
            joueurAdverse1.Cacher(g);
            gardienD.Cacher(g);
            passeur.Cacher(g);
            foot.Cacher(g);
           
        }

        //DEPLACEMENT FOOTBALLEUR | PASSEUR | JOUEUR_ADVERSE
        public virtual void Marcher(int deplX, int deplY, Graphics g, PictureBox pict, BufferedGraphics bufferG)
        {
            int deplXneg = -20;

            g.Clear(pict.BackColor);
            decor.Afficher(g);
            passeur.Cacher(g);
            foot.Cacher(g);
            joueurAdverse1.Cacher(g);
            joueurAdverse1.Bouger(0, 0, Math.PI / 15, Math.PI / 15, Math.PI / 15, Math.PI / 10, -Math.PI / 20, -Math.PI / 15, -Math.PI / 20, Math.PI / 20);
            passeur.Bouger(0, 0, Math.PI / 15, Math.PI / 15, -Math.PI / 15, -Math.PI / 10, -Math.PI / 20, Math.PI / 15, Math.PI / 20, Math.PI / 20);
            foot.Bouger(0, 0, Math.PI / 15, Math.PI / 15, -Math.PI / 15, -Math.PI / 10, -Math.PI / 20, Math.PI / 15, Math.PI / 20, Math.PI / 20);
            Afficher(g);
            bufferG.Render();
            Thread.Sleep(30);


            g.Clear(pict.BackColor);
            decor.Afficher(g);
            passeur.Cacher(g);
            foot.Cacher(g);
            joueurAdverse1.Cacher(g);
            joueurAdverse1.Bouger(0, 0, Math.PI / 15, Math.PI / 15, Math.PI / 15, Math.PI / 10, -Math.PI / 20, -Math.PI / 15, -Math.PI / 20, Math.PI / 20);
            passeur.Bouger(0, 0, Math.PI / 15, Math.PI / 15, -Math.PI / 15, -Math.PI / 10, -Math.PI / 20, Math.PI / 15, Math.PI / 20, Math.PI / 20);
            foot.Bouger(0, 0, Math.PI / 15, Math.PI / 15, -Math.PI / 15, -Math.PI / 10, -Math.PI / 20, Math.PI / 15, Math.PI / 20, Math.PI / 20);
            Afficher(g);
            bufferG.Render();
            Thread.Sleep(30);

            g.Clear(pict.BackColor);
            decor.Afficher(g);
            passeur.Cacher(g);
            foot.Cacher(g);
            joueurAdverse1.Cacher(g);
            joueurAdverse1.Bouger(0, 0, Math.PI / 15, Math.PI / 15, Math.PI / 15, Math.PI / 10, -Math.PI / 20, -Math.PI / 15, -Math.PI / 20, Math.PI / 20);
            passeur.Bouger(0, 0, Math.PI / 15, Math.PI / 15, -Math.PI / 15, -Math.PI / 10, -Math.PI / 20, Math.PI / 15, Math.PI / 20, Math.PI / 20);
            foot.Bouger(0, 0, Math.PI / 15, Math.PI / 15, -Math.PI / 15, -Math.PI / 10, -Math.PI / 20, Math.PI / 15, Math.PI / 20, Math.PI / 20);
            Afficher(g);
            bufferG.Render();
            Thread.Sleep(30);


            g.Clear(pict.BackColor);
            decor.Afficher(g);
            passeur.Cacher(g);
            foot.Cacher(g);
            joueurAdverse1.Cacher(g);
            joueurAdverse1.Bouger(0, 0, Math.PI / 15, Math.PI / 15, Math.PI / 15, Math.PI / 10, -Math.PI / 20, -Math.PI / 15, -Math.PI / 20, Math.PI / 20);
            passeur.Bouger(0, 0, Math.PI / 15, Math.PI / 15, -Math.PI / 15, -Math.PI / 10, -Math.PI / 20, Math.PI / 15, Math.PI / 20, Math.PI / 20);
            foot.Bouger(0, 0, Math.PI / 15, Math.PI / 15, -Math.PI / 15, -Math.PI / 10, -Math.PI / 20, Math.PI / 15, Math.PI / 20, Math.PI / 20);
            Afficher(g);
            bufferG.Render();
            Thread.Sleep(30);


            //////////////////////////////////////////

            foot.Cacher(g);
            passeur.Cacher(g);
            joueurAdverse1.Cacher(g);
            joueurAdverse1.Bouger(deplXneg / 10, deplY / 15, -Math.PI / 15, -Math.PI / 15, -Math.PI / 15, -Math.PI / 10, Math.PI / 20, Math.PI / 15, Math.PI / 20, -Math.PI / 20);
            passeur.Bouger(deplX / 15, deplY / 15, -Math.PI / 15, -Math.PI / 15, Math.PI / 15, Math.PI / 10, Math.PI / 20, -Math.PI / 15, -Math.PI / 20, -Math.PI / 20);
            foot.Bouger(deplX / 20, deplY / 20, -Math.PI / 15, -Math.PI / 15, Math.PI / 15, Math.PI / 10, Math.PI / 20, -Math.PI / 15, -Math.PI / 20, -Math.PI / 20);
            Afficher(g);
            bufferG.Render();
            Thread.Sleep(30);

            foot.Cacher(g);
            passeur.Cacher(g);
            joueurAdverse1.Cacher(g);
            joueurAdverse1.Bouger(deplXneg / 10, deplY / 15, -Math.PI / 15, -Math.PI / 15, -Math.PI / 15, -Math.PI / 10, Math.PI / 20, Math.PI / 15, Math.PI / 20, -Math.PI / 20);
            passeur.Bouger(deplX / 15, deplY / 15, -Math.PI / 15, -Math.PI / 15, Math.PI / 15, Math.PI / 10, Math.PI / 20, -Math.PI / 15, -Math.PI / 20, -Math.PI / 20);
            foot.Bouger(deplX / 20, deplY / 20, -Math.PI / 15, -Math.PI / 15, Math.PI / 15, Math.PI / 10, Math.PI / 20, -Math.PI / 15, -Math.PI / 20, -Math.PI / 20);
            Afficher(g);
            bufferG.Render();
            Thread.Sleep(30);


            foot.Cacher(g);
            passeur.Cacher(g);
            joueurAdverse1.Cacher(g);
            joueurAdverse1.Bouger(deplXneg / 10, deplY / 15, -Math.PI / 15, -Math.PI / 15, -Math.PI / 15, -Math.PI / 10, Math.PI / 20, Math.PI / 15, Math.PI / 20, -Math.PI / 20);
            passeur.Bouger(deplX / 15, deplY / 15, -Math.PI / 15, -Math.PI / 15, Math.PI / 15, Math.PI / 10, Math.PI / 20, -Math.PI / 15, -Math.PI / 20, -Math.PI / 20);
            foot.Bouger(deplX / 20, deplY / 20, -Math.PI / 15, -Math.PI / 15, Math.PI / 15, Math.PI / 10, Math.PI / 20, -Math.PI / 15, -Math.PI / 20, -Math.PI / 20);
            Afficher(g);
            bufferG.Render();
            Thread.Sleep(30);

            foot.Cacher(g);
            passeur.Cacher(g);
            joueurAdverse1.Cacher(g);
            joueurAdverse1.Bouger(deplXneg / 10, deplY / 15, -Math.PI / 15, -Math.PI / 15, -Math.PI / 15, -Math.PI / 10, Math.PI / 20, Math.PI / 15, Math.PI / 20, -Math.PI / 20);
            passeur.Bouger(deplX / 15, deplY / 15, -Math.PI / 15, -Math.PI / 15, Math.PI / 15, Math.PI / 10, Math.PI / 20, -Math.PI / 15, -Math.PI / 20, -Math.PI / 20);
            foot.Bouger(deplX / 20, deplY / 20, -Math.PI / 15, -Math.PI / 15, Math.PI / 15, Math.PI / 10, Math.PI / 20, -Math.PI / 15, -Math.PI / 20, -Math.PI / 20);
            Afficher(g);
            bufferG.Render();
            Thread.Sleep(30);

            DeplBallonPasseur(52, 0, g, pict, bufferG);


            //////////////////////////////////////////

            foot.Cacher(g);
            passeur.Cacher(g);
            joueurAdverse1.Cacher(g);
            joueurAdverse1.Bouger(deplXneg / 10, deplY / 15, -Math.PI / 15, Math.PI / 15, -Math.PI / 20, Math.PI / 20, Math.PI / 20, -Math.PI / 15, Math.PI / 15, Math.PI / 15);
            passeur.Bouger(deplX / 15, deplY / 15, -Math.PI / 20, Math.PI / 15, Math.PI / 20, Math.PI / 20, Math.PI / 15, Math.PI / 15, -Math.PI / 10, -Math.PI / 10);
            foot.Bouger(deplX / 20, deplY / 20, -Math.PI / 20, Math.PI / 15, Math.PI / 20, Math.PI / 20, Math.PI / 15, Math.PI / 15, -Math.PI / 10, -Math.PI / 10);
            Afficher(g);
            bufferG.Render();
            Thread.Sleep(30);


            foot.Cacher(g);
            passeur.Cacher(g);
            joueurAdverse1.Cacher(g);
            joueurAdverse1.Bouger(deplXneg / 10, deplY / 15, -Math.PI / 15, Math.PI / 15, -Math.PI / 20, Math.PI / 20, Math.PI / 20, -Math.PI / 15, Math.PI / 15, Math.PI / 15);
            passeur.Bouger(deplX / 15, deplY / 15, -Math.PI / 20, Math.PI / 15, Math.PI / 20, Math.PI / 20, Math.PI / 15, Math.PI / 15, -Math.PI / 10, -Math.PI / 10);
            foot.Bouger(deplX / 20, deplY / 20, -Math.PI / 20, Math.PI / 15, Math.PI / 20, Math.PI / 20, Math.PI / 15, Math.PI / 15, -Math.PI / 10, -Math.PI / 10);
            Afficher(g);
            bufferG.Render();
            Thread.Sleep(30);


            foot.Cacher(g);
            passeur.Cacher(g);
            joueurAdverse1.Cacher(g);
            joueurAdverse1.Bouger(deplXneg / 10, deplY / 15, -Math.PI / 15, Math.PI / 15, -Math.PI / 20, Math.PI / 20, Math.PI / 20, -Math.PI / 15, Math.PI / 15, Math.PI / 15);
            passeur.Bouger(deplX / 15, deplY / 15, -Math.PI / 20, Math.PI / 15, Math.PI / 20, Math.PI / 20, Math.PI / 15, Math.PI / 15, -Math.PI / 10, -Math.PI / 10);
            foot.Bouger(deplX / 20, deplY / 20, -Math.PI / 20, Math.PI / 15, Math.PI / 20, Math.PI / 20, Math.PI / 15, Math.PI / 15, -Math.PI / 10, -Math.PI / 10);
            Afficher(g);
            bufferG.Render();
            Thread.Sleep(30);


            foot.Cacher(g);
            passeur.Cacher(g);
            joueurAdverse1.Cacher(g);
            joueurAdverse1.Bouger(deplXneg / 10, deplY / 15, -Math.PI / 15, Math.PI / 15, -Math.PI / 20, Math.PI / 20, Math.PI / 20, -Math.PI / 15, Math.PI / 15, Math.PI / 15);
            passeur.Bouger(deplX / 15, deplY / 15, -Math.PI / 20, Math.PI / 15, Math.PI / 20, Math.PI / 20, Math.PI / 15, Math.PI / 15, -Math.PI / 10, -Math.PI / 10);
            foot.Bouger(deplX / 20, deplY / 20, -Math.PI / 20, Math.PI / 15, Math.PI / 20, Math.PI / 20, Math.PI / 15, Math.PI / 15, -Math.PI / 10, -Math.PI / 10);
            Afficher(g);
            bufferG.Render();
            Thread.Sleep(30);



            //////////////////////////////////////////

            foot.Cacher(g);
            passeur.Cacher(g);
            joueurAdverse1.Cacher(g);
            joueurAdverse1.Bouger(deplXneg / 15, deplY / 15, Math.PI / 15, -Math.PI / 15, Math.PI / 20, -Math.PI / 20, -Math.PI / 20, Math.PI / 15, -Math.PI / 15, -Math.PI / 15);
            passeur.Bouger(deplX / 15, deplY / 15, Math.PI / 20, -Math.PI / 15, -Math.PI / 20, -Math.PI / 20, -Math.PI / 15, -Math.PI / 15, Math.PI / 10, Math.PI / 10);
            foot.Bouger(deplX / 20, deplY / 20, Math.PI / 20, -Math.PI / 15, -Math.PI / 20, -Math.PI / 20, -Math.PI / 15, -Math.PI / 15, Math.PI / 10, Math.PI / 10);
            Afficher(g);
            bufferG.Render();
            Thread.Sleep(30);


            foot.Cacher(g);
            passeur.Cacher(g);
            joueurAdverse1.Cacher(g);
            joueurAdverse1.Bouger(deplXneg / 15, deplY / 15, Math.PI / 15, -Math.PI / 15, Math.PI / 20, -Math.PI / 20, -Math.PI / 20, Math.PI / 15, -Math.PI / 15, -Math.PI / 15);
            passeur.Bouger(deplX / 15, deplY / 15, Math.PI / 20, -Math.PI / 15, -Math.PI / 20, -Math.PI / 20, -Math.PI / 15, -Math.PI / 15, Math.PI / 10, Math.PI / 10);
            foot.Bouger(deplX / 15, deplY / 15, Math.PI / 20, -Math.PI / 15, -Math.PI / 20, -Math.PI / 20, -Math.PI / 15, -Math.PI / 15, Math.PI / 10, Math.PI / 10);
            Afficher(g);
            bufferG.Render();
            Thread.Sleep(30);


            foot.Cacher(g);
            passeur.Cacher(g);
            joueurAdverse1.Cacher(g);
            joueurAdverse1.Bouger(deplXneg / 15, deplY / 15, Math.PI / 15, -Math.PI / 15, Math.PI / 20, -Math.PI / 20, -Math.PI / 20, Math.PI / 15, -Math.PI / 15, -Math.PI / 15);
            passeur.Bouger(deplX / 15, deplY / 15, Math.PI / 20, -Math.PI / 15, -Math.PI / 20, -Math.PI / 20, -Math.PI / 15, -Math.PI / 15, Math.PI / 10, Math.PI / 10);
            foot.Bouger(deplX / 20, deplY / 20, Math.PI / 20, -Math.PI / 15, -Math.PI / 20, -Math.PI / 20, -Math.PI / 15, -Math.PI / 15, Math.PI / 10, Math.PI / 10);
            Afficher(g);
            bufferG.Render();
            Thread.Sleep(30);


            foot.Cacher(g);
            passeur.Cacher(g);
            joueurAdverse1.Cacher(g);
            joueurAdverse1.Bouger(deplXneg / 15, deplY / 15, Math.PI / 15, -Math.PI / 15, Math.PI / 20, -Math.PI / 20, -Math.PI / 20, Math.PI / 15, -Math.PI / 15, -Math.PI / 15);
            passeur.Bouger(deplX / 15, deplY / 15, Math.PI / 20, -Math.PI / 15, -Math.PI / 20, -Math.PI / 20, -Math.PI / 15, -Math.PI / 15, Math.PI / 10, Math.PI / 10);
            foot.Bouger(deplX / 20, deplY / 20, Math.PI / 20, -Math.PI / 15, -Math.PI / 20, -Math.PI / 20, -Math.PI / 15, -Math.PI / 15, Math.PI / 10, Math.PI / 10);
            Afficher(g);
            Thread.Sleep(30);
            bufferG.Render();

        }

        //DEPLACEMENT GARDIEN ADVERSE)
        public virtual void MarcherGardienAdverse(int deplX, int deplY, Graphics g, PictureBox pict, BufferedGraphics bufferG)
        {

            g.Clear(pict.BackColor);
            decor.Afficher(g);
            gardienD.Cacher(g);
            gardienD.Bouger(0, 0, Math.PI / 15, Math.PI / 15, Math.PI / 15, Math.PI / 10, -Math.PI / 20, -Math.PI / 15, -Math.PI / 20, Math.PI / 20);
            Afficher(g);
            bufferG.Render();
            Thread.Sleep(10);


            g.Clear(pict.BackColor);
            decor.Afficher(g);
            gardienD.Cacher(g);
            gardienD.Bouger(0, 0, Math.PI / 15, Math.PI / 15, Math.PI / 15, Math.PI / 10, -Math.PI / 20, -Math.PI / 15,-Math.PI / 20, Math.PI / 20);
            Afficher(g);
            bufferG.Render();
            Thread.Sleep(10);

            g.Clear(pict.BackColor);
            decor.Afficher(g);
            gardienD.Cacher(g);
            gardienD.Bouger(0, 0, Math.PI / 15, Math.PI / 15, Math.PI / 15, Math.PI / 10, -Math.PI / 20, -Math.PI / 15, -Math.PI / 20, Math.PI / 20);
            Afficher(g);
            bufferG.Render();
            Thread.Sleep(10);


            g.Clear(pict.BackColor);
            decor.Afficher(g);
            gardienD.Cacher(g);
            gardienD.Bouger(0, 0, Math.PI / 15, Math.PI / 15, Math.PI / 15, Math.PI / 10, -Math.PI / 20, -Math.PI / 15, -Math.PI / 20, Math.PI / 20);
            Afficher(g);
            bufferG.Render();
            Thread.Sleep(10);

            //////////////////////////////////////////

            foot.Cacher(g);
            gardienD.Cacher(g);
            gardienD.Bouger(deplX / 10, deplY / 15, -Math.PI / 15, -Math.PI / 15, -Math.PI / 15, -Math.PI / 10, Math.PI / 20, Math.PI / 15, Math.PI / 20, -Math.PI / 20);
            Afficher(g);
            bufferG.Render();
            Thread.Sleep(10);

            foot.Cacher(g);
            gardienD.Cacher(g);
            gardienD.Bouger(deplX / 10, deplY / 15, -Math.PI / 15, -Math.PI / 15, -Math.PI / 15, -Math.PI / 10, Math.PI / 20, Math.PI / 15, Math.PI / 20, -Math.PI / 20);
            Afficher(g);
            bufferG.Render();
            Thread.Sleep(10);


            foot.Cacher(g);
            gardienD.Cacher(g);
            gardienD.Bouger(deplX / 10, deplY / 15, -Math.PI / 15, -Math.PI / 15, -Math.PI / 15, -Math.PI / 10, Math.PI / 20, Math.PI / 15, Math.PI / 20, -Math.PI / 20);
            Afficher(g);
            bufferG.Render();
            Thread.Sleep(10);

            foot.Cacher(g);
            gardienD.Cacher(g);
            gardienD.Bouger(deplX / 10, deplY / 15, -Math.PI / 15, -Math.PI / 15, -Math.PI / 15, -Math.PI / 10, Math.PI / 20, Math.PI / 15, Math.PI / 20, -Math.PI / 20);
            Afficher(g);
            bufferG.Render();
            Thread.Sleep(10);


            //////////////////////////////////////////
            
            g.Clear(pict.BackColor);
            decor.Afficher(g);
            gardienD.Cacher(g);
            gardienD.Bouger(deplX / 10, deplY / 15, -Math.PI / 15, Math.PI / 15, -Math.PI / 20, Math.PI / 20, Math.PI / 20, -Math.PI / 15, Math.PI / 15, Math.PI / 15);
            Afficher(g);
            bufferG.Render();
            Thread.Sleep(10);

            g.Clear(pict.BackColor);
            decor.Afficher(g);
            gardienD.Cacher(g);
            gardienD.Bouger(deplX / 10, deplY / 15, -Math.PI / 15, Math.PI / 15, -Math.PI / 20, Math.PI / 20, Math.PI / 20, -Math.PI / 15, Math.PI / 15, Math.PI / 15);
            Afficher(g);
            bufferG.Render();
            Thread.Sleep(10);

            g.Clear(pict.BackColor);
            decor.Afficher(g);
            gardienD.Cacher(g);
            gardienD.Bouger(deplX / 10, deplY / 15, -Math.PI / 15, Math.PI / 15, -Math.PI / 20, Math.PI / 20, Math.PI / 20, -Math.PI / 15, Math.PI / 15, Math.PI / 15);
            Afficher(g);
            bufferG.Render();
            Thread.Sleep(10);

            g.Clear(pict.BackColor);
            decor.Afficher(g);
            gardienD.Cacher(g);
            gardienD.Bouger(deplX / 10, deplY / 15, -Math.PI / 15, Math.PI / 15, -Math.PI / 20, Math.PI / 20, Math.PI / 20, -Math.PI / 15, Math.PI / 15, Math.PI / 15);
            Afficher(g);
            bufferG.Render();
            Thread.Sleep(10);

            /////////////////////////////////

            foot.Cacher(g);
            gardienD.Cacher(g);
            gardienD.Bouger(deplX / 15, deplY / 15, Math.PI / 15, -Math.PI / 15, Math.PI / 20, -Math.PI / 20, -Math.PI / 20, Math.PI / 15, -Math.PI / 15, -Math.PI / 15);
            Afficher(g);
            bufferG.Render();
            Thread.Sleep(10);

            foot.Cacher(g);
            gardienD.Cacher(g);
            gardienD.Bouger(deplX / 15, deplY / 15, Math.PI / 15, -Math.PI / 15, Math.PI / 20, -Math.PI / 20, -Math.PI / 20, Math.PI / 15, -Math.PI / 15, -Math.PI / 15);
            Afficher(g);
            bufferG.Render();
            Thread.Sleep(10);


            foot.Cacher(g);
            gardienD.Cacher(g);
            gardienD.Bouger(deplX / 15, deplY / 15, Math.PI / 15, -Math.PI / 15, Math.PI / 20, -Math.PI / 20, -Math.PI / 20, Math.PI / 15, -Math.PI / 15, -Math.PI / 15);
            Afficher(g);
            bufferG.Render();
            Thread.Sleep(10);

            foot.Cacher(g);
            gardienD.Cacher(g);
            gardienD.Bouger(deplX / 15, deplY / 15, Math.PI / 15, -Math.PI / 15, Math.PI / 20, -Math.PI / 20, -Math.PI / 20, Math.PI / 15, -Math.PI / 15, -Math.PI / 15);
            Afficher(g);
            bufferG.Render();
            Thread.Sleep(10);


        }

        //TIRER DANS LE BALLON -> MARQUER + FETER (SAUTER)
        public virtual void Tirer(int deplX, int deplY, Graphics g, PictureBox pict, BufferedGraphics bufferG)
        {
            g.Clear(pict.BackColor);
            decor.Afficher(g);
            foot.Cacher(g);
            foot.Bouger(0, 0, Math.PI / 20, -Math.PI / 15, -Math.PI / 20, -Math.PI / 20, -Math.PI / 15, -Math.PI / 15, Math.PI / 15, -Math.PI / 20);
            Afficher(g);
            bufferG.Render();
            Thread.Sleep(30);

            g.Clear(pict.BackColor);
            decor.Afficher(g);
            foot.Cacher(g);
            foot.Bouger(0, 0, Math.PI / 20, -Math.PI / 15, -Math.PI / 20, -Math.PI / 20, -Math.PI / 15, -Math.PI / 15, Math.PI / 15, -Math.PI / 20);
            Afficher(g);
            bufferG.Render();
            Thread.Sleep(30);

            g.Clear(pict.BackColor);
            decor.Afficher(g);
            foot.Cacher(g);
            foot.Bouger(0, 0, Math.PI / 20, -Math.PI / 15, -Math.PI / 20, -Math.PI / 20, -Math.PI / 15, -Math.PI / 15, Math.PI / 15, -Math.PI / 20);
            Afficher(g);
            bufferG.Render();
            Thread.Sleep(30);

            g.Clear(pict.BackColor);
            decor.Afficher(g);
            foot.Cacher(g);
            foot.Bouger(0, 0, Math.PI / 20, -Math.PI / 15, -Math.PI / 20, -Math.PI / 20, -Math.PI / 15, -Math.PI / 15, Math.PI / 15, -Math.PI / 20);
            Afficher(g);
            bufferG.Render();
            Thread.Sleep(100);

            //TIR AU GOAL
            g.Clear(pict.BackColor);
            decor.Afficher(g);
            foot.Cacher(g);
            Marquer(15, 5, g, pict, bufferG);
            Afficher(g);
            bufferG.Render();
            Thread.Sleep(300);



            ///////////////

            g.Clear(pict.BackColor);
            decor.Afficher(g);
            foot.Cacher(g);
            foot.Bouger(deplX / 15, deplY / 15, -Math.PI / 20, Math.PI / 15, Math.PI / 20, Math.PI / 20, Math.PI / 15, Math.PI / 15, -Math.PI / 15, Math.PI / 20);
            Afficher(g);
            bufferG.Render();
            Thread.Sleep(30);

            g.Clear(pict.BackColor);
            decor.Afficher(g);
            foot.Cacher(g);
            foot.Bouger(deplX / 15, deplY / 15, -Math.PI / 20, Math.PI / 15, Math.PI / 20, Math.PI / 20, Math.PI / 15, Math.PI / 15, -Math.PI / 15, Math.PI / 20);
            Afficher(g);
            bufferG.Render();
            Thread.Sleep(30);

            g.Clear(pict.BackColor);
            decor.Afficher(g);
            foot.Cacher(g);
            foot.Bouger(deplX / 15, deplY / 15, -Math.PI / 20, Math.PI / 15, Math.PI / 20, Math.PI / 20, Math.PI / 15, Math.PI / 15, -Math.PI / 15, Math.PI / 20);
            Afficher(g);
            bufferG.Render();
            Thread.Sleep(30);

            g.Clear(pict.BackColor);
            decor.Afficher(g);
            foot.Cacher(g);
            foot.Bouger(deplX / 15, deplY / 15, -Math.PI / 20, Math.PI / 15, Math.PI / 20, Math.PI / 20, Math.PI / 15, Math.PI / 15, -Math.PI / 15, Math.PI / 20);
            Afficher(g);
            bufferG.Render();
            Thread.Sleep(30);

            //FETER GOAL
            g.Clear(pict.BackColor);
            decor.Afficher(g);
            foot.Cacher(g);
            passeur.Cacher(g);
            Sauter(0, 0, g, pict, bufferG);
            Afficher(g);
            bufferG.Render();
        }

        //MARQUER UN GOAL -> UTILISE DANS TIRER
        public virtual void Marquer(int deplX, int deplY, Graphics g, PictureBox pict, BufferedGraphics bufferG)
        {
            g.Clear(pict.BackColor);
            decor.Afficher(g);
            decor.Balle.Bouger(deplX, -deplY);
            Afficher(g);
            bufferG.Render();
            Thread.Sleep(30);

            g.Clear(pict.BackColor);
            decor.Afficher(g);
            decor.Balle.Bouger(deplX, -deplY);
            Afficher(g);
            bufferG.Render();
            Thread.Sleep(30);

            g.Clear(pict.BackColor);
            decor.Afficher(g);
            decor.Balle.Bouger(deplX, -deplY);
            Afficher(g);
            bufferG.Render();
            Thread.Sleep(30);

            g.Clear(pict.BackColor);
            decor.Afficher(g);
            decor.Balle.Bouger(deplX, -deplY);
            Afficher(g);
            bufferG.Render();
            Thread.Sleep(30);

            g.Clear(pict.BackColor);
            decor.Afficher(g);
            decor.Balle.Bouger(deplX, -deplY);
            Afficher(g);
            bufferG.Render();
            Thread.Sleep(30);

            g.Clear(pict.BackColor);
            decor.Afficher(g);
            decor.Balle.Bouger(deplX, -deplY);
            Afficher(g);
            bufferG.Render();
            Thread.Sleep(30);

            g.Clear(pict.BackColor);
            decor.Afficher(g);
            decor.Balle.Bouger(deplX, -deplY);
            Afficher(g);
            bufferG.Render();
            Thread.Sleep(30);

            ///////////////////////////////////
            
            g.Clear(pict.BackColor);
            decor.Afficher(g);
            decor.Balle.Bouger(deplX, 0);
            Afficher(g);
            bufferG.Render();
            Thread.Sleep(30);

            g.Clear(pict.BackColor);
            decor.Afficher(g);
            decor.Balle.Bouger(deplX, 0);
            Afficher(g);
            bufferG.Render();
            Thread.Sleep(30);

            g.Clear(pict.BackColor);
            decor.Afficher(g);
            decor.Balle.Bouger(deplX, 0);
            Afficher(g);
            bufferG.Render();
            Thread.Sleep(30);

            g.Clear(pict.BackColor);
            decor.Afficher(g);
            decor.Balle.Bouger(deplX, 0);
            Afficher(g);
            bufferG.Render();
            Thread.Sleep(30);

            g.Clear(pict.BackColor);
            decor.Afficher(g);
            decor.Balle.Bouger(deplX, 0);
            Afficher(g);
            bufferG.Render();
            Thread.Sleep(30);

            g.Clear(pict.BackColor);
            decor.Afficher(g);
            decor.Balle.Bouger(deplX, 0);
            Afficher(g);
            bufferG.Render();
            Thread.Sleep(30);

            g.Clear(pict.BackColor);
            decor.Afficher(g);
            decor.Balle.Bouger(deplX, 0);
            Afficher(g);
            bufferG.Render();
            Thread.Sleep(30);

            g.Clear(pict.BackColor);
            decor.Afficher(g);
            decor.Balle.Bouger(deplX, 0);
            Afficher(g);
            bufferG.Render();
            Thread.Sleep(30);

            ////////////////////////////////

            g.Clear(pict.BackColor);
            decor.Afficher(g);
            decor.Balle.Bouger(deplX, deplY);
            Afficher(g);
            bufferG.Render();
            Thread.Sleep(30);

            g.Clear(pict.BackColor);
            decor.Afficher(g);
            decor.Balle.Bouger(deplX, deplY);
            Afficher(g);
            bufferG.Render();
            Thread.Sleep(30);

            g.Clear(pict.BackColor);
            decor.Afficher(g);
            decor.Balle.Bouger(deplX, deplY);
            Afficher(g);
            bufferG.Render();
            Thread.Sleep(30);

            g.Clear(pict.BackColor);
            decor.Afficher(g);
            decor.Balle.Bouger(deplX, deplY);
            Afficher(g);
            bufferG.Render();
            Thread.Sleep(30);
        }

        //SAUTER SUR PLACE -> UTILISE DANS TIRER
        public virtual void Sauter(int deplX, int deplY, Graphics g, PictureBox pict, BufferedGraphics bufferG)
        {
            int i = 0;
            g.Clear(pict.BackColor);
            decor.Afficher(g);
            foot.Cacher(g);
            passeur.Cacher(g);
            passeur.Bouger(0, 0, 0, 0, 0, 0, 0, 0, 0, 0);
            foot.Bouger(0, 0, 0, 0, 0, 0, 0, 0, 0, 0);
            Afficher(g);
            bufferG.Render();
            Thread.Sleep(30);

            ////////////////////////////

            while (i < 10)
            {
                g.Clear(pict.BackColor);
                decor.Afficher(g);
                foot.Cacher(g);
                passeur.Cacher(g);
                passeur.Bouger(0, -2, 0, 0, 0, 0, 0, 0, 0, 0);
                foot.Bouger(0, -2, 0, 0, 0, 0, 0, 0, 0, 0);
                Afficher(g);
                bufferG.Render();
                Thread.Sleep(20);

                g.Clear(pict.BackColor);
                decor.Afficher(g);
                foot.Cacher(g);
                passeur.Cacher(g);
                passeur.Bouger(0, -2, 0, 0, 0, 0, 0, 0, 0, 0);
                foot.Bouger(0, -2, 0, 0, 0, 0, 0, 0, 0, 0);
                Afficher(g);
                bufferG.Render();
                Thread.Sleep(20);

                g.Clear(pict.BackColor);
                decor.Afficher(g);
                foot.Cacher(g);
                passeur.Cacher(g);
                passeur.Bouger(0, -2, 0, 0, 0, 0, 0, 0, 0, 0);
                foot.Bouger(0, -2, 0, 0, 0, 0, 0, 0, 0, 0);
                Afficher(g);
                bufferG.Render();
                Thread.Sleep(20);

                g.Clear(pict.BackColor);
                decor.Afficher(g);
                foot.Cacher(g);
                passeur.Cacher(g);
                passeur.Bouger(0, -2, 0, 0, 0, 0, 0, 0, 0, 0);
                foot.Bouger(0, -2, 0, 0, 0, 0, 0, 0, 0, 0);
                Afficher(g);
                bufferG.Render();
                Thread.Sleep(20);

                g.Clear(pict.BackColor);
                decor.Afficher(g);
                foot.Cacher(g);
                passeur.Cacher(g);
                passeur.Bouger(0, -2, 0, 0, 0, 0, 0, 0, 0, 0);
                foot.Bouger(0, -2, 0, 0, 0, 0, 0, 0, 0, 0);
                Afficher(g);
                bufferG.Render();
                Thread.Sleep(20);

                /////////////////////////////////////////

                g.Clear(pict.BackColor);
                decor.Afficher(g);
                foot.Cacher(g);
                passeur.Bouger(0, 2, 0, 0, 0, 0, 0, 0, 0, 0);
                foot.Bouger(0, 2, 0, 0, 0, 0, 0, 0, 0, 0);
                Afficher(g);
                bufferG.Render();
                Thread.Sleep(20);
                i++;

                g.Clear(pict.BackColor);
                decor.Afficher(g);
                foot.Cacher(g);
                passeur.Bouger(0, 2, 0, 0, 0, 0, 0, 0, 0, 0);
                foot.Bouger(0, 2, 0, 0, 0, 0, 0, 0, 0, 0);
                Afficher(g);
                bufferG.Render();
                Thread.Sleep(20);
                i++;

                g.Clear(pict.BackColor);
                decor.Afficher(g);
                foot.Cacher(g);
                passeur.Bouger(0, 2, 0, 0, 0, 0, 0, 0, 0, 0);
                foot.Bouger(0, 2, 0, 0, 0, 0, 0, 0, 0, 0);
                Afficher(g);
                bufferG.Render();
                Thread.Sleep(20);
                i++;

                g.Clear(pict.BackColor);
                decor.Afficher(g);
                foot.Cacher(g);
                passeur.Bouger(0, 2, 0, 0, 0, 0, 0, 0, 0, 0);
                foot.Bouger(0, 2, 0, 0, 0, 0, 0, 0, 0, 0);
                Afficher(g);
                bufferG.Render();
                Thread.Sleep(20);
                i++;

                g.Clear(pict.BackColor);
                decor.Afficher(g);
                foot.Cacher(g);
                passeur.Bouger(0, 2, 0, 0, 0, 0, 0, 0, 0, 0);
                foot.Bouger(0, 2, 0, 0, 0, 0, 0, 0, 0, 0);
                Afficher(g);
                bufferG.Render();
                Thread.Sleep(20);
                i++;

            }
        }

        //DEPLACEMENT DU BALLON

        //La méthode DeplBallon est utilisée dans la méthode marcher afin que le ballon avance en même temps que le personnage qui va faire la passe
        public virtual void DeplBallonPasseur(int deplX, int deplY, Graphics g, PictureBox pict, BufferedGraphics bufferG)
        {
            g.Clear(pict.BackColor);
            decor.Afficher(g);
            decor.Balle.Bouger(deplX / 6, deplY);
            Afficher(g);
            bufferG.Render();
            Thread.Sleep(10);

            g.Clear(pict.BackColor);
            decor.Afficher(g);
            decor.Balle.Bouger(deplX / 6, deplY+1);
            Afficher(g);
            bufferG.Render();
            Thread.Sleep(10);


            g.Clear(pict.BackColor);
            decor.Afficher(g);
            decor.Balle.Bouger(deplX / 6, deplY+1);
            Afficher(g);
            bufferG.Render();
            Thread.Sleep(10);


            g.Clear(pict.BackColor);
            decor.Afficher(g);
            decor.Balle.Bouger(deplX / 5, deplY);
            Afficher(g);
            bufferG.Render();
            Thread.Sleep(10);


        }

        //PASSE DU PASSEUR
        public virtual void Passer(int deplX, int deplY, Graphics g, PictureBox pict, BufferedGraphics bufferG)
        {
            int i = 0;

            g.Clear(pict.BackColor);
            decor.Afficher(g);
            passeur.Cacher(g);
            passeur.Bouger(0, 0, Math.PI / 20, -Math.PI / 15, -Math.PI / 20, -Math.PI / 20, -Math.PI / 15, -Math.PI / 15, Math.PI / 15, -Math.PI / 20);
            Afficher(g);
            bufferG.Render();
            Thread.Sleep(30);

            g.Clear(pict.BackColor);
            decor.Afficher(g);
            passeur.Cacher(g);
            passeur.Bouger(0, 0, Math.PI / 20, -Math.PI / 15, -Math.PI / 20, -Math.PI / 20, -Math.PI / 15, -Math.PI / 15, Math.PI / 15, -Math.PI / 20);
            Afficher(g);
            bufferG.Render();
            Thread.Sleep(30);

            g.Clear(pict.BackColor);
            decor.Afficher(g);
            passeur.Cacher(g);
            passeur.Bouger(0, 0, Math.PI / 20, -Math.PI / 15, -Math.PI / 20, -Math.PI / 20, -Math.PI / 15, -Math.PI / 15, Math.PI / 15, -Math.PI / 20);
            Afficher(g);
            bufferG.Render();
            Thread.Sleep(30);

            g.Clear(pict.BackColor);
            decor.Afficher(g);
            passeur.Cacher(g);
            passeur.Bouger(0, 0, Math.PI / 20, -Math.PI / 15, -Math.PI / 20, -Math.PI / 20, -Math.PI / 15, -Math.PI / 15, Math.PI / 15, -Math.PI / 20);
            Afficher(g);
            bufferG.Render();

            Thread.Sleep(100);

            //TIR AU GOAL
            g.Clear(pict.BackColor);
            decor.Afficher(g);
            passeur.Cacher(g);
            BallonPasse(20, 0, g, pict, bufferG);
            Afficher(g);
            bufferG.Render();


            Thread.Sleep(300);

            while (i<35)
            {
                BallonPasse(20, 0, g, pict, bufferG);
                i++;
            }
            


            ///////////////

            g.Clear(pict.BackColor);
            decor.Afficher(g);
            passeur.Cacher(g);
            passeur.Bouger(deplX / 15, deplY / 15, -Math.PI / 20, Math.PI / 15, Math.PI / 20, Math.PI / 20, Math.PI / 15, Math.PI / 15, -Math.PI / 15, Math.PI / 20);
            Afficher(g);
            bufferG.Render();
            Thread.Sleep(10);

            g.Clear(pict.BackColor);
            decor.Afficher(g);
            passeur.Cacher(g);
            passeur.Bouger(deplX / 15, deplY / 15, -Math.PI / 20, Math.PI / 15, Math.PI / 20, Math.PI / 20, Math.PI / 15, Math.PI / 15, -Math.PI / 15, Math.PI / 20);
            Afficher(g);
            bufferG.Render();
            Thread.Sleep(10);

            g.Clear(pict.BackColor);
            decor.Afficher(g);
            passeur.Cacher(g);
            passeur.Bouger(deplX / 15, deplY / 15, -Math.PI / 20, Math.PI / 15, Math.PI / 20, Math.PI / 20, Math.PI / 15, Math.PI / 15, -Math.PI / 15, Math.PI / 20);
            Afficher(g);
            bufferG.Render();
            Thread.Sleep(10);

            g.Clear(pict.BackColor);
            decor.Afficher(g);
            passeur.Cacher(g);
            passeur.Bouger(deplX / 15, deplY / 15, -Math.PI / 20, Math.PI / 15, Math.PI / 20, Math.PI / 20, Math.PI / 15, Math.PI / 15, -Math.PI / 15, Math.PI / 20);
            Afficher(g);
            bufferG.Render();
            Thread.Sleep(10);
        }

        //EFFET DU BALON DURANT LA PASSE -> UTILISE DANS PASSER
        public virtual void BallonPasse(int deplX, int deplY, Graphics g, PictureBox pict, BufferedGraphics bufferG)
        {
            g.Clear(pict.BackColor);
            decor.Afficher(g);
            decor.Balle.Bouger(deplX/9, -deplY+1);
            Afficher(g);
            bufferG.Render();
            Thread.Sleep(10);
        }

        #endregion
    }
}
