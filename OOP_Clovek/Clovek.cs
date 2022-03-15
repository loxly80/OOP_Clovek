using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Clovek
{
    public class Clovek
    {
        // soukromé proměnné - nejsou dostupné mimo třídu Clovek
        private int energie;
        private int dovednost;

        // vlastnosti - zveřejňují hodnoty ven z třídy
        public string Jmeno { get; set; }
        public string Prijmeni { get; set; }
        public DateTime DatumNarozeni { get; set; }
        public int Energie { get => energie; }
        public int Zivot { get; set; }
        public int Dovednost { get => dovednost; }

        //konstruktor - pomocí této metody vznikne konkrétní objekt - instance třídy
        public Clovek()
        {
            Jmeno = "";
            Prijmeni = "";
            DatumNarozeni = DateTime.Now;
            energie = 100;
            Zivot = 100;
            dovednost = 0;
        }
        

        public void ZvysitDovednost()
        {
            dovednost += 20;
            energie += 10;
        }
    }
}
