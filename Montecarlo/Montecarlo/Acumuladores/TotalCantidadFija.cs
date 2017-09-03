using System.Collections.Generic;
using System.Linq;

namespace Montecarlo.Acumuladores
{
    public class TotalCantidadFija : IAcumulador
    {
        public TotalCantidadFija(int cantidad)
        {
            Cantidad = cantidad;
            Valores = new List<decimal>(Cantidad);
        }

        public decimal CalcularSiguiente(decimal valor)
        {
            if (Valores.Count == Cantidad)
                EliminarPrimero();

            Valores.Add(valor);

            var promedio = Valores.Sum();

            return promedio;
        }

        private void EliminarPrimero()
        {
            Valores.RemoveAt(0);
        }

        private int Cantidad { get; }
        private IList<decimal> Valores { get; }
    }
}
