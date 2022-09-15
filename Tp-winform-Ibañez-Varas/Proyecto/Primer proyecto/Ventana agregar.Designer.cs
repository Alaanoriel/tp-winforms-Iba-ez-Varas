
namespace Primer_proyecto
{
    partial class Ventana_agregar
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
            this.Label_CodigoArticulo = new System.Windows.Forms.Label();
            this.Txtbox_CodigoArticulo = new System.Windows.Forms.TextBox();
            this.Label_Nombre = new System.Windows.Forms.Label();
            this.Txtbox_Nombre = new System.Windows.Forms.TextBox();
            this.Label_Precio = new System.Windows.Forms.Label();
            this.Txtbox_Precio = new System.Windows.Forms.TextBox();
            this.Label_Descripcion = new System.Windows.Forms.Label();
            this.Txtbox_Descripcion = new System.Windows.Forms.TextBox();
            this.Label_Marca = new System.Windows.Forms.Label();
            this.Label_Categoria = new System.Windows.Forms.Label();
            this.ComboBox_Marca = new System.Windows.Forms.ComboBox();
            this.ComboBox_Categoria = new System.Windows.Forms.ComboBox();
            this.Label_Imagen = new System.Windows.Forms.Label();
            this.DataGrid_Productos = new System.Windows.Forms.DataGridView();
            this.Button_Agregar = new System.Windows.Forms.Button();
            this.Button_Modificar = new System.Windows.Forms.Button();
            this.Button_Eliminar = new System.Windows.Forms.Button();
            this.Button_Celdas = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid_Productos)).BeginInit();
            this.SuspendLayout();
            // 
            // Label_CodigoArticulo
            // 
            this.Label_CodigoArticulo.AutoSize = true;
            this.Label_CodigoArticulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_CodigoArticulo.Location = new System.Drawing.Point(12, 18);
            this.Label_CodigoArticulo.Name = "Label_CodigoArticulo";
            this.Label_CodigoArticulo.Size = new System.Drawing.Size(154, 20);
            this.Label_CodigoArticulo.TabIndex = 0;
            this.Label_CodigoArticulo.Text = "Codigo de articulo";
            // 
            // Txtbox_CodigoArticulo
            // 
            this.Txtbox_CodigoArticulo.Location = new System.Drawing.Point(172, 20);
            this.Txtbox_CodigoArticulo.Name = "Txtbox_CodigoArticulo";
            this.Txtbox_CodigoArticulo.Size = new System.Drawing.Size(156, 20);
            this.Txtbox_CodigoArticulo.TabIndex = 1;
            // 
            // Label_Nombre
            // 
            this.Label_Nombre.AutoSize = true;
            this.Label_Nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Nombre.Location = new System.Drawing.Point(52, 62);
            this.Label_Nombre.Name = "Label_Nombre";
            this.Label_Nombre.Size = new System.Drawing.Size(71, 20);
            this.Label_Nombre.TabIndex = 2;
            this.Label_Nombre.Text = "Nombre";
            // 
            // Txtbox_Nombre
            // 
            this.Txtbox_Nombre.Location = new System.Drawing.Point(172, 64);
            this.Txtbox_Nombre.Name = "Txtbox_Nombre";
            this.Txtbox_Nombre.Size = new System.Drawing.Size(156, 20);
            this.Txtbox_Nombre.TabIndex = 3;
            // 
            // Label_Precio
            // 
            this.Label_Precio.AutoSize = true;
            this.Label_Precio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Precio.Location = new System.Drawing.Point(424, 64);
            this.Label_Precio.Name = "Label_Precio";
            this.Label_Precio.Size = new System.Drawing.Size(59, 20);
            this.Label_Precio.TabIndex = 4;
            this.Label_Precio.Text = "Precio";
            // 
            // Txtbox_Precio
            // 
            this.Txtbox_Precio.Location = new System.Drawing.Point(522, 66);
            this.Txtbox_Precio.Name = "Txtbox_Precio";
            this.Txtbox_Precio.Size = new System.Drawing.Size(218, 20);
            this.Txtbox_Precio.TabIndex = 5;
            // 
            // Label_Descripcion
            // 
            this.Label_Descripcion.AutoSize = true;
            this.Label_Descripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Descripcion.Location = new System.Drawing.Point(403, 20);
            this.Label_Descripcion.Name = "Label_Descripcion";
            this.Label_Descripcion.Size = new System.Drawing.Size(103, 20);
            this.Label_Descripcion.TabIndex = 6;
            this.Label_Descripcion.Text = "Descripcion";
            // 
            // Txtbox_Descripcion
            // 
            this.Txtbox_Descripcion.Location = new System.Drawing.Point(522, 3);
            this.Txtbox_Descripcion.Multiline = true;
            this.Txtbox_Descripcion.Name = "Txtbox_Descripcion";
            this.Txtbox_Descripcion.Size = new System.Drawing.Size(218, 50);
            this.Txtbox_Descripcion.TabIndex = 7;
            // 
            // Label_Marca
            // 
            this.Label_Marca.AutoSize = true;
            this.Label_Marca.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Marca.Location = new System.Drawing.Point(52, 107);
            this.Label_Marca.Name = "Label_Marca";
            this.Label_Marca.Size = new System.Drawing.Size(58, 20);
            this.Label_Marca.TabIndex = 8;
            this.Label_Marca.Text = "Marca";
            // 
            // Label_Categoria
            // 
            this.Label_Categoria.AutoSize = true;
            this.Label_Categoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Categoria.Location = new System.Drawing.Point(39, 144);
            this.Label_Categoria.Name = "Label_Categoria";
            this.Label_Categoria.Size = new System.Drawing.Size(87, 20);
            this.Label_Categoria.TabIndex = 9;
            this.Label_Categoria.Text = "Categoria";
            // 
            // ComboBox_Marca
            // 
            this.ComboBox_Marca.FormattingEnabled = true;
            this.ComboBox_Marca.Location = new System.Drawing.Point(172, 106);
            this.ComboBox_Marca.Name = "ComboBox_Marca";
            this.ComboBox_Marca.Size = new System.Drawing.Size(156, 21);
            this.ComboBox_Marca.TabIndex = 10;
            // 
            // ComboBox_Categoria
            // 
            this.ComboBox_Categoria.FormattingEnabled = true;
            this.ComboBox_Categoria.Location = new System.Drawing.Point(172, 146);
            this.ComboBox_Categoria.Name = "ComboBox_Categoria";
            this.ComboBox_Categoria.Size = new System.Drawing.Size(156, 21);
            this.ComboBox_Categoria.TabIndex = 11;
            // 
            // Label_Imagen
            // 
            this.Label_Imagen.AutoSize = true;
            this.Label_Imagen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Imagen.Location = new System.Drawing.Point(424, 107);
            this.Label_Imagen.Name = "Label_Imagen";
            this.Label_Imagen.Size = new System.Drawing.Size(69, 20);
            this.Label_Imagen.TabIndex = 12;
            this.Label_Imagen.Text = "Imagen";
            // 
            // DataGrid_Productos
            // 
            this.DataGrid_Productos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGrid_Productos.Location = new System.Drawing.Point(172, 195);
            this.DataGrid_Productos.Name = "DataGrid_Productos";
            this.DataGrid_Productos.Size = new System.Drawing.Size(568, 166);
            this.DataGrid_Productos.TabIndex = 13;
            // 
            // Button_Agregar
            // 
            this.Button_Agregar.Location = new System.Drawing.Point(43, 195);
            this.Button_Agregar.Name = "Button_Agregar";
            this.Button_Agregar.Size = new System.Drawing.Size(123, 36);
            this.Button_Agregar.TabIndex = 14;
            this.Button_Agregar.Text = "Agregar producto";
            this.Button_Agregar.UseVisualStyleBackColor = true;
            // 
            // Button_Modificar
            // 
            this.Button_Modificar.Location = new System.Drawing.Point(43, 237);
            this.Button_Modificar.Name = "Button_Modificar";
            this.Button_Modificar.Size = new System.Drawing.Size(123, 36);
            this.Button_Modificar.TabIndex = 15;
            this.Button_Modificar.Text = "Modificar";
            this.Button_Modificar.UseVisualStyleBackColor = true;
            // 
            // Button_Eliminar
            // 
            this.Button_Eliminar.Location = new System.Drawing.Point(43, 279);
            this.Button_Eliminar.Name = "Button_Eliminar";
            this.Button_Eliminar.Size = new System.Drawing.Size(123, 36);
            this.Button_Eliminar.TabIndex = 16;
            this.Button_Eliminar.Text = "Eliminar";
            this.Button_Eliminar.UseVisualStyleBackColor = true;
            // 
            // Button_Celdas
            // 
            this.Button_Celdas.Location = new System.Drawing.Point(43, 321);
            this.Button_Celdas.Name = "Button_Celdas";
            this.Button_Celdas.Size = new System.Drawing.Size(123, 36);
            this.Button_Celdas.TabIndex = 17;
            this.Button_Celdas.Text = "Limpiar celdas";
            this.Button_Celdas.UseVisualStyleBackColor = true;
            // 
            // Ventana_agregar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(754, 373);
            this.Controls.Add(this.Button_Celdas);
            this.Controls.Add(this.Button_Eliminar);
            this.Controls.Add(this.Button_Modificar);
            this.Controls.Add(this.Button_Agregar);
            this.Controls.Add(this.DataGrid_Productos);
            this.Controls.Add(this.Label_Imagen);
            this.Controls.Add(this.ComboBox_Categoria);
            this.Controls.Add(this.ComboBox_Marca);
            this.Controls.Add(this.Label_Categoria);
            this.Controls.Add(this.Label_Marca);
            this.Controls.Add(this.Txtbox_Descripcion);
            this.Controls.Add(this.Label_Descripcion);
            this.Controls.Add(this.Txtbox_Precio);
            this.Controls.Add(this.Label_Precio);
            this.Controls.Add(this.Txtbox_Nombre);
            this.Controls.Add(this.Label_Nombre);
            this.Controls.Add(this.Txtbox_CodigoArticulo);
            this.Controls.Add(this.Label_CodigoArticulo);
            this.Name = "Ventana_agregar";
            this.Text = "Nuevo producto";
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid_Productos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Label_CodigoArticulo;
        private System.Windows.Forms.TextBox Txtbox_CodigoArticulo;
        private System.Windows.Forms.Label Label_Nombre;
        private System.Windows.Forms.TextBox Txtbox_Nombre;
        private System.Windows.Forms.Label Label_Precio;
        private System.Windows.Forms.TextBox Txtbox_Precio;
        private System.Windows.Forms.Label Label_Descripcion;
        private System.Windows.Forms.TextBox Txtbox_Descripcion;
        private System.Windows.Forms.Label Label_Marca;
        private System.Windows.Forms.Label Label_Categoria;
        private System.Windows.Forms.ComboBox ComboBox_Marca;
        private System.Windows.Forms.ComboBox ComboBox_Categoria;
        private System.Windows.Forms.Label Label_Imagen;
        private System.Windows.Forms.DataGridView DataGrid_Productos;
        private System.Windows.Forms.Button Button_Agregar;
        private System.Windows.Forms.Button Button_Modificar;
        private System.Windows.Forms.Button Button_Eliminar;
        private System.Windows.Forms.Button Button_Celdas;
    }
}