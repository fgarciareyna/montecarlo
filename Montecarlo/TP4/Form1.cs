using System;
using System.Windows.Forms;

namespace TP4
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void btn_simular_Click(object sender, EventArgs e)
        {
            if (FormularioValido())
            {
                
            }
        }

        private bool FormularioValido()
        {
            decimal stockInicial;
            decimal costoAlmacenamiento;
            decimal costoFaltante;
            decimal cantidadIteraciones;
            decimal mostrarDesde;
            decimal cantidadAMostrar;

            if (!decimal.TryParse(txt_stock_inicial.Text, out stockInicial) || stockInicial < 0)
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

            if (!decimal.TryParse(txt_cant_iteraciones.Text, out cantidadIteraciones) || cantidadIteraciones <= 0)
            {
                MessageBox.Show(@"Se debe realizar al menos una simulación");
                txt_cant_iteraciones.Focus();
                return false;
            }

            if (!decimal.TryParse(txt_mostrar_desde.Text, out mostrarDesde) || mostrarDesde <= 0)
            {
                MessageBox.Show(@"La simulación inicial debe ser un número positivo");
                txt_mostrar_desde.Focus();
                return false;
            }

            if (!decimal.TryParse(txt_mostrar_cant.Text, out cantidadAMostrar) || cantidadAMostrar < 0)
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
    }
}
