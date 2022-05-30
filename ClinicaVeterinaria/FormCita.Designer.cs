
namespace ClinicaVeterinaria
{
    partial class FormCita
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCita));
            this.gpbFormularioCita = new System.Windows.Forms.GroupBox();
            this.btnRegistrarMascotaCita = new System.Windows.Forms.Button();
            this.btnCancelarCita = new System.Windows.Forms.Button();
            this.btnGenerarCita = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPrecioCita = new System.Windows.Forms.TextBox();
            this.cboEstadoCita = new System.Windows.Forms.ComboBox();
            this.dtpHoraCita = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaCita = new System.Windows.Forms.DateTimePicker();
            this.cboNombreMascotaCita = new System.Windows.Forms.ComboBox();
            this.cboNombreDoctorCita = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.gpbFormularioCita.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpbFormularioCita
            // 
            this.gpbFormularioCita.Controls.Add(this.btnRegistrarMascotaCita);
            this.gpbFormularioCita.Controls.Add(this.btnCancelarCita);
            this.gpbFormularioCita.Controls.Add(this.btnGenerarCita);
            this.gpbFormularioCita.Controls.Add(this.label1);
            this.gpbFormularioCita.Controls.Add(this.txtPrecioCita);
            this.gpbFormularioCita.Controls.Add(this.cboEstadoCita);
            this.gpbFormularioCita.Controls.Add(this.dtpHoraCita);
            this.gpbFormularioCita.Controls.Add(this.dtpFechaCita);
            this.gpbFormularioCita.Controls.Add(this.cboNombreMascotaCita);
            this.gpbFormularioCita.Controls.Add(this.cboNombreDoctorCita);
            this.gpbFormularioCita.Controls.Add(this.label2);
            this.gpbFormularioCita.Controls.Add(this.label9);
            this.gpbFormularioCita.Controls.Add(this.label8);
            this.gpbFormularioCita.Controls.Add(this.label7);
            this.gpbFormularioCita.Controls.Add(this.label5);
            this.gpbFormularioCita.Controls.Add(this.label6);
            this.gpbFormularioCita.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbFormularioCita.ForeColor = System.Drawing.Color.Black;
            this.gpbFormularioCita.Location = new System.Drawing.Point(12, 12);
            this.gpbFormularioCita.Name = "gpbFormularioCita";
            this.gpbFormularioCita.Size = new System.Drawing.Size(504, 281);
            this.gpbFormularioCita.TabIndex = 10;
            this.gpbFormularioCita.TabStop = false;
            this.gpbFormularioCita.Text = "Formulario";
            // 
            // btnRegistrarMascotaCita
            // 
            this.btnRegistrarMascotaCita.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrarMascotaCita.Image = ((System.Drawing.Image)(resources.GetObject("btnRegistrarMascotaCita.Image")));
            this.btnRegistrarMascotaCita.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRegistrarMascotaCita.Location = new System.Drawing.Point(68, 229);
            this.btnRegistrarMascotaCita.Name = "btnRegistrarMascotaCita";
            this.btnRegistrarMascotaCita.Size = new System.Drawing.Size(160, 36);
            this.btnRegistrarMascotaCita.TabIndex = 19;
            this.btnRegistrarMascotaCita.Text = "Registrar Mascota";
            this.btnRegistrarMascotaCita.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegistrarMascotaCita.UseVisualStyleBackColor = true;
            this.btnRegistrarMascotaCita.Click += new System.EventHandler(this.btnRegistrarMascotaCita_Click);
            // 
            // btnCancelarCita
            // 
            this.btnCancelarCita.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarCita.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelarCita.Image")));
            this.btnCancelarCita.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelarCita.Location = new System.Drawing.Point(244, 229);
            this.btnCancelarCita.Name = "btnCancelarCita";
            this.btnCancelarCita.Size = new System.Drawing.Size(99, 36);
            this.btnCancelarCita.TabIndex = 18;
            this.btnCancelarCita.Text = "Cancelar";
            this.btnCancelarCita.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelarCita.UseVisualStyleBackColor = true;
            this.btnCancelarCita.Click += new System.EventHandler(this.btnCancelarCita_Click);
            // 
            // btnGenerarCita
            // 
            this.btnGenerarCita.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerarCita.Image = ((System.Drawing.Image)(resources.GetObject("btnGenerarCita.Image")));
            this.btnGenerarCita.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGenerarCita.Location = new System.Drawing.Point(360, 229);
            this.btnGenerarCita.Name = "btnGenerarCita";
            this.btnGenerarCita.Size = new System.Drawing.Size(122, 36);
            this.btnGenerarCita.TabIndex = 17;
            this.btnGenerarCita.Text = "Generar Cita";
            this.btnGenerarCita.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGenerarCita.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(367, 144);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 24);
            this.label1.TabIndex = 16;
            this.label1.Text = "S/.";
            // 
            // txtPrecioCita
            // 
            this.txtPrecioCita.Location = new System.Drawing.Point(404, 140);
            this.txtPrecioCita.Name = "txtPrecioCita";
            this.txtPrecioCita.Size = new System.Drawing.Size(78, 31);
            this.txtPrecioCita.TabIndex = 15;
            // 
            // cboEstadoCita
            // 
            this.cboEstadoCita.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboEstadoCita.FormattingEnabled = true;
            this.cboEstadoCita.Items.AddRange(new object[] {
            "En curso",
            "Pendiente",
            "Realizada"});
            this.cboEstadoCita.Location = new System.Drawing.Point(118, 145);
            this.cboEstadoCita.Name = "cboEstadoCita";
            this.cboEstadoCita.Size = new System.Drawing.Size(136, 26);
            this.cboEstadoCita.TabIndex = 14;
            // 
            // dtpHoraCita
            // 
            this.dtpHoraCita.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpHoraCita.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpHoraCita.Location = new System.Drawing.Point(371, 103);
            this.dtpHoraCita.Name = "dtpHoraCita";
            this.dtpHoraCita.Size = new System.Drawing.Size(111, 24);
            this.dtpHoraCita.TabIndex = 13;
            // 
            // dtpFechaCita
            // 
            this.dtpFechaCita.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaCita.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaCita.Location = new System.Drawing.Point(371, 63);
            this.dtpFechaCita.Name = "dtpFechaCita";
            this.dtpFechaCita.Size = new System.Drawing.Size(111, 24);
            this.dtpFechaCita.TabIndex = 12;
            // 
            // cboNombreMascotaCita
            // 
            this.cboNombreMascotaCita.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboNombreMascotaCita.FormattingEnabled = true;
            this.cboNombreMascotaCita.Location = new System.Drawing.Point(118, 105);
            this.cboNombreMascotaCita.Name = "cboNombreMascotaCita";
            this.cboNombreMascotaCita.Size = new System.Drawing.Size(136, 26);
            this.cboNombreMascotaCita.TabIndex = 11;
            // 
            // cboNombreDoctorCita
            // 
            this.cboNombreDoctorCita.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboNombreDoctorCita.FormattingEnabled = true;
            this.cboNombreDoctorCita.Location = new System.Drawing.Point(118, 65);
            this.cboNombreDoctorCita.Name = "cboNombreDoctorCita";
            this.cboNombreDoctorCita.Size = new System.Drawing.Size(136, 26);
            this.cboNombreDoctorCita.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(42, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Doctor:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(27, 104);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(85, 24);
            this.label9.TabIndex = 8;
            this.label9.Text = "Mascota:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(300, 144);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 24);
            this.label8.TabIndex = 7;
            this.label8.Text = "Precio:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(43, 144);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 24);
            this.label7.TabIndex = 6;
            this.label7.Text = "Estado:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(296, 63);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 24);
            this.label5.TabIndex = 4;
            this.label5.Text = "Fecha:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(309, 103);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 24);
            this.label6.TabIndex = 5;
            this.label6.Text = "Hora:";
            // 
            // FormCita
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 303);
            this.Controls.Add(this.gpbFormularioCita);
            this.Name = "FormCita";
            this.Text = "FormCita";
            this.gpbFormularioCita.ResumeLayout(false);
            this.gpbFormularioCita.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbFormularioCita;
        private System.Windows.Forms.Button btnRegistrarMascotaCita;
        private System.Windows.Forms.Button btnCancelarCita;
        private System.Windows.Forms.Button btnGenerarCita;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPrecioCita;
        private System.Windows.Forms.ComboBox cboEstadoCita;
        private System.Windows.Forms.DateTimePicker dtpHoraCita;
        private System.Windows.Forms.DateTimePicker dtpFechaCita;
        private System.Windows.Forms.ComboBox cboNombreMascotaCita;
        private System.Windows.Forms.ComboBox cboNombreDoctorCita;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}