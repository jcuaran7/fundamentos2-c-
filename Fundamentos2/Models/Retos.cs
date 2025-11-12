using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentos2.Models
{
    public class Retos
    {
        public string Nombre { get; set; }
        public int Edad { get; set; }

        public Retos(string Nombre, int Edad)
        {
            this.Nombre = Nombre;
            this.Edad = Edad; 
        }


        public void MostrarDatos()
        {
            Console.WriteLine($"Mi Nombre es: {this.Nombre}, Tengo: {this.Edad} Años");

        }

       
    }



}
