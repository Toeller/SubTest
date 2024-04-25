using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubTest
{
    //Datenklasse
    internal class Testergebnis
    {
        private int idProband = -1;
        private int idBild = -1;
        private int gezeigteZiffer = -1;
        private TimeSpan time = TimeSpan.Zero;
        private bool correct = false;

        public int IdProband { get => idProband; set => idProband = value; }
        public int IdBild { get => idBild; set => idBild = value; }
        public int GezeigteZiffer { get => gezeigteZiffer; set => gezeigteZiffer = value; }
        public TimeSpan Time { get => time; set => time = value; }
        public bool Correct { get => correct; set => correct = value; }


        public Testergebnis()
        {

        }
        public Testergebnis(int idProband, int idBild,int gezeigteZiffer,TimeSpan time, bool correct)
        {
            IdProband = idProband;
            IdBild = idBild;
            GezeigteZiffer= gezeigteZiffer;
            Time = time;
            Correct = correct;
        }
    }
}
