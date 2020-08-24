namespace WindowsForms001
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
            this.button1 = new System.Windows.Forms.Button();
            this.labelNombre = new System.Windows.Forms.Label();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.textBoxApellidos = new System.Windows.Forms.TextBox();
            this.LabelApellidos = new System.Windows.Forms.Label();
            this.buttonPersona = new System.Windows.Forms.Button();
            this.labelNota1 = new System.Windows.Forms.Label();
            this.labelNota2 = new System.Windows.Forms.Label();
            this.labelNota3 = new System.Windows.Forms.Label();
            this.textBoxNota1 = new System.Windows.Forms.TextBox();
            this.textBoxNota3 = new System.Windows.Forms.TextBox();
            this.textBoxNota2 = new System.Windows.Forms.TextBox();
            this.buttonSumarNotas = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(79, 21);
            this.button1.TabIndex = 0;
            this.button1.Text = "Hola mundo";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Location = new System.Drawing.Point(12, 41);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(50, 13);
            this.labelNombre.TabIndex = 1;
            this.labelNombre.Text = "Nombre: ";
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Location = new System.Drawing.Point(68, 38);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(143, 20);
            this.textBoxNombre.TabIndex = 2;
            // 
            // textBoxApellidos
            // 
            this.textBoxApellidos.Location = new System.Drawing.Point(68, 64);
            this.textBoxApellidos.Name = "textBoxApellidos";
            this.textBoxApellidos.Size = new System.Drawing.Size(143, 20);
            this.textBoxApellidos.TabIndex = 4;
            // 
            // LabelApellidos
            // 
            this.LabelApellidos.AutoSize = true;
            this.LabelApellidos.Location = new System.Drawing.Point(12, 67);
            this.LabelApellidos.Name = "LabelApellidos";
            this.LabelApellidos.Size = new System.Drawing.Size(52, 13);
            this.LabelApellidos.TabIndex = 3;
            this.LabelApellidos.Text = "Apellidos:";
            // 
            // buttonPersona
            // 
            this.buttonPersona.Location = new System.Drawing.Point(15, 90);
            this.buttonPersona.Name = "buttonPersona";
            this.buttonPersona.Size = new System.Drawing.Size(196, 41);
            this.buttonPersona.TabIndex = 5;
            this.buttonPersona.Text = "Datos de la persona";
            this.buttonPersona.UseVisualStyleBackColor = true;
            this.buttonPersona.Click += new System.EventHandler(this.buttonPersona_Click);
            // 
            // labelNota1
            // 
            this.labelNota1.AutoEllipsis = true;
            this.labelNota1.AutoSize = true;
            this.labelNota1.Location = new System.Drawing.Point(401, 48);
            this.labelNota1.Name = "labelNota1";
            this.labelNota1.Size = new System.Drawing.Size(42, 13);
            this.labelNota1.TabIndex = 6;
            this.labelNota1.Text = "Nota 1:";
            // 
            // labelNota2
            // 
            this.labelNota2.AutoSize = true;
            this.labelNota2.Location = new System.Drawing.Point(401, 74);
            this.labelNota2.Name = "labelNota2";
            this.labelNota2.Size = new System.Drawing.Size(45, 13);
            this.labelNota2.TabIndex = 7;
            this.labelNota2.Text = "Nota 2: ";
            // 
            // labelNota3
            // 
            this.labelNota3.AutoSize = true;
            this.labelNota3.Location = new System.Drawing.Point(401, 100);
            this.labelNota3.Name = "labelNota3";
            this.labelNota3.Size = new System.Drawing.Size(45, 13);
            this.labelNota3.TabIndex = 8;
            this.labelNota3.Text = "Nota 3: ";
            // 
            // textBoxNota1
            // 
            this.textBoxNota1.Location = new System.Drawing.Point(452, 45);
            this.textBoxNota1.Name = "textBoxNota1";
            this.textBoxNota1.Size = new System.Drawing.Size(20, 20);
            this.textBoxNota1.TabIndex = 9;
            // 
            // textBoxNota3
            // 
            this.textBoxNota3.Location = new System.Drawing.Point(452, 97);
            this.textBoxNota3.Name = "textBoxNota3";
            this.textBoxNota3.Size = new System.Drawing.Size(20, 20);
            this.textBoxNota3.TabIndex = 10;
            // 
            // textBoxNota2
            // 
            this.textBoxNota2.Location = new System.Drawing.Point(452, 71);
            this.textBoxNota2.Name = "textBoxNota2";
            this.textBoxNota2.Size = new System.Drawing.Size(20, 20);
            this.textBoxNota2.TabIndex = 11;
            // 
            // buttonSumarNotas
            // 
            this.buttonSumarNotas.Location = new System.Drawing.Point(404, 123);
            this.buttonSumarNotas.Name = "buttonSumarNotas";
            this.buttonSumarNotas.Size = new System.Drawing.Size(68, 23);
            this.buttonSumarNotas.TabIndex = 12;
            this.buttonSumarNotas.Text = "Sumar Notas";
            this.buttonSumarNotas.UseVisualStyleBackColor = true;
            this.buttonSumarNotas.Click += new System.EventHandler(this.buttonSumarNotas_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonSumarNotas);
            this.Controls.Add(this.textBoxNota2);
            this.Controls.Add(this.textBoxNota3);
            this.Controls.Add(this.textBoxNota1);
            this.Controls.Add(this.labelNota3);
            this.Controls.Add(this.labelNota2);
            this.Controls.Add(this.labelNota1);
            this.Controls.Add(this.buttonPersona);
            this.Controls.Add(this.textBoxApellidos);
            this.Controls.Add(this.LabelApellidos);
            this.Controls.Add(this.textBoxNombre);
            this.Controls.Add(this.labelNombre);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.TextBox textBoxApellidos;
        private System.Windows.Forms.Label LabelApellidos;
        private System.Windows.Forms.Button buttonPersona;
        private System.Windows.Forms.Label labelNota1;
        private System.Windows.Forms.Label labelNota2;
        private System.Windows.Forms.Label labelNota3;
        private System.Windows.Forms.TextBox textBoxNota1;
        private System.Windows.Forms.TextBox textBoxNota3;
        private System.Windows.Forms.TextBox textBoxNota2;
        private System.Windows.Forms.Button buttonSumarNotas;
    }
}

