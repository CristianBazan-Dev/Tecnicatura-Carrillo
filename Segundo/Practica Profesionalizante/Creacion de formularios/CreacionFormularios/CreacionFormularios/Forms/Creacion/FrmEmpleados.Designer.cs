
namespace CreacionFormularios.Forms.Creacion
{
    partial class FrmEmpleados
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
            this.TxtApellido = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtDni = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtTelefono = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtHorario = new System.Windows.Forms.TextBox();
            this.CrearEmpleadoBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TxtApellido
            // 
            this.TxtApellido.Location = new System.Drawing.Point(35, 44);
            this.TxtApellido.Name = "TxtApellido";
            this.TxtApellido.Size = new System.Drawing.Size(257, 20);
            this.TxtApellido.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Apellido";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nombre";
            // 
            // TxtNombre
            // 
            this.TxtNombre.Location = new System.Drawing.Point(35, 111);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(257, 20);
            this.TxtNombre.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "DNI";
            // 
            // TxtDni
            // 
            this.TxtDni.Location = new System.Drawing.Point(35, 177);
            this.TxtDni.Name = "TxtDni";
            this.TxtDni.Size = new System.Drawing.Size(257, 20);
            this.TxtDni.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 223);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Telefono";
            // 
            // TxtTelefono
            // 
            this.TxtTelefono.Location = new System.Drawing.Point(35, 242);
            this.TxtTelefono.Name = "TxtTelefono";
            this.TxtTelefono.Size = new System.Drawing.Size(257, 20);
            this.TxtTelefono.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(35, 278);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Horario";
            // 
            // TxtHorario
            // 
            this.TxtHorario.Location = new System.Drawing.Point(35, 297);
            this.TxtHorario.Name = "TxtHorario";
            this.TxtHorario.Size = new System.Drawing.Size(257, 20);
            this.TxtHorario.TabIndex = 8;
            // 
            // CrearEmpleadoBtn
            // 
            this.CrearEmpleadoBtn.Location = new System.Drawing.Point(138, 369);
            this.CrearEmpleadoBtn.Name = "CrearEmpleadoBtn";
            this.CrearEmpleadoBtn.Size = new System.Drawing.Size(75, 23);
            this.CrearEmpleadoBtn.TabIndex = 10;
            this.CrearEmpleadoBtn.Text = "Crear";
            this.CrearEmpleadoBtn.UseVisualStyleBackColor = true;
            this.CrearEmpleadoBtn.Click += new System.EventHandler(this.CrearEmpleadoBtn_Click);
            // 
            // FrmEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 404);
            this.Controls.Add(this.CrearEmpleadoBtn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TxtHorario);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TxtTelefono);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtDni);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtNombre);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtApellido);
            this.Name = "FrmEmpleados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmEmpleados";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtApellido;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtDni;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtTelefono;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtHorario;
        private System.Windows.Forms.Button CrearEmpleadoBtn;
    }
}