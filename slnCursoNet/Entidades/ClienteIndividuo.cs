using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace slnCursoNet.Entidades
{
    public class ClienteIndividuo
    {
        #region Propiedades
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string CUIT { get; set; }
        public string Email { get; set; }
        public string Telefono { get; set; }
        public string Direccion { get; set; }

        #endregion

        #region Constructor

        public ClienteIndividuo(string Nombre, string Apellido, string CUIT, string Email, string Telefono, string Direccion) 
        {
            this.Nombre = Nombre;
            this.Apellido = Apellido;
            this.CUIT = CUIT;
            this.Email = Email;
            this.Telefono = Telefono;
            this.Direccion= Direccion;
        }
        #endregion

    }
}
