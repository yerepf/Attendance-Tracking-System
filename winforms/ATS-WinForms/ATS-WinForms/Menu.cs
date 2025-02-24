﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATS_WinForms
{
    public partial class Menu: Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void Menu_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void Tiempo_Tick(object sender, EventArgs e)
        {
            LB_HORARIO.Text = DateTime.Now.ToString("hh:mm:ss");
            LB_FECHA.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
