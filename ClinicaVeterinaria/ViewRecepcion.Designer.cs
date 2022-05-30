
namespace ClinicaVeterinaria
{
    partial class ViewRecepcion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewRecepcion));
            this.BtnVistaClientes = new System.Windows.Forms.Button();
            this.BtnVistaDoctores = new System.Windows.Forms.Button();
            this.BtnVistaCitas = new System.Windows.Forms.Button();
            this.gbRecepcionista = new System.Windows.Forms.GroupBox();
            this.lblIDRecepcionista = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblNombreRecepcionista = new System.Windows.Forms.Label();
            this.gbRecepcionista.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnVistaClientes
            // 
            this.BtnVistaClientes.BackColor = System.Drawing.Color.White;
            this.BtnVistaClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnVistaClientes.Image = ((System.Drawing.Image)(resources.GetObject("BtnVistaClientes.Image")));
            this.BtnVistaClientes.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnVistaClientes.Location = new System.Drawing.Point(12, 141);
            this.BtnVistaClientes.Name = "BtnVistaClientes";
            this.BtnVistaClientes.Padding = new System.Windows.Forms.Padding(0, 6, 0, 5);
            this.BtnVistaClientes.Size = new System.Drawing.Size(105, 95);
            this.BtnVistaClientes.TabIndex = 7;
            this.BtnVistaClientes.Text = "Gestion Mascotas";
            this.BtnVistaClientes.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnVistaClientes.UseVisualStyleBackColor = false;
            this.BtnVistaClientes.Click += new System.EventHandler(this.BtnVistaClientes_Click);
            // 
            // BtnVistaDoctores
            // 
            this.BtnVistaDoctores.BackColor = System.Drawing.Color.White;
            this.BtnVistaDoctores.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnVistaDoctores.Image = ((System.Drawing.Image)(resources.GetObject("BtnVistaDoctores.Image")));
            this.BtnVistaDoctores.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnVistaDoctores.Location = new System.Drawing.Point(162, 141);
            this.BtnVistaDoctores.Name = "BtnVistaDoctores";
            this.BtnVistaDoctores.Padding = new System.Windows.Forms.Padding(0, 6, 0, 5);
            this.BtnVistaDoctores.Size = new System.Drawing.Size(105, 95);
            this.BtnVistaDoctores.TabIndex = 6;
            this.BtnVistaDoctores.Text = "Gestion Doctores";
            this.BtnVistaDoctores.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnVistaDoctores.UseVisualStyleBackColor = false;
            this.BtnVistaDoctores.Click += new System.EventHandler(this.BtnVistaDoctores_Click);
            // 
            // BtnVistaCitas
            // 
            this.BtnVistaCitas.BackColor = System.Drawing.Color.White;
            this.BtnVistaCitas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnVistaCitas.Image = ((System.Drawing.Image)(resources.GetObject("BtnVistaCitas.Image")));
            this.BtnVistaCitas.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnVistaCitas.Location = new System.Drawing.Point(308, 141);
            this.BtnVistaCitas.Name = "BtnVistaCitas";
            this.BtnVistaCitas.Padding = new System.Windows.Forms.Padding(0, 6, 0, 5);
            this.BtnVistaCitas.Size = new System.Drawing.Size(105, 95);
            this.BtnVistaCitas.TabIndex = 5;
            this.BtnVistaCitas.Text = "Gestion de Citas";
            this.BtnVistaCitas.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnVistaCitas.UseVisualStyleBackColor = false;
            this.BtnVistaCitas.Click += new System.EventHandler(this.BtnVistaCitas_Click);
            // 
            // gbRecepcionista
            // 
            this.gbRecepcionista.Controls.Add(this.lblIDRecepcionista);
            this.gbRecepcionista.Controls.Add(this.lblId);
            this.gbRecepcionista.Controls.Add(this.lblNombre);
            this.gbRecepcionista.Controls.Add(this.lblNombreRecepcionista);
            this.gbRecepcionista.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbRecepcionista.Location = new System.Drawing.Point(12, 12);
            this.gbRecepcionista.Name = "gbRecepcionista";
            this.gbRecepcionista.Size = new System.Drawing.Size(401, 111);
            this.gbRecepcionista.TabIndex = 4;
            this.gbRecepcionista.TabStop = false;
            this.gbRecepcionista.Text = "Datos Recepcionista";
            this.gbRecepcionista.Enter += new System.EventHandler(this.gbRecepcionista_Enter);
            // 
            // lblIDRecepcionista
            // 
            this.lblIDRecepcionista.AutoSize = true;
            this.lblIDRecepcionista.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIDRecepcionista.Location = new System.Drawing.Point(147, 44);
            this.lblIDRecepcionista.Name = "lblIDRecepcionista";
            this.lblIDRecepcionista.Size = new System.Drawing.Size(95, 18);
            this.lblIDRecepcionista.TabIndex = 3;
            this.lblIDRecepcionista.Text = "placeholder";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(118, 44);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(23, 18);
            this.lblId.TabIndex = 2;
            this.lblId.Text = "Id:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(6, 72);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(135, 18);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre Completo:";
            // 
            // lblNombreRecepcionista
            // 
            this.lblNombreRecepcionista.AutoSize = true;
            this.lblNombreRecepcionista.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreRecepcionista.Location = new System.Drawing.Point(147, 72);
            this.lblNombreRecepcionista.Name = "lblNombreRecepcionista";
            this.lblNombreRecepcionista.Size = new System.Drawing.Size(95, 18);
            this.lblNombreRecepcionista.TabIndex = 0;
            this.lblNombreRecepcionista.Text = "placeholder";
            // 
            // ViewRecepcion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 254);
            this.Controls.Add(this.BtnVistaClientes);
            this.Controls.Add(this.BtnVistaDoctores);
            this.Controls.Add(this.BtnVistaCitas);
            this.Controls.Add(this.gbRecepcionista);
            this.Name = "ViewRecepcion";
            this.Text = "VistaRecepcion";
            this.Load += new System.EventHandler(this.ViewRecepcion_Load);
            this.gbRecepcionista.ResumeLayout(false);
            this.gbRecepcionista.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnVistaClientes;
        private System.Windows.Forms.Button BtnVistaDoctores;
        private System.Windows.Forms.Button BtnVistaCitas;
        private System.Windows.Forms.GroupBox gbRecepcionista;
        private System.Windows.Forms.Label lblIDRecepcionista;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblNombreRecepcionista;
    }
}