using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using pryZarateSP1._2.Controls;

namespace pryZarateSP1._2
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

        private TabControl tabControl1;
        private TabPage tabPageEspecialidades;
        private TabPage tabPageMedicos;
        private DataGridView dgvCargaMedicos;
        private Button btnCargar;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageEspecialidades = new System.Windows.Forms.TabPage();
            this.tabPageMedicos = new System.Windows.Forms.TabPage();
            this.dgvCargaMedicos = new System.Windows.Forms.DataGridView();
            this.btnCargar = new System.Windows.Forms.Button();
            this.ucMedicos1 = new pryZarateSP1._2.Controls.ucMedicos();
            this.ucEspecialidades1 = new pryZarateSP1._2.Controls.ucEspecialidades();
            this.tabControl1.SuspendLayout();
            this.tabPageEspecialidades.SuspendLayout();
            this.tabPageMedicos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCargaMedicos)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageEspecialidades);
            this.tabControl1.Controls.Add(this.tabPageMedicos);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 647);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPageEspecialidades
            // 
            this.tabPageEspecialidades.BackColor = System.Drawing.Color.GhostWhite;
            this.tabPageEspecialidades.Controls.Add(this.ucEspecialidades1);
            this.tabPageEspecialidades.Location = new System.Drawing.Point(4, 22);
            this.tabPageEspecialidades.Name = "tabPageEspecialidades";
            this.tabPageEspecialidades.Padding = new System.Windows.Forms.Padding(6);
            this.tabPageEspecialidades.Size = new System.Drawing.Size(792, 621);
            this.tabPageEspecialidades.TabIndex = 0;
            this.tabPageEspecialidades.Text = "Especialidades";
            // 
            // tabPageMedicos
            // 
            this.tabPageMedicos.BackColor = System.Drawing.Color.GhostWhite;
            this.tabPageMedicos.Controls.Add(this.ucMedicos1);
            this.tabPageMedicos.Controls.Add(this.dgvCargaMedicos);
            this.tabPageMedicos.Controls.Add(this.btnCargar);
            this.tabPageMedicos.Location = new System.Drawing.Point(4, 22);
            this.tabPageMedicos.Name = "tabPageMedicos";
            this.tabPageMedicos.Padding = new System.Windows.Forms.Padding(6);
            this.tabPageMedicos.Size = new System.Drawing.Size(792, 621);
            this.tabPageMedicos.TabIndex = 1;
            this.tabPageMedicos.Text = "Médicos";
            this.tabPageMedicos.Click += new System.EventHandler(this.tabPageMedicos_Click);
            // 
            // dgvCargaMedicos
            // 
            this.dgvCargaMedicos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCargaMedicos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCargaMedicos.BackgroundColor = System.Drawing.Color.DarkSlateGray;
            this.dgvCargaMedicos.Location = new System.Drawing.Point(9, 346);
            this.dgvCargaMedicos.Name = "dgvCargaMedicos";
            this.dgvCargaMedicos.Size = new System.Drawing.Size(758, 238);
            this.dgvCargaMedicos.TabIndex = 1;
            // 
            // btnCargar
            // 
            this.btnCargar.Location = new System.Drawing.Point(9, 312);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(120, 28);
            this.btnCargar.TabIndex = 2;
            this.btnCargar.Text = "Cargar Médicos";
            this.btnCargar.Click += new System.EventHandler(this.button1_Click);
            // 
            // ucMedicos1
            // 
            this.ucMedicos1.BackColor = System.Drawing.Color.GhostWhite;
            this.ucMedicos1.Location = new System.Drawing.Point(6, 6);
            this.ucMedicos1.Name = "ucMedicos1";
            this.ucMedicos1.Size = new System.Drawing.Size(777, 300);
            this.ucMedicos1.TabIndex = 0;
            // 
            // ucEspecialidades1
            // 
            this.ucEspecialidades1.BackColor = System.Drawing.Color.GhostWhite;
            this.ucEspecialidades1.Location = new System.Drawing.Point(9, 9);
            this.ucEspecialidades1.Name = "ucEspecialidades1";
            this.ucEspecialidades1.Size = new System.Drawing.Size(752, 355);
            this.ucEspecialidades1.TabIndex = 0;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(800, 647);
            this.Controls.Add(this.tabControl1);
            this.Name = "frmPrincipal";
            this.Text = "Gestión Clínica";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPageEspecialidades.ResumeLayout(false);
            this.tabPageMedicos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCargaMedicos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ucMedicos ucMedicos1;
        private ucEspecialidades ucEspecialidades1;
    }
}