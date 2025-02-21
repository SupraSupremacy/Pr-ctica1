using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo1__5136099_
{
    public class Persona
    {
        public Persona(string ojos, string altura, string peso, string sexo)
        {
            this.Ojos = ojos;
            this.Altura = altura;
            this.Peso = peso;
            this.Sexo = sexo;
        }

        public string Ojos;
        public string Altura;
        public string Peso;
        public string Sexo;
        public void Hablar(string texto)
        {
            Console.WriteLine("Voy a decir: " + texto);
        }
        public void Comer(double calorías)
        {
            Console.WriteLine("Ganando " + calorías + " Calorías");
            this.Peso += calorías / 1000;
        }
        public void Correr(double calorías)
        {
            Console.WriteLine("Perdiendo " + calorías + " Calorías");
            this.Peso += calorías / 1000;
        }
    }
}
