using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.IO;
using System.Net.Http;
using Fundamentos2.Models;
using Fundamentos2.Service;
using System.Linq;
using Fundamentos2.Errors;



namespace Fundamentos2
{

    class Program
    {
        //public static SendRequest<Cerveza> service { get; private set; }
        public delegate void Mostrar(string cadena);

        static async Task Main(string[] args)

        {   /* DESERIALIZACION DE JSON TRAIDO DE UNA URL A OBJETOS C#
             
            string url = "https://jsonplaceholder.typicode.com/posts";
            HttpClient client = new HttpClient();

            var httpResponse = await client.GetAsync(url);

            if (httpResponse.IsSuccessStatusCode)
            {
                var content = await httpResponse.Content.ReadAsStringAsync();

                // ✅ Agrega las opciones
                var options = new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true
                };

                List<Models.Post> posts =
                    JsonSerializer.Deserialize<List<Models.Post>>(content, options);

                foreach (var post in posts)
                {
                    Console.WriteLine($"Post ID: {post.Id}, Title: {post.Title}");
                }
            }
            else
            {
                Console.WriteLine("Error fetching data from the API.");
            }

            */


            //-----------------------------------------------------------------------------------------------------------


            /* post,put y delete

            string url = "https://jsonplaceholder.typicode.com/posts/";
            var client = new HttpClient();

            Post post = new Post
            {
                userId = 1,
                title = "hola como esta",
                body = "saludos"
            };
            var data = JsonSerializer.Serialize<Post>(post);
            HttpContent content 
                = new StringContent(data, Encoding.UTF8, "application/json");
                var httpResponse = await client.PostAsync(url, content);

            //PUT---var httpResponse = await client.put(url, content); necesita el numero de id a lado de la url
            //DELETE---var httpResponse = await client.DeleteAsync(url); Para delete no necesitamos ni la data ni el content

            if (httpResponse.IsSuccessStatusCode)
            {
                var result = await httpResponse.Content.ReadAsStringAsync();
                Post postResult = JsonSerializer.Deserialize<Post>(result);
            }
            */


            //-----------------------------------------------------------------------------------------------------------


            /* ----Uso de la clase genérica para enviar requests-----
            var cerveza = new Cerveza()
            { Alcohol = 5, Dulce = 10, Cantidad=500, Marca = "Colima", Nombre="Ticus"};

            var post = new Post() { body = "body", title = "hola", userId = 50 };

            Service.SendRequest<Post> service = new Service.SendRequest<Post>();
            var CervezaRespuesta = await service.Send(post);

            */


            //-----------------------------------------------------------------------------------------------------------


            /* ------ USO DE LINQ CON LISTA DE NUMEROS PARA CONSULTAR COLECCIONES -----
            
            List<int> numeros = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            //recibir el numero igual a 7
            var numero7 = numeros.Where(d => d == 7).FirstOrDefault();
            Console.WriteLine($"El numero es: {numero7}");

            //recibir los numeros ordenados
            var numerosOrdenados = numeros.OrderBy(d => d);
            foreach (var numero in numerosOrdenados)
            {
                Console.WriteLine(numero);
            }

            // Obtener la suma de todos los numeros
            var suma = numeros.Sum(d => d);
            Console.WriteLine($"La suma de todos los numeros es: {suma}");
            */


            //-----------------------------------------------------------------------------------------------------------


            /*
            // ------Uso de LINQ con lista de cervezas para consultar colecciones-----
            List<Bar> bares = new List<Bar>()
            {
                new Bar("el bar")
                {
                    cervezas = new List<Cerveza>()
                    {
                        new Cerveza(500) { Alcohol=5, Dulce=10, Marca="Colima", Nombre="Ticus"},
                        new Cerveza(600) { Alcohol=6, Dulce=20, Marca="Corona", Nombre="Corona Light"},
                        new Cerveza(700) { Alcohol=7, Dulce=30, Marca="Modelo", Nombre="Negra Modelo"},
                        new Cerveza(500) { Alcohol=5, Dulce=10, Marca="Colima", Nombre="Ticus"},
                        new Cerveza(600) { Alcohol=6, Dulce=20, Marca="Corona", Nombre="Corona Light"},
                    }
                },

                new Bar("el bar 2")
                {
                    cervezas = new List<Cerveza>()
                    {
                        new Cerveza(800) { Alcohol=8, Dulce=40, Marca="Victoria", Nombre="Victoria Clasica"},
                        new Cerveza(700) { Alcohol=7, Dulce=30, Marca="Modelo", Nombre="Negra Modelo"},
                        new Cerveza(600) { Alcohol=6, Dulce=20, Marca="Corona", Nombre="Corona Light"},
                        new Cerveza(800) { Alcohol=8, Dulce=40, Marca="Victoria", Nombre="Victoria Clasica"},
                    }
                },

                new Bar("el bar nuevo")

            };

            // filtro de busqueda
            var bar = (from d in bares
                      where d.cervezas.Where(c => c.Nombre == "").Count()>0
                      select d).ToList();
            
            // retornar datos con un conjunto especifico de atributos cantidad y nombre
            var bar = (from d in bares
                       where d.cervezas.Where(c => c.Nombre == "Negra Modelo").Count() > 0
                       select new BarData(d.Nombre)
                       {
                           bebidas = (from c in d.cervezas
                                      select new Bebida(c.Nombre, c.Cantidad)
                                      ).ToList()
                       }
                       ).ToList();
            
            */


            //-----------------------------------------------------------------------------------------


            /*
            // ---- CONSULTA DE CERVEZAS ORDENADAS POR MARCA ----

            List< Cerveza > cervezas = new List<Cerveza>()
            {
                new Cerveza(500) { Alcohol=5, Dulce=10, Marca="Colima", Nombre="Ticus"},
                new Cerveza(600) { Alcohol=6, Dulce=20, Marca="Corona", Nombre="Corona Light"},
                new Cerveza(700) { Alcohol=7, Dulce=30, Marca="Modelo", Nombre="Negra Modelo"},
                new Cerveza(800) { Alcohol=8, Dulce=40, Marca="Victoria", Nombre="Victoria Clasica"},
            };
            
            //consultar orden alfabeticamente las cervezas por marca
            var cervezasOrdenadas = from d in cervezas
                                    orderby d.Marca
                                    select d;

            foreach (var cerveza in cervezasOrdenadas)
            {
                Console.WriteLine($"Marca: {cerveza.Marca}, Nombre: {cerveza.Nombre}");
            }
            */


            //----------------------------------------------------------------------------------------------------------


            /*
            //----------EXCEPCIONES------------

            try
            {
                var searcherBeer = new SearcherBeer();
                var cantidad = searcherBeer.GetCantidad("Victoriass Clasica");
                Console.WriteLine("ok");
            }
            catch (FieldAccessException ex)
            {
                Console.WriteLine(" si te vi");
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine(" ha caido en una operacion invalida");
            }
            catch (BeerNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
            }

            catch (Exception ex)
            {
                Console.WriteLine("Una Excepcion inesperada");
            }
            finally
            {
                Console.WriteLine("Proceso terminado");
            }
            */

            //----------------------------------------------------------------------------------------------------------

            //-----------FUNCION DE DELEGADOS------------
            Mostrar mostrar = Show;


        }

        public static void HacerAlgo(Mostrar funcionFinal)
        {

        }

        //-----------FUNCION DE DELEGADOS------------
        public static void Show( string cad)
        {
            Console.WriteLine("Hola soy un delegado");
        }




    }
}