
namespace FundamentosPrueba
{
    partial class Form25FicherosMascotas
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
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtRaza = new System.Windows.Forms.TextBox();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnLeer = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lstMascotas = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(13, 32);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(149, 23);
            this.txtNombre.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Raza";
            // 
            // txtRaza
            // 
            this.txtRaza.Location = new System.Drawing.Point(13, 98);
            this.txtRaza.Name = "txtRaza";
            this.txtRaza.Size = new System.Drawing.Size(149, 23);
            this.txtRaza.TabIndex = 3;
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(13, 153);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(149, 43);
            this.btnNuevo.TabIndex = 4;
            this.btnNuevo.Text = "Nuevo Registro";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnLeer
            // 
            this.btnLeer.Location = new System.Drawing.Point(13, 223);
            this.btnLeer.Name = "btnLeer";
            this.btnLeer.Size = new System.Drawing.Size(149, 43);
            this.btnLeer.TabIndex = 5;
            this.btnLeer.Text = "Leer registros";
            this.btnLeer.UseVisualStyleBackColor = true;
            this.btnLeer.Click += new System.EventHandler(this.btnLeer_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(13, 293);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(149, 43);
            this.btnGuardar.TabIndex = 6;
            this.btnGuardar.Text = "Guardar Registros";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(214, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Mascotas";
            // 
            // lstMascotas
            // 
            this.lstMascotas.FormattingEnabled = true;
            this.lstMascotas.ItemHeight = 15;
            this.lstMascotas.Location = new System.Drawing.Point(214, 32);
            this.lstMascotas.Name = "lstMascotas";
            this.lstMascotas.Size = new System.Drawing.Size(212, 304);
            this.lstMascotas.TabIndex = 8;
            this.lstMascotas.SelectedIndexChanged += new System.EventHandler(this.lstMascotas_SelectedIndexChanged);
            // 
            // Form25FicherosMascotas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 356);
            this.Controls.Add(this.lstMascotas);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnLeer);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.txtRaza);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label1);
            this.Name = "Form25FicherosMascotas";
            this.Text = "Form25FicherosMascotas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtRaza;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnLeer;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lstMascotas;
    }
}