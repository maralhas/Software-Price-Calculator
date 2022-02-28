using System;
using System.Collections.Generic;
using System.Text;

namespace Software_Price_Calculator
{
    class Horas
    {
        public int HorasDeDesenvolvimento;
        public int HorasDeTeste;
        public int HorasDeImplementacao;
        public int HorasDeTreinamento;
        public int HorasParaTrabalhar;

        public int SomarHoras()
        {
            return (HorasDeDesenvolvimento + HorasDeTeste + HorasDeImplementacao + HorasDeTreinamento) * HorasParaTrabalhar;
        }
    }
}
