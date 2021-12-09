
namespace FundamentosPrueba
{
    partial class Form27SerializationList
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
            this.lstMascotas = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnLeer = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.txtRaza = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAnios = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lstMascotas
            // 
            this.lstMascotas.FormattingEnabled = true;
            this.lstMascotas.ItemHeight = 15;
            this.lstMascotas.Location = new System.Drawing.Point(223, 36);
            this.lstMascotas.Name = "lstMascotas";
            this.lstMascotas.Size = new System.Drawing.Size(212, 259);
            this.lstMascotas.TabIndex = 17;
            this.lstMascotas.SelectedIndexChanged += new System.EventHandler(this.lstMascotas_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(223, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 15);
            this.label3.TabIndex = 16;
            this.label3.Text = "Mascotas";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(22, 251);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(149, 43);
            this.btnGuardar.TabIndex = 15;
            this.btnGuardar.Text = "Guardar Registros";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnLeer
            // 
            this.btnLeer.Location = new System.Drawing.Point(22, 202);
            this.btnLeer.Name = "btnLeer";
            this.btnLeer.Size = new System.Drawing.Size(149, 43);
            this.btnLeer.TabIndex = 14;
            this.btnLeer.Text = "Leer registros";
            this.btnLeer.UseVisualStyleBackColor = true;
            this.btnLeer.Click += new System.EventHandler(this.btnLeer_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(22, 153);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(149, 43);
            this.btnNuevo.TabIndex = 13;
            this.btnNuevo.Text = "Nuevo Registro";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // txtRaza
            // 
            this.txtRaza.Location = new System.Drawing.Point(22, 80);
            this.txtRaza.Name = "txtRaza";
            this.txtRaza.Size = new System.Drawing.Size(149, 23);
            this.txtRaza.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 15);
            this.label2.TabIndex = 11;
            this.label2.Text = "Raza";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(22, 36);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(149, 23);
            this.txtNombre.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 15);
            this.label1.TabIndex = 9;
            this.label1.Text = "Nombre";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 15);
            this.label4.TabIndex = 18;
            this.label4.Text = "Años";
            // 
            // txtAnios
            // 
            this.txtAnios.Location = new System.Drawing.Point(22, 124);
            this.txtAnios.Name = "txtAnios";
            this.txtAnios.Size = new System.Drawing.Size(149, 23);
            this.txtAnios.TabIndex = 19;
            // 
            // Form27SerializationList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 313);
            this.Controls.Add(this.txtAnios);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lstMascotas);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnLeer);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.txtRaza);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label1);
            this.Name = "Form27SerializationList";
            this.Text = "Form27SerializationList";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstMascotas;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnLeer;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.TextBox txtRaza;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAnios;
    }
}