
namespace Primer_proyecto
{
    partial class Ventana_Buscar
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Label_Dato = new System.Windows.Forms.Label();
            this.Button_Buscar = new System.Windows.Forms.Button();
            this.Button_Modificar = new System.Windows.Forms.Button();
            this.Button_Limpiar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(166, 33);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(333, 20);
            this.textBox1.TabIndex = 0;
            // 
            // Label_Dato
            // 
            this.Label_Dato.AutoSize = true;
            this.Label_Dato.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Dato.Location = new System.Drawing.Point(7, 33);
            this.Label_Dato.Name = "Label_Dato";
            this.Label_Dato.Size = new System.Drawing.Size(153, 20);
            this.Label_Dato.TabIndex = 3;
            this.Label_Dato.Text = "Dato del producto";
            // 
            // Button_Buscar
            // 
            this.Button_Buscar.Location = new System.Drawing.Point(166, 60);
            this.Button_Buscar.Name = "Button_Buscar";
            this.Button_Buscar.Size = new System.Drawing.Size(107, 23);
            this.Button_Buscar.TabIndex = 4;
            this.Button_Buscar.Text = "Buscar";
            this.Button_Buscar.UseVisualStyleBackColor = true;
            // 
            // Button_Modificar
            // 
            this.Button_Modificar.Location = new System.Drawing.Point(279, 60);
            this.Button_Modificar.Name = "Button_Modificar";
            this.Button_Modificar.Size = new System.Drawing.Size(107, 23);
            this.Button_Modificar.TabIndex = 5;
            this.Button_Modificar.Text = "Modificar";
            this.Button_Modificar.UseVisualStyleBackColor = true;
            // 
            // Button_Limpiar
            // 
            this.Button_Limpiar.Location = new System.Drawing.Point(392, 60);
            this.Button_Limpiar.Name = "Button_Limpiar";
            this.Button_Limpiar.Size = new System.Drawing.Size(107, 23);
            this.Button_Limpiar.TabIndex = 6;
            this.Button_Limpiar.Text = "Limpiar texto";
            this.Button_Limpiar.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 117);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(610, 150);
            this.dataGridView1.TabIndex = 7;
            // 
            // Ventana_Buscar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(635, 313);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Button_Limpiar);
            this.Controls.Add(this.Button_Modificar);
            this.Controls.Add(this.Button_Buscar);
            this.Controls.Add(this.Label_Dato);
            this.Controls.Add(this.textBox1);
            this.Name = "Ventana_Buscar";
            this.Text = "Ventana_Buscar";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label Label_Dato;
        private System.Windows.Forms.Button Button_Buscar;
        private System.Windows.Forms.Button Button_Modificar;
        private System.Windows.Forms.Button Button_Limpiar;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}