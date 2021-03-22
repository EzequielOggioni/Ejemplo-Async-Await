namespace awaitasync
{
    partial class frmTask
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
            this.btnTareas = new System.Windows.Forms.Button();
            this.btnSync = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnTareas
            // 
            this.btnTareas.Location = new System.Drawing.Point(87, 40);
            this.btnTareas.Name = "btnTareas";
            this.btnTareas.Size = new System.Drawing.Size(110, 48);
            this.btnTareas.TabIndex = 0;
            this.btnTareas.Text = "Ejecutar Asincronicos";
            this.btnTareas.UseVisualStyleBackColor = true;
            this.btnTareas.Click += new System.EventHandler(this.btnTareas_Click);
            // 
            // btnSync
            // 
            this.btnSync.Location = new System.Drawing.Point(277, 43);
            this.btnSync.Name = "btnSync";
            this.btnSync.Size = new System.Drawing.Size(72, 43);
            this.btnSync.TabIndex = 1;
            this.btnSync.Text = "Sincronico";
            this.btnSync.UseVisualStyleBackColor = true;
            this.btnSync.Click += new System.EventHandler(this.btnSync_Click);
            // 
            // frmTask
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(617, 272);
            this.Controls.Add(this.btnSync);
            this.Controls.Add(this.btnTareas);
            this.Name = "frmTask";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnTareas;
        private System.Windows.Forms.Button btnSync;
    }
}

