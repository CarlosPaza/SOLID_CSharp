using System;
using System.Collections.Generic;
using System.Text;

namespace SingleResponsabilityPrinciple
{
    public class CalculadoraDeSalario
    {
        public double calcula(Funcionario funcionario)
        {
            return funcionario.CalcularSalario();
        }
    }
}
