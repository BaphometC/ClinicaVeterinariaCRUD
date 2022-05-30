
namespace ClinicaVeterinaria
{
    partial class ViewDoctores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewDoctores));
            this.btnAgregarDoctor = new System.Windows.Forms.Button();
            this.btnEditarDoctor = new System.Windows.Forms.Button();
            this.btnEliminarDoctor = new System.Windows.Forms.Button();
            this.dgvListaDoctor = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaDoctor)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAgregarDoctor
            // 
            this.btnAgregarDoctor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarDoctor.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregarDoctor.Image")));
            this.btnAgregarDoctor.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAgregarDoctor.Location = new System.Drawing.Point(13, 500);
            this.btnAgregarDoctor.Name = "btnAgregarDoctor";
            this.btnAgregarDoctor.Size = new System.Drawing.Size(138, 36);
            this.btnAgregarDoctor.TabIndex = 35;
            this.btnAgregarDoctor.Text = "Agregar Doctor";
            this.btnAgregarDoctor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregarDoctor.UseVisualStyleBackColor = true;
            this.btnAgregarDoctor.Click += new System.EventHandler(this.btnAgregarDoctor_Click);
            // 
            // btnEditarDoctor
            // 
            this.btnEditarDoctor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarDoctor.Image = ((System.Drawing.Image)(resources.GetObject("btnEditarDoctor.Image")));
            this.btnEditarDoctor.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEditarDoctor.Location = new System.Drawing.Point(498, 500);
            this.btnEditarDoctor.Name = "btnEditarDoctor";
            this.btnEditarDoctor.Size = new System.Drawing.Size(125, 36);
            this.btnEditarDoctor.TabIndex = 34;
            this.btnEditarDoctor.Text = "Editar Doctor";
            this.btnEditarDoctor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditarDoctor.UseVisualStyleBackColor = true;
            // 
            // btnEliminarDoctor
            // 
            this.btnEliminarDoctor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarDoctor.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminarDoctor.Image")));
            this.btnEliminarDoctor.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEliminarDoctor.Location = new System.Drawing.Point(646, 500);
            this.btnEliminarDoctor.Name = "btnEliminarDoctor";
            this.btnEliminarDoctor.Size = new System.Drawing.Size(142, 36);
            this.btnEliminarDoctor.TabIndex = 33;
            this.btnEliminarDoctor.Text = "Eliminar Doctor";
            this.btnEliminarDoctor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminarDoctor.UseVisualStyleBackColor = true;
            // 
            // dgvListaDoctor
            // 
            this.dgvListaDoctor.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvListaDoctor.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvListaDoctor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaDoctor.Location = new System.Drawing.Point(12, 12);
            this.dgvListaDoctor.Name = "dgvListaDoctor";
            this.dgvListaDoctor.Size = new System.Drawing.Size(776, 468);
            this.dgvListaDoctor.TabIndex = 32;
            this.dgvListaDoctor.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListaDoctor_CellContentClick);
            // 
            // ViewDoctores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 547);
            this.Controls.Add(this.btnAgregarDoctor);
            this.Controls.Add(this.btnEditarDoctor);
            this.Controls.Add(this.btnEliminarDoctor);
            this.Controls.Add(this.dgvListaDoctor);
            this.Name = "ViewDoctores";
            this.Text = "ViewDoctores";
            this.Load += new System.EventHandler(this.ViewDoctores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaDoctor)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAgregarDoctor;
        private System.Windows.Forms.Button btnEditarDoctor;
        private System.Windows.Forms.Button btnEliminarDoctor;
        private System.Windows.Forms.DataGridView dgvListaDoctor;
    }
}