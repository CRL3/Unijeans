namespace Unijeans.Vista.Rol
{
    partial class ListarRol
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
            this.data_grid_rol = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.data_grid_rol)).BeginInit();
            this.SuspendLayout();
            // 
            // data_grid_rol
            // 
            this.data_grid_rol.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_grid_rol.Location = new System.Drawing.Point(287, 158);
            this.data_grid_rol.Name = "data_grid_rol";
            this.data_grid_rol.Size = new System.Drawing.Size(368, 243);
            this.data_grid_rol.TabIndex = 0;
            // 
            // ListarRol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1001, 738);
            this.Controls.Add(this.data_grid_rol);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ListarRol";
            this.Text = "ListarRol";
            ((System.ComponentModel.ISupportInitialize)(this.data_grid_rol)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView data_grid_rol;
    }
}