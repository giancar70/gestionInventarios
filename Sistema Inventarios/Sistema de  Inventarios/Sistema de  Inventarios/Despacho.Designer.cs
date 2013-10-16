namespace Sistema_de__Inventarios
{
    partial class Despacho
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
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.tbox_requerimiento = new System.Windows.Forms.TextBox();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.dgrid_lista = new System.Windows.Forms.DataGridView();
            this.btn_Confirmar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_lista)).BeginInit();
            this.SuspendLayout();
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(30, 25);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(107, 17);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Por requerimiento";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Codigo de requerimiento";
            // 
            // tbox_requerimiento
            // 
            this.tbox_requerimiento.Location = new System.Drawing.Point(171, 55);
            this.tbox_requerimiento.Name = "tbox_requerimiento";
            this.tbox_requerimiento.Size = new System.Drawing.Size(100, 20);
            this.tbox_requerimiento.TabIndex = 2;
            // 
            // btn_buscar
            // 
            this.btn_buscar.Location = new System.Drawing.Point(329, 52);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(75, 23);
            this.btn_buscar.TabIndex = 3;
            this.btn_buscar.Text = "Buscar";
            this.btn_buscar.UseVisualStyleBackColor = true;
            this.btn_buscar.Click += new System.EventHandler(this.btn_buscar_Click);
            // 
            // dgrid_lista
            // 
            this.dgrid_lista.AllowDrop = true;
            this.dgrid_lista.AllowUserToAddRows = false;
            this.dgrid_lista.AllowUserToDeleteRows = false;
            this.dgrid_lista.AllowUserToResizeColumns = false;
            this.dgrid_lista.AllowUserToResizeRows = false;
            this.dgrid_lista.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgrid_lista.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgrid_lista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrid_lista.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgrid_lista.EnableHeadersVisualStyles = false;
            this.dgrid_lista.Location = new System.Drawing.Point(30, 106);
            this.dgrid_lista.MultiSelect = false;
            this.dgrid_lista.Name = "dgrid_lista";
            this.dgrid_lista.ReadOnly = true;
            this.dgrid_lista.Size = new System.Drawing.Size(448, 150);
            this.dgrid_lista.TabIndex = 4;
            // 
            // btn_Confirmar
            // 
            this.btn_Confirmar.Location = new System.Drawing.Point(512, 233);
            this.btn_Confirmar.Name = "btn_Confirmar";
            this.btn_Confirmar.Size = new System.Drawing.Size(75, 23);
            this.btn_Confirmar.TabIndex = 5;
            this.btn_Confirmar.Text = "Confirmar";
            this.btn_Confirmar.UseVisualStyleBackColor = true;
            this.btn_Confirmar.Click += new System.EventHandler(this.btn_Confirmar_Click);
            // 
            // Despacho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 284);
            this.Controls.Add(this.btn_Confirmar);
            this.Controls.Add(this.dgrid_lista);
            this.Controls.Add(this.btn_buscar);
            this.Controls.Add(this.tbox_requerimiento);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.radioButton1);
            this.Name = "Despacho";
            this.Text = "Despacho";
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_lista)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbox_requerimiento;
        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.DataGridView dgrid_lista;
        private System.Windows.Forms.Button btn_Confirmar;
    }
}