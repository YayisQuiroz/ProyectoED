using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppTienda
{
    public class Venta
    {
        private int numeroVenta;
        private DateTime fecha;
        private string producto;
        private int cantidad;
        private decimal total;

        public Venta() { }
        public Venta(int Numeroventa, DateTime Fecha, string Producto, int Cantidad, decimal Total) 
        {
            numeroVenta = Numeroventa;
            fecha = Fecha;
            producto = Producto;
            cantidad = Cantidad;
            total = Total;
        }
        public int NumeroVenta { get => numeroVenta; set => numeroVenta = value; }
        public DateTime Fecha { get => fecha; set => fecha = value; }
        public string Producto { get => producto; set => producto = value; }
        public int Cantidad { get => cantidad; set => cantidad = value; }
        public decimal Total { get => total; set => total = value; }
    }
}
