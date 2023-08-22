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
    public partial class FormularioPrincipal : Form
    {
        private Cliente cliente;
        // Agregar la lista de productos
        private List<Producto> listaProductos; 

        public FormularioPrincipal()
        {
            InitializeComponent();
        // Inicializar el cliente y sus tarjetas con saldos disponibles
            cliente = new Cliente

            {
                Nombre = "Bernardo Adonis",
                TarjetaCredito = new TarjetaCredito { SaldoDisponible = 1000 },
                TarjetaDebito = new TarjetaDebito { SaldoDisponible = 2000 }
            };
            cliente.SaldoInsuficiente += Cliente_SaldoInsuficiente;

         // Inicializar la lista de productos de ejemplo
            listaProductos = new List<Producto>
            {
                new Producto { Nombre = "Pantalon", Precio = 500 },
                new Producto { Nombre = "Camisa", Precio = 500 },
                new Producto { Nombre = "Carro", Precio = 2000 },
                new Producto { Nombre = "Bicicleta", Precio = 100 },
                new Producto { Nombre = "Motocicleta", Precio = 1200 },
                new Producto { Nombre = "Zapatos", Precio = 200 }
            };

         // Llenar el ListBox con los nombres de los productos
            foreach (var producto in listaProductos)
            {
                ListBoxProductos.Items.Add(producto.Nombre);
            }
        }
        // Método para manejar el evento de saldo insuficiente
        private void Cliente_SaldoInsuficiente(object sender, EventArgs e)
        {
            MessageBox.Show("No hay suficientes fondos en ninguna de las tarjetas para realizar la compra.");
        }
        // Botón para abrir el formulario de compra
        private void ButtonRealizarCompra_Click(object sender, EventArgs e)
        {
            FormularioCompra formularioCompra = new FormularioCompra(cliente);
            formularioCompra.ShowDialog();
        }
        // Manejar el evento cuando se selecciona un producto en el ListBox
        private void ListBoxProductos_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indiceSeleccionado = ListBoxProductos.SelectedIndex;

            if (indiceSeleccionado >= 0)
            {
                Producto productoSeleccionado = listaProductos[indiceSeleccionado];
                double totalAPagar = 0;
                int cantidadProductosSeleccionados = 0;
         // Calcular el total a pagar y la cantidad de productos seleccionados
                foreach (int index in ListBoxProductos.SelectedIndices)
                {
                    Producto producto = listaProductos[index];
                    totalAPagar += producto.Precio;
                    cantidadProductosSeleccionados++;
                }

         // Mostrar el total a pagar y la cantidad de productos seleccionados en el label
                PrecioProductoLabel.Text = $"Total a pagar: ${totalAPagar.ToString("0.00", CultureInfo.InvariantCulture)}\n" +
                                            $"Productos seleccionados: {cantidadProductosSeleccionados}";
            }
            else
            {
         // Limpiar el label si no hay producto seleccionado
                PrecioProductoLabel.Text = string.Empty;
            }
        }
    }
}
