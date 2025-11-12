using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Fundamentos2.Models
{
    public class Bebida
    {
        public string Nombre { get; set; }
        public int Cantidad { get; set; }

        // Constructor sin parámetros para serialización
        public Bebida()
        {
        }

        // Constructor
        public Bebida(string Nombre, int Cantidad)
        {
            this.Nombre = Nombre;
            this.Cantidad = Cantidad;
        }


        // Metodo para beberse una cantidad de la bebida
        public void Beberse(int CuantoBebio)
        {


            this.Cantidad -= CuantoBebio;
        }

    }
}
