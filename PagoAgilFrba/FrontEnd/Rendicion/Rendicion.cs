﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PagoAgilFrba.FrontEnd.Rendicion
{
    public partial class Rendicion : Form
    {
        private Models.BO.Usuario usuarioLogueado;

        public Rendicion()
        {
            InitializeComponent();
        }

        public Rendicion(Models.BO.Usuario usuarioLogueado)
        {
            // TODO: Complete member initialization
            this.usuarioLogueado = usuarioLogueado;
        }
    }
}
