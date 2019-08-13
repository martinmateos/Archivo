namespace Archivo
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
            this.guardar_button = new System.Windows.Forms.Button();
            this.leer_button = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // guardar_button
            // 
            this.guardar_button.Location = new System.Drawing.Point(263, 212);
            this.guardar_button.Name = "guardar_button";
            this.guardar_button.Size = new System.Drawing.Size(139, 23);
            this.guardar_button.TabIndex = 0;
            this.guardar_button.Text = "Guardar Button";
            this.guardar_button.UseVisualStyleBackColor = true;
            this.guardar_button.Click += new System.EventHandler(this.Guardar_button_Click);
            // 
            // leer_button
            // 
            this.leer_button.Location = new System.Drawing.Point(451, 212);
            this.leer_button.Name = "leer_button";
            this.leer_button.Size = new System.Drawing.Size(139, 23);
            this.leer_button.TabIndex = 1;
            this.leer_button.Text = "Leer Button";
            this.leer_button.UseVisualStyleBackColor = true;
            this.leer_button.Click += new System.EventHandler(this.Leer_button_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(263, 173);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(327, 20);
            this.textBox1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(260, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.leer_button);
            this.Controls.Add(this.guardar_button);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button guardar_button;
        private System.Windows.Forms.Button leer_button;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
    }
}

