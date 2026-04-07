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
        private ucEspecialidades ucEspecialidades1;
        private ucMedicos ucMedicos1;
        private DataGridView dataGridView1;
        private Button button1;

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
            this.ucEspecialidades1 = new pryZarateSP1._2.Controls.ucEspecialidades();
            this.tabPageMedicos = new System.Windows.Forms.TabPage();
            this.ucMedicos1 = new pryZarateSP1._2.Controls.ucMedicos();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPageEspecialidades.SuspendLayout();
            this.tabPageMedicos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            this.tabPageEspecialidades.Controls.Add(this.ucEspecialidades1);
            this.tabPageEspecialidades.Location = new System.Drawing.Point(4, 22);
            this.tabPageEspecialidades.Name = "tabPageEspecialidades";
            this.tabPageEspecialidades.Padding = new System.Windows.Forms.Padding(6);
            this.tabPageEspecialidades.Size = new System.Drawing.Size(792, 621);
            this.tabPageEspecialidades.TabIndex = 0;
            this.tabPageEspecialidades.Text = "Especialidades";
            this.tabPageEspecialidades.UseVisualStyleBackColor = true;
            // 
            // ucEspecialidades1
            // 
            this.ucEspecialidades1.Location = new System.Drawing.Point(6, 6);
            this.ucEspecialidades1.Name = "ucEspecialidades1";
            this.ucEspecialidades1.Size = new System.Drawing.Size(380, 300);
            this.ucEspecialidades1.TabIndex = 0;
            // 
            // tabPageMedicos
            // 
            this.tabPageMedicos.Controls.Add(this.ucMedicos1);
            this.tabPageMedicos.Controls.Add(this.dataGridView1);
            this.tabPageMedicos.Controls.Add(this.button1);
            this.tabPageMedicos.Location = new System.Drawing.Point(4, 22);
            this.tabPageMedicos.Name = "tabPageMedicos";
            this.tabPageMedicos.Padding = new System.Windows.Forms.Padding(6);
            this.tabPageMedicos.Size = new System.Drawing.Size(792, 621);
            this.tabPageMedicos.TabIndex = 1;
            this.tabPageMedicos.Text = "Médicos";
            this.tabPageMedicos.UseVisualStyleBackColor = true;
            // 
            // ucMedicos1
            // 
            this.ucMedicos1.Location = new System.Drawing.Point(6, 6);
            this.ucMedicos1.Name = "ucMedicos1";
            this.ucMedicos1.Size = new System.Drawing.Size(777, 300);
            this.ucMedicos1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(9, 346);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(758, 238);
            this.dataGridView1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(9, 312);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 28);
            this.button1.TabIndex = 2;
            this.button1.Text = "Cargar Médicos";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 647);
            this.Controls.Add(this.tabControl1);
            this.Name = "frmPrincipal";
            this.Text = "Gestión Clínica";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPageEspecialidades.ResumeLayout(false);
            this.tabPageMedicos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
    }
}