using System;
using System.Collections.Generic;
using System.Windows.Forms;
using pryZarateSP1._2.Models;
using pryZarateSP1._2.Data;

namespace pryZarateSP1._2.Controls
{
    public partial class ucEspecialidades : UserControl
    {
        // Evento que notifica que se agregó una especialidad nueva
        public event EventHandler EspecialidadAdded;

        private Label lblId;
        private Label lblNombre;
        private TextBox txtId;
        private TextBox txtNombre;
        private Button btnAgregar;
        private DataGridView dgvEspecialidades;

        public ucEspecialidades()
        {
            InitializeComponent();
            LoadEspecialidades();
        }

        private void InitializeComponent()
        {
            this.lblId = new Label();
            this.lblNombre = new Label();
            this.txtId = new TextBox();
            this.txtNombre = new TextBox();
            this.btnAgregar = new Button();
            this.dgvEspecialidades = new DataGridView();

            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(6, 8);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(66, 13);
            this.lblId.TabIndex = 0;
            this.lblId.Text = "Número (Id):";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(100, 5);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(120, 20);
            this.txtId.TabIndex = 1;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(6, 36);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(53, 13);
            this.lblNombre.TabIndex = 2;
            this.lblNombre.Text = "Nombre:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(100, 33);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(200, 20);
            this.txtNombre.TabIndex = 3;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(100, 60);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(120, 25);
            this.btnAgregar.TabIndex = 4;
            this.btnAgregar.Text = "Agregar Especialidad";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new EventHandler(this.btnAgregar_Click);
            // 
            // dgvEspecialidades
            // 
            this.dgvEspecialidades.AllowUserToAddRows = false;
            this.dgvEspecialidades.AllowUserToDeleteRows = false;
            this.dgvEspecialidades.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEspecialidades.Location = new System.Drawing.Point(6, 95);
            this.dgvEspecialidades.MultiSelect = false;
            this.dgvEspecialidades.Name = "dgvEspecialidades";
            this.dgvEspecialidades.ReadOnly = true;
            this.dgvEspecialidades.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dgvEspecialidades.Size = new System.Drawing.Size(360, 200);
            this.dgvEspecialidades.TabIndex = 5;

            // 
            // ucEspecialidades
            // 
            this.Controls.Add(this.dgvEspecialidades);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.lblId);
            this.Name = "ucEspecialidades1";
            this.Size = new System.Drawing.Size(380, 300);
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            int id;
            if (!int.TryParse(txtId.Text.Trim(), out id))
            {
                MessageBox.Show("El número de especialidad debe ser un número entero.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtId.Focus();
                return;
            }

            var nombre = txtNombre.Text.Trim();
            if (string.IsNullOrWhiteSpace(nombre))
            {
                MessageBox.Show("El nombre de la especialidad no puede estar vacío.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            // notificar a los suscriptores (ej. ucMedicos / frmPrincipal)
            EspecialidadAdded?.Invoke(this, EventArgs.Empty);

            // limpiar campos
            txtId.Text = "";
            txtNombre.Text = "";
            txtId.Focus();
        }

        // Método público usado por frmPrincipal para cargar la lista inicial
        public void LoadEspecialidades()
        {
            var lista = Repository.GetEspecialidades();
            dgvEspecialidades.DataSource = new List<Especialidad>(lista);
        }
    }
}