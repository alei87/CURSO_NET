
namespace LISTADO_ALUMNO
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.TxtCodigo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtDNI = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.CmbTurno = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.CmbSexo = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtCodigoBusqueda = new System.Windows.Forms.TextBox();
            this.BtnCodigo = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.TxtDNIBusqueda = new System.Windows.Forms.TextBox();
            this.BtnDNIBusqueda = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.CmbEspecialidad = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.CmbModulo = new System.Windows.Forms.ComboBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.BtnAlta = new System.Windows.Forms.Button();
            this.BtnBaja = new System.Windows.Forms.Button();
            this.BtnModificar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código";
            // 
            // TxtCodigo
            // 
            this.TxtCodigo.Enabled = false;
            this.TxtCodigo.Location = new System.Drawing.Point(97, 19);
            this.TxtCodigo.Name = "TxtCodigo";
            this.TxtCodigo.Size = new System.Drawing.Size(116, 20);
            this.TxtCodigo.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "DNI";
            // 
            // TxtDNI
            // 
            this.TxtDNI.Location = new System.Drawing.Point(97, 59);
            this.TxtDNI.Name = "TxtDNI";
            this.TxtDNI.Size = new System.Drawing.Size(116, 20);
            this.TxtDNI.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Turno";
            // 
            // CmbTurno
            // 
            this.CmbTurno.FormattingEnabled = true;
            this.CmbTurno.Items.AddRange(new object[] {
            "Diurno",
            "Nocturno"});
            this.CmbTurno.Location = new System.Drawing.Point(97, 104);
            this.CmbTurno.Name = "CmbTurno";
            this.CmbTurno.Size = new System.Drawing.Size(116, 21);
            this.CmbTurno.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(240, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Nombre";
            // 
            // TxtNombre
            // 
            this.TxtNombre.Location = new System.Drawing.Point(303, 60);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(216, 20);
            this.TxtNombre.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(243, 111);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Sexo";
            // 
            // CmbSexo
            // 
            this.CmbSexo.FormattingEnabled = true;
            this.CmbSexo.Items.AddRange(new object[] {
            "Masculino",
            "Femenino"});
            this.CmbSexo.Location = new System.Drawing.Point(303, 102);
            this.CmbSexo.Name = "CmbSexo";
            this.CmbSexo.Size = new System.Drawing.Size(121, 21);
            this.CmbSexo.TabIndex = 9;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BtnDNIBusqueda);
            this.groupBox1.Controls.Add(this.TxtDNIBusqueda);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.BtnCodigo);
            this.groupBox1.Controls.Add(this.TxtCodigoBusqueda);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Location = new System.Drawing.Point(545, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(227, 100);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Búsqueda";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 32);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Código";
            // 
            // TxtCodigoBusqueda
            // 
            this.TxtCodigoBusqueda.Location = new System.Drawing.Point(61, 25);
            this.TxtCodigoBusqueda.Name = "TxtCodigoBusqueda";
            this.TxtCodigoBusqueda.Size = new System.Drawing.Size(75, 20);
            this.TxtCodigoBusqueda.TabIndex = 1;
            // 
            // BtnCodigo
            // 
            this.BtnCodigo.Location = new System.Drawing.Point(158, 22);
            this.BtnCodigo.Name = "BtnCodigo";
            this.BtnCodigo.Size = new System.Drawing.Size(49, 23);
            this.BtnCodigo.TabIndex = 2;
            this.BtnCodigo.Text = "Código";
            this.BtnCodigo.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 62);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(26, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "DNI";
            // 
            // TxtDNIBusqueda
            // 
            this.TxtDNIBusqueda.Location = new System.Drawing.Point(61, 55);
            this.TxtDNIBusqueda.Name = "TxtDNIBusqueda";
            this.TxtDNIBusqueda.Size = new System.Drawing.Size(75, 20);
            this.TxtDNIBusqueda.TabIndex = 4;
            // 
            // BtnDNIBusqueda
            // 
            this.BtnDNIBusqueda.Location = new System.Drawing.Point(158, 51);
            this.BtnDNIBusqueda.Name = "BtnDNIBusqueda";
            this.BtnDNIBusqueda.Size = new System.Drawing.Size(49, 23);
            this.BtnDNIBusqueda.TabIndex = 5;
            this.BtnDNIBusqueda.Text = "DNI";
            this.BtnDNIBusqueda.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(27, 164);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "Especialidad";
            // 
            // CmbEspecialidad
            // 
            this.CmbEspecialidad.FormattingEnabled = true;
            this.CmbEspecialidad.Location = new System.Drawing.Point(113, 155);
            this.CmbEspecialidad.Name = "CmbEspecialidad";
            this.CmbEspecialidad.Size = new System.Drawing.Size(134, 21);
            this.CmbEspecialidad.TabIndex = 12;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(271, 163);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(42, 13);
            this.label9.TabIndex = 13;
            this.label9.Text = "Módulo";
            // 
            // CmbModulo
            // 
            this.CmbModulo.FormattingEnabled = true;
            this.CmbModulo.Items.AddRange(new object[] {
            "Todos",
            "DAM",
            "DAW"});
            this.CmbModulo.Location = new System.Drawing.Point(319, 156);
            this.CmbModulo.Name = "CmbModulo";
            this.CmbModulo.Size = new System.Drawing.Size(134, 21);
            this.CmbModulo.TabIndex = 14;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(478, 157);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(72, 17);
            this.checkBox1.TabIndex = 16;
            this.checkBox1.Text = "Repetidor";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // BtnAlta
            // 
            this.BtnAlta.Location = new System.Drawing.Point(557, 136);
            this.BtnAlta.Name = "BtnAlta";
            this.BtnAlta.Size = new System.Drawing.Size(51, 41);
            this.BtnAlta.TabIndex = 17;
            this.BtnAlta.Text = "Alta";
            this.BtnAlta.UseVisualStyleBackColor = true;
            // 
            // BtnBaja
            // 
            this.BtnBaja.Location = new System.Drawing.Point(630, 136);
            this.BtnBaja.Name = "BtnBaja";
            this.BtnBaja.Size = new System.Drawing.Size(51, 41);
            this.BtnBaja.TabIndex = 18;
            this.BtnBaja.Text = "Baja";
            this.BtnBaja.UseVisualStyleBackColor = true;
            // 
            // BtnModificar
            // 
            this.BtnModificar.Location = new System.Drawing.Point(703, 136);
            this.BtnModificar.Name = "BtnModificar";
            this.BtnModificar.Size = new System.Drawing.Size(51, 41);
            this.BtnModificar.TabIndex = 19;
            this.BtnModificar.Text = "Modi";
            this.BtnModificar.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(23, 202);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(749, 219);
            this.dataGridView1.TabIndex = 20;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.BtnModificar);
            this.Controls.Add(this.BtnBaja);
            this.Controls.Add(this.BtnAlta);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.CmbModulo);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.CmbEspecialidad);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.CmbSexo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TxtNombre);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.CmbTurno);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtDNI);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtCodigo);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Listado de Alumnos";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtCodigo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtDNI;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox CmbTurno;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox CmbSexo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BtnDNIBusqueda;
        private System.Windows.Forms.TextBox TxtDNIBusqueda;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button BtnCodigo;
        private System.Windows.Forms.TextBox TxtCodigoBusqueda;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox CmbEspecialidad;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox CmbModulo;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button BtnAlta;
        private System.Windows.Forms.Button BtnBaja;
        private System.Windows.Forms.Button BtnModificar;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

