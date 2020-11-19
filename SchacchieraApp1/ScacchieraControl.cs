using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchacchieraApp1
{
    class ScacchieraControl:Control
    {
        int lato;
        public int Lato
        {
            get { return lato; }
            set { lato = value; Refresh(); }
        }
        public ScacchieraControl()
        {

        }
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            var g = e.Graphics;
            //decido il lato della casella (1/8 della dimensione minore)
            if (Width < Height)
                lato = Width / 8;
            else lato = Height / 8;
            for(int i=0; i<8; i++)
            {
                for(int j=0; j<8; j++)
                {
                    //assegno x e y del punto da cui iniziare a fare il quadrato
                    int x = i * Lato;
                    int y = j * Lato;
                    //se sia riga che colonna sono pari o dispari ci metto il colore chiaro
                    if (j % 2 == 1 && i % 2 == 1 || j % 2 == 0 && i % 2 == 0)  
                        g.FillRectangle(Brushes.LightPink, new Rectangle(x, y, Lato, Lato));
                    else
                        //altrimenti quello scuro <3
                        g.FillRectangle(Brushes.HotPink, new Rectangle(x, y, Lato, Lato));
                }
            }
            //per le stringhe devo ancora pensarlo un attimo uwu
        }
    }
}
