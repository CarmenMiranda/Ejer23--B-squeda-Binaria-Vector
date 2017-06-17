namespace Ejer23_Busqueda_Binaria_Vector
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
            this.lblTamaño = new System.Windows.Forms.Label();
            this.txtTamaño = new System.Windows.Forms.TextBox();
            this.btnCrearVector = new System.Windows.Forms.Button();
            this.btnLlenarVector = new System.Windows.Forms.Button();
            this.txtLímite = new System.Windows.Forms.TextBox();
            this.lblLímite = new System.Windows.Forms.Label();
            this.btnOrdenarVector = new System.Windows.Forms.Button();
            this.btnMostrarVector = new System.Windows.Forms.Button();
            this.txtInformación = new System.Windows.Forms.TextBox();
            this.btnBusqueda = new System.Windows.Forms.Button();
            this.txtNumeroBusqueda = new System.Windows.Forms.TextBox();
            this.lblBusqueda = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTamaño
            // 
            this.lblTamaño.AutoSize = true;
            this.lblTamaño.Location = new System.Drawing.Point(20, 18);
            this.lblTamaño.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTamaño.Name = "lblTamaño";
            this.lblTamaño.Size = new System.Drawing.Size(67, 18);
            this.lblTamaño.TabIndex = 0;
            this.lblTamaño.Text = "Tamaño:";
            // 
            // txtTamaño
            // 
            this.txtTamaño.Location = new System.Drawing.Point(95, 15);
            this.txtTamaño.Name = "txtTamaño";
            this.txtTamaño.Size = new System.Drawing.Size(100, 24);
            this.txtTamaño.TabIndex = 1;
            // 
            // btnCrearVector
            // 
            this.btnCrearVector.Location = new System.Drawing.Point(95, 46);
            this.btnCrearVector.Name = "btnCrearVector";
            this.btnCrearVector.Size = new System.Drawing.Size(100, 31);
            this.btnCrearVector.TabIndex = 2;
            this.btnCrearVector.Text = "Crear";
            this.btnCrearVector.UseVisualStyleBackColor = true;
            this.btnCrearVector.Click += new System.EventHandler(this.btnCrearVector_Click);
            // 
            // btnLlenarVector
            // 
            this.btnLlenarVector.Location = new System.Drawing.Point(95, 114);
            this.btnLlenarVector.Name = "btnLlenarVector";
            this.btnLlenarVector.Size = new System.Drawing.Size(100, 31);
            this.btnLlenarVector.TabIndex = 5;
            this.btnLlenarVector.Text = "Llenar";
            this.btnLlenarVector.UseVisualStyleBackColor = true;
            this.btnLlenarVector.Click += new System.EventHandler(this.btnLlenarVector_Click);
            // 
            // txtLímite
            // 
            this.txtLímite.Location = new System.Drawing.Point(95, 83);
            this.txtLímite.Name = "txtLímite";
            this.txtLímite.Size = new System.Drawing.Size(100, 24);
            this.txtLímite.TabIndex = 4;
            // 
            // lblLímite
            // 
            this.lblLímite.AutoSize = true;
            this.lblLímite.Location = new System.Drawing.Point(20, 86);
            this.lblLímite.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLímite.Name = "lblLímite";
            this.lblLímite.Size = new System.Drawing.Size(51, 18);
            this.lblLímite.TabIndex = 3;
            this.lblLímite.Text = "Límite:";
            // 
            // btnOrdenarVector
            // 
            this.btnOrdenarVector.Location = new System.Drawing.Point(12, 151);
            this.btnOrdenarVector.Name = "btnOrdenarVector";
            this.btnOrdenarVector.Size = new System.Drawing.Size(75, 31);
            this.btnOrdenarVector.TabIndex = 6;
            this.btnOrdenarVector.Text = "Ordenar";
            this.btnOrdenarVector.UseVisualStyleBackColor = true;
            this.btnOrdenarVector.Click += new System.EventHandler(this.btnOrdenarVector_Click);
            // 
            // btnMostrarVector
            // 
            this.btnMostrarVector.Location = new System.Drawing.Point(95, 151);
            this.btnMostrarVector.Name = "btnMostrarVector";
            this.btnMostrarVector.Size = new System.Drawing.Size(100, 31);
            this.btnMostrarVector.TabIndex = 7;
            this.btnMostrarVector.Text = "Mostrar";
            this.btnMostrarVector.UseVisualStyleBackColor = true;
            this.btnMostrarVector.Click += new System.EventHandler(this.btnMostrarVector_Click);
            // 
            // txtInformación
            // 
            this.txtInformación.Location = new System.Drawing.Point(224, 15);
            this.txtInformación.Multiline = true;
            this.txtInformación.Name = "txtInformación";
            this.txtInformación.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtInformación.Size = new System.Drawing.Size(251, 314);
            this.txtInformación.TabIndex = 8;
            // 
            // btnBusqueda
            // 
            this.btnBusqueda.Location = new System.Drawing.Point(52, 240);
            this.btnBusqueda.Name = "btnBusqueda";
            this.btnBusqueda.Size = new System.Drawing.Size(143, 31);
            this.btnBusqueda.TabIndex = 11;
            this.btnBusqueda.Text = "Busqueda binaria";
            this.btnBusqueda.UseVisualStyleBackColor = true;
            this.btnBusqueda.Click += new System.EventHandler(this.btnBusqueda_Click);
            // 
            // txtNumeroBusqueda
            // 
            this.txtNumeroBusqueda.Location = new System.Drawing.Point(95, 210);
            this.txtNumeroBusqueda.Name = "txtNumeroBusqueda";
            this.txtNumeroBusqueda.Size = new System.Drawing.Size(100, 24);
            this.txtNumeroBusqueda.TabIndex = 10;
            // 
            // lblBusqueda
            // 
            this.lblBusqueda.Location = new System.Drawing.Point(10, 197);
            this.lblBusqueda.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBusqueda.Name = "lblBusqueda";
            this.lblBusqueda.Size = new System.Drawing.Size(78, 40);
            this.lblBusqueda.TabIndex = 9;
            this.lblBusqueda.Text = "Número a buscar:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 342);
            this.Controls.Add(this.btnBusqueda);
            this.Controls.Add(this.txtNumeroBusqueda);
            this.Controls.Add(this.lblBusqueda);
            this.Controls.Add(this.txtInformación);
            this.Controls.Add(this.btnMostrarVector);
            this.Controls.Add(this.btnOrdenarVector);
            this.Controls.Add(this.btnLlenarVector);
            this.Controls.Add(this.txtLímite);
            this.Controls.Add(this.lblLímite);
            this.Controls.Add(this.btnCrearVector);
            this.Controls.Add(this.txtTamaño);
            this.Controls.Add(this.lblTamaño);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTamaño;
        private System.Windows.Forms.TextBox txtTamaño;
        private System.Windows.Forms.Button btnCrearVector;
        private System.Windows.Forms.Button btnLlenarVector;
        private System.Windows.Forms.TextBox txtLímite;
        private System.Windows.Forms.Label lblLímite;
        private System.Windows.Forms.Button btnOrdenarVector;
        private System.Windows.Forms.Button btnMostrarVector;
        private System.Windows.Forms.TextBox txtInformación;
        private System.Windows.Forms.Button btnBusqueda;
        private System.Windows.Forms.TextBox txtNumeroBusqueda;
        private System.Windows.Forms.Label lblBusqueda;
    }
}

