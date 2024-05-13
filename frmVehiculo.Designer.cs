
namespace pryPachecoEtapa2
{
    partial class frmVehiculo
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
            this.btnAparecer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAparecer
            // 
            this.btnAparecer.Location = new System.Drawing.Point(291, 403);
            this.btnAparecer.Name = "btnAparecer";
            this.btnAparecer.Size = new System.Drawing.Size(127, 35);
            this.btnAparecer.TabIndex = 0;
            this.btnAparecer.Text = "APARECER";
            this.btnAparecer.UseVisualStyleBackColor = true;
            this.btnAparecer.Click += new System.EventHandler(this.btnAparecer_Click);
            // 
            // frmVehiculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(735, 450);
            this.Controls.Add(this.btnAparecer);
            this.Name = "frmVehiculo";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmVehiculo_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAparecer;
    }
}

