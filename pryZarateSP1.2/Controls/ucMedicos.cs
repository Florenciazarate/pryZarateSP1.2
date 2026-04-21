using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using pryZarateSP1._2.Models;
using pryZarateSP1._2.Data;

namespace pryZarateSP1._2.Controls
{
    public partial class ucMedicos : UserControl
    {
        public ucMedicos()
        {
            InitializeComponent();
            CargarEspecialidades();
        }

        public void CargarEspecialidades()
        {
            var lista = Repository.GetEspecialidades().ToList();
            cmbEspecialidades.DataSource = lista;
            cmbEspecialidades.DisplayMember = "Nombre";
            cmbEspecialidades.ValueMember = "Id";

            if (lista.Count == 0)
            {
                dgvMedicos.DataSource = null;
            }
            else
            {
                cmbEspecialidades.SelectedIndex = 0;
            }

            txtMatricula.Enabled = true;
            txtNombre.Text = string.Empty;
            txtApellido.Text = string.Empty;
            txtMatricula.Text = string.Empty;
        }

        private void CargarMedicosPorEspecialidad(int especialidadId)
        {
            var lista = Repository.GetMedicosByEspecialidadId(especialidadId)
                        .Select(m => new { Matricula = m.Matricula, Nombre = m.Nombre, Apellido = m.Apellido, EspecialidadId = m.EspecialidadId })
                        .ToList();
            dgvMedicos.DataSource = lista;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            int matricula;
            if (!int.TryParse(txtMatricula.Text.Trim(), out matricula))
            {
                MessageBox.Show("La matricula debe ser un numero entero.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMatricula.Focus();
                return;
            }

            var nombre = txtNombre.Text.Trim();
            if (string.IsNullOrWhiteSpace(nombre))
            {
                MessageBox.Show("El nombre del medico no puede estar vacio.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNombre.Focus();
                return;
            }

            var apellido = txtApellido.Text.Trim();
            if (string.IsNullOrWhiteSpace(apellido))
            {
                MessageBox.Show("El apellido del medico no puede estar vacio.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtApellido.Focus();
                return;
            }

            if (cmbEspecialidades.SelectedItem == null)
            {
                MessageBox.Show("Seleccione una especialidad.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmbEspecialidades.Focus();
                return;
            }

            var especialidad = (Especialidad)cmbEspecialidades.SelectedItem;
            var nuevo = new Medico { Matricula = matricula, Nombre = nombre, Apellido = apellido, EspecialidadId = especialidad.Id };

            string error;
            if (!Repository.AddMedico(nuevo, out error))
            {
                MessageBox.Show(error, "Error al agregar medico", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            CargarMedicosPorEspecialidad(especialidad.Id);
            txtMatricula.Text = "";
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtMatricula.Focus();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            int matricula;
            if (!int.TryParse(txtMatricula.Text.Trim(), out matricula))
            {
                MessageBox.Show("La matricula debe ser un numero entero.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMatricula.Focus();
                return;
            }

            var nombre = txtNombre.Text.Trim();
            if (string.IsNullOrWhiteSpace(nombre))
            {
                MessageBox.Show("El nombre del medico no puede estar vacio.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNombre.Focus();
                return;
            }

            var apellido = txtApellido.Text.Trim();
            if (string.IsNullOrWhiteSpace(apellido))
            {
                MessageBox.Show("El apellido del medico no puede estar vacio.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtApellido.Focus();
                return;
            }

            if (cmbEspecialidades.SelectedItem == null)
            {
                MessageBox.Show("Seleccione una especialidad.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmbEspecialidades.Focus();
                return;
            }

            var especialidad = (Especialidad)cmbEspecialidades.SelectedItem;
            string error;
            if (!Repository.UpdateMedico(matricula, nombre, apellido, especialidad.Id, out error))
            {
                MessageBox.Show(error, "Error al editar medico", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            CargarMedicosPorEspecialidad(especialidad.Id);
            MessageBox.Show("Medico actualizado.", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            txtMatricula.Enabled = true;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvMedicos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione un medico de la lista para eliminar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var row = dgvMedicos.SelectedRows[0];
            var matriculaObj = row.Cells[0].Value;
            if (matriculaObj == null || !int.TryParse(matriculaObj.ToString(), out int matricula))
            {
                MessageBox.Show("No se pudo obtener la matricula del registro seleccionado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var confirm = MessageBox.Show($"Confirma eliminar el medico con matricula {matricula}?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm != DialogResult.Yes) return;

            string error;
            if (!Repository.RemoveMedico(matricula, out error))
            {
                MessageBox.Show(error, "Error al eliminar medico", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (cmbEspecialidades.SelectedItem is Especialidad esp)
            {
                CargarMedicosPorEspecialidad(esp.Id);
            }
            MessageBox.Show("Medico eliminado.", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void dgvMedicos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            var row = dgvMedicos.Rows[e.RowIndex];
            var matriculaObj = row.Cells[0].Value;
            if (matriculaObj == null || !int.TryParse(matriculaObj.ToString(), out int matricula)) return;

            var medico = Repository.GetMedicos().FirstOrDefault(m => m.Matricula == matricula);
            if (medico == null) return;

            txtMatricula.Text = medico.Matricula.ToString();
            txtMatricula.Enabled = false;
            txtNombre.Text = medico.Nombre;
            txtApellido.Text = medico.Apellido;
            cmbEspecialidades.SelectedItem = Repository.GetEspecialidades().FirstOrDefault(x => x.Id == medico.EspecialidadId);
        }

        private void cmbEspecialidades_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbEspecialidades.SelectedItem is Especialidad esp)
            {
                CargarMedicosPorEspecialidad(esp.Id);
            }
            else
            {
                dgvMedicos.DataSource = null;
            }
        }

        private void btnAgregar_MouseEnter(object sender, EventArgs e) { btnAgregar.BackColor = Color.FromArgb(56, 178, 172); }
        private void btnAgregar_MouseLeave(object sender, EventArgs e) { btnAgregar.BackColor = Color.FromArgb(44, 122, 123); }
        private void btnEditar_MouseEnter(object sender, EventArgs e) { btnEditar.BackColor = Color.FromArgb(113, 128, 150); }
        private void btnEditar_MouseLeave(object sender, EventArgs e) { btnEditar.BackColor = Color.FromArgb(74, 85, 104); }
        private void btnEliminar_MouseEnter(object sender, EventArgs e) { btnEliminar.BackColor = Color.FromArgb(245, 101, 101); }
        private void btnEliminar_MouseLeave(object sender, EventArgs e) { btnEliminar.BackColor = Color.FromArgb(229, 62, 62); }
    }
}
