using System;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using Montecarlo.Acumuladores;
using Montecarlo.TablaDistribucion;

namespace TP4
{
    public partial class Principal : Form
    {
        private readonly DistribucionAleatoria _demanda;
        private readonly DistribucionAleatoria _demora;
        private const int Decimales = 3;

        public Principal()
        {
            var culture = CultureInfo.InvariantCulture;
            Thread.CurrentThread.CurrentCulture = culture;
            Thread.CurrentThread.CurrentUICulture = culture;

            InitializeComponent();
            btn_comparar.Enabled = false;
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

            if (mostrarDesde + cantidadAMostrar - 1 > cantidadIteraciones)
            {
                MessageBox.Show(@"La cantidad de simulaciones a realizar no es suficiente");
                txt_cant_iteraciones.Focus();
                return false;
            }

            return true;
        }

        private void Limpiar(string estrategia)
        {
            tb_simulaciones.Rows.Clear();
            graph.Series[estrategia].Points.Clear();
        }

        private void SimularA()
        {
            const string estrategia = "Estrategia A";
            Limpiar(estrategia);

            // Pedir 10 decenas cada 7 días
            const int cantidadAPedir = 10;
            const int diasEntrePedidos = 7;

            var stock = int.Parse(txt_stock_inicial.Text);
            var precioAlmacenamiento = Math.Round(double.Parse(txt_costo_alm.Text), Decimales) * 10;
            var precioFaltante = Math.Round(double.Parse(txt_costo_falt.Text), Decimales) * 10;

            var simulaciones = int.Parse(txt_cant_iteraciones.Text);
            var mostrarDesde = int.Parse(txt_mostrar_desde.Text);
            var cantidadAMostrar = int.Parse(txt_mostrar_cant.Text);

            var acumuladorTotalCosto = new TotalAcumulado();
            var acumuladorPromedioCosto = new PromedioAcumulado();

            var diasProximoPedido = diasEntrePedidos;
            var demora = 0;
            double costoPromedio = 0;

            for (var dia = 1; dia <= simulaciones; dia++)
            {
                //Pedido
                diasProximoPedido = diasProximoPedido > 0 ? diasProximoPedido - 1 : diasEntrePedidos;
                demora = demora > 0 ? demora - 1 : diasProximoPedido == 0 ? (int)_demora.ObtenerValor() : -1;
                var pedido = demora == 0 ? cantidadAPedir : 0;
                stock += pedido;

                //Ventas
                var demanda = (int)_demanda.ObtenerValor();
                var ventas = Math.Min(demanda, stock);
                stock -= ventas;

                //Costos
                var costoPedido = demora <= 0 && diasProximoPedido == 0 ? Math.Round(CostoPedido.ObtenerCosto(cantidadAPedir), Decimales) : 0;
                var costoFaltante = Math.Round((demanda - ventas) * precioFaltante, Decimales);
                var costoAlmacenamiento = Math.Round(stock * precioAlmacenamiento, Decimales);
                var costoTotal = Math.Round(costoFaltante + costoAlmacenamiento + costoPedido, Decimales);
                var costoAcumulado = Math.Round(acumuladorTotalCosto.CalcularSiguiente(costoTotal), Decimales);
                costoPromedio = Math.Round(acumuladorPromedioCosto.CalcularSiguiente(costoTotal), Decimales);

                //Tabla
                if (mostrarDesde <= dia && dia < mostrarDesde + cantidadAMostrar)
                {
                    tb_simulaciones.Rows.Add(dia, demanda, ventas, stock, costoAlmacenamiento, costoFaltante,
                        costoPedido, costoTotal, costoAcumulado, costoPromedio,
                        diasProximoPedido, demora, pedido);
                }

                //Gráfico
                graph.Series[estrategia].Points.Add(new DataPoint(dia, costoPromedio));
            }

            //Resultado
            txt_res_A.Text = costoPromedio.ToString();

            HabilitarComparacion();
        }

