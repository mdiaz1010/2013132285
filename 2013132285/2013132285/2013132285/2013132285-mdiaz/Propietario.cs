using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2013132285_mdiaz
{
    class Propietario
    {
        public string Dni { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string LicenciaConducir{ get; set; }

        public Propietario(string _dni, string _nombre, string _apellidos, string _licencia)
        {
            Dni = _dni;
            Nombres = _nombre;
            Apellidos = _apellidos;
            LicenciaConducir = _licencia;
        }
        public Propietario()
        {

        }

    }
}
