
namespace WindowsFormsApp1
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TXTNOMBRE = new System.Windows.Forms.TextBox();
            this.TXTPRECIO = new System.Windows.Forms.TextBox();
            this.TXTUNI = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.BTNELIMINAR = new System.Windows.Forms.Button();
            this.BTNANIADIR = new System.Windows.Forms.Button();
            this.BTNMODIFICAR = new System.Windows.Forms.Button();
            this.TXTBUSCAR = new System.Windows.Forms.TextBox();
            this.BTNBUSCAR = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(158, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "NOMBRE PRODUCTO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(204, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "PRECIO UNI.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(174, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "UNIDADES STOCK";
            // 
            // TXTNOMBRE
            // 
            this.TXTNOMBRE.Location = new System.Drawing.Point(354, 31);
            this.TXTNOMBRE.Name = "TXTNOMBRE";
            this.TXTNOMBRE.Size = new System.Drawing.Size(100, 20);
            this.TXTNOMBRE.TabIndex = 3;
            // 
            // TXTPRECIO
            // 
            this.TXTPRECIO.Location = new System.Drawing.Point(354, 71);
            this.TXTPRECIO.Name = "TXTPRECIO";
            this.TXTPRECIO.Size = new System.Drawing.Size(100, 20);
            this.TXTPRECIO.TabIndex = 4;
            // 
            // TXTUNI
            // 
            this.TXTUNI.Location = new System.Drawing.Point(354, 113);
            this.TXTUNI.Name = "TXTUNI";
            this.TXTUNI.Size = new System.Drawing.Size(100, 20);
            this.TXTUNI.TabIndex = 5;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(580, 29);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(169, 21);
            this.comboBox1.TabIndex = 6;
            // 
            // BTNELIMINAR
            // 
            this.BTNELIMINAR.Location = new System.Drawing.Point(580, 78);
            this.BTNELIMINAR.Name = "BTNELIMINAR";
            this.BTNELIMINAR.Size = new System.Drawing.Size(169, 51);
            this.BTNELIMINAR.TabIndex = 7;
            this.BTNELIMINAR.Text = "ELIMINAR";
            this.BTNELIMINAR.UseVisualStyleBackColor = true;
            this.BTNELIMINAR.Click += new System.EventHandler(this.BTNELIMINAR_Click);
            // 
            // BTNANIADIR
            // 
            this.BTNANIADIR.Location = new System.Drawing.Point(52, 161);
            this.BTNANIADIR.Name = "BTNANIADIR";
            this.BTNANIADIR.Size = new System.Drawing.Size(135, 52);
            this.BTNANIADIR.TabIndex = 8;
            this.BTNANIADIR.Text = "AÑADIR";
            this.BTNANIADIR.UseVisualStyleBackColor = true;
            this.BTNANIADIR.Click += new System.EventHandler(this.BTNANIADIR_Click);
            // 
            // BTNMODIFICAR
            // 
            this.BTNMODIFICAR.Location = new System.Drawing.Point(207, 161);
            this.BTNMODIFICAR.Name = "BTNMODIFICAR";
            this.BTNMODIFICAR.Size = new System.Drawing.Size(182, 52);
            this.BTNMODIFICAR.TabIndex = 9;
            this.BTNMODIFICAR.Text = "MODIFICAR";
            this.BTNMODIFICAR.UseVisualStyleBackColor = true;
            this.BTNMODIFICAR.Click += new System.EventHandler(this.BTNMODIFICAR_Click);
            // 
            // TXTBUSCAR
            // 
            this.TXTBUSCAR.Location = new System.Drawing.Point(602, 144);
            this.TXTBUSCAR.Name = "TXTBUSCAR";
            this.TXTBUSCAR.Size = new System.Drawing.Size(129, 20);
            this.TXTBUSCAR.TabIndex = 10;
            // 
            // BTNBUSCAR
            // 
            this.BTNBUSCAR.Location = new System.Drawing.Point(580, 170);
            this.BTNBUSCAR.Name = "BTNBUSCAR";
            this.BTNBUSCAR.Size = new System.Drawing.Size(169, 43);
            this.BTNBUSCAR.TabIndex = 11;
            this.BTNBUSCAR.Text = "BUSCAR";
            this.BTNBUSCAR.UseVisualStyleBackColor = true;
            this.BTNBUSCAR.Click += new System.EventHandler(this.BTNBUSCAR_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(52, 233);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(697, 184);
            this.dataGridView1.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.BTNBUSCAR);
            this.Controls.Add(this.TXTBUSCAR);
            this.Controls.Add(this.BTNMODIFICAR);
            this.Controls.Add(this.BTNANIADIR);
            this.Controls.Add(this.BTNELIMINAR);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.TXTUNI);
            this.Controls.Add(this.TXTPRECIO);
            this.Controls.Add(this.TXTNOMBRE);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "EXAMEN";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TXTNOMBRE;
        private System.Windows.Forms.TextBox TXTPRECIO;
        private System.Windows.Forms.TextBox TXTUNI;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button BTNELIMINAR;
        private System.Windows.Forms.Button BTNANIADIR;
        private System.Windows.Forms.Button BTNMODIFICAR;
        private System.Windows.Forms.TextBox TXTBUSCAR;
        private System.Windows.Forms.Button BTNBUSCAR;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

