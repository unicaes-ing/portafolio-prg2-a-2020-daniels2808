using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;

namespace Práctica_10
{
    public class Carro : Automovil
    {
        private int puertas;
        public int Puertas { get => puertas; set => puertas = value; }

        public Carro(string marca, int millaje,string modelo, double precio,int puertas) : base(marca, millaje, modelo, precio)
        {
            this.puertas = puertas;
        }
    }
}
