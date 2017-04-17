using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ensambladoraProject.Entities
{
   public class Volante
    {
      public  string NumSerie { get; set; }
		public Volante() { }
		public Volante(string NumSerie) {
			this.NumSerie = NumSerie;
		}
    }
}
