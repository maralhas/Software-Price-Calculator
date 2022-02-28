using System;
using System.Runtime.InteropServices;

namespace Software_Price_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Imposto imposto = new Imposto();
            Salario salario = new Salario();
            Custos custo = new Custos();
            Horas hora = new Horas();
            Lucro lucro = new Lucro();

            Console.WriteLine("Calculador preço de software");
            Console.WriteLine("Versão 1.0 Inicio do projeto 23/02/2022");
            Console.WriteLine("Desenvolvedor: Ian");

            Console.Write("Informe o salário base: ");
            salario.SalarioBase = double.Parse(Console.ReadLine());
            Console.Write("Informe a porcentagem para calculo da carga tributaria: ");
            imposto.CargaTributaria = double.Parse(Console.ReadLine());
            salario.CalcularSalarioBase(imposto.CalcularPorcentagem());

            Console.Write("Informe o numero de Horas para desenvolvimento do Software: ");
            hora.HorasDeDesenvolvimento = int.Parse(Console.ReadLine());
            Console.Write("Informe o numero de Horas para teste de software: ");
            hora.HorasDeTeste = int.Parse(Console.ReadLine());
            Console.Write("Informe o numero de Horas para Implementação do Software: ");
            hora.HorasDeImplementacao = int.Parse(Console.ReadLine());
            Console.Write("Informe o numero de Horas para Treinamento: ");
            hora.HorasDeTreinamento = int.Parse(Console.ReadLine());
            hora.HorasParaTrabalhar = (hora.HorasDeTreinamento + hora.HorasDeImplementacao + hora.HorasDeTeste + hora.HorasDeDesenvolvimento);
            Console.WriteLine("Numero de Horas trabalhasdas: " + hora.HorasParaTrabalhar);
            salario.CalcularHoraDeTrabalho(hora.SomarHoras());

            Console.Write("Informe o custo fixo: ");
            custo.CustoFixo = double.Parse(Console.ReadLine());
            salario.CalcularValorMinimoDaHoraDeTrabalho(custo.CalcularCustoFixoPorHora(hora.SomarHoras()));

            Console.Write("Informe a porcetagem para o Lucro: ");
            lucro.MargemDeLucro = double.Parse(Console.ReadLine());
            salario.CalcularValorACobrar(lucro.CalcularLucro());
            salario.CalcularTotalDoProjeto(hora.SomarHoras());

            Console.WriteLine();
            Console.Write($"O preço do projeto é de R${salario.TotalDoProjeto:F2}");
           

        }
    }
}
