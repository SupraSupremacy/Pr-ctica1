using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad2._3__5136099_
{
    public class Ordenador
    {
        public Ordenador(string marca, string procesador, string memoria, string discoduro)
        {
            this.Marca = marca;
            this.Procesador = procesador;
            this.Memoria = memoria;
            this.DiscoDuro = discoduro;
        }
        public string Marca;
        public string Procesador;
        public string Memoria;
        public string DiscoDuro;

        public void MayorCapacidad(int capacidad)
        {
            Console.WriteLine("La capacidad del disco duro ha sido aumentada " + capacidad + "GB");
        }
        public void MenorCapacidad(int capacidad)
        {
            Console.WriteLine("La capacidad del disco duro ha sido reducida " + capacidad + "GB");
        }
    }
}
