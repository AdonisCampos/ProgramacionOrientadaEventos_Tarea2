using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaTarjetas
{
    public class Cliente
    {
        // Propiedades de la clase Cliente
        public string Nombre { get; set; }
        public TarjetaCredito TarjetaCredito { get; set; }
        public TarjetaDebito TarjetaDebito { get; set; }
        // Delegado para el evento SaldoInsuficiente
        public delegate void SaldoInsuficienteEventHandler(object sender, EventArgs e);
        // Constructor de la clase Cliente
        public Cliente()
        {
            Nombre = "Bernardo Adonis Campos"; 
            TarjetaCredito = new TarjetaCredito();
            TarjetaDebito = new TarjetaDebito();
        }
        // Evento personalizado SaldoInsuficiente
        public event SaldoInsuficienteEventHandler? SaldoInsuficiente;

        // Método para invocar el evento SaldoInsuficiente
        public void OnSaldoInsuficiente()
        {
            SaldoInsuficiente?.Invoke(this, EventArgs.Empty);
        }
    }
}
