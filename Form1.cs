using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio86
{
    public partial class frmContenedorFrases : Form
    {
        public frmContenedorFrases()
        {
            InitializeComponent();
        }
        List<string> Frase = new List<string>();
        private void GuardarButton_Click(object sender, EventArgs e)
        {

            if (ValidarDatos())
            {
                 var Frases = FraseTextBox.Text;
                 Frase.Add(Frases);
                
            }

        }

        private bool ValidarDatos()
        {
            bool Valido = true;
            errorProvider1.Clear();

            if (string.IsNullOrEmpty(FraseTextBox.Text))
            {
                Valido = false;
                errorProvider1.SetError(FraseTextBox, "No se ha ingresado ninguna frase");
            }
            else if (FraseTextBox.Text.Length>255)
            {
                Valido = false;
                errorProvider1.SetError(FraseTextBox, "Las Frases no pueden superar los 255 caracteres.");
            }
            return Valido;
        }

        private void Cancelbutton_Click(object sender, EventArgs e)
        {
            IncializarControles();
        }

        private void IncializarControles()
        {
            FraseTextBox.Clear();
            FraseTextBox.Focus();
        }

        private void MostrarListaButton_Click(object sender, EventArgs e)
        {
          frmDatos frm = new frmDatos() { Text = "Mostrando la lista..." }; 

            frm.SetLista(Frase);

            frm.ShowDialog(this);
        }
        
        
    }
}
