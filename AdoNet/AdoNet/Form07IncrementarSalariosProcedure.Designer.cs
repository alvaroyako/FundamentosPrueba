﻿
namespace AdoNet
{
    partial class Form07IncrementarSalariosProcedure
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
            this.cmbHospitales = new System.Windows.Forms.ComboBox();
            this.btnModificar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lstPlantilla = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hospitales";
            // 
            // cmbHospitales
            // 
            this.cmbHospitales.FormattingEnabled = true;
            this.cmbHospitales.Location = new System.Drawing.Point(13, 41);
            this.cmbHospitales.Name = "cmbHospitales";
            this.cmbHospitales.Size = new System.Drawing.Size(121, 23);
            this.cmbHospitales.TabIndex = 1;
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(152, 41);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(115, 23);
            this.btnModificar.TabIndex = 2;
            this.btnModificar.Text = "Modificar Salarios";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Plantilla";
            // 
            // lstPlantilla
            // 
            this.lstPlantilla.FormattingEnabled = true;
            this.lstPlantilla.ItemHeight = 15;
            this.lstPlantilla.Location = new System.Drawing.Point(13, 121);
            this.lstPlantilla.Name = "lstPlantilla";
            this.lstPlantilla.Size = new System.Drawing.Size(254, 109);
            this.lstPlantilla.TabIndex = 4;
            // 
            // Form07IncrementarSalariosProcedure
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(286, 254);
            this.Controls.Add(this.lstPlantilla);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.cmbHospitales);
            this.Controls.Add(this.label1);
            this.Name = "Form07IncrementarSalariosProcedure";
            this.Text = "Form07IncrementarSalariosProcedure";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbHospitales;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lstPlantilla;
    }
}