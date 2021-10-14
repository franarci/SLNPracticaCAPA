namespace WindowsFiguras
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
            this.btnCirculo = new System.Windows.Forms.Button();
            this.btnRectangulo = new System.Windows.Forms.Button();
            this.btnTriangulo = new System.Windows.Forms.Button();
            this.lblCirculo = new System.Windows.Forms.Label();
            this.lblRectangulo = new System.Windows.Forms.Label();
            this.lblTriangulo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCirculo
            // 
            this.btnCirculo.Location = new System.Drawing.Point(101, 199);
            this.btnCirculo.Name = "btnCirculo";
            this.btnCirculo.Size = new System.Drawing.Size(75, 23);
            this.btnCirculo.TabIndex = 0;
            this.btnCirculo.Text = "Circulo";
            this.btnCirculo.UseVisualStyleBackColor = true;
            this.btnCirculo.Click += new System.EventHandler(this.btnCirculo_Click);
            // 
            // btnRectangulo
            // 
            this.btnRectangulo.Location = new System.Drawing.Point(329, 199);
            this.btnRectangulo.Name = "btnRectangulo";
            this.btnRectangulo.Size = new System.Drawing.Size(75, 23);
            this.btnRectangulo.TabIndex = 1;
            this.btnRectangulo.Text = "Rectangulo";
            this.btnRectangulo.UseVisualStyleBackColor = true;
            this.btnRectangulo.Click += new System.EventHandler(this.btnRectangulo_Click);
            // 
            // btnTriangulo
            // 
            this.btnTriangulo.Location = new System.Drawing.Point(573, 199);
            this.btnTriangulo.Name = "btnTriangulo";
            this.btnTriangulo.Size = new System.Drawing.Size(75, 23);
            this.btnTriangulo.TabIndex = 2;
            this.btnTriangulo.Text = "Triangulo";
            this.btnTriangulo.UseVisualStyleBackColor = true;
            this.btnTriangulo.Click += new System.EventHandler(this.btnTriangulo_Click);
            // 
            // lblCirculo
            // 
            this.lblCirculo.AutoSize = true;
            this.lblCirculo.Location = new System.Drawing.Point(98, 145);
            this.lblCirculo.Name = "lblCirculo";
            this.lblCirculo.Size = new System.Drawing.Size(0, 13);
            this.lblCirculo.TabIndex = 3;
            // 
            // lblRectangulo
            // 
            this.lblRectangulo.AutoSize = true;
            this.lblRectangulo.Location = new System.Drawing.Point(326, 145);
            this.lblRectangulo.Name = "lblRectangulo";
            this.lblRectangulo.Size = new System.Drawing.Size(0, 13);
            this.lblRectangulo.TabIndex = 4;
            // 
            // lblTriangulo
            // 
            this.lblTriangulo.AutoSize = true;
            this.lblTriangulo.Location = new System.Drawing.Point(570, 156);
            this.lblTriangulo.Name = "lblTriangulo";
            this.lblTriangulo.Size = new System.Drawing.Size(0, 13);
            this.lblTriangulo.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblTriangulo);
            this.Controls.Add(this.lblRectangulo);
            this.Controls.Add(this.lblCirculo);
            this.Controls.Add(this.btnTriangulo);
            this.Controls.Add(this.btnRectangulo);
            this.Controls.Add(this.btnCirculo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCirculo;
        private System.Windows.Forms.Button btnRectangulo;
        private System.Windows.Forms.Button btnTriangulo;
        private System.Windows.Forms.Label lblCirculo;
        private System.Windows.Forms.Label lblRectangulo;
        private System.Windows.Forms.Label lblTriangulo;
    }
}

