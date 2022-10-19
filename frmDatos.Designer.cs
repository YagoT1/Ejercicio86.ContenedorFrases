
namespace Ejercicio86
{
    partial class frmDatos
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
            this.components = new System.ComponentModel.Container();
            this.DatosDataGridView = new System.Windows.Forms.DataGridView();
            this.ColFrase = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cerrarbutton = new System.Windows.Forms.Button();
            this.frmDatosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.DatosDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.frmDatosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // DatosDataGridView
            // 
            this.DatosDataGridView.AllowUserToAddRows = false;
            this.DatosDataGridView.AllowUserToDeleteRows = false;
            this.DatosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DatosDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColFrase});
            this.DatosDataGridView.Location = new System.Drawing.Point(12, 4);
            this.DatosDataGridView.Name = "DatosDataGridView";
            this.DatosDataGridView.ReadOnly = true;
            this.DatosDataGridView.RowHeadersWidth = 51;
            this.DatosDataGridView.RowTemplate.Height = 24;
            this.DatosDataGridView.Size = new System.Drawing.Size(786, 372);
            this.DatosDataGridView.TabIndex = 5;
            // 
            // ColFrase
            // 
            this.ColFrase.HeaderText = "FRASES";
            this.ColFrase.MinimumWidth = 6;
            this.ColFrase.Name = "ColFrase";
            this.ColFrase.ReadOnly = true;
            this.ColFrase.Width = 125;
            // 
            // Cerrarbutton
            // 
            this.Cerrarbutton.Location = new System.Drawing.Point(686, 382);
            this.Cerrarbutton.Name = "Cerrarbutton";
            this.Cerrarbutton.Size = new System.Drawing.Size(102, 65);
            this.Cerrarbutton.TabIndex = 6;
            this.Cerrarbutton.Text = "CERRAR";
            this.Cerrarbutton.UseVisualStyleBackColor = true;
            this.Cerrarbutton.Click += new System.EventHandler(this.Cerrarbutton_Click);
            // 
            // frmDatosBindingSource
            // 
            this.frmDatosBindingSource.DataSource = typeof(Ejercicio86.frmDatos);
            // 
            // frmDatos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Cerrarbutton);
            this.Controls.Add(this.DatosDataGridView);
            this.Name = "frmDatos";
            this.Text = "LISTADO DE FRASES";
            ((System.ComponentModel.ISupportInitialize)(this.DatosDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.frmDatosBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DatosDataGridView;
        private System.Windows.Forms.Button Cerrarbutton;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColFrase;
        private System.Windows.Forms.BindingSource frmDatosBindingSource;
    }
}