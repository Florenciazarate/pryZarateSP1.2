using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using pryZarateSP1._2.Models;
using pryZarateSP1._2.Data;

namespace pryZarateSP1._2
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
            ucEspecialidades1.EspecialidadAdded += ucEspecialidades1_EspecialidadAdded;
        }

        private void ucEspecialidades1_EspecialidadAdded(object sender, EventArgs e)
        {
            ucMedicos1.CargarEspecialidades();
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabGestion.SelectedTab == tabPageMedicos)
            {
                ucMedicos1.CargarEspecialidades();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<Medico> medicos = Repository.GetMedicos().ToList();
            dgvCargaMedicos.DataSource = medicos.Select(m => new { Matricula = m.Matricula, Nombre = m.Nombre, EspecialidadId = m.EspecialidadId }).ToList();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            ucEspecialidades1.LoadEspecialidades();
            ucMedicos1.CargarEspecialidades();
        }

        private void btnCargar_MouseEnter(object sender, EventArgs e) { btnCargar.BackColor = Color.FromArgb(56, 178, 172); }
        private void btnCargar_MouseLeave(object sender, EventArgs e) { btnCargar.BackColor = Color.FromArgb(44, 122, 123); }
    }
}
