using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ejemplo1__5136099_.Properties;

namespace Ejemplo1__5136099_
{
   public class Program
    {
    static void Main(string[] args)
        {
            Persona Personal = new Persona("Verdes", "187", "85", "V");
            Console.WriteLine("Descripción de la persona:");
            Console.WriteLine("Ojos: " + Personal.Ojos);
            Console.WriteLine("Altura: " + Personal.Altura);
            Console.WriteLine("Peso: " + Personal.Peso);
            Console.WriteLine("Sexo: " + Personal.Sexo);

            Personal.Hablar("Me llamo Borja");
            Console.WriteLine("Color de mis ojos: " + Personal.Ojos);
            Console.WriteLine("Mi peso actual es: " + Personal.Peso);

            Persona Persona1 = new PersonaNadadora("Verdes", "187", "85", "V");
            Console.WriteLine("Descripción de la persona:");
            Console.WriteLine("Ojos: " + Persona1.Ojos);
            Console.WriteLine("Altura: " + Persona1.Altura);
            Console.WriteLine("Peso: " + Persona1.Peso);
            Console.WriteLine("Sexo: " + Persona1.Sexo);
            Personal.Hablar("Me llamo Borja");
            Console.WriteLine("Color de mis ojos: " + Persona1.Ojos);
            Personal.Correr(1000);
            Console.WriteLine("Mi peso actual es: " + Persona1.Peso);
           // Persona1.nadar();
           //Console.WriteLine("Tras nadar peso:" Persona1.Peso);
        }
    }
}