        private void SimularB()
        {
            const string estrategia = "Estrategia B";
            Limpiar(estrategia);

            // Pedir la demanda de los últimos 10 días cada 10 días
            var acumuladorCantidadAPedir = new TotalCantidadFija(10);
            const int diasEntrePedidos = 10;

            var stock = int.Parse(txt_stock_inicial.Text);
            var precioAlmacenamiento = Math.Round(double.Parse(txt_costo_alm.Text), Decimales) * 10;
            var precioFaltante = Math.Round(double.Parse(txt_costo_falt.Text), Decimales) * 10;

            var simulaciones = int.Parse(txt_cant_iteraciones.Text);
            var mostrarDesde = int.Parse(txt_mostrar_desde.Text);
            var cantidadAMostrar = int.Parse(txt_mostrar_cant.Text);

            var acumuladorTotalCosto = new TotalAcumulado();
            var acumuladorPromedioCosto = new PromedioAcumulado();

            var diasProximoPedido = diasEntrePedidos;
            var demora = 0;
            var cantidadAPedir = 0;
            double costoPromedio = 0;

            for (var dia = 1; dia <= simulaciones; dia++)
            {
                //Pedido
                diasProximoPedido = diasProximoPedido > 0 ? diasProximoPedido - 1 : diasEntrePedidos;
                demora = demora > 0 ? demora - 1 : diasProximoPedido == 0 ? (int)_demora.ObtenerValor() : -1;
                var demanda = (int)_demanda.ObtenerValor();
                var cantidad = (int) acumuladorCantidadAPedir.CalcularSiguiente(demanda);

                if (diasProximoPedido == 0)
                    cantidadAPedir = cantidad;

                var pedido = demora == 0 ? cantidadAPedir : 0;
                stock += pedido;

                //Ventas
                var ventas = Math.Min(demanda, stock);
                stock -= ventas;

                //Costos
                var costoPedido = demora <= 0 && diasProximoPedido == 0 ? Math.Round(CostoPedido.ObtenerCosto(cantidadAPedir), Decimales) : 0;
                var costoFaltante = Math.Round((demanda - ventas) * precioFaltante, Decimales);
                var costoAlmacenamiento = Math.Round(stock * precioAlmacenamiento, Decimales);
                var costoTotal = Math.Round(costoFaltante + costoAlmacenamiento + costoPedido, Decimales);
                var costoAcumulado = Math.Round(acumuladorTotalCosto.CalcularSiguiente(costoTotal), Decimales);
                costoPromedio = Math.Round(acumuladorPromedioCosto.CalcularSiguiente(costoTotal), Decimales);

                //Tabla
                if (mostrarDesde <= dia && dia < mostrarDesde + cantidadAMostrar)
                {
                    tb_simulaciones.Rows.Add(dia, demanda, ventas, stock, costoAlmacenamiento, costoFaltante,
                        costoPedido, costoTotal, costoAcumulado, costoPromedio,
                        diasProximoPedido, demora, pedido);
                }

                //Gráfico
                graph.Series[estrategia].Points.Add(new DataPoint(dia, costoPromedio));
            }

            //Resultado
            txt_res_B.Text = costoPromedio.ToString();

            HabilitarComparacion();
        }

