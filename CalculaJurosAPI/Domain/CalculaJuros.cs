using System;

namespace CalculaJurosAPI.Domain
{
    public class CalculaJuros
    {
        public decimal Calcular(decimal valorInical, decimal taxaJuros, int meses)
        {
            var jurosPeriodo = (decimal) Math.Pow(1 + (double) taxaJuros, meses);
            return  Truncar(valorInical * jurosPeriodo);
        }
        
        public decimal Truncar(decimal valor)
        {
            return Math.Truncate(100 * valor) / 100;
        }
    }
}