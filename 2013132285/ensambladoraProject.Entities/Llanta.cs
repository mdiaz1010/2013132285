using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ensambladoraProject.Entities
{
	class Llanta
	{
		string NumSerie { get; }

		public Llanta() { }

		public Llanta(string NumSerie)
		{
			this.NumSerie = NumSerie;
		}
	}
}
