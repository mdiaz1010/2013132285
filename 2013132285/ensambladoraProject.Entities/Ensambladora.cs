using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ensambladoraProject.Entities
{


    public class Ensambladora
    {

        List<Carro> _Carros;
        Volante volante;
        Parabrisas parabrisas;
        Propietario propietario;
        TipoAuto tipoauto;

        public Ensambladora()
        {
           List<Carro> _Carros;
			volante = new Volante();
            propietario = new Propietario();
            parabrisas = new Parabrisas();
            tipoauto = new TipoAuto();
        }

        public void Agregar(Carro carro)
        {
            
            volante.NumSerie = "volante-";
            parabrisas.NumSerie = "parabrisas-";
             
             var tipoCarro = TipoCarro.automovil.ToString();
            var name = (TipoCarro)Enum.Parse(typeof(TipoCarro), tipoCarro);
            

            if (tipoCarro ==null) {
                  _Carros.Add(new Automovil(volante, parabrisas, 4, propietario));
              }
              else {
                  
              }
        }

		public void Eliminar(Carro carro)
		{
			if (_Carros.Count == 6)
				return;
			volante.NumSerie = "volante-";
			parabrisas.NumSerie = "parabrisas-";
			
			var tipoCarro = TipoCarro.automovil.ToString();
			var name = (TipoCarro)Enum.Parse(typeof(TipoCarro), tipoCarro);
			

			if (tipoCarro == null)
			{
				_Carros.Remove(new Automovil(volante, parabrisas, 4, propietario));
			}
			else
			{
				
			}
		}
		public void IniciarPersonalizador(Carro carrito) {
			
			Console.WriteLine("Iniciar Personalizacion del carro[{0}]", carrito);
			Console.ReadKey();
		}
		public void FinalizarPersonalizador()
		{
			Carro carrito = new Carro();
			Console.WriteLine("Finalizar Personalizacion del Carro[{0}]", carrito);
		}
	}
}
