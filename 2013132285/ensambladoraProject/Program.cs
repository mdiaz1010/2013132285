using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ensambladoraProject.Entities;
using System.Threading;
namespace ensambladoraProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Ensambladora ensambladora = new Ensambladora();
            Parabrisas parabrisas = new Parabrisas("para-123");
            Volante volante = new Volante("vol-123");
            Propietario propietario = new Propietario();
            volante.NumSerie = "12345";
            parabrisas.NumSerie = "6789-";
            propietario.DNI = "12345678";
            var a =TipoCarro.automovil;
            var a1 = a.ToString();
            var name = (TipoCarro)Enum.Parse(typeof(TipoCarro), a1);

           //  Carro carros = new Carro(volante, parabrisas,4,propietario,name);
            //Carro carros= new Carro();
            var carros = new Carro(volante, parabrisas, 4,5, propietario);
            //carros.NumSerieChasis = Console.ReadLine();
            ensambladora.Agregar( carros);
			ensambladora.IniciarPersonalizador(carros);



        }
    }
}
