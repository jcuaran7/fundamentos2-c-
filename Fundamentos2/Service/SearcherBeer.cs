using Fundamentos2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
using Fundamentos2.Errors;

namespace Fundamentos2.Service
{
    public class SearcherBeer
    {

        List<Cerveza> cervezas = new List<Cerveza>()
        {
            new Cerveza() { Alcohol=8, Dulce=30, Cantidad = 10, Marca="Victoria", Nombre="Victoria Clasica"},
            new Cerveza() { Alcohol=7, Dulce=30, Cantidad = 20, Marca="Modelo", Nombre="Negra Modelo"},
            new Cerveza() { Alcohol=6, Dulce=20, Cantidad = 30, Marca="Corona", Nombre="Corona Light"}

        };

        public int GetCantidad(string Nombre)
        {
            var cerveza = (from d in cervezas
                          where d.Nombre == Nombre
                          select d).FirstOrDefault();
            if(cerveza==null)
            
            throw new BeerNotFoundException("La cerveza Se ha terminado.");
            
            return cerveza.Cantidad;
        }

        
    }
}
