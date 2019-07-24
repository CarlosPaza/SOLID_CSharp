﻿using System;
using System.Collections.Generic;
using System.Text;

namespace OCP_e_DIP
{
    public class TabelaDePrecoPadrao : ITabelaDePreco
    {
        public double DescontoPara(double valor)
        {
            if (valor > 5000) return 0.03;
            if (valor > 1000) return 0.05;
            return 0;
        }
    }
}
