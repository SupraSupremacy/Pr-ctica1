using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2._1__5136099_.Properties
{
   public class Program
    {
        static void Main(string[] args)
            {
                Coche Coche1 = new Coche("Mazda", "MX-5 Miata NA", 195, 100);
                Console.WriteLine("Descripción del vehículo:");
                Console.WriteLine("Marca: " + Coche1.Marca);
                Console.WriteLine("Modelo: " + Coche1.Modelo);
                Console.WriteLine("Velocidad Max: " + Coche1.VelocidadMax);
                Console.WriteLine("Velocidad Act: " + Coche1.VelocidadAct);
                Coche1.Acelerar(5);
                Coche1.Desacelerar(5);
            }
    }
}
