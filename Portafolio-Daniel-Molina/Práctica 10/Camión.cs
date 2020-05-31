using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Práctica_10
{
    public class Camión:Automovil
    {
        private int capacidadCarga;
        private int tanqueCombustible;

        public int CapacidadCarga { get => capacidadCarga; set => capacidadCarga = value; }
        public int TanqueCombustible { get => tanqueCombustible; set => tanqueCombustible = value; }
        public Camión(string marca, int millaje, string modelo, double precio,int capacidadCarga, int tanqueCombustible) : base(marca,millaje,modelo,precio)
        {
            this.CapacidadCarga = capacidadCarga;
            this.TanqueCombustible = tanqueCombustible;
        }

       
    }
}
