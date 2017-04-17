using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ensambladoraProject.Entities
{
   public class Propietario
    {
        public string DNI { set; get; }
        public string Nombres { set; get; }
        public string Apellidos { set; get; }
        public string LicenciaConducir { set; get; }

		public Propietario() { }
		public Propietario(string DNI, string Nombres, string Apellidos, string LicenciaConducir) {
			this.DNI = DNI;
			this.Nombres = Nombres;
			this.Apellidos = Apellidos;
			this.LicenciaConducir = LicenciaConducir;
		}
    }
}
