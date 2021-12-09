
namespace AdoNet
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnConectar = new System.Windows.Forms.Button();
            this.btnDesconectar = new System.Windows.Forms.Button();
            this.btnLeer = new System.Windows.Forms.Button();
            this.lblMensaje = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lstApellidos = new System.Windows.Forms.ListBox();
            this.lstColumnas = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lstTiposDato = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnConectar
            // 
            this.btnConectar.Location = new System.Drawing.Point(13, 26);
            this.btnConectar.Name = "btnConectar";
            this.btnConectar.Size = new System.Drawing.Size(93, 23);
            this.btnConectar.TabIndex = 0;
            this.btnConectar.Text = "Conectar";
            this.btnConectar.UseVisualStyleBackColor = true;
            this.btnConectar.Click += new System.EventHandler(this.btnConectar_Click);
            // 
            // btnDesconectar
            // 
            this.btnDesconectar.Location = new System.Drawing.Point(13, 66);
            this.btnDesconectar.Name = "btnDesconectar";
            this.btnDesconectar.Size = new System.Drawing.Size(93, 23);
            this.btnDesconectar.TabIndex = 1;
            this.btnDesconectar.Text = "Desconectar";
            this.btnDesconectar.UseVisualStyleBackColor = true;
            this.btnDesconectar.Click += new System.EventHandler(this.btnDesconectar_Click);
            // 
            // btnLeer
            // 
            this.btnLeer.Location = new System.Drawing.Point(13, 108);
            this.btnLeer.Name = "btnLeer";
            this.btnLeer.Size = new System.Drawing.Size(93, 23);
            this.btnLeer.TabIndex = 2;
            this.btnLeer.Text = "Leer Datos";
            this.btnLeer.UseVisualStyleBackColor = true;
            this.btnLeer.Click += new System.EventHandler(this.btnLeer_Click);
            // 
            // lblMensaje
            // 
            this.lblMensaje.AutoSize = true;
            this.lblMensaje.Location = new System.Drawing.Point(13, 197);
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.Size = new System.Drawing.Size(64, 15);
            this.lblMensaje.TabIndex = 3;
            this.lblMensaje.Text = "lblMensaje";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(163, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Apellidos";
            // 
            // lstApellidos
            // 
            this.lstApellidos.FormattingEnabled = true;
            this.lstApellidos.ItemHeight = 15;
            this.lstApellidos.Location = new System.Drawing.Point(163, 37);
            this.lstApellidos.Name = "lstApellidos";
            this.lstApellidos.Size = new System.Drawing.Size(120, 154);
            this.lstApellidos.TabIndex = 5;
            // 
            // lstColumnas
            // 
            this.lstColumnas.FormattingEnabled = true;
            this.lstColumnas.ItemHeight = 15;
            this.lstColumnas.Location = new System.Drawing.Point(333, 37);
            this.lstColumnas.Name = "lstColumnas";
            this.lstColumnas.Size = new System.Drawing.Size(120, 154);
            this.lstColumnas.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(333, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Columnas";
            // 
            // lstTiposDato
            // 
            this.lstTiposDato.FormattingEnabled = true;
            this.lstTiposDato.ItemHeight = 15;
            this.lstTiposDato.Location = new System.Drawing.Point(494, 37);
            this.lstTiposDato.Name = "lstTiposDato";
            this.lstTiposDato.Size = new System.Drawing.Size(120, 154);
            this.lstTiposDato.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(494, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "Tipos dato";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 237);
            this.Controls.Add(this.lstTiposDato);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lstColumnas);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lstApellidos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblMensaje);
            this.Controls.Add(this.btnLeer);
            this.Controls.Add(this.btnDesconectar);
            this.Controls.Add(this.btnConectar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConectar;
        private System.Windows.Forms.Button btnDesconectar;
        private System.Windows.Forms.Button btnLeer;
        private System.Windows.Forms.Label lblMensaje;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lstApellidos;
        private System.Windows.Forms.ListBox lstColumnas;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lstTiposDato;
        private System.Windows.Forms.Label label4;
    }
}

