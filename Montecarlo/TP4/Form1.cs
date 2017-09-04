using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Montecarlo.Acumuladores;
using Montecarlo.TablaDistribucion;

namespace TP4
{
    public partial class Principal : Form
    {
        private DistribucionAleatoria _demanda;
        private DistribucionAleatoria _demora;

        public Principal()
        {
            InitializeComponent();
            _demanda = new DistribucionAleatoria(new List<Probabilidad>()
            {
                new Probabilidad(0, 0.05),
                new Probabilidad(10, 0.12),
                new Probabilidad(20, 0.18),
                new Probabilidad(30, 0.25),
                new Probabilidad(40, 0.22),
                new Probabilidad(50, 0.18)
            });
            _demora = new DistribucionAleatoria(new List<Probabilidad>()
            {
                new Probabilidad(0, 0.301),
                new Probabilidad(2, 0.361),
                new Probabilidad(3, 0.217),
                new Probabilidad(5, 0.087),
                new Probabilidad(6, 0.026),
                new Probabilidad(7, 0.006),
                new Probabilidad(9, 0.001),
            });
        }

        private void btn_simular_Click(object sender, EventArgs e)
        {
            if (!FormularioValido()) return;

            if (rad_A.Checked)
            {
                SimularA();
            }

            else if (rad_B.Checked)
            {
                SimularB();
            }

            else if (rad_C.Checked)
            {
                SimularC();
            }

            else
            {
                MessageBox.Show(@"Se debe seleccionar una estrategia");
                rad_A.Focus();
            }
        }

        private bool FormularioValido()
        {
            int stockInicial;
            decimal costoAlmacenamiento;
            decimal costoFaltante;
            int cantidadIteraciones;
            int mostrarDesde;
            int cantidadAMostrar;

            if (!int.TryParse(txt_stock_inicial.Text, out stockInicial) || stockInicial < 0)
            {
                MessageBox.Show(@"El stock inicial debe ser positivo");
                txt_stock_inicial.Focus();
                return false;
            }

            if (!decimal.TryParse(txt_costo_alm.Text, out costoAlmacenamiento) || costoAlmacenamiento > 0)
            {
                MessageBox.Show(@"El costo de almacenamiento debe ser negativo");
                txt_costo_alm.Focus();
                return false;
            }

            if (!decimal.TryParse(txt_costo_falt.Text, out costoFaltante) || costoFaltante > 0)
            {
                MessageBox.Show(@"El costo por faltante debe ser negativo");
                txt_costo_falt.Focus();
                return false;
            }

            if (!int.TryParse(txt_cant_iteraciones.Text, out cantidadIteraciones) || cantidadIteraciones <= 0)
            {
                MessageBox.Show(@"Se debe realizar al menos una simulación");
                txt_cant_iteraciones.Focus();
                return false;
            }

            if (!int.TryParse(txt_mostrar_desde.Text, out mostrarDesde) || mostrarDesde <= 0)
            {
                MessageBox.Show(@"La simulación inicial debe ser un número positivo");
                txt_mostrar_desde.Focus();
                return false;
            }

            if (!int.TryParse(txt_mostrar_cant.Text, out cantidadAMostrar) || cantidadAMostrar < 0)
            {
                MessageBox.Show(@"Se debe mostrar al menos una simulación");
                txt_mostrar_cant.Focus();
                return false;
            }

            if (mostrarDesde + cantidadAMostrar < cantidadIteraciones)
            {
                MessageBox.Show(@"La cantidad de simulaciones a realizar no es suficiente");
                txt_cant_iteraciones.Focus();
                return false;
            }

            return true;
        }

        private void SimularA()
        {
            // Pedir 10 decenas cada 7 días
            const int cantidadAPedir = 10;
            const int diasEntrePedidos = 7;

            var stock = int.Parse(txt_stock_inicial.Text);
            var precioAlmacenamiento = double.Parse(txt_costo_alm.Text);
            var precioFaltante = double.Parse(txt_costo_falt.Text);

            var simulaciones = int.Parse(txt_cant_iteraciones.Text);
            var mostrarDesde = int.Parse(txt_mostrar_desde.Text);
            var cantidadAMostrar = int.Parse(txt_mostrar_cant.Text);

            var acumuladorTotalCosto = new TotalAcumulado();
            var acumuladorPromedioCosto = new PromedioAcumulado();

            var diasProximoPedido = diasEntrePedidos;
            var demora = 0;
            double costoAcumulado;
            double costoPromedio;

            for (var dia = 1; dia <= simulaciones; dia++)
            {
                diasProximoPedido = diasProximoPedido > 0 ? diasProximoPedido - 1 : diasEntrePedidos;
                demora = demora > 0 ? demora - 1 : diasProximoPedido == 0 ? (int)_demora.ObtenerValor() : 0;
                var costoPedido = demora == 0 && diasProximoPedido == 0 ? CostoPedido.ObtenerCosto(cantidadAPedir) : 0;
                var demanda = (int)_demanda.ObtenerValor();
                var ventas = Math.Min(demanda, stock);
                var costoFaltante = (demanda - ventas) * precioFaltante;
                stock -= ventas;
                var costoAlmacenamiento = stock * precioAlmacenamiento;
                var costoTotal = costoFaltante + costoAlmacenamiento + costoPedido;
                costoAcumulado = acumuladorTotalCosto.CalcularSiguiente(costoTotal);
                costoPromedio = acumuladorPromedioCosto.CalcularSiguiente(costoTotal);
                var pedido = demora == 1 ? cantidadAPedir : 0;
                stock += pedido;
            }

        }

        private void SimularB()
        {
            var stock = int.Parse(txt_stock_inicial.Text);
            var costoAlmacenamiento = double.Parse(txt_costo_alm.Text);
            var costoFaltante = double.Parse(txt_costo_falt.Text);

            var simulaciones = int.Parse(txt_cant_iteraciones.Text);
            var mostrarDesde = int.Parse(txt_mostrar_desde.Text);
            var cantidadAMostrar = int.Parse(txt_mostrar_cant.Text);

            for (var i = 1; i <= simulaciones; i++)
            {

            }
        }

        private void SimularC()
        {
            var stock = int.Parse(txt_stock_inicial.Text);
            var costoAlmacenamiento = double.Parse(txt_costo_alm.Text);
            var costoFaltante = double.Parse(txt_costo_falt.Text);

            var simulaciones = int.Parse(txt_cant_iteraciones.Text);
            var mostrarDesde = int.Parse(txt_mostrar_desde.Text);
            var cantidadAMostrar = int.Parse(txt_mostrar_cant.Text);

            for (var i = 1; i <= simulaciones; i++)
            {

            }
        }
    }
}
