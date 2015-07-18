namespace Unijeans
{
    partial class Cargando
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
            this.components = new System.ComponentModel.Container();
            this.lb_unijeans = new System.Windows.Forms.Label();
            this.barra_progreso = new System.Windows.Forms.ProgressBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // lb_unijeans
            // 
            this.lb_unijeans.AutoSize = true;
            this.lb_unijeans.Font = new System.Drawing.Font("Matura MT Script Capitals", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_unijeans.Location = new System.Drawing.Point(12, 32);
            this.lb_unijeans.Name = "lb_unijeans";
            this.lb_unijeans.Size = new System.Drawing.Size(304, 85);
            this.lb_unijeans.TabIndex = 0;
            this.lb_unijeans.Text = "Unijeans";
            // 
            // barra_progreso
            // 
            this.barra_progreso.ForeColor = System.Drawing.SystemColors.ControlText;
            this.barra_progreso.Location = new System.Drawing.Point(197, 211);
            this.barra_progreso.Name = "barra_progreso";
            this.barra_progreso.Size = new System.Drawing.Size(257, 10);
            this.barra_progreso.Step = 100;
            this.barra_progreso.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.barra_progreso.TabIndex = 1;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Cargando
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(479, 265);
            this.Controls.Add(this.barra_progreso);
            this.Controls.Add(this.lb_unijeans);
            this.ForeColor = System.Drawing.SystemColors.Window;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Cargando";
            this.Text = "Cargando";
            this.Load += new System.EventHandler(this.Cargando_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_unijeans;
        private System.Windows.Forms.ProgressBar barra_progreso;
        private System.Windows.Forms.Timer timer1;
    }
}