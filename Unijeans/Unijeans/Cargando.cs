﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Unijeans
{
    public partial class Cargando : Form
    {
        public Cargando()
        {
            InitializeComponent();
        }

        private void Cargando_Load(object sender, EventArgs e)
        {
            barra_progreso.ForeColor = Color.Red;
            this.timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            barra_progreso.Increment(1);
            Thread.Sleep(100);
            if (barra_progreso.Value == 100)
            {
                timer1.Stop();
                this.Visible = false;
                Principal o = new Principal(1);
                o.Visible = true;
                
                
                
            }
        }


    }
}
