﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Encapsulamento
{
    public class Pagamento
    {
        public double Valor { get; private set; }
        public MeioDePagamento Forma { get; private set; }

        public Pagamento(double valor, MeioDePagamento forma)
        {
            // TODO: Complete member initialization
            this.Valor = valor;
            this.Forma = forma;
        }


    }
}
