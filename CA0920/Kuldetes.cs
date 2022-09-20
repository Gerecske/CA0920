using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA0920
{
    internal class Kuldetes
    {
        public string Kod { get; set; }
        public DateOnly KilovesNapja { get; set; }
        public string SikloNeve { get; set; }
        private int KoldetesenToltotNap { get; set; }
        private int KoldetesenToltotOra { get; set; }

        public int KuldetesHossza
        {
            get
            {
                return KoldetesenToltotNap * 24 + KoldetesenToltotOra;
            }
        }
        public string ErkezesHelye { get; set; }
        public int UtasokSzama { get; set; }
        public Kuldetes(string fileEgySora)
        {
            var adattagok = fileEgySora.Split(';');
            Kod = adattagok[0];
            KilovesNapja = DateOnly.Parse(adattagok[1]);
            SikloNeve = adattagok[2];
            KoldetesenToltotNap = int.Parse(adattagok[3]);
            KoldetesenToltotOra = int.Parse(adattagok[4]);
            ErkezesHelye = adattagok[5];
            UtasokSzama = int.Parse(adattagok[6]);
        }
    }
}
