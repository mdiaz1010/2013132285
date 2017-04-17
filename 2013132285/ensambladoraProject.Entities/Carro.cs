using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ensambladoraProject.Entities
{
    public  class Carro
    {
        public string NumSerieMotor { get; set; }
        public string NumSerieChasis { get; set; }
        Volante _volante;
        Parabrisas _parabrisas;
        Propietario _propietario;
		private Volante volante;
		private Parabrisas parabrisas;
		private int v1;
		private int v2;
		private Propietario propietario;

		public Carro( )
        {
           
        }

        public  Carro(Volante volante,Parabrisas parabrisas,int numLlantas, int numAsientos, Propietario propietario,TipoCarro tipoCarro) {
            _volante = volante;
            _parabrisas = parabrisas;
            _propietario = propietario;
        }

		public Carro(Volante volante, Parabrisas parabrisas, int v1, int v2, Propietario propietario)
		{
			this.volante = volante;
			this.parabrisas = parabrisas;
			this.v1 = v1;
			this.v2 = v2;
			this.propietario = propietario;
		}
	}
}
