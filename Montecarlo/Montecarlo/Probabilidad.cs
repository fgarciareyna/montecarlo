using System;

namespace Montecarlo
{
    public class Probabilidad
    {
        public Probabilidad(decimal valor, decimal probabilidadAsociada)
        {
            if (probabilidadAsociada < 0 || probabilidadAsociada >1)
                throw new NotSupportedException("La probabilidad asociada debe ser entre 0 y 1");

            Valor = valor;
            ProbabilidadAsociada = probabilidadAsociada;
        }

        public decimal Valor { get; protected set; }
        public decimal ProbabilidadAsociada { get; protected set; }
    }
}
