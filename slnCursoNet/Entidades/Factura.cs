using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace slnCursoNet.Entidades
{
    public class Factura : DocumentoComercial
    {
        #region Propiedades
        public string Tipo { get; set; }

        #endregion

        #region Constructor

        public Factura(string Tipo, string Numero, DateTime Fecha, string Cliente, string Direccion, string CondicionIVA, string CondicionVenta, string Detalle, decimal Total):base(Numero, Fecha, Cliente, Direccion, CondicionIVA, CondicionVenta, Detalle, Total)
        {
            this.Tipo = Tipo;

        }
        
        #endregion 
    }
}
