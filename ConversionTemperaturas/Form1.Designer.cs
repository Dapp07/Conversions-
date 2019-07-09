namespace ConversionTemperaturas
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnSalir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIngresa = new System.Windows.Forms.TextBox();
            this.txtSalida = new System.Windows.Forms.TextBox();
            this.cobIngresa = new System.Windows.Forms.ComboBox();
            this.cobSalida = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(400, 12);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 0;
            this.btnSalir.Text = "X";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Convertidor de Temperaturas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(229, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "=";
            // 
            // txtIngresa
            // 
            this.txtIngresa.Location = new System.Drawing.Point(53, 78);
            this.txtIngresa.Name = "txtIngresa";
            this.txtIngresa.Size = new System.Drawing.Size(118, 20);
            this.txtIngresa.TabIndex = 3;
            this.txtIngresa.TextChanged += new System.EventHandler(this.TxtIngresa_TextChanged);
            // 
            // txtSalida
            // 
            this.txtSalida.Location = new System.Drawing.Point(276, 78);
            this.txtSalida.Name = "txtSalida";
            this.txtSalida.ReadOnly = true;
            this.txtSalida.Size = new System.Drawing.Size(118, 20);
            this.txtSalida.TabIndex = 4;
            // 
            // cobIngresa
            // 
            this.cobIngresa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cobIngresa.FormattingEnabled = true;
            this.cobIngresa.Location = new System.Drawing.Point(53, 104);
            this.cobIngresa.Name = "cobIngresa";
            this.cobIngresa.Size = new System.Drawing.Size(121, 21);
            this.cobIngresa.TabIndex = 5;
            this.cobIngresa.SelectedIndexChanged += new System.EventHandler(this.CobIngresa_SelectedIndexChanged);
            // 
            // cobSalida
            // 
            this.cobSalida.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cobSalida.FormattingEnabled = true;
            this.cobSalida.Location = new System.Drawing.Point(276, 104);
            this.cobSalida.Name = "cobSalida";
            this.cobSalida.Size = new System.Drawing.Size(121, 21);
            this.cobSalida.TabIndex = 6;
            this.cobSalida.SelectedIndexChanged += new System.EventHandler(this.CobSalida_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 211);
            this.Controls.Add(this.cobSalida);
            this.Controls.Add(this.cobIngresa);
            this.Controls.Add(this.txtSalida);
            this.Controls.Add(this.txtIngresa);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSalir);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIngresa;
        private System.Windows.Forms.TextBox txtSalida;
        private System.Windows.Forms.ComboBox cobIngresa;
        private System.Windows.Forms.ComboBox cobSalida;
    }
}

