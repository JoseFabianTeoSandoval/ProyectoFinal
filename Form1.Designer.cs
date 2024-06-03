using System.Windows.Forms;

namespace ProyectoFinal
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
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxid = new System.Windows.Forms.TextBox();
            this.textBoxnombre = new System.Windows.Forms.TextBox();
            this.textBoxapellido = new System.Windows.Forms.TextBox();
            this.textBoxaldea = new System.Windows.Forms.TextBox();
            this.textBoxrango = new System.Windows.Forms.TextBox();
            this.numericUpDownnivelpoder = new System.Windows.Forms.NumericUpDown();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.dateTimePickerfechaagregado = new System.Windows.Forms.DateTimePicker();
            this.comboBoxrango = new System.Windows.Forms.ComboBox();
            this.comboBoxaldea = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttoncargar = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonbuscar = new System.Windows.Forms.Button();
            this.buttonactualizar = new System.Windows.Forms.Button();
            this.buttoneliminar = new System.Windows.Forms.Button();
            this.buttonCrear = new System.Windows.Forms.Button();
            this.buttonnext = new System.Windows.Forms.Button();
            this.buttonanterior = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownnivelpoder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Apellido";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Nivel de Poder";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(41, 190);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(150, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Fecha de Agregado";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(41, 228);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Aldea";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(41, 294);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 20);
            this.label7.TabIndex = 6;
            this.label7.Text = "Rango";
            // 
            // textBoxid
            // 
            this.textBoxid.Location = new System.Drawing.Point(242, 35);
            this.textBoxid.Name = "textBoxid";
            this.textBoxid.Size = new System.Drawing.Size(100, 26);
            this.textBoxid.TabIndex = 7;
            // 
            // textBoxnombre
            // 
            this.textBoxnombre.Location = new System.Drawing.Point(242, 71);
            this.textBoxnombre.Name = "textBoxnombre";
            this.textBoxnombre.Size = new System.Drawing.Size(216, 26);
            this.textBoxnombre.TabIndex = 8;
            // 
            // textBoxapellido
            // 
            this.textBoxapellido.Location = new System.Drawing.Point(242, 111);
            this.textBoxapellido.Name = "textBoxapellido";
            this.textBoxapellido.Size = new System.Drawing.Size(216, 26);
            this.textBoxapellido.TabIndex = 9;
            // 
            // textBoxaldea
            // 
            this.textBoxaldea.Location = new System.Drawing.Point(242, 228);
            this.textBoxaldea.Name = "textBoxaldea";
            this.textBoxaldea.Size = new System.Drawing.Size(216, 26);
            this.textBoxaldea.TabIndex = 12;
            // 
            // textBoxrango
            // 
            this.textBoxrango.Location = new System.Drawing.Point(242, 294);
            this.textBoxrango.Name = "textBoxrango";
            this.textBoxrango.Size = new System.Drawing.Size(216, 26);
            this.textBoxrango.TabIndex = 13;
            // 
            // numericUpDownnivelpoder
            // 
            this.numericUpDownnivelpoder.Location = new System.Drawing.Point(242, 145);
            this.numericUpDownnivelpoder.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numericUpDownnivelpoder.Name = "numericUpDownnivelpoder";
            this.numericUpDownnivelpoder.Size = new System.Drawing.Size(120, 26);
            this.numericUpDownnivelpoder.TabIndex = 14;
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(45, 416);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersWidth = 62;
            this.dataGridView.RowTemplate.Height = 28;
            this.dataGridView.Size = new System.Drawing.Size(808, 282);
            this.dataGridView.TabIndex = 15;
            // 
            // dateTimePickerfechaagregado
            // 
            this.dateTimePickerfechaagregado.Location = new System.Drawing.Point(242, 183);
            this.dateTimePickerfechaagregado.Name = "dateTimePickerfechaagregado";
            this.dateTimePickerfechaagregado.Size = new System.Drawing.Size(216, 26);
            this.dateTimePickerfechaagregado.TabIndex = 16;
            // 
            // comboBoxrango
            // 
            this.comboBoxrango.FormattingEnabled = true;
            this.comboBoxrango.Location = new System.Drawing.Point(242, 335);
            this.comboBoxrango.Name = "comboBoxrango";
            this.comboBoxrango.Size = new System.Drawing.Size(216, 28);
            this.comboBoxrango.TabIndex = 17;
            // 
            // comboBoxaldea
            // 
            this.comboBoxaldea.FormattingEnabled = true;
            this.comboBoxaldea.Location = new System.Drawing.Point(242, 261);
            this.comboBoxaldea.Name = "comboBoxaldea";
            this.comboBoxaldea.Size = new System.Drawing.Size(216, 28);
            this.comboBoxaldea.TabIndex = 18;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonanterior);
            this.groupBox1.Controls.Add(this.buttonnext);
            this.groupBox1.Controls.Add(this.buttoncargar);
            this.groupBox1.Location = new System.Drawing.Point(899, 416);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 282);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Opciones";
            // 
            // buttoncargar
            // 
            this.buttoncargar.Location = new System.Drawing.Point(50, 40);
            this.buttoncargar.Name = "buttoncargar";
            this.buttoncargar.Size = new System.Drawing.Size(96, 52);
            this.buttoncargar.TabIndex = 0;
            this.buttoncargar.Text = "Cargar";
            this.buttoncargar.UseVisualStyleBackColor = true;
            this.buttoncargar.Click += new System.EventHandler(this.buttoncargar_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buttonbuscar);
            this.groupBox2.Controls.Add(this.buttonactualizar);
            this.groupBox2.Controls.Add(this.buttoneliminar);
            this.groupBox2.Controls.Add(this.buttonCrear);
            this.groupBox2.Location = new System.Drawing.Point(503, 37);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(177, 326);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "opciones";
            // 
            // buttonbuscar
            // 
            this.buttonbuscar.Location = new System.Drawing.Point(43, 36);
            this.buttonbuscar.Name = "buttonbuscar";
            this.buttonbuscar.Size = new System.Drawing.Size(96, 45);
            this.buttonbuscar.TabIndex = 3;
            this.buttonbuscar.Text = "Buscar";
            this.buttonbuscar.UseVisualStyleBackColor = true;
            this.buttonbuscar.Click += new System.EventHandler(this.buttonbuscar_Click);
            // 
            // buttonactualizar
            // 
            this.buttonactualizar.Location = new System.Drawing.Point(43, 187);
            this.buttonactualizar.Name = "buttonactualizar";
            this.buttonactualizar.Size = new System.Drawing.Size(96, 46);
            this.buttonactualizar.TabIndex = 2;
            this.buttonactualizar.Text = "Actualizar";
            this.buttonactualizar.UseVisualStyleBackColor = true;
            this.buttonactualizar.Click += new System.EventHandler(this.buttonactualizar_Click);
            // 
            // buttoneliminar
            // 
            this.buttoneliminar.Location = new System.Drawing.Point(43, 257);
            this.buttoneliminar.Name = "buttoneliminar";
            this.buttoneliminar.Size = new System.Drawing.Size(96, 49);
            this.buttoneliminar.TabIndex = 1;
            this.buttoneliminar.Text = "Eliminar";
            this.buttoneliminar.UseVisualStyleBackColor = true;
            this.buttoneliminar.Click += new System.EventHandler(this.buttoneliminar_Click);
            // 
            // buttonCrear
            // 
            this.buttonCrear.Location = new System.Drawing.Point(43, 108);
            this.buttonCrear.Name = "buttonCrear";
            this.buttonCrear.Size = new System.Drawing.Size(96, 50);
            this.buttonCrear.TabIndex = 0;
            this.buttonCrear.Text = "Crear";
            this.buttonCrear.UseVisualStyleBackColor = true;
            this.buttonCrear.Click += new System.EventHandler(this.buttonCrear_Click);
            // 
            // buttonnext
            // 
            this.buttonnext.Location = new System.Drawing.Point(50, 108);
            this.buttonnext.Name = "buttonnext";
            this.buttonnext.Size = new System.Drawing.Size(96, 54);
            this.buttonnext.TabIndex = 1;
            this.buttonnext.Text = "Siguiente";
            this.buttonnext.UseVisualStyleBackColor = true;
            this.buttonnext.Click += new System.EventHandler(this.buttonnext_Click);
            // 
            // buttonanterior
            // 
            this.buttonanterior.Location = new System.Drawing.Point(50, 180);
            this.buttonanterior.Name = "buttonanterior";
            this.buttonanterior.Size = new System.Drawing.Size(96, 55);
            this.buttonanterior.TabIndex = 2;
            this.buttonanterior.Text = "Anterior";
            this.buttonanterior.UseVisualStyleBackColor = true;
            this.buttonanterior.Click += new System.EventHandler(this.buttonanterior_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1347, 773);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.comboBoxaldea);
            this.Controls.Add(this.comboBoxrango);
            this.Controls.Add(this.dateTimePickerfechaagregado);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.numericUpDownnivelpoder);
            this.Controls.Add(this.textBoxrango);
            this.Controls.Add(this.textBoxaldea);
            this.Controls.Add(this.textBoxapellido);
            this.Controls.Add(this.textBoxnombre);
            this.Controls.Add(this.textBoxid);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownnivelpoder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxid;
        private System.Windows.Forms.TextBox textBoxnombre;
        private System.Windows.Forms.TextBox textBoxapellido;
        private System.Windows.Forms.TextBox textBoxaldea;
        private System.Windows.Forms.TextBox textBoxrango;
        private System.Windows.Forms.NumericUpDown numericUpDownnivelpoder;
        private DataGridView dataGridView;
        private System.Windows.Forms.DataGridView dataGridViewPersonajes;
        private System.Windows.Forms.DateTimePicker dateTimePickerfechaagregado;
        private System.Windows.Forms.ComboBox comboBoxrango;
        private System.Windows.Forms.ComboBox comboBoxaldea;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button buttonCrear;
        private System.Windows.Forms.Button buttonactualizar;
        private System.Windows.Forms.Button buttoneliminar;
        private System.Windows.Forms.Button buttoncargar;
        private Button buttonbuscar;
        private Button buttonnext;
        private Button buttonanterior;
    }
}

