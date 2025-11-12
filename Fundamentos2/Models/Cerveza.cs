using Fundamentos2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Fundamentos2.Models
{
    public class Cerveza : Bebida, IBebidaAlcoholica, IBebidaDulce, IRequestable
    {
        public int Alcohol { get; set; }
        public int Dulce { get; set; }
        public string Marca { get; set; }
        public int id { get; set; }


        public void MaxRecomendado()
        {
            Console.WriteLine("La cantidad maxima recomendada de cervezas son 10");
        }

        public void MaxRecomendadoDulce()
        {

        }

        public Cerveza() : base()
        {

        }

        public Cerveza(int Cantidad, string Nombre = "Cerveza") : base(Nombre, Cantidad)
        {
            Alcohol = 5;
            Marca = "Poker";

        }

    }


}
