namespace AgenciaDeViajes
{
    partial class Viaje
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.textDestino = new System.Windows.Forms.TextBox();
            this.textDescripcion = new System.Windows.Forms.TextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.textIdViaje = new System.Windows.Forms.TextBox();
            this.IdViaje = new System.Windows.Forms.Label();
            this.comboIdGuia = new System.Windows.Forms.ComboBox();
            this.dateTimeSalida = new System.Windows.Forms.DateTimePicker();
            this.dateTimeRegreso = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(28, 261);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(857, 319);
            this.dataGridView1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(80, 51);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(137, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Destino";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(80, 97);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(137, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Fecha de Salida";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(379, 51);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(130, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = "Descripción";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(66, 147);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(151, 23);
            this.button4.TabIndex = 4;
            this.button4.Text = "Fecha de Regreso";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(425, 96);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(130, 23);
            this.button5.TabIndex = 5;
            this.button5.Text = "ID Guia";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // textDestino
            // 
            this.textDestino.Location = new System.Drawing.Point(240, 51);
            this.textDestino.Name = "textDestino";
            this.textDestino.Size = new System.Drawing.Size(86, 22);
            this.textDestino.TabIndex = 6;
            // 
            // textDescripcion
            // 
            this.textDescripcion.Location = new System.Drawing.Point(527, 51);
            this.textDescripcion.Name = "textDescripcion";
            this.textDescripcion.Size = new System.Drawing.Size(100, 22);
            this.textDescripcion.TabIndex = 9;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(184, 203);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 11;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(332, 203);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 23);
            this.btnEditar.TabIndex = 12;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(465, 203);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 13;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // textIdViaje
            // 
            this.textIdViaje.Location = new System.Drawing.Point(777, 55);
            this.textIdViaje.Name = "textIdViaje";
            this.textIdViaje.Size = new System.Drawing.Size(100, 22);
            this.textIdViaje.TabIndex = 14;
            this.textIdViaje.Visible = false;
            // 
            // IdViaje
            // 
            this.IdViaje.AutoSize = true;
            this.IdViaje.Location = new System.Drawing.Point(722, 58);
            this.IdViaje.Name = "IdViaje";
            this.IdViaje.Size = new System.Drawing.Size(49, 16);
            this.IdViaje.TabIndex = 15;
            this.IdViaje.Text = "IdViaje";
            this.IdViaje.Visible = false;
            // 
            // comboIdGuia
            // 
            this.comboIdGuia.FormattingEnabled = true;
            this.comboIdGuia.Location = new System.Drawing.Point(561, 96);
            this.comboIdGuia.Name = "comboIdGuia";
            this.comboIdGuia.Size = new System.Drawing.Size(121, 24);
            this.comboIdGuia.TabIndex = 16;
            // 
            // dateTimeSalida
            // 
            this.dateTimeSalida.Location = new System.Drawing.Point(223, 96);
            this.dateTimeSalida.Name = "dateTimeSalida";
            this.dateTimeSalida.Size = new System.Drawing.Size(200, 22);
            this.dateTimeSalida.TabIndex = 17;
            // 
            // dateTimeRegreso
            // 
            this.dateTimeRegreso.Location = new System.Drawing.Point(223, 147);
            this.dateTimeRegreso.Name = "dateTimeRegreso";
            this.dateTimeRegreso.Size = new System.Drawing.Size(200, 22);
            this.dateTimeRegreso.TabIndex = 18;
            // 
            // Viaje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(926, 610);
            this.Controls.Add(this.dateTimeRegreso);
            this.Controls.Add(this.dateTimeSalida);
            this.Controls.Add(this.comboIdGuia);
            this.Controls.Add(this.IdViaje);
            this.Controls.Add(this.textIdViaje);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.textDescripcion);
            this.Controls.Add(this.textDestino);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Viaje";
            this.Text = "Viaje";
            this.Load += new System.EventHandler(this.Viaje_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox textDestino;
        private System.Windows.Forms.TextBox textDescripcion;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.TextBox textIdViaje;
        private System.Windows.Forms.Label IdViaje;
        private System.Windows.Forms.ComboBox comboIdGuia;
        private System.Windows.Forms.DateTimePicker dateTimeSalida;
        private System.Windows.Forms.DateTimePicker dateTimeRegreso;
    }
}