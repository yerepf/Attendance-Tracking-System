using System;
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
    public partial class LOGIN : Form
    {
        public LOGIN()
        {
            InitializeComponent();
        }

        //Variables
        bool VisibilidadContraseña;

        //FUNCIONES
        private void MostrarClave_Click(object sender, EventArgs e)
        {
            if (VisibilidadContraseña == false)
            {
                TB_CLAVE.PasswordChar = '\0';
                VisibilidadContraseña = true;
                MostrarClave.Image = ATS_WinForms.Properties.Resources.cerrar_ojo1;
            }
            else
            {
                TB_CLAVE.PasswordChar = '*';
                VisibilidadContraseña = false;
                MostrarClave.Image = ATS_WinForms.Properties.Resources.foto;
            }
        }
        private void BT_SALIR_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TB_USUARIO_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                TB_CLAVE.Focus();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
            if (TB_USUARIO.Text.Length >= 10 && e.KeyCode != Keys.Back)
            {
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void TB_CLAVE_KeyDown(object sender, KeyEventArgs e)
        {
            if (TB_CLAVE.Text.Length >= 10 && e.KeyCode != Keys.Back)
            {
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void BT_ENTRAR_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Hide();
        }
    }
}
