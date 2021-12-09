
namespace FundamentosPrueba
{
    partial class Form23TrabajarFicheros
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
            this.txtContenido = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLeer = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.lstNombres = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtContenido
            // 
            this.txtContenido.Location = new System.Drawing.Point(12, 31);
            this.txtContenido.Name = "txtContenido";
            this.txtContenido.Size = new System.Drawing.Size(293, 280);
            this.txtContenido.TabIndex = 0;
            this.txtContenido.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Contenido";
            // 
            // btnLeer
            // 
            this.btnLeer.Location = new System.Drawing.Point(311, 31);
            this.btnLeer.Name = "btnLeer";
            this.btnLeer.Size = new System.Drawing.Size(94, 56);
            this.btnLeer.TabIndex = 2;
            this.btnLeer.Text = "Leer Fichero";
            this.btnLeer.UseVisualStyleBackColor = true;
            this.btnLeer.Click += new System.EventHandler(this.btnLeer_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(311, 119);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(94, 56);
            this.btnGuardar.TabIndex = 3;
            this.btnGuardar.Text = "Guardar Fichero";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // lstNombres
            // 
            this.lstNombres.FormattingEnabled = true;
            this.lstNombres.ItemHeight = 15;
            this.lstNombres.Location = new System.Drawing.Point(472, 119);
            this.lstNombres.Name = "lstNombres";
            this.lstNombres.Size = new System.Drawing.Size(130, 199);
            this.lstNombres.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(472, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nombres";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(472, 57);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(130, 23);
            this.txtNombre.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(472, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Nombre";
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(608, 57);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(36, 31);
            this.btnNuevo.TabIndex = 8;
            this.btnNuevo.Text = "+";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // Form23TrabajarFicheros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 334);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lstNombres);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnLeer);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtContenido);
            this.Name = "Form23TrabajarFicheros";
            this.Text = "Form23TrabajarFicheros";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox txtContenido;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLeer;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.ListBox lstNombres;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnNuevo;
    }
}