﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Encapsulamento
{
    public class Boleto
    {
        public double Valor { get; private set; }

        public Boleto(double valor)
        {
            this.Valor = valor;
        }
    }
}
