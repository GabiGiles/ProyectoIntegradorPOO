namespace WindowsAppDemos
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCrearObjetos = new System.Windows.Forms.Button();
            this.btnSuma = new System.Windows.Forms.Button();
            this.lblResultado = new System.Windows.Forms.Label();
            this.btnClientes = new System.Windows.Forms.Button();
            this.btnListaCliente = new System.Windows.Forms.Button();
            this.lstClientes = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnCrearObjetos
            // 
            this.btnCrearObjetos.Location = new System.Drawing.Point(394, 36);
            this.btnCrearObjetos.Name = "btnCrearObjetos";
            this.btnCrearObjetos.Size = new System.Drawing.Size(199, 23);
            this.btnCrearObjetos.TabIndex = 0;
            this.btnCrearObjetos.Text = "Crear objetos";
            this.btnCrearObjetos.UseVisualStyleBackColor = true;
            this.btnCrearObjetos.Click += new System.EventHandler(this.btnCrearObjetos_Click);
            // 
            // btnSuma
            // 
            this.btnSuma.Location = new System.Drawing.Point(394, 86);
            this.btnSuma.Name = "btnSuma";
            this.btnSuma.Size = new System.Drawing.Size(190, 23);
            this.btnSuma.TabIndex = 1;
            this.btnSuma.Text = "Sumar";
            this.btnSuma.UseVisualStyleBackColor = true;
            this.btnSuma.Click += new System.EventHandler(this.btnSuma_Click);
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(593, 227);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(0, 16);
            this.lblResultado.TabIndex = 2;
            // 
            // btnClientes
            // 
            this.btnClientes.Location = new System.Drawing.Point(394, 152);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Size = new System.Drawing.Size(190, 23);
            this.btnClientes.TabIndex = 3;
            this.btnClientes.Text = "Crear clientes";
            this.btnClientes.UseVisualStyleBackColor = true;
            this.btnClientes.Click += new System.EventHandler(this.btnClientes_Click);
            // 
            // btnListaCliente
            // 
            this.btnListaCliente.Location = new System.Drawing.Point(406, 227);
            this.btnListaCliente.Name = "btnListaCliente";
            this.btnListaCliente.Size = new System.Drawing.Size(178, 23);
            this.btnListaCliente.TabIndex = 4;
            this.btnListaCliente.Text = "Crear lista de Clientes";
            this.btnListaCliente.UseVisualStyleBackColor = true;
            this.btnListaCliente.Click += new System.EventHandler(this.btnListaCliente_Click);
            // 
            // lstClientes
            // 
            this.lstClientes.FormattingEnabled = true;
            this.lstClientes.ItemHeight = 16;
            this.lstClientes.Location = new System.Drawing.Point(406, 277);
            this.lstClientes.Name = "lstClientes";
            this.lstClientes.Size = new System.Drawing.Size(161, 148);
            this.lstClientes.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lstClientes);
            this.Controls.Add(this.btnListaCliente);
            this.Controls.Add(this.btnClientes);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.btnSuma);
            this.Controls.Add(this.btnCrearObjetos);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCrearObjetos;
        private System.Windows.Forms.Button btnSuma;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Button btnClientes;
        private System.Windows.Forms.Button btnListaCliente;
        private System.Windows.Forms.ListBox lstClientes;
    }
}

