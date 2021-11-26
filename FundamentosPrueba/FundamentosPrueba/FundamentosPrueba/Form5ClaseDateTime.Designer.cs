
namespace FundamentosPrueba
{
    partial class Form5ClaseDateTime
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
            this.txtFechaActual = new System.Windows.Forms.TextBox();
            this.chkFormato = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnIncrementar = new System.Windows.Forms.Button();
            this.txtIncremento = new System.Windows.Forms.TextBox();
            this.Incremento = new System.Windows.Forms.Label();
            this.rdbAño = new System.Windows.Forms.RadioButton();
            this.rdbMes = new System.Windows.Forms.RadioButton();
            this.rdbDia = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNuevaFecha = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fecha actual";
            // 
            // txtFechaActual
            // 
            this.txtFechaActual.Location = new System.Drawing.Point(25, 46);
            this.txtFechaActual.Name = "txtFechaActual";
            this.txtFechaActual.Size = new System.Drawing.Size(360, 23);
            this.txtFechaActual.TabIndex = 1;
            // 
            // chkFormato
            // 
            this.chkFormato.AutoSize = true;
            this.chkFormato.Location = new System.Drawing.Point(25, 86);
            this.chkFormato.Name = "chkFormato";
            this.chkFormato.Size = new System.Drawing.Size(149, 19);
            this.chkFormato.TabIndex = 2;
            this.chkFormato.Text = "Cambiar formato fecha";
            this.chkFormato.UseVisualStyleBackColor = true;
            this.chkFormato.CheckedChanged += new System.EventHandler(this.chkFormato_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnIncrementar);
            this.groupBox1.Controls.Add(this.txtIncremento);
            this.groupBox1.Controls.Add(this.Incremento);
            this.groupBox1.Controls.Add(this.rdbAño);
            this.groupBox1.Controls.Add(this.rdbMes);
            this.groupBox1.Controls.Add(this.rdbDia);
            this.groupBox1.Location = new System.Drawing.Point(25, 127);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(360, 110);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Incrementar Fecha";
            // 
            // btnIncrementar
            // 
            this.btnIncrementar.Location = new System.Drawing.Point(239, 72);
            this.btnIncrementar.Name = "btnIncrementar";
            this.btnIncrementar.Size = new System.Drawing.Size(100, 32);
            this.btnIncrementar.TabIndex = 5;
            this.btnIncrementar.Text = "Incrementar";
            this.btnIncrementar.UseVisualStyleBackColor = true;
            this.btnIncrementar.Click += new System.EventHandler(this.btnIncrementar_Click);
            // 
            // txtIncremento
            // 
            this.txtIncremento.Location = new System.Drawing.Point(239, 42);
            this.txtIncremento.Name = "txtIncremento";
            this.txtIncremento.Size = new System.Drawing.Size(100, 23);
            this.txtIncremento.TabIndex = 4;
            // 
            // Incremento
            // 
            this.Incremento.AutoSize = true;
            this.Incremento.Location = new System.Drawing.Point(239, 23);
            this.Incremento.Name = "Incremento";
            this.Incremento.Size = new System.Drawing.Size(68, 15);
            this.Incremento.TabIndex = 3;
            this.Incremento.Text = "Incremento";
            // 
            // rdbAño
            // 
            this.rdbAño.AutoSize = true;
            this.rdbAño.Location = new System.Drawing.Point(7, 75);
            this.rdbAño.Name = "rdbAño";
            this.rdbAño.Size = new System.Drawing.Size(47, 19);
            this.rdbAño.TabIndex = 2;
            this.rdbAño.TabStop = true;
            this.rdbAño.Text = "Año";
            this.rdbAño.UseVisualStyleBackColor = true;
            // 
            // rdbMes
            // 
            this.rdbMes.AutoSize = true;
            this.rdbMes.Location = new System.Drawing.Point(7, 49);
            this.rdbMes.Name = "rdbMes";
            this.rdbMes.Size = new System.Drawing.Size(47, 19);
            this.rdbMes.TabIndex = 1;
            this.rdbMes.TabStop = true;
            this.rdbMes.Text = "Mes";
            this.rdbMes.UseVisualStyleBackColor = true;
            // 
            // rdbDia
            // 
            this.rdbDia.AutoSize = true;
            this.rdbDia.Location = new System.Drawing.Point(7, 23);
            this.rdbDia.Name = "rdbDia";
            this.rdbDia.Size = new System.Drawing.Size(42, 19);
            this.rdbDia.TabIndex = 0;
            this.rdbDia.TabStop = true;
            this.rdbDia.Text = "Dia";
            this.rdbDia.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 266);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nueva Fecha";
            // 
            // txtNuevaFecha
            // 
            this.txtNuevaFecha.Location = new System.Drawing.Point(25, 285);
            this.txtNuevaFecha.Name = "txtNuevaFecha";
            this.txtNuevaFecha.Size = new System.Drawing.Size(360, 23);
            this.txtNuevaFecha.TabIndex = 5;
            // 
            // Form5ClaseDateTime
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 347);
            this.Controls.Add(this.txtNuevaFecha);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.chkFormato);
            this.Controls.Add(this.txtFechaActual);
            this.Controls.Add(this.label1);
            this.Name = "Form5ClaseDateTime";
            this.Text = "Form5ClaseDateTime";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFechaActual;
        private System.Windows.Forms.CheckBox chkFormato;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdbAño;
        private System.Windows.Forms.RadioButton rdbMes;
        private System.Windows.Forms.RadioButton rdbDia;
        private System.Windows.Forms.Button btnIncrementar;
        private System.Windows.Forms.TextBox txtIncremento;
        private System.Windows.Forms.Label Incremento;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNuevaFecha;
    }
}