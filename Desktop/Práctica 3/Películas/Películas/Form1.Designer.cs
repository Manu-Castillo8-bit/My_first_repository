namespace Películas
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.txtMinutos = new System.Windows.Forms.TextBox();
            this.butConsulta = new System.Windows.Forms.Button();
            this.butAlta = new System.Windows.Forms.Button();
            this.butBaja = new System.Windows.Forms.Button();
            this.butModificacion = new System.Windows.Forms.Button();
            this.butAceptar = new System.Windows.Forms.Button();
            this.butCancelar = new System.Windows.Forms.Button();
            this.butSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(196, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Películas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(27, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Código:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(27, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Título:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(25, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Duración:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(256, 169);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Minutos:";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(95, 76);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(119, 20);
            this.txtCodigo.TabIndex = 5;
            // 
            // txtTitulo
            // 
            this.txtTitulo.Location = new System.Drawing.Point(95, 118);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(344, 20);
            this.txtTitulo.TabIndex = 6;
            // 
            // txtMinutos
            // 
            this.txtMinutos.Location = new System.Drawing.Point(95, 168);
            this.txtMinutos.Name = "txtMinutos";
            this.txtMinutos.Size = new System.Drawing.Size(155, 20);
            this.txtMinutos.TabIndex = 7;
            // 
            // butConsulta
            // 
            this.butConsulta.Location = new System.Drawing.Point(21, 214);
            this.butConsulta.Name = "butConsulta";
            this.butConsulta.Size = new System.Drawing.Size(119, 49);
            this.butConsulta.TabIndex = 8;
            this.butConsulta.Text = "Consulta";
            this.butConsulta.UseVisualStyleBackColor = true;
            this.butConsulta.Click += new System.EventHandler(this.butConsulta_Click);
            // 
            // butAlta
            // 
            this.butAlta.Location = new System.Drawing.Point(146, 214);
            this.butAlta.Name = "butAlta";
            this.butAlta.Size = new System.Drawing.Size(119, 49);
            this.butAlta.TabIndex = 9;
            this.butAlta.Text = "Alta";
            this.butAlta.UseVisualStyleBackColor = true;
            this.butAlta.Click += new System.EventHandler(this.butAlta_Click);
            // 
            // butBaja
            // 
            this.butBaja.Location = new System.Drawing.Point(271, 214);
            this.butBaja.Name = "butBaja";
            this.butBaja.Size = new System.Drawing.Size(119, 49);
            this.butBaja.TabIndex = 10;
            this.butBaja.Text = "Baja";
            this.butBaja.UseVisualStyleBackColor = true;
            this.butBaja.Click += new System.EventHandler(this.butBaja_Click);
            // 
            // butModificacion
            // 
            this.butModificacion.Location = new System.Drawing.Point(396, 214);
            this.butModificacion.Name = "butModificacion";
            this.butModificacion.Size = new System.Drawing.Size(119, 49);
            this.butModificacion.TabIndex = 11;
            this.butModificacion.Text = "Modificación";
            this.butModificacion.UseVisualStyleBackColor = true;
            this.butModificacion.Click += new System.EventHandler(this.butModificacion_Click);
            // 
            // butAceptar
            // 
            this.butAceptar.Location = new System.Drawing.Point(79, 279);
            this.butAceptar.Name = "butAceptar";
            this.butAceptar.Size = new System.Drawing.Size(119, 49);
            this.butAceptar.TabIndex = 12;
            this.butAceptar.Text = "Aceptar";
            this.butAceptar.UseVisualStyleBackColor = true;
            this.butAceptar.Click += new System.EventHandler(this.butAceptar_Click);
            // 
            // butCancelar
            // 
            this.butCancelar.Location = new System.Drawing.Point(320, 279);
            this.butCancelar.Name = "butCancelar";
            this.butCancelar.Size = new System.Drawing.Size(119, 49);
            this.butCancelar.TabIndex = 13;
            this.butCancelar.Text = "Cancelar";
            this.butCancelar.UseVisualStyleBackColor = true;
            this.butCancelar.Click += new System.EventHandler(this.butCancelar_Click);
            // 
            // butSalir
            // 
            this.butSalir.Location = new System.Drawing.Point(193, 354);
            this.butSalir.Name = "butSalir";
            this.butSalir.Size = new System.Drawing.Size(119, 49);
            this.butSalir.TabIndex = 14;
            this.butSalir.Text = "Salir";
            this.butSalir.UseVisualStyleBackColor = true;
            this.butSalir.Click += new System.EventHandler(this.butSalir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 427);
            this.Controls.Add(this.butSalir);
            this.Controls.Add(this.butCancelar);
            this.Controls.Add(this.butAceptar);
            this.Controls.Add(this.butModificacion);
            this.Controls.Add(this.butBaja);
            this.Controls.Add(this.butAlta);
            this.Controls.Add(this.butConsulta);
            this.Controls.Add(this.txtMinutos);
            this.Controls.Add(this.txtTitulo);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.TextBox txtMinutos;
        private System.Windows.Forms.Button butConsulta;
        private System.Windows.Forms.Button butAlta;
        private System.Windows.Forms.Button butBaja;
        private System.Windows.Forms.Button butModificacion;
        private System.Windows.Forms.Button butAceptar;
        private System.Windows.Forms.Button butCancelar;
        private System.Windows.Forms.Button butSalir;
    }
}

