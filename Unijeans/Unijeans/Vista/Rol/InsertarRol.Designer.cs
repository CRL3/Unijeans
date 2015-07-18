namespace Unijeans.Vista.Rol
{
    partial class InsertarRol
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
            this.lb_descripcion = new System.Windows.Forms.Label();
            this.txt_descripcion = new System.Windows.Forms.TextBox();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.lb_InsertarRol = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lb_descripcion
            // 
            this.lb_descripcion.AutoSize = true;
            this.lb_descripcion.Location = new System.Drawing.Point(332, 228);
            this.lb_descripcion.Name = "lb_descripcion";
            this.lb_descripcion.Size = new System.Drawing.Size(63, 13);
            this.lb_descripcion.TabIndex = 1;
            this.lb_descripcion.Text = "Descripcion";
            // 
            // txt_descripcion
            // 
            this.txt_descripcion.Location = new System.Drawing.Point(452, 225);
            this.txt_descripcion.Name = "txt_descripcion";
            this.txt_descripcion.Size = new System.Drawing.Size(233, 20);
            this.txt_descripcion.TabIndex = 3;
            // 
            // btn_guardar
            // 
            this.btn_guardar.Location = new System.Drawing.Point(436, 332);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(121, 34);
            this.btn_guardar.TabIndex = 4;
            this.btn_guardar.Text = "Guardar";
            this.btn_guardar.UseVisualStyleBackColor = true;
            // 
            // lb_InsertarRol
            // 
            this.lb_InsertarRol.AutoSize = true;
            this.lb_InsertarRol.Font = new System.Drawing.Font("Cooper Black", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_InsertarRol.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lb_InsertarRol.Location = new System.Drawing.Point(418, 122);
            this.lb_InsertarRol.Name = "lb_InsertarRol";
            this.lb_InsertarRol.Size = new System.Drawing.Size(139, 24);
            this.lb_InsertarRol.TabIndex = 5;
            this.lb_InsertarRol.Text = "Insertar Rol";
            this.lb_InsertarRol.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // InsertarRol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(956, 631);
            this.Controls.Add(this.lb_InsertarRol);
            this.Controls.Add(this.btn_guardar);
            this.Controls.Add(this.txt_descripcion);
            this.Controls.Add(this.lb_descripcion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "InsertarRol";
            this.Text = "InsertarRol";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_descripcion;
        private System.Windows.Forms.TextBox txt_descripcion;
        private System.Windows.Forms.Button btn_guardar;
        private System.Windows.Forms.Label lb_InsertarRol;
    }
}