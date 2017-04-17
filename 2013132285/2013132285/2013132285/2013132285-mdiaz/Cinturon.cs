using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2013132285_mdiaz
{
    class Cinturon
    {

        public int    Metraje { get; set; }
        public string NumSerie { get; set; }

        public Cinturon(string _NumSerie,int _Metraje){
            NumSerie=_NumSerie;
            Metraje=_Metraje;
        }

        public Cinturon()
        {

        }


        
    }
}
