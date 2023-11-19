namespace PryLedoTP
{
    partial class frmListadoEmpleados
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
            this.dgvGrilla = new System.Windows.Forms.DataGridView();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtBuscarApellido = new System.Windows.Forms.TextBox();
            this.lblBuscarApellido = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnBuscar1 = new System.Windows.Forms.Button();
            this.txtCiu = new System.Windows.Forms.TextBox();
            this.lblBuscarCiu = new System.Windows.Forms.Label();
            this.BtnVolver = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrilla)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvGrilla
            // 
            this.dgvGrilla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGrilla.Location = new System.Drawing.Point(39, 219);
            this.dgvGrilla.Name = "dgvGrilla";
            this.dgvGrilla.Size = new System.Drawing.Size(495, 197);
            this.dgvGrilla.TabIndex = 3;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(39, 34);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(495, 168);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnBuscar);
            this.tabPage1.Controls.Add(this.txtBuscarApellido);
            this.tabPage1.Controls.Add(this.lblBuscarApellido);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(487, 135);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Apellido";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.Azure;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Location = new System.Drawing.Point(391, 98);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(90, 31);
            this.btnBuscar.TabIndex = 2;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtBuscarApellido
            // 
            this.txtBuscarApellido.Location = new System.Drawing.Point(182, 51);
            this.txtBuscarApellido.Name = "txtBuscarApellido";
            this.txtBuscarApellido.Size = new System.Drawing.Size(207, 26);
            this.txtBuscarApellido.TabIndex = 1;
            // 
            // lblBuscarApellido
            // 
            this.lblBuscarApellido.AutoSize = true;
            this.lblBuscarApellido.Location = new System.Drawing.Point(107, 54);
            this.lblBuscarApellido.Name = "lblBuscarApellido";
            this.lblBuscarApellido.Size = new System.Drawing.Size(69, 20);
            this.lblBuscarApellido.TabIndex = 0;
            this.lblBuscarApellido.Text = "Apellido:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnBuscar1);
            this.tabPage2.Controls.Add(this.txtCiu);
            this.tabPage2.Controls.Add(this.lblBuscarCiu);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(487, 135);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Barrio";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnBuscar1
            // 
            this.btnBuscar1.BackColor = System.Drawing.Color.Azure;
            this.btnBuscar1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar1.Location = new System.Drawing.Point(391, 100);
            this.btnBuscar1.Name = "btnBuscar1";
            this.btnBuscar1.Size = new System.Drawing.Size(90, 29);
            this.btnBuscar1.TabIndex = 6;
            this.btnBuscar1.Text = "Buscar";
            this.btnBuscar1.UseVisualStyleBackColor = false;
            this.btnBuscar1.Click += new System.EventHandler(this.btnBuscar1_Click);
            // 
            // txtCiu
            // 
            this.txtCiu.Location = new System.Drawing.Point(184, 54);
            this.txtCiu.Name = "txtCiu";
            this.txtCiu.Size = new System.Drawing.Size(186, 26);
            this.txtCiu.TabIndex = 2;
            // 
            // lblBuscarCiu
            // 
            this.lblBuscarCiu.AutoSize = true;
            this.lblBuscarCiu.Location = new System.Drawing.Point(123, 57);
            this.lblBuscarCiu.Name = "lblBuscarCiu";
            this.lblBuscarCiu.Size = new System.Drawing.Size(55, 20);
            this.lblBuscarCiu.TabIndex = 1;
            this.lblBuscarCiu.Text = "Barrio:";
            // 
            // BtnVolver
            // 
            this.BtnVolver.BackColor = System.Drawing.Color.Azure;
            this.BtnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnVolver.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnVolver.Location = new System.Drawing.Point(434, 432);
            this.BtnVolver.Name = "BtnVolver";
            this.BtnVolver.Size = new System.Drawing.Size(90, 31);
            this.BtnVolver.TabIndex = 3;
            this.BtnVolver.Text = "Volver";
            this.BtnVolver.UseVisualStyleBackColor = false;
            this.BtnVolver.Click += new System.EventHandler(this.BtnVolver_Click);
            // 
            // frmListadoEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.ClientSize = new System.Drawing.Size(578, 475);
            this.Controls.Add(this.dgvGrilla);
            this.Controls.Add(this.BtnVolver);
            this.Controls.Add(this.tabControl1);
            this.Name = "frmListadoEmpleados";
            this.Text = "frmListadoEmpleados";
            this.Load += new System.EventHandler(this.frmListadoEmpleados_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrilla)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvGrilla;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button BtnVolver;
        private System.Windows.Forms.TextBox txtBuscarApellido;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label lblBuscarApellido;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox txtCiu;
        private System.Windows.Forms.Label lblBuscarCiu;
        private System.Windows.Forms.Button btnBuscar1;
    }
}