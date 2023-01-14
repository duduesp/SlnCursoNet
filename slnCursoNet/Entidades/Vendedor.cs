using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace slnCursoNet.Entidades
{
    public class Vendedor
    {
        #region
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string DNI { get; set; }
        public string Email { get; set; }
        public string Telefono { get; set; }
        public string Direccion { get; set; }
        #endregion

        #region Constructor

        public Vendedor (string Nombre, string Apellido, string DNI, string Email, string Telefono, string Direccion)
        {
            this.Nombre = Nombre;
            this.Apellido = Apellido;
            this.DNI = DNI;
            this.Email = Email;
            this.Telefono = Telefono;
            this.Direccion= Direccion;
        }


        #endregion

    }
}
