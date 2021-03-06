
namespace ClinicaVeterinaria
{
    partial class ViewMascotas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewMascotas));
            this.btnEditarMascota = new System.Windows.Forms.Button();
            this.btnEliminarCliente = new System.Windows.Forms.Button();
            this.btnAgregarDueñoMascota = new System.Windows.Forms.Button();
            this.btnAgregarMascotaCita = new System.Windows.Forms.Button();
            this.dgvListaClientes = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEditarMascota
            // 
            this.btnEditarMascota.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarMascota.Image = ((System.Drawing.Image)(resources.GetObject("btnEditarMascota.Image")));
            this.btnEditarMascota.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEditarMascota.Location = new System.Drawing.Point(583, 498);
            this.btnEditarMascota.Name = "btnEditarMascota";
            this.btnEditarMascota.Size = new System.Drawing.Size(135, 36);
            this.btnEditarMascota.TabIndex = 33;
            this.btnEditarMascota.Text = "Editar Mascota";
            this.btnEditarMascota.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditarMascota.UseVisualStyleBackColor = true;
            this.btnEditarMascota.Click += new System.EventHandler(this.btnEditarMascota_Click);
            // 
            // btnEliminarCliente
            // 
            this.btnEliminarCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarCliente.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminarCliente.Image")));
            this.btnEliminarCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEliminarCliente.Location = new System.Drawing.Point(420, 498);
            this.btnEliminarCliente.Name = "btnEliminarCliente";
            this.btnEliminarCliente.Size = new System.Drawing.Size(142, 36);
            this.btnEliminarCliente.TabIndex = 32;
            this.btnEliminarCliente.Text = "Eliminar Cliente";
            this.btnEliminarCliente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminarCliente.UseVisualStyleBackColor = true;
            this.btnEliminarCliente.Click += new System.EventHandler(this.btnEliminarCliente_Click);
            // 
            // btnAgregarDueñoMascota
            // 
            this.btnAgregarDueñoMascota.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarDueñoMascota.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregarDueñoMascota.Image")));
            this.btnAgregarDueñoMascota.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAgregarDueñoMascota.Location = new System.Drawing.Point(26, 540);
            this.btnAgregarDueñoMascota.Name = "btnAgregarDueñoMascota";
            this.btnAgregarDueñoMascota.Size = new System.Drawing.Size(146, 36);
            this.btnAgregarDueñoMascota.TabIndex = 31;
            this.btnAgregarDueñoMascota.Text = "Agregar Dueño";
            this.btnAgregarDueñoMascota.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregarDueñoMascota.UseVisualStyleBackColor = true;
            this.btnAgregarDueñoMascota.Click += new System.EventHandler(this.btnAgregarDueñoMascota_Click);
            // 
            // btnAgregarMascotaCita
            // 
            this.btnAgregarMascotaCita.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarMascotaCita.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregarMascotaCita.Image")));
            this.btnAgregarMascotaCita.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAgregarMascotaCita.Location = new System.Drawing.Point(26, 498);
            this.btnAgregarMascotaCita.Name = "btnAgregarMascotaCita";
            this.btnAgregarMascotaCita.Size = new System.Drawing.Size(146, 36);
            this.btnAgregarMascotaCita.TabIndex = 30;
            this.btnAgregarMascotaCita.Text = "Agregar Mascota";
            this.btnAgregarMascotaCita.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregarMascotaCita.UseVisualStyleBackColor = true;
            this.btnAgregarMascotaCita.Click += new System.EventHandler(this.btnAgregarMascotaCita_Click);
            // 
            // dgvListaClientes
            // 
            this.dgvListaClientes.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dgvListaClientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvListaClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaClientes.Location = new System.Drawing.Point(12, 12);
            this.dgvListaClientes.Name = "dgvListaClientes";
            this.dgvListaClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListaClientes.Size = new System.Drawing.Size(706, 468);
            this.dgvListaClientes.TabIndex = 29;
            // 
            // ViewMascotas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(732, 587);
            this.Controls.Add(this.btnEditarMascota);
            this.Controls.Add(this.btnEliminarCliente);
            this.Controls.Add(this.btnAgregarDueñoMascota);
            this.Controls.Add(this.btnAgregarMascotaCita);
            this.Controls.Add(this.dgvListaClientes);
            this.Name = "ViewMascotas";
            this.Text = "VistaPacientes";
            this.Load += new System.EventHandler(this.VistaPacientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaClientes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnEditarMascota;
        private System.Windows.Forms.Button btnEliminarCliente;
        private System.Windows.Forms.Button btnAgregarDueñoMascota;
        private System.Windows.Forms.Button btnAgregarMascotaCita;
        private System.Windows.Forms.DataGridView dgvListaClientes;
    }
}