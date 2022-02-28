using System;
using System.Collections.Generic;
using System.Text;

namespace Software_Price_Calculator
{
    class Custos
    {
        public double CustoFixo;
        public double CustoFixoPorHora;
        public double CalcularCustoFixoPorHora(double horas)
        {
            return CustoFixoPorHora = CustoFixo / horas;
        }
    }
}
