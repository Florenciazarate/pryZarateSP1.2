namespace pryZarateSP1._2.Controls
{
    partial class ucEspecialidades
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblSubtitulo;
        private System.Windows.Forms.Panel pnlFormulario;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Panel pnlGrid;
        private System.Windows.Forms.Label lblListado;
        private System.Windows.Forms.DataGridView dgvEspecialidades;

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
            System.Windows.Forms.DataGridViewCellStyle dgvEstiloHeader = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dgvEstiloCelda = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dgvEstiloAlternado = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblSubtitulo = new System.Windows.Forms.Label();
            this.pnlFormulario = new System.Windows.Forms.Panel();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.lblId = new System.Windows.Forms.Label();
            this.pnlGrid = new System.Windows.Forms.Panel();
            this.dgvEspecialidades = new System.Windows.Forms.DataGridView();
            this.lblListado = new System.Windows.Forms.Label();
            this.pnlFormulario.SuspendLayout();
            this.pnlGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEspecialidades)).BeginInit();
            this.SuspendLayout();
            //
            // lblTitulo
            //
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(44, 122, 123);
            this.lblTitulo.Location = new System.Drawing.Point(20, 18);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(290, 30);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Gestion de Especialidades";
            //
            // lblSubtitulo
            //
            this.lblSubtitulo.AutoSize = true;
            this.lblSubtitulo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblSubtitulo.ForeColor = System.Drawing.Color.FromArgb(113, 128, 150);
            this.lblSubtitulo.Location = new System.Drawing.Point(22, 52);
            this.lblSubtitulo.Name = "lblSubtitulo";
            this.lblSubtitulo.Size = new System.Drawing.Size(300, 15);
            this.lblSubtitulo.TabIndex = 1;
            this.lblSubtitulo.Text = "De de alta las especialidades disponibles en la clinica.";
            //
            // pnlFormulario
            //
            this.pnlFormulario.BackColor = System.Drawing.Color.White;
            this.pnlFormulario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlFormulario.Controls.Add(this.btnAgregar);
            this.pnlFormulario.Controls.Add(this.txtNombre);
            this.pnlFormulario.Controls.Add(this.lblNombre);
            this.pnlFormulario.Controls.Add(this.txtId);
            this.pnlFormulario.Controls.Add(this.lblId);
            this.pnlFormulario.Location = new System.Drawing.Point(20, 82);
            this.pnlFormulario.Name = "pnlFormulario";
            this.pnlFormulario.Padding = new System.Windows.Forms.Padding(18);
            this.pnlFormulario.Size = new System.Drawing.Size(710, 110);
            this.pnlFormulario.TabIndex = 2;
            //
            // lblId
            //
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblId.ForeColor = System.Drawing.Color.FromArgb(45, 55, 72);
            this.lblId.Location = new System.Drawing.Point(18, 14);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(72, 15);
            this.lblId.TabIndex = 0;
            this.lblId.Text = "Numero (Id)";
            //
            // txtId
            //
            this.txtId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtId.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtId.Location = new System.Drawing.Point(18, 34);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(140, 23);
            this.txtId.TabIndex = 1;
            //
            // lblNombre
            //
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblNombre.ForeColor = System.Drawing.Color.FromArgb(45, 55, 72);
            this.lblNombre.Location = new System.Drawing.Point(180, 14);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(52, 15);
            this.lblNombre.TabIndex = 2;
            this.lblNombre.Text = "Nombre";
            //
            // txtNombre
            //
            this.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNombre.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtNombre.Location = new System.Drawing.Point(180, 34);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(300, 23);
            this.txtNombre.TabIndex = 3;
            //
            // btnAgregar
            //
            this.btnAgregar.BackColor = System.Drawing.Color.FromArgb(44, 122, 123);
            this.btnAgregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregar.FlatAppearance.BorderSize = 0;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnAgregar.ForeColor = System.Drawing.Color.White;
            this.btnAgregar.Location = new System.Drawing.Point(510, 33);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(180, 36);
            this.btnAgregar.TabIndex = 4;
            this.btnAgregar.Text = "Agregar Especialidad";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            this.btnAgregar.MouseEnter += new System.EventHandler(this.btnAgregar_MouseEnter);
            this.btnAgregar.MouseLeave += new System.EventHandler(this.btnAgregar_MouseLeave);
            //
            // pnlGrid
            //
            this.pnlGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlGrid.BackColor = System.Drawing.Color.White;
            this.pnlGrid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlGrid.Controls.Add(this.dgvEspecialidades);
            this.pnlGrid.Controls.Add(this.lblListado);
            this.pnlGrid.Location = new System.Drawing.Point(20, 205);
            this.pnlGrid.Name = "pnlGrid";
            this.pnlGrid.Size = new System.Drawing.Size(710, 240);
            this.pnlGrid.TabIndex = 3;
            //
            // lblListado
            //
            this.lblListado.AutoSize = true;
            this.lblListado.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.lblListado.ForeColor = System.Drawing.Color.FromArgb(45, 55, 72);
            this.lblListado.Location = new System.Drawing.Point(16, 12);
            this.lblListado.Name = "lblListado";
            this.lblListado.Size = new System.Drawing.Size(180, 19);
            this.lblListado.TabIndex = 0;
            this.lblListado.Text = "Especialidades registradas";
            //
            // dgvEspecialidades
            //
            dgvEstiloHeader.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dgvEstiloHeader.BackColor = System.Drawing.Color.FromArgb(44, 122, 123);
            dgvEstiloHeader.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold);
            dgvEstiloHeader.ForeColor = System.Drawing.Color.White;
            dgvEstiloHeader.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            dgvEstiloHeader.SelectionBackColor = System.Drawing.Color.FromArgb(44, 122, 123);
            dgvEstiloHeader.SelectionForeColor = System.Drawing.Color.White;
            this.dgvEspecialidades.ColumnHeadersDefaultCellStyle = dgvEstiloHeader;
            this.dgvEspecialidades.AllowUserToAddRows = false;
            this.dgvEspecialidades.AllowUserToDeleteRows = false;
            this.dgvEspecialidades.AllowUserToResizeRows = false;
            this.dgvEspecialidades.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvEspecialidades.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEspecialidades.BackgroundColor = System.Drawing.Color.White;
            this.dgvEspecialidades.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvEspecialidades.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvEspecialidades.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvEspecialidades.ColumnHeadersHeight = 38;
            dgvEstiloCelda.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dgvEstiloCelda.BackColor = System.Drawing.Color.White;
            dgvEstiloCelda.Font = new System.Drawing.Font("Segoe UI", 9F);
            dgvEstiloCelda.ForeColor = System.Drawing.Color.FromArgb(45, 55, 72);
            dgvEstiloCelda.Padding = new System.Windows.Forms.Padding(6, 0, 0, 0);
            dgvEstiloCelda.SelectionBackColor = System.Drawing.Color.FromArgb(237, 248, 248);
            dgvEstiloCelda.SelectionForeColor = System.Drawing.Color.FromArgb(45, 55, 72);
            this.dgvEspecialidades.DefaultCellStyle = dgvEstiloCelda;
            dgvEstiloAlternado.BackColor = System.Drawing.Color.FromArgb(249, 250, 251);
            this.dgvEspecialidades.AlternatingRowsDefaultCellStyle = dgvEstiloAlternado;
            this.dgvEspecialidades.EnableHeadersVisualStyles = false;
            this.dgvEspecialidades.GridColor = System.Drawing.Color.FromArgb(226, 232, 240);
            this.dgvEspecialidades.Location = new System.Drawing.Point(12, 40);
            this.dgvEspecialidades.MultiSelect = false;
            this.dgvEspecialidades.Name = "dgvEspecialidades";
            this.dgvEspecialidades.ReadOnly = true;
            this.dgvEspecialidades.RowHeadersVisible = false;
            this.dgvEspecialidades.RowTemplate.Height = 32;
            this.dgvEspecialidades.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEspecialidades.Size = new System.Drawing.Size(684, 186);
            this.dgvEspecialidades.TabIndex = 1;
            //
            // ucEspecialidades
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(247, 250, 252);
            this.Controls.Add(this.pnlGrid);
            this.Controls.Add(this.pnlFormulario);
            this.Controls.Add(this.lblSubtitulo);
            this.Controls.Add(this.lblTitulo);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Name = "ucEspecialidades";
            this.Padding = new System.Windows.Forms.Padding(20);
            this.Size = new System.Drawing.Size(752, 465);
            this.pnlFormulario.ResumeLayout(false);
            this.pnlFormulario.PerformLayout();
            this.pnlGrid.ResumeLayout(false);
            this.pnlGrid.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEspecialidades)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion
    }
}
