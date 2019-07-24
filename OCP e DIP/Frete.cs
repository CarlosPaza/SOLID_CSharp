using System;
using System.Collections.Generic;
using System.Text;

namespace OCP_e_DIP
{
    public class Frete : IServicoEntrega
    {
        public double Para(string cidade)
        {

            if ("SAO PAULO".Equals(cidade.ToUpper()))
            {
                return 15;
            }
            return 30;
        }
    }
}
