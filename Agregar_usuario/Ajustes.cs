﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Agregar_usuario
{
    public partial class frmAjustes : Form
    {
        public frmAjustes()
        {
            InitializeComponent();
        }

        private void btnContra_Click(object sender, EventArgs e)
        {
            frmContra contraseña = new frmContra();
            contraseña.Show();
        }
    }
}
