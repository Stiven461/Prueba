namespace Presentacion
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
            this.label_Titulo = new System.Windows.Forms.Label();
            this.button_salir = new System.Windows.Forms.Button();
            this.button_Guardar = new System.Windows.Forms.Button();
            this.dateTimePicker_Fecha = new System.Windows.Forms.DateTimePicker();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label_Liquidacion = new System.Windows.Forms.Label();
            this.label_Valor_Servicio = new System.Windows.Forms.Label();
            this.label_Afiliacion = new System.Windows.Forms.Label();
            this.label_Identificacion = new System.Windows.Forms.Label();
            this.label_Salario_Devengado = new System.Windows.Forms.Label();
            this.label_Fecha_Liquidacion = new System.Windows.Forms.Label();
            this.textBox_Liquidacion = new System.Windows.Forms.TextBox();
            this.textBox_ValorServicio = new System.Windows.Forms.TextBox();
            this.textBox_Identificacion = new System.Windows.Forms.TextBox();
            this.button_Borrar = new System.Windows.Forms.Button();
            this.comboBox_TipoAfiliacion = new System.Windows.Forms.ComboBox();
            this.comboBox_Tipo_Identificacion = new System.Windows.Forms.ComboBox();
            this.comboBox_Salario_Devengado = new System.Windows.Forms.ComboBox();
            this.label_TipoIdentificacion = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label_Titulo
            // 
            this.label_Titulo.AutoSize = true;
            this.label_Titulo.Font = new System.Drawing.Font("Verdana", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Titulo.Location = new System.Drawing.Point(412, 9);
            this.label_Titulo.Name = "label_Titulo";
            this.label_Titulo.Size = new System.Drawing.Size(220, 25);
            this.label_Titulo.TabIndex = 0;
            this.label_Titulo.Text = "IPS SALUD TOTAL";
            // 
            // button_salir
            // 
            this.button_salir.Location = new System.Drawing.Point(943, 549);
            this.button_salir.Name = "button_salir";
            this.button_salir.Size = new System.Drawing.Size(75, 23);
            this.button_salir.TabIndex = 1;
            this.button_salir.Text = "Salir";
            this.button_salir.UseVisualStyleBackColor = true;
            this.button_salir.Click += new System.EventHandler(this.button_salir_Click);
            // 
            // button_Guardar
            // 
            this.button_Guardar.Location = new System.Drawing.Point(2, 549);
            this.button_Guardar.Name = "button_Guardar";
            this.button_Guardar.Size = new System.Drawing.Size(75, 23);
            this.button_Guardar.TabIndex = 2;
            this.button_Guardar.Text = "Guardar";
            this.button_Guardar.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker_Fecha
            // 
            this.dateTimePicker_Fecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker_Fecha.Location = new System.Drawing.Point(219, 147);
            this.dateTimePicker_Fecha.Name = "dateTimePicker_Fecha";
            this.dateTimePicker_Fecha.Size = new System.Drawing.Size(96, 20);
            this.dateTimePicker_Fecha.TabIndex = 3;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(397, 73);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(621, 434);
            this.dataGridView1.TabIndex = 4;
            // 
            // label_Liquidacion
            // 
            this.label_Liquidacion.AutoSize = true;
            this.label_Liquidacion.Location = new System.Drawing.Point(67, 88);
            this.label_Liquidacion.Name = "label_Liquidacion";
            this.label_Liquidacion.Size = new System.Drawing.Size(101, 13);
            this.label_Liquidacion.TabIndex = 5;
            this.label_Liquidacion.Text = "Numero Liquidacion";
            // 
            // label_Valor_Servicio
            // 
            this.label_Valor_Servicio.AutoSize = true;
            this.label_Valor_Servicio.Location = new System.Drawing.Point(67, 396);
            this.label_Valor_Servicio.Name = "label_Valor_Servicio";
            this.label_Valor_Servicio.Size = new System.Drawing.Size(89, 13);
            this.label_Valor_Servicio.TabIndex = 9;
            this.label_Valor_Servicio.Text = "Valor del Servicio";
            // 
            // label_Afiliacion
            // 
            this.label_Afiliacion.AutoSize = true;
            this.label_Afiliacion.Location = new System.Drawing.Point(67, 266);
            this.label_Afiliacion.Name = "label_Afiliacion";
            this.label_Afiliacion.Size = new System.Drawing.Size(88, 13);
            this.label_Afiliacion.TabIndex = 10;
            this.label_Afiliacion.Text = "Tipo de Afiliación";
            // 
            // label_Identificacion
            // 
            this.label_Identificacion.AutoSize = true;
            this.label_Identificacion.Location = new System.Drawing.Point(67, 208);
            this.label_Identificacion.Name = "label_Identificacion";
            this.label_Identificacion.Size = new System.Drawing.Size(115, 13);
            this.label_Identificacion.TabIndex = 11;
            this.label_Identificacion.Text = "Identificación Paciente";
            // 
            // label_Salario_Devengado
            // 
            this.label_Salario_Devengado.AutoSize = true;
            this.label_Salario_Devengado.Location = new System.Drawing.Point(67, 330);
            this.label_Salario_Devengado.Name = "label_Salario_Devengado";
            this.label_Salario_Devengado.Size = new System.Drawing.Size(98, 13);
            this.label_Salario_Devengado.TabIndex = 12;
            this.label_Salario_Devengado.Text = "Salario Devengado";
            // 
            // label_Fecha_Liquidacion
            // 
            this.label_Fecha_Liquidacion.AutoSize = true;
            this.label_Fecha_Liquidacion.Location = new System.Drawing.Point(67, 154);
            this.label_Fecha_Liquidacion.Name = "label_Fecha_Liquidacion";
            this.label_Fecha_Liquidacion.Size = new System.Drawing.Size(94, 13);
            this.label_Fecha_Liquidacion.TabIndex = 13;
            this.label_Fecha_Liquidacion.Text = "Fecha Liquidacion";
            // 
            // textBox_Liquidacion
            // 
            this.textBox_Liquidacion.Location = new System.Drawing.Point(219, 85);
            this.textBox_Liquidacion.Name = "textBox_Liquidacion";
            this.textBox_Liquidacion.Size = new System.Drawing.Size(100, 20);
            this.textBox_Liquidacion.TabIndex = 14;
            // 
            // textBox_ValorServicio
            // 
            this.textBox_ValorServicio.Location = new System.Drawing.Point(219, 389);
            this.textBox_ValorServicio.Name = "textBox_ValorServicio";
            this.textBox_ValorServicio.Size = new System.Drawing.Size(100, 20);
            this.textBox_ValorServicio.TabIndex = 15;
            // 
            // textBox_Identificacion
            // 
            this.textBox_Identificacion.Location = new System.Drawing.Point(219, 201);
            this.textBox_Identificacion.Name = "textBox_Identificacion";
            this.textBox_Identificacion.Size = new System.Drawing.Size(100, 20);
            this.textBox_Identificacion.TabIndex = 18;
            // 
            // button_Borrar
            // 
            this.button_Borrar.Location = new System.Drawing.Point(855, 549);
            this.button_Borrar.Name = "button_Borrar";
            this.button_Borrar.Size = new System.Drawing.Size(75, 23);
            this.button_Borrar.TabIndex = 19;
            this.button_Borrar.Text = "Borrar Todo";
            this.button_Borrar.UseVisualStyleBackColor = true;
            // 
            // comboBox_TipoAfiliacion
            // 
            this.comboBox_TipoAfiliacion.FormattingEnabled = true;
            this.comboBox_TipoAfiliacion.Items.AddRange(new object[] {
            "Contributivo",
            "Subsidiado"});
            this.comboBox_TipoAfiliacion.Location = new System.Drawing.Point(219, 257);
            this.comboBox_TipoAfiliacion.Name = "comboBox_TipoAfiliacion";
            this.comboBox_TipoAfiliacion.Size = new System.Drawing.Size(100, 21);
            this.comboBox_TipoAfiliacion.TabIndex = 20;
            // 
            // comboBox_Tipo_Identificacion
            // 
            this.comboBox_Tipo_Identificacion.FormattingEnabled = true;
            this.comboBox_Tipo_Identificacion.Items.AddRange(new object[] {
            "Cedula",
            "Tarjeta Identidad",
            "Visa",
            "Cedula Extranjera"});
            this.comboBox_Tipo_Identificacion.Location = new System.Drawing.Point(219, 455);
            this.comboBox_Tipo_Identificacion.Name = "comboBox_Tipo_Identificacion";
            this.comboBox_Tipo_Identificacion.Size = new System.Drawing.Size(100, 21);
            this.comboBox_Tipo_Identificacion.TabIndex = 21;
            // 
            // comboBox_Salario_Devengado
            // 
            this.comboBox_Salario_Devengado.FormattingEnabled = true;
            this.comboBox_Salario_Devengado.Items.AddRange(new object[] {
            "Menor 2",
            "2 a 5",
            "Mayor 6"});
            this.comboBox_Salario_Devengado.Location = new System.Drawing.Point(219, 322);
            this.comboBox_Salario_Devengado.Name = "comboBox_Salario_Devengado";
            this.comboBox_Salario_Devengado.Size = new System.Drawing.Size(100, 21);
            this.comboBox_Salario_Devengado.TabIndex = 22;
            // 
            // label_TipoIdentificacion
            // 
            this.label_TipoIdentificacion.AutoSize = true;
            this.label_TipoIdentificacion.Location = new System.Drawing.Point(67, 463);
            this.label_TipoIdentificacion.Name = "label_TipoIdentificacion";
            this.label_TipoIdentificacion.Size = new System.Drawing.Size(94, 13);
            this.label_TipoIdentificacion.TabIndex = 23;
            this.label_TipoIdentificacion.Text = "Tipo Identificación";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1030, 584);
            this.Controls.Add(this.label_TipoIdentificacion);
            this.Controls.Add(this.comboBox_Salario_Devengado);
            this.Controls.Add(this.comboBox_Tipo_Identificacion);
            this.Controls.Add(this.comboBox_TipoAfiliacion);
            this.Controls.Add(this.button_Borrar);
            this.Controls.Add(this.textBox_Identificacion);
            this.Controls.Add(this.textBox_ValorServicio);
            this.Controls.Add(this.textBox_Liquidacion);
            this.Controls.Add(this.label_Fecha_Liquidacion);
            this.Controls.Add(this.label_Salario_Devengado);
            this.Controls.Add(this.label_Identificacion);
            this.Controls.Add(this.label_Afiliacion);
            this.Controls.Add(this.label_Valor_Servicio);
            this.Controls.Add(this.label_Liquidacion);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.dateTimePicker_Fecha);
            this.Controls.Add(this.button_Guardar);
            this.Controls.Add(this.button_salir);
            this.Controls.Add(this.label_Titulo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_Titulo;
        private System.Windows.Forms.Button button_salir;
        private System.Windows.Forms.Button button_Guardar;
        private System.Windows.Forms.DateTimePicker dateTimePicker_Fecha;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label_Liquidacion;
        private System.Windows.Forms.Label label_Valor_Servicio;
        private System.Windows.Forms.Label label_Afiliacion;
        private System.Windows.Forms.Label label_Identificacion;
        private System.Windows.Forms.Label label_Salario_Devengado;
        private System.Windows.Forms.Label label_Fecha_Liquidacion;
        private System.Windows.Forms.TextBox textBox_Liquidacion;
        private System.Windows.Forms.TextBox textBox_ValorServicio;
        private System.Windows.Forms.TextBox textBox_Identificacion;
        private System.Windows.Forms.Button button_Borrar;
        private System.Windows.Forms.ComboBox comboBox_TipoAfiliacion;
        private System.Windows.Forms.ComboBox comboBox_Tipo_Identificacion;
        private System.Windows.Forms.ComboBox comboBox_Salario_Devengado;
        private System.Windows.Forms.Label label_TipoIdentificacion;
    }
}

