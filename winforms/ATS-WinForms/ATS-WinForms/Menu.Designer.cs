namespace ATS_WinForms
{
    partial class Menu
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.panelChildForm = new System.Windows.Forms.Panel();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.panelSideMenu = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnReportes = new System.Windows.Forms.Button();
            this.btnDistritos = new System.Windows.Forms.Button();
            this.btnEstudiantes = new System.Windows.Forms.Button();
            this.btnIsntituciones = new System.Windows.Forms.Button();
            this.btnUsuaario = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.lb_NEstudiante = new System.Windows.Forms.Label();
            this.LB_FECHA = new System.Windows.Forms.Label();
            this.LB_HORARIO = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Tiempo = new System.Windows.Forms.Timer(this.components);
            this.lb_CEstudiante = new System.Windows.Forms.Label();
            this.panelChildForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            this.panelSideMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelChildForm
            // 
            this.panelChildForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.panelChildForm.Controls.Add(this.pictureBox9);
            this.panelChildForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelChildForm.Location = new System.Drawing.Point(258, 0);
            this.panelChildForm.Name = "panelChildForm";
            this.panelChildForm.Size = new System.Drawing.Size(951, 759);
            this.panelChildForm.TabIndex = 9;
            // 
            // pictureBox9
            // 
            this.pictureBox9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox9.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox9.Image")));
            this.pictureBox9.Location = new System.Drawing.Point(77, 75);
            this.pictureBox9.MinimumSize = new System.Drawing.Size(706, 493);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(807, 584);
            this.pictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox9.TabIndex = 2;
            this.pictureBox9.TabStop = false;
            // 
            // panelSideMenu
            // 
            this.panelSideMenu.AutoScroll = true;
            this.panelSideMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(1)))), ((int)(((byte)(28)))));
            this.panelSideMenu.Controls.Add(this.btnExit);
            this.panelSideMenu.Controls.Add(this.btnReportes);
            this.panelSideMenu.Controls.Add(this.btnDistritos);
            this.panelSideMenu.Controls.Add(this.btnEstudiantes);
            this.panelSideMenu.Controls.Add(this.btnIsntituciones);
            this.panelSideMenu.Controls.Add(this.btnUsuaario);
            this.panelSideMenu.Controls.Add(this.panelLogo);
            this.panelSideMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSideMenu.Location = new System.Drawing.Point(0, 0);
            this.panelSideMenu.Name = "panelSideMenu";
            this.panelSideMenu.Size = new System.Drawing.Size(258, 759);
            this.panelSideMenu.TabIndex = 8;
            // 
            // btnExit
            // 
            this.btnExit.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.btnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Roboto Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExit.Location = new System.Drawing.Point(0, 700);
            this.btnExit.Name = "btnExit";
            this.btnExit.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnExit.Size = new System.Drawing.Size(258, 59);
            this.btnExit.TabIndex = 9;
            this.btnExit.Text = "Cerrar sesión";
            this.btnExit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnReportes
            // 
            this.btnReportes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnReportes.FlatAppearance.BorderSize = 0;
            this.btnReportes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.btnReportes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.btnReportes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReportes.Font = new System.Drawing.Font("Roboto SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReportes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.btnReportes.Image = ((System.Drawing.Image)(resources.GetObject("btnReportes.Image")));
            this.btnReportes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReportes.Location = new System.Drawing.Point(0, 573);
            this.btnReportes.Name = "btnReportes";
            this.btnReportes.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnReportes.Size = new System.Drawing.Size(258, 86);
            this.btnReportes.TabIndex = 8;
            this.btnReportes.Text = "Reportes";
            this.btnReportes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReportes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnReportes.UseVisualStyleBackColor = true;
            this.btnReportes.Click += new System.EventHandler(this.btnReportes_Click);
            // 
            // btnDistritos
            // 
            this.btnDistritos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDistritos.FlatAppearance.BorderSize = 0;
            this.btnDistritos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.btnDistritos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnDistritos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDistritos.Font = new System.Drawing.Font("Roboto SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDistritos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.btnDistritos.Image = ((System.Drawing.Image)(resources.GetObject("btnDistritos.Image")));
            this.btnDistritos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDistritos.Location = new System.Drawing.Point(0, 487);
            this.btnDistritos.Name = "btnDistritos";
            this.btnDistritos.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnDistritos.Size = new System.Drawing.Size(258, 86);
            this.btnDistritos.TabIndex = 6;
            this.btnDistritos.Text = "Distritos";
            this.btnDistritos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDistritos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDistritos.UseVisualStyleBackColor = true;
            // 
            // btnEstudiantes
            // 
            this.btnEstudiantes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEstudiantes.FlatAppearance.BorderSize = 0;
            this.btnEstudiantes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.btnEstudiantes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnEstudiantes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEstudiantes.Font = new System.Drawing.Font("Roboto SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEstudiantes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.btnEstudiantes.Image = ((System.Drawing.Image)(resources.GetObject("btnEstudiantes.Image")));
            this.btnEstudiantes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEstudiantes.Location = new System.Drawing.Point(0, 401);
            this.btnEstudiantes.Name = "btnEstudiantes";
            this.btnEstudiantes.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnEstudiantes.Size = new System.Drawing.Size(258, 86);
            this.btnEstudiantes.TabIndex = 5;
            this.btnEstudiantes.Text = "Estudiantes";
            this.btnEstudiantes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEstudiantes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEstudiantes.UseVisualStyleBackColor = true;
            // 
            // btnIsntituciones
            // 
            this.btnIsntituciones.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnIsntituciones.FlatAppearance.BorderSize = 0;
            this.btnIsntituciones.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.btnIsntituciones.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnIsntituciones.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIsntituciones.Font = new System.Drawing.Font("Roboto SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIsntituciones.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.btnIsntituciones.Image = ((System.Drawing.Image)(resources.GetObject("btnIsntituciones.Image")));
            this.btnIsntituciones.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIsntituciones.Location = new System.Drawing.Point(0, 315);
            this.btnIsntituciones.Name = "btnIsntituciones";
            this.btnIsntituciones.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnIsntituciones.Size = new System.Drawing.Size(258, 86);
            this.btnIsntituciones.TabIndex = 3;
            this.btnIsntituciones.Text = "Instituciones";
            this.btnIsntituciones.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIsntituciones.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnIsntituciones.UseVisualStyleBackColor = true;
            // 
            // btnUsuaario
            // 
            this.btnUsuaario.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnUsuaario.FlatAppearance.BorderSize = 0;
            this.btnUsuaario.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.btnUsuaario.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnUsuaario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsuaario.Font = new System.Drawing.Font("Roboto SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsuaario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.btnUsuaario.Image = ((System.Drawing.Image)(resources.GetObject("btnUsuaario.Image")));
            this.btnUsuaario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUsuaario.Location = new System.Drawing.Point(0, 229);
            this.btnUsuaario.Name = "btnUsuaario";
            this.btnUsuaario.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnUsuaario.Size = new System.Drawing.Size(258, 86);
            this.btnUsuaario.TabIndex = 1;
            this.btnUsuaario.Text = "Usuarios";
            this.btnUsuaario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUsuaario.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnUsuaario.UseVisualStyleBackColor = true;
            // 
            // panelLogo
            // 
            this.panelLogo.Controls.Add(this.lb_CEstudiante);
            this.panelLogo.Controls.Add(this.lb_NEstudiante);
            this.panelLogo.Controls.Add(this.LB_FECHA);
            this.panelLogo.Controls.Add(this.LB_HORARIO);
            this.panelLogo.Controls.Add(this.pictureBox1);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(258, 229);
            this.panelLogo.TabIndex = 0;
            // 
            // lb_NEstudiante
            // 
            this.lb_NEstudiante.AutoSize = true;
            this.lb_NEstudiante.BackColor = System.Drawing.Color.Transparent;
            this.lb_NEstudiante.Font = new System.Drawing.Font("Roboto Medium", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_NEstudiante.ForeColor = System.Drawing.Color.White;
            this.lb_NEstudiante.Location = new System.Drawing.Point(67, 154);
            this.lb_NEstudiante.Name = "lb_NEstudiante";
            this.lb_NEstudiante.Size = new System.Drawing.Size(122, 25);
            this.lb_NEstudiante.TabIndex = 3;
            this.lb_NEstudiante.Text = "Estudiante";
            // 
            // LB_FECHA
            // 
            this.LB_FECHA.AutoSize = true;
            this.LB_FECHA.BackColor = System.Drawing.Color.Transparent;
            this.LB_FECHA.Font = new System.Drawing.Font("Roboto Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_FECHA.ForeColor = System.Drawing.Color.White;
            this.LB_FECHA.Location = new System.Drawing.Point(158, 9);
            this.LB_FECHA.Name = "LB_FECHA";
            this.LB_FECHA.Size = new System.Drawing.Size(53, 19);
            this.LB_FECHA.TabIndex = 2;
            this.LB_FECHA.Text = "Fecha";
            // 
            // LB_HORARIO
            // 
            this.LB_HORARIO.AutoSize = true;
            this.LB_HORARIO.BackColor = System.Drawing.Color.Transparent;
            this.LB_HORARIO.Font = new System.Drawing.Font("Roboto Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_HORARIO.ForeColor = System.Drawing.Color.White;
            this.LB_HORARIO.Location = new System.Drawing.Point(12, 9);
            this.LB_HORARIO.Name = "LB_HORARIO";
            this.LB_HORARIO.Size = new System.Drawing.Size(44, 19);
            this.LB_HORARIO.TabIndex = 1;
            this.LB_HORARIO.Text = "Hora";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(63, 48);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(129, 103);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Tiempo
            // 
            this.Tiempo.Enabled = true;
            this.Tiempo.Tick += new System.EventHandler(this.Tiempo_Tick);
            // 
            // lb_CEstudiante
            // 
            this.lb_CEstudiante.AutoSize = true;
            this.lb_CEstudiante.BackColor = System.Drawing.Color.Transparent;
            this.lb_CEstudiante.Font = new System.Drawing.Font("Roboto Medium", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_CEstudiante.ForeColor = System.Drawing.Color.White;
            this.lb_CEstudiante.Location = new System.Drawing.Point(88, 181);
            this.lb_CEstudiante.Name = "lb_CEstudiante";
            this.lb_CEstudiante.Size = new System.Drawing.Size(73, 25);
            this.lb_CEstudiante.TabIndex = 4;
            this.lb_CEstudiante.Text = "Curso";
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1209, 759);
            this.Controls.Add(this.panelChildForm);
            this.Controls.Add(this.panelSideMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Menu_FormClosing);
            this.panelChildForm.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            this.panelSideMenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            this.panelLogo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelChildForm;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.Panel panelSideMenu;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnReportes;
        private System.Windows.Forms.Button btnDistritos;
        private System.Windows.Forms.Button btnEstudiantes;
        private System.Windows.Forms.Button btnIsntituciones;
        private System.Windows.Forms.Button btnUsuaario;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label LB_HORARIO;
        private System.Windows.Forms.Timer Tiempo;
        private System.Windows.Forms.Label LB_FECHA;
        private System.Windows.Forms.Label lb_NEstudiante;
        private System.Windows.Forms.Label lb_CEstudiante;
    }
}