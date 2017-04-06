using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2013132285_mdiaz
{
    class Asiento
    {
        Cinturon _cinturon;
        public String NumSerie { get; set; }

        public Asiento(String _numSerie)
        {
            _cinturon = new Cinturon();
            NumSerie = _numSerie;
        }
        public Asiento()
        {

        }
    }
}
