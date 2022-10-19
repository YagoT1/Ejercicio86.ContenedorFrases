
namespace Ejercicio86
{
    partial class frmContenedorFrases
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
            this.components = new System.ComponentModel.Container();
            this.button = new System.Windows.Forms.Button();
            this.GuardarButton = new System.Windows.Forms.Button();
            this.FraseTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.MostrarListabutton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // button
            // 
            this.button.Location = new System.Drawing.Point(205, 89);
            this.button.Name = "button";
            this.button.Size = new System.Drawing.Size(128, 79);
            this.button.TabIndex = 3;
            this.button.Text = "Cancelar";
            this.button.UseVisualStyleBackColor = true;
            this.button.Click += new System.EventHandler(this.Cancelbutton_Click);
            // 
            // GuardarButton
            // 
            this.GuardarButton.Location = new System.Drawing.Point(32, 89);
            this.GuardarButton.Name = "GuardarButton";
            this.GuardarButton.Size = new System.Drawing.Size(128, 79);
            this.GuardarButton.TabIndex = 2;
            this.GuardarButton.Text = "Guardar";
            this.GuardarButton.UseVisualStyleBackColor = true;
            this.GuardarButton.Click += new System.EventHandler(this.GuardarButton_Click);
            // 
            // FraseTextBox
            // 
            this.FraseTextBox.Location = new System.Drawing.Point(12, 39);
            this.FraseTextBox.MaxLength = 255;
            this.FraseTextBox.Name = "FraseTextBox";
            this.FraseTextBox.Size = new System.Drawing.Size(517, 22);
            this.FraseTextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(202, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Inserte una Frase";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // MostrarListabutton
            // 
            this.MostrarListabutton.Location = new System.Drawing.Point(375, 89);
            this.MostrarListabutton.Name = "MostrarListabutton";
            this.MostrarListabutton.Size = new System.Drawing.Size(128, 79);
            this.MostrarListabutton.TabIndex = 3;
            this.MostrarListabutton.Text = "Mostrar Lista";
            this.MostrarListabutton.UseVisualStyleBackColor = true;
            this.MostrarListabutton.Click += new System.EventHandler(this.MostrarListaButton_Click);
            // 
            // frmContenedorFrases
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 217);
            this.Controls.Add(this.MostrarListabutton);
            this.Controls.Add(this.button);
            this.Controls.Add(this.GuardarButton);
            this.Controls.Add(this.FraseTextBox);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(612, 264);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(612, 264);
            this.Name = "frmContenedorFrases";
            this.Text = "Contenedor de Frases";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button;
        private System.Windows.Forms.Button GuardarButton;
        private System.Windows.Forms.TextBox FraseTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button MostrarListabutton;
    }
}

