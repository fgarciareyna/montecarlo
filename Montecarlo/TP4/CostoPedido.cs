using System;

namespace TP4
{
    public static class CostoPedido
    {
        public static double ObtenerCosto(double cantidad)
        {
            if (cantidad <= 0)
                throw new NotSupportedException("La cantidad pedida debe ser positiva");

            if (cantidad <= 20)
                return -20;

            if (cantidad <= 40)
                return -25;

            return -30;
        }
    }
}
