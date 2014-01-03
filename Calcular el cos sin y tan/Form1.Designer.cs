namespace Calcular_el_cos_sin_y_tan
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
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
            this.ComboBox_Funciones = new System.Windows.Forms.ComboBox();
            this.Button_Run = new System.Windows.Forms.Button();
            this.Label1 = new System.Windows.Forms.Label();
            this.TextBox_Angulo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ComboBox_Funciones
            // 
            this.ComboBox_Funciones.FormattingEnabled = true;
            this.ComboBox_Funciones.Items.AddRange(new object[] {
            "Cos",
            "Sin",
            "Tan"});
            this.ComboBox_Funciones.Location = new System.Drawing.Point(155, 91);
            this.ComboBox_Funciones.Name = "ComboBox_Funciones";
            this.ComboBox_Funciones.Size = new System.Drawing.Size(89, 21);
            this.ComboBox_Funciones.TabIndex = 12;
            this.ComboBox_Funciones.Text = "Funciones";
            // 
            // Button_Run
            // 
            this.Button_Run.Location = new System.Drawing.Point(99, 173);
            this.Button_Run.Name = "Button_Run";
            this.Button_Run.Size = new System.Drawing.Size(75, 23);
            this.Button_Run.TabIndex = 11;
            this.Button_Run.Text = "Run";
            this.Button_Run.UseVisualStyleBackColor = true;
            this.Button_Run.Click += new System.EventHandler(this.Button_Run_Click);
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(40, 63);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(89, 15);
            this.Label1.TabIndex = 10;
            this.Label1.Text = "Ingrese Angulo";
            // 
            // TextBox_Angulo
            // 
            this.TextBox_Angulo.Location = new System.Drawing.Point(43, 91);
            this.TextBox_Angulo.Name = "TextBox_Angulo";
            this.TextBox_Angulo.Size = new System.Drawing.Size(75, 20);
            this.TextBox_Angulo.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 258);
            this.Controls.Add(this.ComboBox_Funciones);
            this.Controls.Add(this.Button_Run);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.TextBox_Angulo);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.ComboBox ComboBox_Funciones;
        internal System.Windows.Forms.Button Button_Run;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.TextBox TextBox_Angulo;
    }
}