        private void SimularC()
        {
            const string estrategia = "Estrategia C";
            Limpiar(estrategia);

            // Pedir la demanda promedio de los últimos 10 días cada 10 días
            var acumuladorCantidadAPedir = new PromedioCantidadFija(10);
            const int diasEntrePedidos = 10;

            var stock = int.Parse(txt_stock_inicial.Text);
            var precioAlmacenamiento = Math.Round(double.Parse(txt_costo_alm.Text), Decimales) * 10;
            var precioFaltante = Math.Round(double.Parse(txt_costo_falt.Text), Decimales) * 10;

            var simulaciones = int.Parse(txt_cant_iteraciones.Text);
            var mostrarDesde = int.Parse(txt_mostrar_desde.Text);
            var cantidadAMostrar = int.Parse(txt_mostrar_cant.Text);

            var acumuladorTotalCosto = new TotalAcumulado();
            var acumuladorPromedioCosto = new PromedioAcumulado();

            var diasProximoPedido = diasEntrePedidos;
            var demora = 0;
            var cantidadAPedir = 0;
            double costoPromedio = 0;

            for (var dia = 1; dia <= simulaciones; dia++)
            {
                //Pedido
                diasProximoPedido = diasProximoPedido > 0 ? diasProximoPedido - 1 : diasEntrePedidos;
                demora = demora > 0 ? demora - 1 : diasProximoPedido == 0 ? (int)_demora.ObtenerValor() : -1;
                var demanda = (int)_demanda.ObtenerValor();
                var cantidad = (int)acumuladorCantidadAPedir.CalcularSiguiente(demanda);

                if (diasProximoPedido == 0)
                    cantidadAPedir = cantidad;

                var pedido = demora == 0 ? cantidadAPedir : 0;
                stock += pedido;

                //Ventas
                var ventas = Math.Min(demanda, stock);
                stock -= ventas;

                //Costos
                var costoPedido = demora <= 0 && diasProximoPedido == 0 ? Math.Round(CostoPedido.ObtenerCosto(cantidadAPedir), Decimales) : 0;
                var costoFaltante = Math.Round((demanda - ventas) * precioFaltante, Decimales);
                var costoAlmacenamiento = Math.Round(stock * precioAlmacenamiento, Decimales);
                var costoTotal = Math.Round(costoFaltante + costoAlmacenamiento + costoPedido, Decimales);
                var costoAcumulado = Math.Round(acumuladorTotalCosto.CalcularSiguiente(costoTotal), Decimales);
                costoPromedio = Math.Round(acumuladorPromedioCosto.CalcularSiguiente(costoTotal), Decimales);

                //Tabla
                if (mostrarDesde <= dia && dia < mostrarDesde + cantidadAMostrar)
                {
                    tb_simulaciones.Rows.Add(dia, demanda, ventas, stock, costoAlmacenamiento, costoFaltante,
                        costoPedido, costoTotal, costoAcumulado, costoPromedio,
                        diasProximoPedido, demora, pedido);
                }

                //Gráfico
                graph.Series[estrategia].Points.Add(new DataPoint(dia, costoPromedio));
            }

            //Resultado
            txt_res_C.Text = costoPromedio.ToString();

            HabilitarComparacion();
        }

        private void HabilitarComparacion()
        {
            if (!string.IsNullOrEmpty(txt_res_A.Text)
                && !string.IsNullOrEmpty(txt_res_B.Text)
                && !string.IsNullOrEmpty(txt_res_C.Text))
            {
                btn_comparar.Enabled = true;
            }
        }

        private void btn_comparar_Click(object sender, EventArgs e)
        {
            var resultadoA = Math.Round(double.Parse(txt_res_A.Text), Decimales);
            var resultadoB = Math.Round(double.Parse(txt_res_B.Text), Decimales);
            var resultadoC = Math.Round(double.Parse(txt_res_C.Text), Decimales);

            string ganadora;

            if (resultadoA >= Math.Max(resultadoB, resultadoC))
                ganadora = "A";

            else if (resultadoB >= resultadoC)
                ganadora = "B";

            else
                ganadora = "C";

            MessageBox.Show($@"La estrategia más conveniente es la {ganadora}");
        }

        private void lnk_A_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show(@"Efectuar un pedido de 10 decenas cada 7 días");
        }

        private void lnk_B_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show(@"Efectuar un pedido de la suma de la demanda de los últimos 10 días (incluyendo el día actual) cada 10 días");
        }

        private void lnk_C_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show(@"Efectuar un pedido del promedio de la demanda de los últimos 10 días (incluyendo el día actual) cada 10 días");
        }
    }
}
