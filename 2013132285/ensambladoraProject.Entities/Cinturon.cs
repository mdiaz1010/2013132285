using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ensambladoraProject.Entities
{
    public class Cinturon 
    {
		public int Metraje { get; set; }
		public string NumSerie { get; set; }

		public Cinturon() { }

		public Cinturon(string NumSerie, int Metraje)
		{
			this.NumSerie = NumSerie;
			this.Metraje  = Metraje;
		}
		


	}
}
