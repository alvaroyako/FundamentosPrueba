
namespace FundamentosPrueba
{
    partial class Form9InvertirTextStringBuilder
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
            this.txtTexto = new System.Windows.Forms.RichTextBox();
            this.btnString = new System.Windows.Forms.Button();
            this.btnStringBuilder = new System.Windows.Forms.Button();
            this.lblTiempo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Texto:";
            // 
            // txtTexto
            // 
            this.txtTexto.Location = new System.Drawing.Point(1, 18);
            this.txtTexto.Name = "txtTexto";
            this.txtTexto.Size = new System.Drawing.Size(422, 409);
            this.txtTexto.TabIndex = 1;
            this.txtTexto.Text = "";
            // 
            // btnString
            // 
            this.btnString.Location = new System.Drawing.Point(429, 18);
            this.btnString.Name = "btnString";
            this.btnString.Size = new System.Drawing.Size(156, 409);
            this.btnString.TabIndex = 2;
            this.btnString.Text = "Invertir S";
            this.btnString.UseVisualStyleBackColor = true;
            this.btnString.Click += new System.EventHandler(this.btnString_Click);
            // 
            // btnStringBuilder
            // 
            this.btnStringBuilder.Location = new System.Drawing.Point(1, 471);
            this.btnStringBuilder.Name = "btnStringBuilder";
            this.btnStringBuilder.Size = new System.Drawing.Size(584, 144);
            this.btnStringBuilder.TabIndex = 3;
            this.btnStringBuilder.Text = "Invertir SB";
            this.btnStringBuilder.UseVisualStyleBackColor = true;
            this.btnStringBuilder.Click += new System.EventHandler(this.btnStringBuilder_Click);
            // 
            // lblTiempo
            // 
            this.lblTiempo.AutoSize = true;
            this.lblTiempo.ForeColor = System.Drawing.Color.Red;
            this.lblTiempo.Location = new System.Drawing.Point(1, 441);
            this.lblTiempo.Name = "lblTiempo";
            this.lblTiempo.Size = new System.Drawing.Size(47, 15);
            this.lblTiempo.TabIndex = 4;
            this.lblTiempo.Text = "Tiempo";
            // 
            // Form9InvertirTextStringBuilder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(597, 627);
            this.Controls.Add(this.lblTiempo);
            this.Controls.Add(this.btnStringBuilder);
            this.Controls.Add(this.btnString);
            this.Controls.Add(this.txtTexto);
            this.Controls.Add(this.label1);
            this.Name = "Form9InvertirTextStringBuilder";
            this.Text = "Form9InvertirTextStringBuilder";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox txtTexto;
        private System.Windows.Forms.Button btnString;
        private System.Windows.Forms.Button btnStringBuilder;
        private System.Windows.Forms.Label lblTiempo;
    }
}