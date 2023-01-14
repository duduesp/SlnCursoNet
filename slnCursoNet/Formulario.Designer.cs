namespace slnCursoNet
{
    partial class Formulario
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCrearProducto_Click = new System.Windows.Forms.Button();
            this.btnCrearCliente_Click = new System.Windows.Forms.Button();
            this.btnCrearEmpresa_Click = new System.Windows.Forms.Button();
            this.btnCrearFactura_Click = new System.Windows.Forms.Button();
            this.btnCrearRemito_Click = new System.Windows.Forms.Button();
            this.btnCrearVendedor_Click = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCrearProducto_Click
            // 
            this.btnCrearProducto_Click.Location = new System.Drawing.Point(83, 46);
            this.btnCrearProducto_Click.Name = "btnCrearProducto_Click";
            this.btnCrearProducto_Click.Size = new System.Drawing.Size(182, 51);
            this.btnCrearProducto_Click.TabIndex = 0;
            this.btnCrearProducto_Click.Text = "Crear Producto";
            this.btnCrearProducto_Click.UseVisualStyleBackColor = true;
            this.btnCrearProducto_Click.Click += new System.EventHandler(this.btnCrearProducto_Click_Click);
            // 
            // btnCrearCliente_Click
            // 
            this.btnCrearCliente_Click.Location = new System.Drawing.Point(306, 46);
            this.btnCrearCliente_Click.Name = "btnCrearCliente_Click";
            this.btnCrearCliente_Click.Size = new System.Drawing.Size(199, 51);
            this.btnCrearCliente_Click.TabIndex = 1;
            this.btnCrearCliente_Click.Text = "Crear Cliente";
            this.btnCrearCliente_Click.UseVisualStyleBackColor = true;
            this.btnCrearCliente_Click.Click += new System.EventHandler(this.btnCrearCliente_Click_Click);
            // 
            // btnCrearEmpresa_Click
            // 
            this.btnCrearEmpresa_Click.Location = new System.Drawing.Point(567, 46);
            this.btnCrearEmpresa_Click.Name = "btnCrearEmpresa_Click";
            this.btnCrearEmpresa_Click.Size = new System.Drawing.Size(181, 51);
            this.btnCrearEmpresa_Click.TabIndex = 2;
            this.btnCrearEmpresa_Click.Text = "Crear Empresa";
            this.btnCrearEmpresa_Click.UseVisualStyleBackColor = true;
            this.btnCrearEmpresa_Click.Click += new System.EventHandler(this.btnCrearEmpresa_Click_Click);
            // 
            // btnCrearFactura_Click
            // 
            this.btnCrearFactura_Click.Location = new System.Drawing.Point(83, 158);
            this.btnCrearFactura_Click.Name = "btnCrearFactura_Click";
            this.btnCrearFactura_Click.Size = new System.Drawing.Size(182, 53);
            this.btnCrearFactura_Click.TabIndex = 3;
            this.btnCrearFactura_Click.Text = "Crear Factura";
            this.btnCrearFactura_Click.UseVisualStyleBackColor = true;
            this.btnCrearFactura_Click.Click += new System.EventHandler(this.btnCrearFactura_Click_Click);
            // 
            // btnCrearRemito_Click
            // 
            this.btnCrearRemito_Click.Location = new System.Drawing.Point(306, 158);
            this.btnCrearRemito_Click.Name = "btnCrearRemito_Click";
            this.btnCrearRemito_Click.Size = new System.Drawing.Size(199, 53);
            this.btnCrearRemito_Click.TabIndex = 4;
            this.btnCrearRemito_Click.Text = "Crear Remito";
            this.btnCrearRemito_Click.UseVisualStyleBackColor = true;
            this.btnCrearRemito_Click.Click += new System.EventHandler(this.btnCrearRemito_Click_Click);
            // 
            // btnCrearVendedor_Click
            // 
            this.btnCrearVendedor_Click.Location = new System.Drawing.Point(567, 158);
            this.btnCrearVendedor_Click.Name = "btnCrearVendedor_Click";
            this.btnCrearVendedor_Click.Size = new System.Drawing.Size(181, 53);
            this.btnCrearVendedor_Click.TabIndex = 5;
            this.btnCrearVendedor_Click.Text = "Crear Vendedor";
            this.btnCrearVendedor_Click.UseVisualStyleBackColor = true;
            this.btnCrearVendedor_Click.Click += new System.EventHandler(this.btnCrearVendedor_Click_Click);
            // 
            // Formulario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCrearVendedor_Click);
            this.Controls.Add(this.btnCrearRemito_Click);
            this.Controls.Add(this.btnCrearFactura_Click);
            this.Controls.Add(this.btnCrearEmpresa_Click);
            this.Controls.Add(this.btnCrearCliente_Click);
            this.Controls.Add(this.btnCrearProducto_Click);
            this.Name = "Formulario";
            this.Text = "Formulario";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCrearProducto_Click;
        private System.Windows.Forms.Button btnCrearCliente_Click;
        private System.Windows.Forms.Button btnCrearEmpresa_Click;
        private System.Windows.Forms.Button btnCrearFactura_Click;
        private System.Windows.Forms.Button btnCrearRemito_Click;
        private System.Windows.Forms.Button btnCrearVendedor_Click;
    }
}