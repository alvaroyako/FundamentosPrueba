
namespace AdoNet
{
    partial class Form05ModificarHospital
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
            this.lstSalas = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnModificar = new System.Windows.Forms.Button();
            this.txtInscripcion = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lstSalas
            // 
            this.lstSalas.FormattingEnabled = true;
            this.lstSalas.ItemHeight = 15;
            this.lstSalas.Location = new System.Drawing.Point(12, 131);
            this.lstSalas.Name = "lstSalas";
            this.lstSalas.Size = new System.Drawing.Size(158, 244);
            this.lstSalas.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 15);
            this.label2.TabIndex = 13;
            this.label2.Text = "Salas";
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(12, 58);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(158, 40);
            this.btnModificar.TabIndex = 12;
            this.btnModificar.Text = "Modificar Salas";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // txtInscripcion
            // 
            this.txtInscripcion.Location = new System.Drawing.Point(12, 28);
            this.txtInscripcion.Name = "txtInscripcion";
            this.txtInscripcion.Size = new System.Drawing.Size(158, 23);
            this.txtInscripcion.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 15);
            this.label1.TabIndex = 10;
            this.label1.Text = "Nuevo nombre";
            // 
            // Form05ModificarHospital
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(182, 382);
            this.Controls.Add(this.lstSalas);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.txtInscripcion);
            this.Controls.Add(this.label1);
            this.Name = "Form05ModificarHospital";
            this.Text = "Form05ModificarHospital";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstSalas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.TextBox txtInscripcion;
        private System.Windows.Forms.Label label1;
    }
}