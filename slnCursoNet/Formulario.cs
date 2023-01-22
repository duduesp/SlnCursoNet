using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using slnCursoNet.Entidades;

namespace slnCursoNet
{
    public partial class Formulario : Form
    {
        public Formulario()
        {
            InitializeComponent();
        }


        private void btnCrearProducto_Click_Click(object sender, EventArgs e)
        {
            Producto jorgelin = new Producto("Jorgelin", "Alfajor", 100, 1.5, 0.21, "Terrabusi", "Golosinas", "Alfajores");

            MessageBox.Show("Producto Creado: " + jorgelin.Nombre + ", Categoria: " + jorgelin.Categoria + ", SubCategoria: " + jorgelin.SubCategoria + ", Proveedor: " + jorgelin.Proveedor + ", Precio de costo: " + jorgelin.PrecioCosto + ", Margen de ganancia: " + (jorgelin.Margen * 100) + "%, IVA: " + (jorgelin.IVA * 100) + "%, Precio Bruto: " + Convert.ToDouble(jorgelin.PrecioBruto) + ", Precio Venta: " + Convert.ToDouble(jorgelin.PrecioVenta));
        
        }

        private void btnCrearCliente_Click_Click(object sender, EventArgs e)
        {
            ClienteIndividuo Lara = new ClienteIndividuo("Lara", "Perez", "21-3333364-0", "lara@hotmail.com", "2222222", "Salta, 1992");
            MessageBox.Show("Cliente Creado: " + Lara.Nombre + " " + Lara.Apellido + ", CUIT: " + Lara.CUIT + ", E-mail: " + Lara.Email + ", Telefono: " + Lara.Telefono + ", Direccion:" + Lara.Direccion);


        }

        private void btnCrearEmpresa_Click_Click(object sender, EventArgs e)
        {
            Empresa proveedor = new Empresa("Coca-Cola", "12-45765789-1", "Juan Perez", "juan@coca-cola.com", "43457890", "CABA");

            MessageBox.Show($"Empresa Creada = Nombre: {proveedor.Nombre}, CUIT: {proveedor.CUIT}, Contacto: {proveedor.Contacto}, Telefono: {proveedor.Telefono}, Direccion: {proveedor.Direccion}");


        }
        private void btnCrearFactura_Click_Click(object sender, EventArgs e)
        {
            Factura factura = new Factura("A", "200-00293-12", DateTime.Now, "Toledo", "Salta 4542", "No-Exento", "30 dias", "Venta Carne", 8400);

            MessageBox.Show($"Factura Creada = Tipo: {factura.Tipo}, Numero: {factura.Numero}, Fecha: {factura.Fecha.ToString()}, Cliente: {factura.Cliente}, Direccion: {factura.Direccion}, CondicionIVA: {factura.CondicionIVA}, Condicion Venta: {factura.CondicionVenta}, Total {factura.Total}");

        }

        private void btnCrearVendedor_Click_Click(object sender, EventArgs e)
        {
            Vendedor Diego = new Vendedor("Diego", "Larroque", "33333", "dieguete@hotmail.com", "23-222222", "AJujuy 3030");

            MessageBox.Show("Cliente Creado: " + Diego.Nombre + " " + Diego.Apellido + ", DNI: " + Diego.DNI + ", E-mail: " + Diego.Email + ", Telefono: " + Diego.Telefono + ", Direccion:" + Diego.Direccion);

        }

        private void btnCrearRemito_Click_Click(object sender, EventArgs e)
        {
            // Guardamos la fecha de hoy en una variable
            DateTime hoy = DateTime.Now;
            // Para que la fecha de entrega siempre sea 48hs después
            DateTime fechaEntrega = DateTime.Now.AddDays(2);

            Remito remito = new Remito("200-06", hoy, "Toledo", "Salta 2210", "No-Exento", "25 dias", "Venta Carne", fechaEntrega, 8400);

            MessageBox.Show($"Factura Creada = Numero: {remito.Numero}, Fecha: {remito.Fecha}, Cliente: {remito.Cliente}, Direccion: {remito.Direccion}, CondicionIVA: {remito.CondicionIVA}, Condicion Venta: {remito.CondicionVenta}, Fecha de entrega: {remito.FechaEntrega}, Total {remito.Total}");

        }
    }
}
