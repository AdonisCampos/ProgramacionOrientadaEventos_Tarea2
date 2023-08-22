using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BibliotecaTarjetas;

namespace TarjetasProgramIU.Forms
{
    public partial class FormularioCompra : Form
    {
        private Cliente cliente;

        public FormularioCompra(Cliente cliente)
        {
            InitializeComponent();
            this.cliente = cliente;
        }

        private void ButtonConfirmarCompra_Click(object sender, EventArgs e)
        {
            // Verificar si el campo de monto está vacío o contiene solo un punto
            if (string.IsNullOrWhiteSpace(TextBoxMontoCompra.Text) || TextBoxMontoCompra.Text == ".")
            {
                MessageBox.Show("Ingrese un monto de compra válido.");
                return;
            }

            // Intentar convertir el valor ingresado a un número
            if (!double.TryParse(TextBoxMontoCompra.Text, NumberStyles.Any, CultureInfo.GetCultureInfo("en-US"), out double montoCompra))
            {
                MessageBox.Show("Ingrese un monto de compra válido.");
                return;
            }

            if (montoCompra <= 0)
            {
                MessageBox.Show("Ingrese un monto de compra válido.");
                return;
            }
            // Verificar si el campo de monto está vacío
            if (string.IsNullOrWhiteSpace(TextBoxMontoCompra.Text))
            {
                MessageBox.Show("Ingrese un monto de compra.");
                return;
            }

            // Realizar la lógica de la compra
            if (montoCompra <= cliente.TarjetaCredito.SaldoDisponible)
            {
                cliente.TarjetaCredito.SaldoDisponible -= montoCompra;
                MessageBox.Show("Compra realizada con éxito usando tarjeta de crédito.");
            }
            else if (montoCompra <= cliente.TarjetaCredito.SaldoDisponible + cliente.TarjetaDebito.SaldoDisponible)
            {
                double montoRestante = montoCompra - cliente.TarjetaCredito.SaldoDisponible;
                cliente.TarjetaCredito.SaldoDisponible = 0;
                cliente.TarjetaDebito.SaldoDisponible -= montoRestante;
                MessageBox.Show("Compra realizada con éxito usando tarjeta de débito.");
            }
            else
            {
             // Invocando el evento personalizado
                cliente.OnSaldoInsuficiente(); 
            }


        }

        private void TextBoxMontoCompra_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verificar si el caracter ingresado no es un número ni un punto
            TextBox textBox = sender as TextBox;
            if (textBox != null && !char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }

            // Solo permite un punto decimal
            if (e.KeyChar == '.' && textBox != null && textBox.Text.Contains('.'))
            {
            // Evitar que se muestre en el cuadro de texto
                e.Handled = true; 
            }
        }
    }
}
