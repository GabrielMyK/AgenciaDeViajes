﻿namespace AgenciaDeViajes
{
    partial class Pago
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
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textMonto = new System.Windows.Forms.TextBox();
            this.textMetodoPago = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.textIdPago = new System.Windows.Forms.TextBox();
            this.comboIdReserva = new System.Windows.Forms.ComboBox();
            this.comboIdViaje = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(27, 320);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(806, 368);
            this.dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(142, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "idReserva";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(195, 252);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Guardar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(163, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "idViaje";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(360, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Fecha de pago";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(283, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Monto";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(352, 122);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 16);
            this.label5.TabIndex = 7;
            this.label5.Text = "Metodo de pago";
            // 
            // textMonto
            // 
            this.textMonto.Location = new System.Drawing.Point(333, 166);
            this.textMonto.Name = "textMonto";
            this.textMonto.Size = new System.Drawing.Size(100, 22);
            this.textMonto.TabIndex = 10;
            // 
            // textMetodoPago
            // 
            this.textMetodoPago.Location = new System.Drawing.Point(465, 119);
            this.textMetodoPago.Name = "textMetodoPago";
            this.textMetodoPago.Size = new System.Drawing.Size(100, 22);
            this.textMetodoPago.TabIndex = 11;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(333, 252);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 12;
            this.button2.Text = "Editar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(500, 235);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(81, 40);
            this.button3.TabIndex = 13;
            this.button3.Text = "Eliminar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(689, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 16);
            this.label6.TabIndex = 14;
            this.label6.Text = "idPago";
            this.label6.Visible = false;
            // 
            // textIdPago
            // 
            this.textIdPago.Location = new System.Drawing.Point(746, 23);
            this.textIdPago.Name = "textIdPago";
            this.textIdPago.Size = new System.Drawing.Size(100, 22);
            this.textIdPago.TabIndex = 15;
            this.textIdPago.Visible = false;
            // 
            // comboIdReserva
            // 
            this.comboIdReserva.FormattingEnabled = true;
            this.comboIdReserva.Location = new System.Drawing.Point(218, 64);
            this.comboIdReserva.Name = "comboIdReserva";
            this.comboIdReserva.Size = new System.Drawing.Size(121, 24);
            this.comboIdReserva.TabIndex = 16;
            // 
            // comboIdViaje
            // 
            this.comboIdViaje.FormattingEnabled = true;
            this.comboIdViaje.Location = new System.Drawing.Point(218, 119);
            this.comboIdViaje.Name = "comboIdViaje";
            this.comboIdViaje.Size = new System.Drawing.Size(121, 24);
            this.comboIdViaje.TabIndex = 17;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(465, 70);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(167, 22);
            this.dateTimePicker1.TabIndex = 18;
            // 
            // Pago
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(858, 710);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.comboIdViaje);
            this.Controls.Add(this.comboIdReserva);
            this.Controls.Add(this.textIdPago);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textMetodoPago);
            this.Controls.Add(this.textMonto);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Pago";
            this.Text = "Pago";
            this.Load += new System.EventHandler(this.Pago_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textMonto;
        private System.Windows.Forms.TextBox textMetodoPago;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textIdPago;
        private System.Windows.Forms.ComboBox comboIdReserva;
        private System.Windows.Forms.ComboBox comboIdViaje;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}