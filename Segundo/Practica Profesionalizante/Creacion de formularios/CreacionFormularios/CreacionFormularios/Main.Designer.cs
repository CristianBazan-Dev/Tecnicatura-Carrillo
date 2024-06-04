
namespace CreacionFormularios
{
    partial class Main
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
            this.BtnLibrary = new FontAwesome.Sharp.IconButton();
            this.BtnProfesors = new FontAwesome.Sharp.IconButton();
            this.BtnStudents = new FontAwesome.Sharp.IconButton();
            this.BtnClose = new FontAwesome.Sharp.IconButton();
            this.SuspendLayout();
            // 
            // BtnLibrary
            // 
            this.BtnLibrary.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnLibrary.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLibrary.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.BtnLibrary.IconChar = FontAwesome.Sharp.IconChar.BookOpen;
            this.BtnLibrary.IconColor = System.Drawing.Color.DeepSkyBlue;
            this.BtnLibrary.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnLibrary.Location = new System.Drawing.Point(12, 12);
            this.BtnLibrary.Name = "BtnLibrary";
            this.BtnLibrary.Size = new System.Drawing.Size(124, 89);
            this.BtnLibrary.TabIndex = 1;
            this.BtnLibrary.Text = "Biblioteca";
            this.BtnLibrary.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BtnLibrary.UseVisualStyleBackColor = true;
            this.BtnLibrary.Click += new System.EventHandler(this.BtnLibrary_Click);
            // 
            // BtnProfesors
            // 
            this.BtnProfesors.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnProfesors.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnProfesors.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.BtnProfesors.IconChar = FontAwesome.Sharp.IconChar.UserGraduate;
            this.BtnProfesors.IconColor = System.Drawing.Color.DeepSkyBlue;
            this.BtnProfesors.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnProfesors.Location = new System.Drawing.Point(166, 12);
            this.BtnProfesors.Name = "BtnProfesors";
            this.BtnProfesors.Size = new System.Drawing.Size(124, 89);
            this.BtnProfesors.TabIndex = 2;
            this.BtnProfesors.Text = "Profesores";
            this.BtnProfesors.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BtnProfesors.UseVisualStyleBackColor = true;
            this.BtnProfesors.Click += new System.EventHandler(this.BtnProfesors_Click);
            // 
            // BtnStudents
            // 
            this.BtnStudents.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnStudents.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnStudents.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.BtnStudents.IconChar = FontAwesome.Sharp.IconChar.UsersLine;
            this.BtnStudents.IconColor = System.Drawing.Color.DeepSkyBlue;
            this.BtnStudents.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnStudents.Location = new System.Drawing.Point(320, 12);
            this.BtnStudents.Name = "BtnStudents";
            this.BtnStudents.Size = new System.Drawing.Size(124, 89);
            this.BtnStudents.TabIndex = 3;
            this.BtnStudents.Text = "Estudiantes";
            this.BtnStudents.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BtnStudents.UseVisualStyleBackColor = true;
            this.BtnStudents.Click += new System.EventHandler(this.BtnStudents_Click);
            // 
            // BtnClose
            // 
            this.BtnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnClose.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnClose.ForeColor = System.Drawing.Color.Firebrick;
            this.BtnClose.IconChar = FontAwesome.Sharp.IconChar.DoorOpen;
            this.BtnClose.IconColor = System.Drawing.Color.Firebrick;
            this.BtnClose.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnClose.Location = new System.Drawing.Point(664, 12);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(124, 89);
            this.BtnClose.TabIndex = 4;
            this.BtnClose.Text = "Salir";
            this.BtnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BtnClose.UseVisualStyleBackColor = true;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnClose);
            this.Controls.Add(this.BtnStudents);
            this.Controls.Add(this.BtnProfesors);
            this.Controls.Add(this.BtnLibrary);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Main_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private FontAwesome.Sharp.IconButton BtnLibrary;
        private FontAwesome.Sharp.IconButton BtnProfesors;
        private FontAwesome.Sharp.IconButton BtnStudents;
        private FontAwesome.Sharp.IconButton BtnClose;
    }
}

