namespace WindowsForms001
{
    partial class Form3
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButtonAvanzado = new System.Windows.Forms.RadioButton();
            this.radioButtonBasico = new System.Windows.Forms.RadioButton();
            this.labelNombre = new System.Windows.Forms.Label();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.textBoxApellidos = new System.Windows.Forms.TextBox();
            this.labelApellidos = new System.Windows.Forms.Label();
            this.textBoxEdad = new System.Windows.Forms.TextBox();
            this.labelEdad = new System.Windows.Forms.Label();
            this.textBoxTelefono = new System.Windows.Forms.TextBox();
            this.labelTelefono = new System.Windows.Forms.Label();
            this.checkBoxEsInformatico = new System.Windows.Forms.CheckBox();
            this.buttonInformatico = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButtonAvanzado);
            this.groupBox1.Controls.Add(this.radioButtonBasico);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(181, 72);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // radioButtonAvanzado
            // 
            this.radioButtonAvanzado.AutoSize = true;
            this.radioButtonAvanzado.Location = new System.Drawing.Point(7, 44);
            this.radioButtonAvanzado.Name = "radioButtonAvanzado";
            this.radioButtonAvanzado.Size = new System.Drawing.Size(73, 17);
            this.radioButtonAvanzado.TabIndex = 1;
            this.radioButtonAvanzado.TabStop = true;
            this.radioButtonAvanzado.Text = "Avanzado";
            this.radioButtonAvanzado.UseVisualStyleBackColor = true;
            this.radioButtonAvanzado.CheckedChanged += new System.EventHandler(this.radioButtonAvanzado_CheckedChanged);
            // 
            // radioButtonBasico
            // 
            this.radioButtonBasico.AutoSize = true;
            this.radioButtonBasico.Location = new System.Drawing.Point(7, 20);
            this.radioButtonBasico.Name = "radioButtonBasico";
            this.radioButtonBasico.Size = new System.Drawing.Size(57, 17);
            this.radioButtonBasico.TabIndex = 0;
            this.radioButtonBasico.TabStop = true;
            this.radioButtonBasico.Text = "Básico";
            this.radioButtonBasico.UseVisualStyleBackColor = true;
            this.radioButtonBasico.CheckedChanged += new System.EventHandler(this.radioButtonBasico_CheckedChanged);
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Location = new System.Drawing.Point(276, 34);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(50, 13);
            this.labelNombre.TabIndex = 1;
            this.labelNombre.Text = "Nombre: ";
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Location = new System.Drawing.Point(337, 29);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(100, 20);
            this.textBoxNombre.TabIndex = 2;
            // 
            // textBoxApellidos
            // 
            this.textBoxApellidos.Location = new System.Drawing.Point(337, 56);
            this.textBoxApellidos.Name = "textBoxApellidos";
            this.textBoxApellidos.Size = new System.Drawing.Size(100, 20);
            this.textBoxApellidos.TabIndex = 4;
            // 
            // labelApellidos
            // 
            this.labelApellidos.AutoSize = true;
            this.labelApellidos.Location = new System.Drawing.Point(276, 59);
            this.labelApellidos.Name = "labelApellidos";
            this.labelApellidos.Size = new System.Drawing.Size(55, 13);
            this.labelApellidos.TabIndex = 3;
            this.labelApellidos.Text = "Apellidos: ";
            // 
            // textBoxEdad
            // 
            this.textBoxEdad.Location = new System.Drawing.Point(337, 82);
            this.textBoxEdad.Name = "textBoxEdad";
            this.textBoxEdad.Size = new System.Drawing.Size(100, 20);
            this.textBoxEdad.TabIndex = 6;
            // 
            // labelEdad
            // 
            this.labelEdad.AutoSize = true;
            this.labelEdad.Location = new System.Drawing.Point(276, 85);
            this.labelEdad.Name = "labelEdad";
            this.labelEdad.Size = new System.Drawing.Size(38, 13);
            this.labelEdad.TabIndex = 5;
            this.labelEdad.Text = "Edad: ";
            // 
            // textBoxTelefono
            // 
            this.textBoxTelefono.Location = new System.Drawing.Point(337, 108);
            this.textBoxTelefono.Name = "textBoxTelefono";
            this.textBoxTelefono.Size = new System.Drawing.Size(100, 20);
            this.textBoxTelefono.TabIndex = 8;
            // 
            // labelTelefono
            // 
            this.labelTelefono.AutoSize = true;
            this.labelTelefono.Location = new System.Drawing.Point(276, 111);
            this.labelTelefono.Name = "labelTelefono";
            this.labelTelefono.Size = new System.Drawing.Size(55, 13);
            this.labelTelefono.TabIndex = 7;
            this.labelTelefono.Text = "Teléfono: ";
            // 
            // checkBoxEsInformatico
            // 
            this.checkBoxEsInformatico.AutoSize = true;
            this.checkBoxEsInformatico.Location = new System.Drawing.Point(19, 276);
            this.checkBoxEsInformatico.Name = "checkBoxEsInformatico";
            this.checkBoxEsInformatico.Size = new System.Drawing.Size(78, 17);
            this.checkBoxEsInformatico.TabIndex = 9;
            this.checkBoxEsInformatico.Text = "Informático";
            this.checkBoxEsInformatico.UseVisualStyleBackColor = true;
            // 
            // buttonInformatico
            // 
            this.buttonInformatico.Location = new System.Drawing.Point(104, 272);
            this.buttonInformatico.Name = "buttonInformatico";
            this.buttonInformatico.Size = new System.Drawing.Size(113, 23);
            this.buttonInformatico.TabIndex = 10;
            this.buttonInformatico.Text = "Botón informático";
            this.buttonInformatico.UseVisualStyleBackColor = true;
            this.buttonInformatico.Click += new System.EventHandler(this.buttonInformatico_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(478, 196);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 12;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(478, 224);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 13;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // listBox1
            // 
            this.listBox1.ForeColor = System.Drawing.Color.SeaGreen;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Items.AddRange(new object[] {
            "Elemento 1",
            "Elemento 2",
            "Elemento 3",
            "Elemento 4",
            "Elemento 5"});
            this.listBox1.Location = new System.Drawing.Point(279, 224);
            this.listBox1.Name = "listBox1";
            this.listBox1.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listBox1.Size = new System.Drawing.Size(120, 95);
            this.listBox1.TabIndex = 14;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(279, 336);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 15;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.buttonInformatico);
            this.Controls.Add(this.checkBoxEsInformatico);
            this.Controls.Add(this.textBoxTelefono);
            this.Controls.Add(this.labelTelefono);
            this.Controls.Add(this.textBoxEdad);
            this.Controls.Add(this.labelEdad);
            this.Controls.Add(this.textBoxApellidos);
            this.Controls.Add(this.labelApellidos);
            this.Controls.Add(this.textBoxNombre);
            this.Controls.Add(this.labelNombre);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButtonAvanzado;
        private System.Windows.Forms.RadioButton radioButtonBasico;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.TextBox textBoxApellidos;
        private System.Windows.Forms.Label labelApellidos;
        private System.Windows.Forms.TextBox textBoxEdad;
        private System.Windows.Forms.Label labelEdad;
        private System.Windows.Forms.TextBox textBoxTelefono;
        private System.Windows.Forms.Label labelTelefono;
        private System.Windows.Forms.CheckBox checkBoxEsInformatico;
        private System.Windows.Forms.Button buttonInformatico;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button1;
    }
}