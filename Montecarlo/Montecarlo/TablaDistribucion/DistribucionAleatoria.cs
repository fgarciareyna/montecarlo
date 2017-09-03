using System;
using System.Collections.Generic;
using System.Linq;

namespace Montecarlo
{
    public class DistribucionAleatoria
    {
        public DistribucionAleatoria(IList<Probabilidad> valores)
        {
            Valores = valores ?? new List<Probabilidad>();

            GenerarTablaRandom();
        }

        public DistribucionAleatoria(decimal valor, decimal probabilidadAsociada)
        {
            var probabilidad = new Probabilidad(valor, probabilidadAsociada);

            Valores = new List<Probabilidad>() {probabilidad};

            GenerarTablaRandom();
        }

        public void AgregarProbabilidad(Probabilidad probabilidad)
        {
            Valores.Add(probabilidad);

            GenerarTablaRandom();
        }

        public void AgregarProbabilidad(decimal valor, decimal probabilidadAsociada)
        {
            var probabilidad = new Probabilidad(valor, probabilidadAsociada);

            Valores.Add(probabilidad);

            GenerarTablaRandom();
        }

        private void GenerarTablaRandom()
        {
            if (Valores.Sum(v => v.ProbabilidadAsociada) > 1)
                throw new NotSupportedException("La suma de las probabilidades no puede ser mayor a 1");

            Valores = Valores.OrderBy(v => v.Valor).ToList();
            RandomAsociados = new List<decimal>(Valores.Count) {[0] = 0};

            for (var i = 1; i < Valores.Count; i++)
            {
                RandomAsociados[i] = RandomAsociados[i - 1] + Valores[i - 1].ProbabilidadAsociada;
            }
        }

        public decimal? ObtenerValor()
        {
            var random = (decimal) new Random().NextDouble();

            for (var i = 1; i < RandomAsociados.Count; i++)
            {
                if (random < RandomAsociados[i])
                    return RandomAsociados[i - 1];
            }

            return null;
        }

        public decimal? ObtenerValor(decimal random)
        {
            if (random < 0 || random > 1)
                throw new NotSupportedException("El número aleatorio debe estar entre 0 y 1");

            for (var i = 1; i < RandomAsociados.Count; i++)
            {
                if (random < RandomAsociados[i])
                    return RandomAsociados[i - 1];
            }

            return null;
        }

        private IList<Probabilidad> Valores { get; set; }
        private IList<decimal> RandomAsociados { get; set; }
    }
}
