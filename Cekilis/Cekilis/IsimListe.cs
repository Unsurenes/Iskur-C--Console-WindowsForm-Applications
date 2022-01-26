using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cekilis
{
    class IsimListe
    {
        public string Ad;
        public string[] isim = new string[50];

        public void Ekle(int a, string ad)
        {

            this.Ad = ad;
            isim[a] = ad;

        }
    }
}
