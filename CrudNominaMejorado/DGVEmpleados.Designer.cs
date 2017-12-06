namespace CrudNominaMejorado
{
    partial class DGVEmpleados
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
            this.tbbusqueda = new System.Windows.Forms.TextBox();
            this.DGVempleado = new System.Windows.Forms.DataGridView();
            this.btbuscar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGVempleado)).BeginInit();
            this.SuspendLayout();
            // 
            // tbbusqueda
            // 
            this.tbbusqueda.Location = new System.Drawing.Point(12, 102);
            this.tbbusqueda.Name = "tbbusqueda";
            this.tbbusqueda.Size = new System.Drawing.Size(422, 20);
            this.tbbusqueda.TabIndex = 0;
            // 
            // DGVempleado
            // 
            this.DGVempleado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVempleado.Location = new System.Drawing.Point(12, 128);
            this.DGVempleado.Name = "DGVempleado";
            this.DGVempleado.Size = new System.Drawing.Size(540, 250);
            this.DGVempleado.TabIndex = 1;
            this.DGVempleado.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVempleado_CellContentClick);
            // 
            // btbuscar
            // 
            this.btbuscar.Location = new System.Drawing.Point(460, 100);
            this.btbuscar.Name = "btbuscar";
            this.btbuscar.Size = new System.Drawing.Size(75, 23);
            this.btbuscar.TabIndex = 2;
            this.btbuscar.Text = "Buscar";
            this.btbuscar.UseVisualStyleBackColor = true;
            // 
            // DGVEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 428);
            this.Controls.Add(this.btbuscar);
            this.Controls.Add(this.DGVempleado);
            this.Controls.Add(this.tbbusqueda);
            this.Name = "DGVEmpleados";
            this.Text = "DGVEmpleados";
            this.Load += new System.EventHandler(this.DGVEmpleados_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVempleado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbbusqueda;
        private System.Windows.Forms.DataGridView DGVempleado;
        private System.Windows.Forms.Button btbuscar;
    }
}