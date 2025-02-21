using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2._2__5136099_
{
    public class Coche
    {
        public Coche(string marca, string modelo, int velocidadMax, int velocidadAct)
        {
            this.Marca = marca;
            this.Modelo = modelo;
            this.VelocidadMax = velocidadMax;
            this.VelocidadAct = velocidadAct;
        }
        public string Marca;
        public string Modelo;
        public int VelocidadMax;
        public int VelocidadAct;

        public void Acelerar(int velocidad)
        {
            Console.WriteLine("Acelerando " + velocidad + " km/h");
        }
        public void Desacelerar(int velocidad)
        {
            Console.WriteLine("desacelerando " + velocidad + " km/h");
            this.VelocidadAct = velocidad - 5;
        }
        public void Frenar(int velocidad)
        {
            Console.WriteLine("desacelerando a 0 km/h");
            this.VelocidadAct = 0;
        }
    }
}
