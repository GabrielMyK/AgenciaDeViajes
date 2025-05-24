namespace AgenciaDeViajes
{
    partial class Alojamiento
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
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textNombre = new System.Windows.Forms.TextBox();
            this.textDireccion = new System.Windows.Forms.TextBox();
            this.textPrecio = new System.Windows.Forms.TextBox();
            this.textTelf = new System.Windows.Forms.TextBox();
            this.textTipo = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.idAloja = new System.Windows.Forms.Label();
            this.textAloja = new System.Windows.Forms.TextBox();
            this.comboIdViaje = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(152, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(152, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Dirección";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(152, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Precio";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(450, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Telefono";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(450, 90);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Tipo";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(450, 148);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "id Viaje";
            // 
            // textNombre
            // 
            this.textNombre.Location = new System.Drawing.Point(228, 40);
            this.textNombre.Name = "textNombre";
            this.textNombre.Size = new System.Drawing.Size(100, 22);
            this.textNombre.TabIndex = 6;
            // 
            // textDireccion
            // 
            this.textDireccion.Location = new System.Drawing.Point(228, 87);
            this.textDireccion.Name = "textDireccion";
            this.textDireccion.Size = new System.Drawing.Size(100, 22);
            this.textDireccion.TabIndex = 7;
            // 
            // textPrecio
            // 
            this.textPrecio.Location = new System.Drawing.Point(228, 145);
            this.textPrecio.Name = "textPrecio";
            this.textPrecio.Size = new System.Drawing.Size(100, 22);
            this.textPrecio.TabIndex = 8;
            // 
            // textTelf
            // 
            this.textTelf.Location = new System.Drawing.Point(517, 40);
            this.textTelf.Name = "textTelf";
            this.textTelf.Size = new System.Drawing.Size(100, 22);
            this.textTelf.TabIndex = 9;
            // 
            // textTipo
            // 
            this.textTipo.Location = new System.Drawing.Point(517, 90);
            this.textTipo.Name = "textTipo";
            this.textTipo.Size = new System.Drawing.Size(100, 22);
            this.textTipo.TabIndex = 10;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(24, 261);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(994, 312);
            this.dataGridView1.TabIndex = 12;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(166, 202);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 13;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(358, 201);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 23);
            this.btnEditar.TabIndex = 14;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(527, 202);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 15;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // idAloja
            // 
            this.idAloja.AutoSize = true;
            this.idAloja.Location = new System.Drawing.Point(720, 43);
            this.idAloja.Name = "idAloja";
            this.idAloja.Size = new System.Drawing.Size(52, 16);
            this.idAloja.TabIndex = 16;
            this.idAloja.Text = "id Aloja";
            this.idAloja.Visible = false;
            // 
            // textAloja
            // 
            this.textAloja.Location = new System.Drawing.Point(788, 37);
            this.textAloja.Name = "textAloja";
            this.textAloja.Size = new System.Drawing.Size(100, 22);
            this.textAloja.TabIndex = 17;
            this.textAloja.Visible = false;
            // 
            // comboIdViaje
            // 
            this.comboIdViaje.FormattingEnabled = true;
            this.comboIdViaje.Location = new System.Drawing.Point(517, 145);
            this.comboIdViaje.Name = "comboIdViaje";
            this.comboIdViaje.Size = new System.Drawing.Size(121, 24);
            this.comboIdViaje.TabIndex = 18;
            // 
            // Alojamiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1051, 585);
            this.Controls.Add(this.comboIdViaje);
            this.Controls.Add(this.textAloja);
            this.Controls.Add(this.idAloja);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textTipo);
            this.Controls.Add(this.textTelf);
            this.Controls.Add(this.textPrecio);
            this.Controls.Add(this.textDireccion);
            this.Controls.Add(this.textNombre);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Alojamiento";
            this.Text = "Alojamiento";
            this.Load += new System.EventHandler(this.Alojamiento_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textNombre;
        private System.Windows.Forms.TextBox textDireccion;
        private System.Windows.Forms.TextBox textPrecio;
        private System.Windows.Forms.TextBox textTelf;
        private System.Windows.Forms.TextBox textTipo;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Label idAloja;
        private System.Windows.Forms.TextBox textAloja;
        private System.Windows.Forms.ComboBox comboIdViaje;
    }
}