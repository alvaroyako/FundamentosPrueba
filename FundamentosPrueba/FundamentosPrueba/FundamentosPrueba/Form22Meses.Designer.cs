
namespace FundamentosPrueba
{
    partial class Form22Meses
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
            this.txtMedia = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMinima = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMaxima = new System.Windows.Forms.TextBox();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.btnMeses = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lstMeses = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // txtMedia
            // 
            this.txtMedia.Location = new System.Drawing.Point(243, 291);
            this.txtMedia.Name = "txtMedia";
            this.txtMedia.Size = new System.Drawing.Size(145, 23);
            this.txtMedia.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(243, 272);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 15);
            this.label4.TabIndex = 18;
            this.label4.Text = "Temperatura Media";
            // 
            // txtMinima
            // 
            this.txtMinima.Location = new System.Drawing.Point(243, 230);
            this.txtMinima.Name = "txtMinima";
            this.txtMinima.Size = new System.Drawing.Size(145, 23);
            this.txtMinima.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(243, 212);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 15);
            this.label3.TabIndex = 16;
            this.label3.Text = "Temperatura Minima";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(243, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 15);
            this.label2.TabIndex = 15;
            this.label2.Text = "Temperatura Maxima";
            // 
            // txtMaxima
            // 
            this.txtMaxima.Location = new System.Drawing.Point(243, 169);
            this.txtMaxima.Name = "txtMaxima";
            this.txtMaxima.Size = new System.Drawing.Size(145, 23);
            this.txtMaxima.TabIndex = 14;
            // 
            // btnMostrar
            // 
            this.btnMostrar.Location = new System.Drawing.Point(243, 82);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(145, 52);
            this.btnMostrar.TabIndex = 13;
            this.btnMostrar.Text = "Mostrar Datos";
            this.btnMostrar.UseVisualStyleBackColor = true;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // btnMeses
            // 
            this.btnMeses.Location = new System.Drawing.Point(243, 13);
            this.btnMeses.Name = "btnMeses";
            this.btnMeses.Size = new System.Drawing.Size(145, 54);
            this.btnMeses.TabIndex = 12;
            this.btnMeses.Text = "Generar Meses";
            this.btnMeses.UseVisualStyleBackColor = true;
            this.btnMeses.Click += new System.EventHandler(this.btnMeses_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 15);
            this.label1.TabIndex = 11;
            this.label1.Text = "Meses";
            // 
            // lstMeses
            // 
            this.lstMeses.FormattingEnabled = true;
            this.lstMeses.ItemHeight = 15;
            this.lstMeses.Location = new System.Drawing.Point(12, 30);
            this.lstMeses.Name = "lstMeses";
            this.lstMeses.Size = new System.Drawing.Size(171, 289);
            this.lstMeses.TabIndex = 10;
            // 
            // Form22Meses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 350);
            this.Controls.Add(this.txtMedia);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtMinima);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMaxima);
            this.Controls.Add(this.btnMostrar);
            this.Controls.Add(this.btnMeses);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstMeses);
            this.Name = "Form22Meses";
            this.Text = "Form22Meses";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMedia;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMinima;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMaxima;
        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.Button btnMeses;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstMeses;
    }
}