
namespace ClinicaVeterinaria
{
    partial class ViewCitas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewCitas));
            this.btnAgregarCita = new System.Windows.Forms.Button();
            this.btnEditarCita = new System.Windows.Forms.Button();
            this.btnEliminarCita = new System.Windows.Forms.Button();
            this.dgvListaCitas = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaCitas)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAgregarCita
            // 
            this.btnAgregarCita.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarCita.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregarCita.Image")));
            this.btnAgregarCita.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAgregarCita.Location = new System.Drawing.Point(12, 497);
            this.btnAgregarCita.Name = "btnAgregarCita";
            this.btnAgregarCita.Size = new System.Drawing.Size(122, 36);
            this.btnAgregarCita.TabIndex = 37;
            this.btnAgregarCita.Text = "Agregar Cita";
            this.btnAgregarCita.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregarCita.UseVisualStyleBackColor = true;
            this.btnAgregarCita.Click += new System.EventHandler(this.btnAgregarCita_Click);
            // 
            // btnEditarCita
            // 
            this.btnEditarCita.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarCita.Image = ((System.Drawing.Image)(resources.GetObject("btnEditarCita.Image")));
            this.btnEditarCita.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEditarCita.Location = new System.Drawing.Point(718, 497);
            this.btnEditarCita.Name = "btnEditarCita";
            this.btnEditarCita.Size = new System.Drawing.Size(108, 36);
            this.btnEditarCita.TabIndex = 36;
            this.btnEditarCita.Text = "Editar Cita";
            this.btnEditarCita.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditarCita.UseVisualStyleBackColor = true;
            // 
            // btnEliminarCita
            // 
            this.btnEliminarCita.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarCita.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminarCita.Image")));
            this.btnEliminarCita.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEliminarCita.Location = new System.Drawing.Point(848, 497);
            this.btnEliminarCita.Name = "btnEliminarCita";
            this.btnEliminarCita.Size = new System.Drawing.Size(127, 36);
            this.btnEliminarCita.TabIndex = 35;
            this.btnEliminarCita.Text = "Eliminar Cita";
            this.btnEliminarCita.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminarCita.UseVisualStyleBackColor = true;
            // 
            // dgvListaCitas
            // 
            this.dgvListaCitas.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dgvListaCitas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvListaCitas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaCitas.Location = new System.Drawing.Point(14, 12);
            this.dgvListaCitas.Name = "dgvListaCitas";
            this.dgvListaCitas.Size = new System.Drawing.Size(963, 468);
            this.dgvListaCitas.TabIndex = 34;
            // 
            // ViewCitas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(989, 549);
            this.Controls.Add(this.btnAgregarCita);
            this.Controls.Add(this.btnEditarCita);
            this.Controls.Add(this.btnEliminarCita);
            this.Controls.Add(this.dgvListaCitas);
            this.Name = "ViewCitas";
            this.Text = "ViewCitas";
            this.Load += new System.EventHandler(this.ViewCitas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaCitas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAgregarCita;
        private System.Windows.Forms.Button btnEditarCita;
        private System.Windows.Forms.Button btnEliminarCita;
        private System.Windows.Forms.DataGridView dgvListaCitas;
    }
}