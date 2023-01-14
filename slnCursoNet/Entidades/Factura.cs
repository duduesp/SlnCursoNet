using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace slnCursoNet.Entidades
{
    public class Factura
    {
        #region Propiedades
        public string Tipo { get; set; }
        public string Numero { get; set; }

        public DateTime Fecha { get; set; }
        public string Cliente { get; set; }
        public string Direccion { get; set; }
        public string CondicionIVA { get; set; }
        public string CondicionVenta { get; set; }
        public string Detalle { get; set; }
        public decimal Total { get; set; }
        #endregion

        #region Constructor

        public Factura(string Tipo, string Numero, DateTime Fecha, string Cliente, string Direccion, string CondicionIVA, string CondicionVenta, string Detalle, decimal Total)
        {
            this.Tipo = Tipo;
            this.Numero = Numero;
            this.Fecha = Fecha;
            this.Cliente = Cliente;
            this.Direccion = Direccion;
            this.CondicionIVA= CondicionIVA;
            this.CondicionVenta= CondicionVenta;
            this.Detalle = Detalle;
            this.Total = Total;
        }

        #endregion 
    }
}
