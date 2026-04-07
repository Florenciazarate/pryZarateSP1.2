using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using pryZarateSP1._2.Models;
using pryZarateSP1._2.Data;
using pryZarateSP1._2.Controls;

namespace pryZarateSP1._2
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
            ucEspecialidades1.EspecialidadAdded += (s, e) => ucMedicos1.CargarEspecialidades();
            tabControl1.SelectedIndexChanged += TabControl1_SelectedIndexChanged;
        }

        private void TabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab == tabPageMedicos)
            {
                ucMedicos1.CargarEspecialidades();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<Medico> medicos = Repository.GetMedicos().ToList();
            dataGridView1.DataSource = medicos.Select(m => new { Matricula = m.Matricula, Nombre = m.Nombre, EspecialidadId = m.EspecialidadId }).ToList();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            CargarEspecialidades();
        }

        private void CargarEspecialidades()
        {
            ucEspecialidades1.LoadEspecialidades();
            ucMedicos1.CargarEspecialidades();
        }

 
    }
}
