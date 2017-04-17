using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ensambladoraProject.Entities
{
    public class Parabrisas
    {
        public string NumSerie { get; set; }

		public Parabrisas(){}
		public Parabrisas(string NumSerie) {
			this.NumSerie = NumSerie;
		}

    }
}
