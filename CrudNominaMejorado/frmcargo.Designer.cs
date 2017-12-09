namespace CrudNominaMejorado
{
    partial class frmcargo
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tbcodigo = new System.Windows.Forms.TextBox();
            this.tbnombre = new System.Windows.Forms.TextBox();
            this.tbestatus = new System.Windows.Forms.TextBox();
            this.btguardar = new System.Windows.Forms.Button();
            this.btactualizar = new System.Windows.Forms.Button();
            this.bteliminar = new System.Windows.Forms.Button();
            this.btconsultar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(80, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(80, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Codigo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(80, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nombre";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.tbestatus);
            this.panel1.Controls.Add(this.tbnombre);
            this.panel1.Controls.Add(this.tbcodigo);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(42, 73);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(375, 147);
            this.panel1.TabIndex = 3;
            // 
            // tbcodigo
            // 
            this.tbcodigo.Location = new System.Drawing.Point(142, 33);
            this.tbcodigo.Name = "tbcodigo";
            this.tbcodigo.Size = new System.Drawing.Size(192, 20);
            this.tbcodigo.TabIndex = 3;
            // 
            // tbnombre
            // 
            this.tbnombre.Location = new System.Drawing.Point(142, 64);
            this.tbnombre.Name = "tbnombre";
            this.tbnombre.Size = new System.Drawing.Size(192, 20);
            this.tbnombre.TabIndex = 4;
            // 
            // tbestatus
            // 
            this.tbestatus.Location = new System.Drawing.Point(142, 100);
            this.tbestatus.Name = "tbestatus";
            this.tbestatus.Size = new System.Drawing.Size(192, 20);
            this.tbestatus.TabIndex = 5;
            // 
            // btguardar
            // 
            this.btguardar.Location = new System.Drawing.Point(42, 268);
            this.btguardar.Name = "btguardar";
            this.btguardar.Size = new System.Drawing.Size(75, 23);
            this.btguardar.TabIndex = 4;
            this.btguardar.Text = "Guardar";
            this.btguardar.UseVisualStyleBackColor = true;
            // 
            // btactualizar
            // 
            this.btactualizar.Location = new System.Drawing.Point(127, 268);
            this.btactualizar.Name = "btactualizar";
            this.btactualizar.Size = new System.Drawing.Size(75, 23);
            this.btactualizar.TabIndex = 5;
            this.btactualizar.Text = "Actualizar";
            this.btactualizar.UseVisualStyleBackColor = true;
            // 
            // bteliminar
            // 
            this.bteliminar.Location = new System.Drawing.Point(213, 268);
            this.bteliminar.Name = "bteliminar";
            this.bteliminar.Size = new System.Drawing.Size(75, 23);
            this.bteliminar.TabIndex = 6;
            this.bteliminar.Text = "Eliminar";
            this.bteliminar.UseVisualStyleBackColor = true;
            // 
            // btconsultar
            // 
            this.btconsultar.Location = new System.Drawing.Point(342, 268);
            this.btconsultar.Name = "btconsultar";
            this.btconsultar.Size = new System.Drawing.Size(75, 23);
            this.btconsultar.TabIndex = 7;
            this.btconsultar.Text = "Consultar";
            this.btconsultar.UseVisualStyleBackColor = true;
            // 
            // frmcargo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 321);
            this.Controls.Add(this.btconsultar);
            this.Controls.Add(this.bteliminar);
            this.Controls.Add(this.btactualizar);
            this.Controls.Add(this.btguardar);
            this.Controls.Add(this.panel1);
            this.Name = "frmcargo";
            this.Text = "Cargos";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox tbestatus;
        private System.Windows.Forms.TextBox tbnombre;
        private System.Windows.Forms.TextBox tbcodigo;
        private System.Windows.Forms.Button btguardar;
        private System.Windows.Forms.Button btactualizar;
        private System.Windows.Forms.Button bteliminar;
        private System.Windows.Forms.Button btconsultar;
    }
}