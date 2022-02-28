using System;
using System.Collections.Generic;
using System.Text;

namespace Software_Price_Calculator
{
    class Salario
    {
        public double SalarioBase;
        public double ValorDaHoraDeTrabalho;
        public double ValorMinimoHoraDeTrabalho;
        public double ValorACobrar;
        public double TotalDoProjeto;

        public double CalcularSalarioBase(double CargaTributaria)
        {
            return SalarioBase += (SalarioBase *= CargaTributaria);
 
        }
        public double CalcularHoraDeTrabalho(double TotalDeHoras)
        {
            return ValorDaHoraDeTrabalho = SalarioBase / TotalDeHoras;
        }

        public double CalcularValorMinimoDaHoraDeTrabalho(double CustoFixoPorHora)
        {
            ValorMinimoHoraDeTrabalho = ValorDaHoraDeTrabalho + CustoFixoPorHora;
            return ValorACobrar = ValorMinimoHoraDeTrabalho;

        }
         public double CalcularValorACobrar(double lucro)
        {
            return ValorACobrar += (ValorMinimoHoraDeTrabalho *= lucro);
        }

        public double CalcularTotalDoProjeto(int horaTrabalhada)
        {
            return TotalDoProjeto = ValorACobrar * horaTrabalhada;
        }
    }
}
