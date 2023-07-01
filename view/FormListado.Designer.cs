namespace view
{
    partial class FormListado
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvPrincipal = new System.Windows.Forms.DataGridView();
            this.pbxImagen = new System.Windows.Forms.PictureBox();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminarFisico = new System.Windows.Forms.Button();
            this.lblFiltrar = new System.Windows.Forms.Label();
            this.cbxFiltrar = new System.Windows.Forms.ComboBox();
            this.lblForma = new System.Windows.Forms.Label();
            this.cbxForma = new System.Windows.Forms.ComboBox();
            this.lblClave = new System.Windows.Forms.Label();
            this.tbxFiltroText = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrincipal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxImagen)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPrincipal
            // 
            this.dgvPrincipal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPrincipal.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvPrincipal.Location = new System.Drawing.Point(1, 72);
            this.dgvPrincipal.MultiSelect = false;
            this.dgvPrincipal.Name = "dgvPrincipal";
            this.dgvPrincipal.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPrincipal.Size = new System.Drawing.Size(648, 284);
            this.dgvPrincipal.TabIndex = 0;
            this.dgvPrincipal.SelectionChanged += new System.EventHandler(this.dgvPrincipal_SelectionChanged);
            // 
            // pbxImagen
            // 
            this.pbxImagen.Location = new System.Drawing.Point(655, 72);
            this.pbxImagen.Name = "pbxImagen";
            this.pbxImagen.Size = new System.Drawing.Size(226, 231);
            this.pbxImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxImagen.TabIndex = 2;
            this.pbxImagen.TabStop = false;
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(187, 395);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(117, 47);
            this.btnModificar.TabIndex = 3;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnEliminarFisico
            // 
            this.btnEliminarFisico.Location = new System.Drawing.Point(30, 395);
            this.btnEliminarFisico.Name = "btnEliminarFisico";
            this.btnEliminarFisico.Size = new System.Drawing.Size(117, 47);
            this.btnEliminarFisico.TabIndex = 4;
            this.btnEliminarFisico.Text = "Eliminar ";
            this.btnEliminarFisico.UseVisualStyleBackColor = true;
            this.btnEliminarFisico.Click += new System.EventHandler(this.btnEliminarFisico_Click);
            // 
            // lblFiltrar
            // 
            this.lblFiltrar.AutoSize = true;
            this.lblFiltrar.Location = new System.Drawing.Point(27, 28);
            this.lblFiltrar.Name = "lblFiltrar";
            this.lblFiltrar.Size = new System.Drawing.Size(56, 13);
            this.lblFiltrar.TabIndex = 5;
            this.lblFiltrar.Text = "Filtrar por: ";
            // 
            // cbxFiltrar
            // 
            this.cbxFiltrar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxFiltrar.FormattingEnabled = true;
            this.cbxFiltrar.Location = new System.Drawing.Point(99, 25);
            this.cbxFiltrar.Name = "cbxFiltrar";
            this.cbxFiltrar.Size = new System.Drawing.Size(116, 21);
            this.cbxFiltrar.TabIndex = 6;
            this.cbxFiltrar.SelectedIndexChanged += new System.EventHandler(this.cbxFiltrar_SelectedIndexChanged);
            // 
            // lblForma
            // 
            this.lblForma.AutoSize = true;
            this.lblForma.Location = new System.Drawing.Point(231, 28);
            this.lblForma.Name = "lblForma";
            this.lblForma.Size = new System.Drawing.Size(39, 13);
            this.lblForma.TabIndex = 7;
            this.lblForma.Text = "Forma:";
            // 
            // cbxForma
            // 
            this.cbxForma.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxForma.FormattingEnabled = true;
            this.cbxForma.Location = new System.Drawing.Point(286, 25);
            this.cbxForma.Name = "cbxForma";
            this.cbxForma.Size = new System.Drawing.Size(116, 21);
            this.cbxForma.TabIndex = 8;
            // 
            // lblClave
            // 
            this.lblClave.AutoSize = true;
            this.lblClave.Location = new System.Drawing.Point(418, 28);
            this.lblClave.Name = "lblClave";
            this.lblClave.Size = new System.Drawing.Size(37, 13);
            this.lblClave.TabIndex = 9;
            this.lblClave.Text = "Clave:";
            // 
            // tbxFiltroText
            // 
            this.tbxFiltroText.Location = new System.Drawing.Point(471, 26);
            this.tbxFiltroText.Name = "tbxFiltroText";
            this.tbxFiltroText.Size = new System.Drawing.Size(116, 20);
            this.tbxFiltroText.TabIndex = 10;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(603, 25);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(116, 23);
            this.btnBuscar.TabIndex = 11;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // FormListado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.ClientSize = new System.Drawing.Size(891, 657);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.tbxFiltroText);
            this.Controls.Add(this.lblClave);
            this.Controls.Add(this.cbxForma);
            this.Controls.Add(this.lblForma);
            this.Controls.Add(this.cbxFiltrar);
            this.Controls.Add(this.lblFiltrar);
            this.Controls.Add(this.btnEliminarFisico);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.pbxImagen);
            this.Controls.Add(this.dgvPrincipal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormListado";
            this.Text = "Articulos";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrincipal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxImagen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPrincipal;
        private System.Windows.Forms.PictureBox pbxImagen;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminarFisico;
        private System.Windows.Forms.Label lblFiltrar;
        private System.Windows.Forms.ComboBox cbxFiltrar;
        private System.Windows.Forms.Label lblForma;
        private System.Windows.Forms.ComboBox cbxForma;
        private System.Windows.Forms.Label lblClave;
        private System.Windows.Forms.TextBox tbxFiltroText;
        private System.Windows.Forms.Button btnBuscar;
    }
}

