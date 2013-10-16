namespace Sistema_de__Inventarios
{
    partial class Login
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnIngresar = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_user = new System.Windows.Forms.TextBox();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.btn_Visitante = new System.Windows.Forms.Button();
            this.panelLogin = new System.Windows.Forms.Panel();
            this.panelVisitante = new System.Windows.Forms.Panel();
            this.panel_Master = new System.Windows.Forms.Panel();
            this.btn_despacho = new System.Windows.Forms.Button();
            this.btn_cerrarSessionMaster = new System.Windows.Forms.Button();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.txt_codigoRequerimiento = new System.Windows.Forms.TextBox();
            this.txt_codigoProducto = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.panelLogin.SuspendLayout();
            this.panelVisitante.SuspendLayout();
            this.panel_Master.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // btnIngresar
            // 
            this.btnIngresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.btnIngresar.Location = new System.Drawing.Point(62, 190);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(75, 34);
            this.btnIngresar.TabIndex = 0;
            this.btnIngresar.Text = "Ingresar";
            this.btnIngresar.UseVisualStyleBackColor = true;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.btn_cancelar.Location = new System.Drawing.Point(404, 190);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(75, 34);
            this.btn_cancelar.TabIndex = 1;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label1.Location = new System.Drawing.Point(58, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Usuario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label2.Location = new System.Drawing.Point(58, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Contraseña";
            // 
            // txt_user
            // 
            this.txt_user.Location = new System.Drawing.Point(214, 27);
            this.txt_user.Name = "txt_user";
            this.txt_user.Size = new System.Drawing.Size(100, 20);
            this.txt_user.TabIndex = 4;
            this.txt_user.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_password
            // 
            this.txt_password.Location = new System.Drawing.Point(214, 69);
            this.txt_password.Name = "txt_password";
            this.txt_password.PasswordChar = '*';
            this.txt_password.Size = new System.Drawing.Size(100, 20);
            this.txt_password.TabIndex = 5;
            this.txt_password.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_Visitante
            // 
            this.btn_Visitante.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.btn_Visitante.Location = new System.Drawing.Point(219, 190);
            this.btn_Visitante.Name = "btn_Visitante";
            this.btn_Visitante.Size = new System.Drawing.Size(95, 34);
            this.btn_Visitante.TabIndex = 6;
            this.btn_Visitante.Text = "Visitante";
            this.btn_Visitante.UseVisualStyleBackColor = true;
            this.btn_Visitante.Click += new System.EventHandler(this.btn_Visitante_Click);
            // 
            // panelLogin
            // 
            this.panelLogin.AutoSize = true;
            this.panelLogin.Controls.Add(this.panelVisitante);
            this.panelLogin.Controls.Add(this.label1);
            this.panelLogin.Controls.Add(this.btn_cancelar);
            this.panelLogin.Controls.Add(this.btn_Visitante);
            this.panelLogin.Controls.Add(this.txt_user);
            this.panelLogin.Controls.Add(this.txt_password);
            this.panelLogin.Controls.Add(this.btnIngresar);
            this.panelLogin.Controls.Add(this.label2);
            this.panelLogin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelLogin.Location = new System.Drawing.Point(0, 0);
            this.panelLogin.Name = "panelLogin";
            this.panelLogin.Size = new System.Drawing.Size(765, 479);
            this.panelLogin.TabIndex = 7;
            // 
            // panelVisitante
            // 
            this.panelVisitante.Controls.Add(this.panel_Master);
            this.panelVisitante.Controls.Add(this.btn_buscar);
            this.panelVisitante.Controls.Add(this.txt_codigoRequerimiento);
            this.panelVisitante.Controls.Add(this.txt_codigoProducto);
            this.panelVisitante.Controls.Add(this.label5);
            this.panelVisitante.Controls.Add(this.label4);
            this.panelVisitante.Controls.Add(this.label3);
            this.panelVisitante.Controls.Add(this.dataGridView);
            this.panelVisitante.Controls.Add(this.button1);
            this.panelVisitante.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelVisitante.Location = new System.Drawing.Point(0, 0);
            this.panelVisitante.Name = "panelVisitante";
            this.panelVisitante.Size = new System.Drawing.Size(765, 479);
            this.panelVisitante.TabIndex = 7;
            this.panelVisitante.Visible = false;
            // 
            // panel_Master
            // 
            this.panel_Master.Controls.Add(this.btn_despacho);
            this.panel_Master.Controls.Add(this.btn_cerrarSessionMaster);
            this.panel_Master.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Master.Location = new System.Drawing.Point(0, 0);
            this.panel_Master.Name = "panel_Master";
            this.panel_Master.Size = new System.Drawing.Size(765, 479);
            this.panel_Master.TabIndex = 9;
            this.panel_Master.Visible = false;
            // 
            // btn_despacho
            // 
            this.btn_despacho.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_despacho.Location = new System.Drawing.Point(62, 50);
            this.btn_despacho.Name = "btn_despacho";
            this.btn_despacho.Size = new System.Drawing.Size(146, 50);
            this.btn_despacho.TabIndex = 1;
            this.btn_despacho.Text = "Despacho";
            this.btn_despacho.UseVisualStyleBackColor = true;
            this.btn_despacho.Click += new System.EventHandler(this.btn_despacho_Click);
            // 
            // btn_cerrarSessionMaster
            // 
            this.btn_cerrarSessionMaster.Location = new System.Drawing.Point(633, 45);
            this.btn_cerrarSessionMaster.Name = "btn_cerrarSessionMaster";
            this.btn_cerrarSessionMaster.Size = new System.Drawing.Size(93, 23);
            this.btn_cerrarSessionMaster.TabIndex = 0;
            this.btn_cerrarSessionMaster.Text = "Cerrar Session";
            this.btn_cerrarSessionMaster.UseVisualStyleBackColor = true;
            this.btn_cerrarSessionMaster.Click += new System.EventHandler(this.btn_cerrarSessionMaster_Click);
            // 
            // btn_buscar
            // 
            this.btn_buscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_buscar.Location = new System.Drawing.Point(404, 94);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(75, 23);
            this.btn_buscar.TabIndex = 8;
            this.btn_buscar.Text = "Buscar";
            this.btn_buscar.UseVisualStyleBackColor = true;
            this.btn_buscar.Click += new System.EventHandler(this.btn_buscar_Click);
            // 
            // txt_codigoRequerimiento
            // 
            this.txt_codigoRequerimiento.Location = new System.Drawing.Point(238, 97);
            this.txt_codigoRequerimiento.Name = "txt_codigoRequerimiento";
            this.txt_codigoRequerimiento.Size = new System.Drawing.Size(100, 20);
            this.txt_codigoRequerimiento.TabIndex = 7;
            // 
            // txt_codigoProducto
            // 
            this.txt_codigoProducto.Location = new System.Drawing.Point(238, 68);
            this.txt_codigoProducto.Name = "txt_codigoProducto";
            this.txt_codigoProducto.Size = new System.Drawing.Size(100, 20);
            this.txt_codigoProducto.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(59, 103);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(151, 15);
            this.label5.TabIndex = 5;
            this.label5.Text = "Código del Requerimiento";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(59, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "Código del Producto";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(23, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 24);
            this.label3.TabIndex = 3;
            this.label3.Text = "Buscar Producto";
            // 
            // dataGridView
            // 
            this.dataGridView.AllowDrop = true;
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.AllowUserToResizeColumns = false;
            this.dataGridView.AllowUserToResizeRows = false;
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView.EnableHeadersVisualStyles = false;
            this.dataGridView.Location = new System.Drawing.Point(27, 168);
            this.dataGridView.MultiSelect = false;
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.Size = new System.Drawing.Size(627, 299);
            this.dataGridView.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(633, 27);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 28);
            this.button1.TabIndex = 0;
            this.button1.Text = "Cerrar Session";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(765, 479);
            this.Controls.Add(this.panelLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Login";
            this.Text = "Ingreso al Sistema";
            this.panelLogin.ResumeLayout(false);
            this.panelLogin.PerformLayout();
            this.panelVisitante.ResumeLayout(false);
            this.panelVisitante.PerformLayout();
            this.panel_Master.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_user;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.Button btn_Visitante;
        private System.Windows.Forms.Panel panelLogin;
        private System.Windows.Forms.Panel panelVisitante;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.TextBox txt_codigoRequerimiento;
        private System.Windows.Forms.TextBox txt_codigoProducto;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel_Master;
        private System.Windows.Forms.Button btn_cerrarSessionMaster;
        private System.Windows.Forms.Button btn_despacho;
    }
}

