using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo1__5136099_.Properties
{
    public class PersonaNadadora:Persona
    {
        public PersonaNadadora(string ojos, string altura, string peso, string sexo) : base(ojos, altura, peso, sexo)
        {
        }
        public void Nadar()
        {
            Console.WriteLine("Nadando para volver al peso ideal");
            this.Peso = "85";
        }
    }
   
    }
