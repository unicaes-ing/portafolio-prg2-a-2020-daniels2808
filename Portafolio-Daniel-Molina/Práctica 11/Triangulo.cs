﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Práctica_11
{
    public class Triangulo:Figura
    {
        private double valor2;

        public Triangulo()
        {

        }

        public double Valor2 { get => valor2; set => valor2 = value; }

        public override double Area()
        {
            return (Valor1 * valor2) / 2;
        }
    }
}
