
namespace FundamentosPrueba
{
    partial class Form21POO
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
            this.btnInstanciarPersona = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnEmpleado = new System.Windows.Forms.Button();
            this.btnDirector = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnInstanciarPersona
            // 
            this.btnInstanciarPersona.Location = new System.Drawing.Point(13, 13);
            this.btnInstanciarPersona.Name = "btnInstanciarPersona";
            this.btnInstanciarPersona.Size = new System.Drawing.Size(164, 54);
            this.btnInstanciarPersona.TabIndex = 0;
            this.btnInstanciarPersona.Text = "InstanciarPersona";
            this.btnInstanciarPersona.UseVisualStyleBackColor = true;
            this.btnInstanciarPersona.Click += new System.EventHandler(this.btnInstanciarPersona_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(220, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Propiedades";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(220, 31);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(290, 409);
            this.listBox1.TabIndex = 2;
            // 
            // btnEmpleado
            // 
            this.btnEmpleado.Location = new System.Drawing.Point(13, 87);
            this.btnEmpleado.Name = "btnEmpleado";
            this.btnEmpleado.Size = new System.Drawing.Size(164, 59);
            this.btnEmpleado.TabIndex = 3;
            this.btnEmpleado.Text = "Instanciar Empleado";
            this.btnEmpleado.UseVisualStyleBackColor = true;
            this.btnEmpleado.Click += new System.EventHandler(this.btnEmpleado_Click);
            // 
            // btnDirector
            // 
            this.btnDirector.Location = new System.Drawing.Point(13, 162);
            this.btnDirector.Name = "btnDirector";
            this.btnDirector.Size = new System.Drawing.Size(164, 58);
            this.btnDirector.TabIndex = 4;
            this.btnDirector.Text = "Instanciar Director";
            this.btnDirector.UseVisualStyleBackColor = true;
            this.btnDirector.Click += new System.EventHandler(this.btnDirector_Click);
            // 
            // Form21POO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 450);
            this.Controls.Add(this.btnDirector);
            this.Controls.Add(this.btnEmpleado);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnInstanciarPersona);
            this.Name = "Form21POO";
            this.Text = "Form21POO";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnInstanciarPersona;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnEmpleado;
        private System.Windows.Forms.Button btnDirector;
    }
}