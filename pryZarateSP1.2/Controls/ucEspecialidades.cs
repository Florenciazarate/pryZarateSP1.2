using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using pryZarateSP1._2.Models;
using pryZarateSP1._2.Data;

namespace pryZarateSP1._2.Controls
{
    public partial class ucEspecialidades : UserControl
    {
        public event EventHandler EspecialidadAdded;

        public ucEspecialidades()
        {
            InitializeComponent();
            LoadEspecialidades();
        }

        public void LoadEspecialidades()
        {
            var lista = Repository.GetEspecialidades();
            dgvEspecialidades.DataSource = new List<Especialidad>(lista);
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            int id;
            if (!int.TryParse(txtId.Text.Trim(), out id))
            {
                MessageBox.Show("El numero de especialidad debe ser un numero entero.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtId.Focus();
                return;
            }

            var nombre = txtNombre.Text.Trim();
            if (string.IsNullOrWhiteSpace(nombre))
            {
                MessageBox.Show("El nombre de la especialidad no puede estar vacio.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNombre.Focus();
                return;
            }

            var nueva = new Especialidad { Id = id, Nombre = nombre };
            string error;
            if (!Repository.AddEspecialidad(nueva, out error))
            {
                MessageBox.Show(error, "Error al agregar especialidad", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            LoadEspecialidades();
            EspecialidadAdded?.Invoke(this, EventArgs.Empty);

            txtId.Text = "";
            txtNombre.Text = "";
            txtId.Focus();
        }

        private void btnAgregar_MouseEnter(object sender, EventArgs e)
        {
            btnAgregar.BackColor = Color.FromArgb(56, 178, 172);
        }

        private void btnAgregar_MouseLeave(object sender, EventArgs e)
        {
            btnAgregar.BackColor = Color.FromArgb(44, 122, 123);
        }
    }
}
