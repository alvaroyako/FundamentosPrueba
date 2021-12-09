
namespace AdoNet
{
    partial class Form02BuscadorEmpleados
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
            this.txtSalario = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lstEmpleados = new System.Windows.Forms.ListBox();
            this.btnOficio = new System.Windows.Forms.Button();
            this.txtOficio = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Salario";
            // 
            // txtSalario
            // 
            this.txtSalario.Location = new System.Drawing.Point(13, 32);
            this.txtSalario.Name = "txtSalario";
            this.txtSalario.Size = new System.Drawing.Size(177, 23);
            this.txtSalario.TabIndex = 1;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(13, 62);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(177, 39);
            this.btnBuscar.TabIndex = 2;
            this.btnBuscar.Text = "Buscar salario";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 217);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Empleados";
            // 
            // lstEmpleados
            // 
            this.lstEmpleados.FormattingEnabled = true;
            this.lstEmpleados.ItemHeight = 15;
            this.lstEmpleados.Location = new System.Drawing.Point(13, 235);
            this.lstEmpleados.Name = "lstEmpleados";
            this.lstEmpleados.Size = new System.Drawing.Size(177, 184);
            this.lstEmpleados.TabIndex = 4;
            // 
            // btnOficio
            // 
            this.btnOficio.Location = new System.Drawing.Point(13, 166);
            this.btnOficio.Name = "btnOficio";
            this.btnOficio.Size = new System.Drawing.Size(177, 39);
            this.btnOficio.TabIndex = 7;
            this.btnOficio.Text = "Buscar Oficios";
            this.btnOficio.UseVisualStyleBackColor = true;
            this.btnOficio.Click += new System.EventHandler(this.btnOficio_Click);
            // 
            // txtOficio
            // 
            this.txtOficio.Location = new System.Drawing.Point(13, 136);
            this.txtOficio.Name = "txtOficio";
            this.txtOficio.Size = new System.Drawing.Size(177, 23);
            this.txtOficio.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Oficio";
            // 
            // Form02BuscadorEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(199, 428);
            this.Controls.Add(this.btnOficio);
            this.Controls.Add(this.txtOficio);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lstEmpleados);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtSalario);
            this.Controls.Add(this.label1);
            this.Name = "Form02BuscadorEmpleados";
            this.Text = "Form02BuscadorEmpleados";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSalario;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lstEmpleados;
        private System.Windows.Forms.Button btnOficio;
        private System.Windows.Forms.TextBox txtOficio;
        private System.Windows.Forms.Label label3;
    }
}