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
    public partial class frmDatos : Form
    {
        public frmDatos()
        {
            InitializeComponent();
        }
        private List<string> lista;

        private void Cerrarbutton_Click(object sender, EventArgs e)
        {
            Close();
        }

        public void SetLista(List<string> frase)
        {
            lista = frase;
        }
        private void FrmMostrarLista_Load(object sender, EventArgs e)
        {
            
            if (lista.Count == 0)
            {
                return;
            }
            
            MostrarLista();
        }

        private void MostrarLista()
        {
            foreach (string frases in lista)
            {
                var r = ConstruirFila();
                SetearFila(r, frases);
                AgregarFila(r);
            }
        }

        private void AgregarFila(DataGridViewRow r)
        {
            DatosDataGridView.Rows.Add(r);
        }

        private void SetearFila(DataGridViewRow r, string frase)
        {
            r.Cells[ColFrase.Index].Value = frase;
        }

        private DataGridViewRow ConstruirFila()
        {
            var r = new DataGridViewRow();
            r.CreateCells(DatosDataGridView);
            return r;
        }
    }   
}
