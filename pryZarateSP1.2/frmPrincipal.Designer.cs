namespace pryZarateSP1._2
{
    partial class frmPrincipal
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblAppTitulo;
        private System.Windows.Forms.Label lblAppSubtitulo;
        private System.Windows.Forms.TabControl tabGestion;
        private System.Windows.Forms.TabPage tabPageEspecialidades;
        private System.Windows.Forms.TabPage tabPageMedicos;
        private System.Windows.Forms.DataGridView dgvCargaMedicos;
        private System.Windows.Forms.Button btnCargar;
        private pryZarateSP1._2.Controls.ucEspecialidades ucEspecialidades1;
        private pryZarateSP1._2.Controls.ucMedicos ucMedicos1;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblAppSubtitulo = new System.Windows.Forms.Label();
            this.lblAppTitulo = new System.Windows.Forms.Label();
            this.tabGestion = new System.Windows.Forms.TabControl();
            this.tabPageEspecialidades = new System.Windows.Forms.TabPage();
            this.ucEspecialidades1 = new pryZarateSP1._2.Controls.ucEspecialidades();
            this.tabPageMedicos = new System.Windows.Forms.TabPage();
            this.btnCargar = new System.Windows.Forms.Button();
            this.dgvCargaMedicos = new System.Windows.Forms.DataGridView();
            this.ucMedicos1 = new pryZarateSP1._2.Controls.ucMedicos();
            this.pnlHeader.SuspendLayout();
            this.tabGestion.SuspendLayout();
            this.tabPageEspecialidades.SuspendLayout();
            this.tabPageMedicos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCargaMedicos)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(122)))), ((int)(((byte)(123)))));
            this.pnlHeader.Controls.Add(this.lblAppSubtitulo);
            this.pnlHeader.Controls.Add(this.lblAppTitulo);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(900, 70);
            this.pnlHeader.TabIndex = 0;
            // 
            // lblAppSubtitulo
            // 
            this.lblAppSubtitulo.AutoSize = true;
            this.lblAppSubtitulo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblAppSubtitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(224)))), ((int)(((byte)(223)))));
            this.lblAppSubtitulo.Location = new System.Drawing.Point(22, 45);
            this.lblAppSubtitulo.Name = "lblAppSubtitulo";
            this.lblAppSubtitulo.Size = new System.Drawing.Size(298, 15);
            this.lblAppSubtitulo.TabIndex = 1;
            this.lblAppSubtitulo.Text = "Sistema de administracion de especialidades y medicos";
            // 
            // lblAppTitulo
            // 
            this.lblAppTitulo.AutoSize = true;
            this.lblAppTitulo.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold);
            this.lblAppTitulo.ForeColor = System.Drawing.Color.White;
            this.lblAppTitulo.Location = new System.Drawing.Point(20, 10);
            this.lblAppTitulo.Name = "lblAppTitulo";
            this.lblAppTitulo.Size = new System.Drawing.Size(175, 32);
            this.lblAppTitulo.TabIndex = 0;
            this.lblAppTitulo.Text = "Gestion Clinica";
            // 
            // tabGestion
            // 
            this.tabGestion.Controls.Add(this.tabPageEspecialidades);
            this.tabGestion.Controls.Add(this.tabPageMedicos);
            this.tabGestion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabGestion.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.tabGestion.ItemSize = new System.Drawing.Size(160, 34);
            this.tabGestion.Location = new System.Drawing.Point(0, 70);
            this.tabGestion.Name = "tabGestion";
            this.tabGestion.SelectedIndex = 0;
            this.tabGestion.Size = new System.Drawing.Size(900, 750);
            this.tabGestion.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabGestion.TabIndex = 1;
            this.tabGestion.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPageEspecialidades
            // 
            this.tabPageEspecialidades.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.tabPageEspecialidades.Controls.Add(this.ucEspecialidades1);
            this.tabPageEspecialidades.Location = new System.Drawing.Point(4, 38);
            this.tabPageEspecialidades.Name = "tabPageEspecialidades";
            this.tabPageEspecialidades.Size = new System.Drawing.Size(892, 708);
            this.tabPageEspecialidades.TabIndex = 0;
            this.tabPageEspecialidades.Text = "  Especialidades";
            // 
            // ucEspecialidades1
            // 
            this.ucEspecialidades1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.ucEspecialidades1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucEspecialidades1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ucEspecialidades1.Location = new System.Drawing.Point(0, 0);
            this.ucEspecialidades1.Name = "ucEspecialidades1";
            this.ucEspecialidades1.Padding = new System.Windows.Forms.Padding(20);
            this.ucEspecialidades1.Size = new System.Drawing.Size(892, 708);
            this.ucEspecialidades1.TabIndex = 0;
            // 
            // tabPageMedicos
            // 
            this.tabPageMedicos.AutoScroll = true;
            this.tabPageMedicos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.tabPageMedicos.Controls.Add(this.btnCargar);
            this.tabPageMedicos.Controls.Add(this.dgvCargaMedicos);
            this.tabPageMedicos.Controls.Add(this.ucMedicos1);
            this.tabPageMedicos.Location = new System.Drawing.Point(4, 38);
            this.tabPageMedicos.Name = "tabPageMedicos";
            this.tabPageMedicos.Size = new System.Drawing.Size(892, 708);
            this.tabPageMedicos.TabIndex = 1;
            this.tabPageMedicos.Text = "  Medicos";
            // 
            // btnCargar
            // 
            this.btnCargar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(122)))), ((int)(((byte)(123)))));
            this.btnCargar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCargar.FlatAppearance.BorderSize = 0;
            this.btnCargar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCargar.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnCargar.ForeColor = System.Drawing.Color.White;
            this.btnCargar.Location = new System.Drawing.Point(20, 520);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(220, 34);
            this.btnCargar.TabIndex = 1;
            this.btnCargar.Text = "Cargar todos los medicos";
            this.btnCargar.UseVisualStyleBackColor = false;
            this.btnCargar.Click += new System.EventHandler(this.button1_Click);
            this.btnCargar.MouseEnter += new System.EventHandler(this.btnCargar_MouseEnter);
            this.btnCargar.MouseLeave += new System.EventHandler(this.btnCargar_MouseLeave);
            // 
            // dgvCargaMedicos
            // 
            this.dgvCargaMedicos.AllowUserToAddRows = false;
            this.dgvCargaMedicos.AllowUserToDeleteRows = false;
            this.dgvCargaMedicos.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(250)))), ((int)(((byte)(251)))));
            this.dgvCargaMedicos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCargaMedicos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCargaMedicos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCargaMedicos.BackgroundColor = System.Drawing.Color.White;
            this.dgvCargaMedicos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvCargaMedicos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(122)))), ((int)(((byte)(123)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(122)))), ((int)(((byte)(123)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            this.dgvCargaMedicos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvCargaMedicos.ColumnHeadersHeight = 36;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(55)))), ((int)(((byte)(72)))));
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(6, 0, 0, 0);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(55)))), ((int)(((byte)(72)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCargaMedicos.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvCargaMedicos.EnableHeadersVisualStyles = false;
            this.dgvCargaMedicos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            this.dgvCargaMedicos.Location = new System.Drawing.Point(20, 560);
            this.dgvCargaMedicos.MultiSelect = false;
            this.dgvCargaMedicos.Name = "dgvCargaMedicos";
            this.dgvCargaMedicos.ReadOnly = true;
            this.dgvCargaMedicos.RowHeadersVisible = false;
            this.dgvCargaMedicos.RowTemplate.Height = 30;
            this.dgvCargaMedicos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCargaMedicos.Size = new System.Drawing.Size(850, 133);
            this.dgvCargaMedicos.TabIndex = 2;
            // 
            // ucMedicos1
            // 
            this.ucMedicos1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ucMedicos1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.ucMedicos1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ucMedicos1.Location = new System.Drawing.Point(0, 0);
            this.ucMedicos1.Name = "ucMedicos1";
            this.ucMedicos1.Padding = new System.Windows.Forms.Padding(20);
            this.ucMedicos1.Size = new System.Drawing.Size(870, 510);
            this.ucMedicos1.TabIndex = 0;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.ClientSize = new System.Drawing.Size(900, 820);
            this.Controls.Add(this.tabGestion);
            this.Controls.Add(this.pnlHeader);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestion Clinica";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.tabGestion.ResumeLayout(false);
            this.tabPageEspecialidades.ResumeLayout(false);
            this.tabPageMedicos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCargaMedicos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
    }
}
