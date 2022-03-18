namespace Ejercicio_N_3
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
            this.usuariotextBox = new System.Windows.Forms.TextBox();
            this.aceptarbutton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.clavetextBox = new System.Windows.Forms.TextBox();
            this.cancelarbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // usuariotextBox
            // 
            this.usuariotextBox.Location = new System.Drawing.Point(156, 56);
            this.usuariotextBox.Margin = new System.Windows.Forms.Padding(4);
            this.usuariotextBox.Name = "usuariotextBox";
            this.usuariotextBox.Size = new System.Drawing.Size(231, 22);
            this.usuariotextBox.TabIndex = 0;
            this.usuariotextBox.Text = "Jandino";
            // 
            // aceptarbutton
            // 
            this.aceptarbutton.Location = new System.Drawing.Point(156, 155);
            this.aceptarbutton.Margin = new System.Windows.Forms.Padding(4);
            this.aceptarbutton.Name = "aceptarbutton";
            this.aceptarbutton.Size = new System.Drawing.Size(100, 28);
            this.aceptarbutton.TabIndex = 1;
            this.aceptarbutton.Text = "Aceptar";
            this.aceptarbutton.UseVisualStyleBackColor = true;
            this.aceptarbutton.Click += new System.EventHandler(this.aceptarbutton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 56);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(57, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Usuario:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(72, 100);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Clave:";
            // 
            // clavetextBox
            // 
            this.clavetextBox.Location = new System.Drawing.Point(156, 100);
            this.clavetextBox.Margin = new System.Windows.Forms.Padding(4);
            this.clavetextBox.Name = "clavetextBox";
            this.clavetextBox.PasswordChar = '*';
            this.clavetextBox.ReadOnly = true;
            this.clavetextBox.Size = new System.Drawing.Size(231, 22);
            this.clavetextBox.TabIndex = 4;
            this.clavetextBox.Text = "1234";
            // 
            // cancelarbutton
            // 
            this.cancelarbutton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelarbutton.Location = new System.Drawing.Point(287, 155);
            this.cancelarbutton.Margin = new System.Windows.Forms.Padding(4);
            this.cancelarbutton.Name = "cancelarbutton";
            this.cancelarbutton.Size = new System.Drawing.Size(100, 28);
            this.cancelarbutton.TabIndex = 5;
            this.cancelarbutton.Text = "Cancelar";
            this.cancelarbutton.UseVisualStyleBackColor = true;
            this.cancelarbutton.Click += new System.EventHandler(this.cancelarbutton_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.aceptarbutton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelarbutton;
            this.ClientSize = new System.Drawing.Size(495, 237);
            this.Controls.Add(this.cancelarbutton);
            this.Controls.Add(this.clavetextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.aceptarbutton);
            this.Controls.Add(this.usuariotextBox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox usuariotextBox;
        private System.Windows.Forms.Button aceptarbutton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox clavetextBox;
        private System.Windows.Forms.Button cancelarbutton;
    }
}

