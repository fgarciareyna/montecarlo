using System.Collections.Generic;

namespace Montecarlo
{
    public class Distribucion
    {
        public Distribucion(IList<Probabilidad> valores)
        {
            Valores = valores ?? new List<Probabilidad>();
        }

        private IList<Probabilidad> Valores { get; set; }
        private IList<decimal> RandomAsociado { get; set; }
    }
}
