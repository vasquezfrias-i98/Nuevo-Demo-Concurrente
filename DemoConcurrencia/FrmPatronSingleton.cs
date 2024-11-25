﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoConcurrencia
{
    public partial class FrmPatronSingleton : Form
    {
        public FrmPatronSingleton()
        {
            InitializeComponent();
        }

        private void FrmPatronSingleton_Load(object sender, EventArgs e)
        {

        }

        private void BtnAsignar_Click(object sender, EventArgs e)
        {
            Singleton cadenaConexion = Singleton.Instance;
            cadenaConexion.cadenaConexion = TxtCadenaConexion.Text;
        }

        private void BtnRecuperar_Click(object sender, EventArgs e)
        {

            Singleton cadenaConexion = Singleton.Instance;
            LblCadenaConexion.Text = cadenaConexion.cadenaConexion;
        }
    }
}
