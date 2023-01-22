using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace slnCursoNet.Entidades
{
    public class Vendedor : Persona
    {
        #region

        public string DNI { get; set; }

        #endregion

        #region Constructor

        public Vendedor (string Nombre, string Apellido, string DNI, string Email, string Telefono, string Direccion): base (Nombre, Apellido, Email, Telefono, Direccion)
        {
;
            this.DNI = DNI;

        }


        #endregion

    }
}
