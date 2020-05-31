using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Práctica_10
{
    public class Microbus:Automovil
    {
        private int pasajeros;

        public int Pasajeros { get => pasajeros; set => pasajeros = value; }
        public Microbus(string marca, int millaje, string modelo, double precio, int pasajeros) : base(marca,millaje,modelo,precio)
        {
            this.pasajeros = pasajeros;
        }
      
    }
}
