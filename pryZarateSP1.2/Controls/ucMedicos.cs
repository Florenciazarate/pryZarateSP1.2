using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using pryZarateSP1._2.Models;
using pryZarateSP1._2.Data;

namespace pryZarateSP1._2.Controls
{
    public partial class ucMedicos : UserControl
    {
        private Label lblMatricula;
        private Label lblNombre;
        private Label lblApellido;
        private Label lblEspecialidad;
        private TextBox txtMatricula;
        private TextBox txtNombre;
        private TextBox txtApellido;
        private ComboBox cmbEspecialidades;
        private Button btnAgregar;
        private Button btnEditar;
        private Button btnEliminar;
        private DataGridView dgvMedicos;

        public ucMedicos()
        {
            InitializeComponent();
            CargarEspecialidades();
        }

        private void InitializeComponent()
        {
            this.lblMatricula = new Label();
            this.lblNombre = new Label();
            this.lblApellido = new Label();
            this.lblEspecialidad = new Label();
            this.txtMatricula = new TextBox();
            this.txtNombre = new TextBox();
            this.txtApellido = new TextBox();
            this.cmbEspecialidades = new ComboBox();
            this.btnAgregar = new Button();
            this.btnEditar = new Button();
            this.btnEliminar = new Button();
            this.dgvMedicos = new DataGridView();

            // 
            // lblMatricula
            // 
            this.lblMatricula.AutoSize = true;
            this.lblMatricula.Location = new System.Drawing.Point(6, 8);
            this.lblMatricula.Name = "lblMatricula";
            this.lblMatricula.Size = new System.Drawing.Size(54, 13);
            this.lblMatricula.Text = "Matrícula:";
            // 
            // txtMatricula
            // 
            this.txtMatricula.Location = new System.Drawing.Point(100, 5);
            this.txtMatricula.Name = "txtMatricula";
            this.txtMatricula.Size = new System.Drawing.Size(120, 20);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(6, 36);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(47, 13);
            this.lblNombre.Text = "Nombre:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(100, 33);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(200, 20);
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(6, 64);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(47, 13);
            this.lblApellido.Text = "Apellido:";
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(100, 61);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(200, 20);
            // 
            // lblEspecialidad
            // 
            this.lblEspecialidad.AutoSize = true;
            this.lblEspecialidad.Location = new System.Drawing.Point(320, 8);
            this.lblEspecialidad.Name = "lblEspecialidad";
            this.lblEspecialidad.Size = new System.Drawing.Size(70, 13);
            this.lblEspecialidad.Text = "Especialidad:";
            // 
            // cmbEspecialidades
            // 
            this.cmbEspecialidades.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cmbEspecialidades.Location = new System.Drawing.Point(400, 5);
            this.cmbEspecialidades.Name = "cmbEspecialidades";
            this.cmbEspecialidades.Size = new System.Drawing.Size(200, 21);
            this.cmbEspecialidades.SelectedIndexChanged += new EventHandler(this.cmbEspecialidades_SelectedIndexChanged);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(100, 90);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(120, 25);
            this.btnAgregar.Text = "Agregar Médico";
            this.btnAgregar.Click += new EventHandler(this.btnAgregar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(230, 90);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(120, 25);
            this.btnEditar.Text = "Editar Médico";
            this.btnEditar.Click += new EventHandler(this.btnEditar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(360, 90);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(120, 25);
            this.btnEliminar.Text = "Eliminar Médico";
            this.btnEliminar.Click += new EventHandler(this.btnEliminar_Click);
            // 
            // dgvMedicos
            // 
            this.dgvMedicos.Location = new System.Drawing.Point(6, 125);
            this.dgvMedicos.Name = "dgvMedicos";
            this.dgvMedicos.Size = new System.Drawing.Size(760, 170);
            this.dgvMedicos.ReadOnly = true;
            this.dgvMedicos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dgvMedicos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMedicos.CellDoubleClick += new DataGridViewCellEventHandler(this.dgvMedicos_CellDoubleClick);

            // 
            // ucMedicos
            // 
            this.Controls.Add(this.lblMatricula);
            this.Controls.Add(this.txtMatricula);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.lblEspecialidad);
            this.Controls.Add(this.cmbEspecialidades);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.dgvMedicos);
            this.Name = "ucMedicos1";
            this.Size = new System.Drawing.Size(780, 300);
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            int matricula;
            if (!int.TryParse(txtMatricula.Text.Trim(), out matricula))
            {
                MessageBox.Show("La matrícula debe ser un número entero.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMatricula.Focus();
                return;
            }

            var nombre = txtNombre.Text.Trim();
            if (string.IsNullOrWhiteSpace(nombre))
            {
                MessageBox.Show("El nombre del médico no puede estar vacío.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNombre.Focus();
                return;
            }

            var apellido = txtApellido.Text.Trim();
            if (string.IsNullOrWhiteSpace(apellido))
            {
                MessageBox.Show("El apellido del médico no puede estar vacío.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show(error, "Error al agregar médico", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // refrescar lista mostrada
            CargarMedicosPorEspecialidad(especialidad.Id);

            // limpiar campos
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
                MessageBox.Show("La matrícula debe ser un número entero.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMatricula.Focus();
                return;
            }

            var nombre = txtNombre.Text.Trim();
            if (string.IsNullOrWhiteSpace(nombre))
            {
                MessageBox.Show("El nombre del médico no puede estar vacío.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNombre.Focus();
                return;
            }

            var apellido = txtApellido.Text.Trim();
            if (string.IsNullOrWhiteSpace(apellido))
            {
                MessageBox.Show("El apellido del médico no puede estar vacío.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show(error, "Error al editar médico", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            CargarMedicosPorEspecialidad(especialidad.Id);
            MessageBox.Show("Médico actualizado.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // permitir editar matrícula nuevamente
            txtMatricula.Enabled = true;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvMedicos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione un médico de la lista para eliminar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var row = dgvMedicos.SelectedRows[0];
            var matriculaObj = row.Cells[0].Value;
            if (matriculaObj == null || !int.TryParse(matriculaObj.ToString(), out int matricula))
            {
                MessageBox.Show("No se pudo obtener la matrícula del registro seleccionado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var confirm = MessageBox.Show($"¿Confirma eliminar el médico con matrícula {matricula}?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm != DialogResult.Yes) return;

            string error;
            if (!Repository.RemoveMedico(matricula, out error))
            {
                MessageBox.Show(error, "Error al eliminar médico", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // refrescar lista
            if (cmbEspecialidades.SelectedItem is Especialidad esp)
            {
                CargarMedicosPorEspecialidad(esp.Id);
            }
            MessageBox.Show("Médico eliminado.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void dgvMedicos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            var row = dgvMedicos.Rows[e.RowIndex];
            var matriculaObj = row.Cells[0].Value;
            if (matriculaObj == null || !int.TryParse(matriculaObj.ToString(), out int matricula)) return;

            var medico = Repository.GetMedicos().FirstOrDefault(m => m.Matricula == matricula);
            if (medico == null) return;

            // llenar campos para edición
            txtMatricula.Text = medico.Matricula.ToString();
            txtMatricula.Enabled = false; // no permitir cambiar la matrícula
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

        private void CargarMedicosPorEspecialidad(int especialidadId)
        {
            var lista = Repository.GetMedicosByEspecialidadId(especialidadId)
                        .Select(m => new { Matricula = m.Matricula, Nombre = m.Nombre, Apellido = m.Apellido, EspecialidadId = m.EspecialidadId })
                        .ToList();
            dgvMedicos.DataSource = lista;
        }

        // Método público usado por frmPrincipal para recargar el combobox de especialidades
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

            // Asegurar que la matrícula se puede editar al crear nuevo
            txtMatricula.Enabled = true;
            txtNombre.Text = string.Empty;
            txtApellido.Text = string.Empty;
            txtMatricula.Text = string.Empty;
        }
    }
}