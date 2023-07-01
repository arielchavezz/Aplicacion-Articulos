namespace view
{
    partial class FormAgregarMarca
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            System.Windows.Forms.Label lblMarca;
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnCancelarMarca = new System.Windows.Forms.Button();
            this.dgvMarca = new System.Windows.Forms.DataGridView();
            this.tbxAgregarMarca = new System.Windows.Forms.TextBox();
            this.btnEliminarMarca = new System.Windows.Forms.Button();
            lblMarca = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMarca)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMarca
            // 
            lblMarca.AutoSize = true;
            lblMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            lblMarca.Location = new System.Drawing.Point(407, 173);
            lblMarca.Name = "lblMarca";
            lblMarca.Size = new System.Drawing.Size(48, 16);
            lblMarca.TabIndex = 0;
            lblMarca.Text = "Marca:";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(410, 244);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 2;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnCancelarMarca
            // 
            this.btnCancelarMarca.Location = new System.Drawing.Point(527, 244);
            this.btnCancelarMarca.Name = "btnCancelarMarca";
            this.btnCancelarMarca.Size = new System.Drawing.Size(75, 23);
            this.btnCancelarMarca.TabIndex = 3;
            this.btnCancelarMarca.Text = "Cancelar";
            this.btnCancelarMarca.UseVisualStyleBackColor = true;
            this.btnCancelarMarca.Click += new System.EventHandler(this.btnCancelarMarca_Click);
            // 
            // dgvMarca
            // 
            this.dgvMarca.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMarca.Location = new System.Drawing.Point(46, 130);
            this.dgvMarca.Name = "dgvMarca";
            this.dgvMarca.Size = new System.Drawing.Size(264, 203);
            this.dgvMarca.TabIndex = 4;
            this.dgvMarca.SelectionChanged += new System.EventHandler(this.dgvMarca_SelectionChanged);
            // 
            // tbxAgregarMarca
            // 
            this.tbxAgregarMarca.Location = new System.Drawing.Point(410, 201);
            this.tbxAgregarMarca.Name = "tbxAgregarMarca";
            this.tbxAgregarMarca.Size = new System.Drawing.Size(100, 20);
            this.tbxAgregarMarca.TabIndex = 5;
            // 
            // btnEliminarMarca
            // 
            this.btnEliminarMarca.Location = new System.Drawing.Point(46, 367);
            this.btnEliminarMarca.Name = "btnEliminarMarca";
            this.btnEliminarMarca.Size = new System.Drawing.Size(75, 23);
            this.btnEliminarMarca.TabIndex = 7;
            this.btnEliminarMarca.Text = "Eliminar";
            this.btnEliminarMarca.UseVisualStyleBackColor = true;
            this.btnEliminarMarca.Click += new System.EventHandler(this.btnEliminarMarca_Click);
            // 
            // FormAgregarMarca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(891, 657);
            this.Controls.Add(this.btnEliminarMarca);
            this.Controls.Add(this.tbxAgregarMarca);
            this.Controls.Add(this.dgvMarca);
            this.Controls.Add(this.btnCancelarMarca);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(lblMarca);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormAgregarMarca";
            this.Text = "FormAgregarMarca";
            this.Load += new System.EventHandler(this.FormAgregarMarca_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMarca)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnCancelarMarca;
        private System.Windows.Forms.DataGridView dgvMarca;
        private System.Windows.Forms.TextBox tbxAgregarMarca;
        private System.Windows.Forms.Button btnEliminarMarca;
    }
}