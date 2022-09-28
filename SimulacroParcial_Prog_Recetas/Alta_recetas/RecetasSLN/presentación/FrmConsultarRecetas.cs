using RecetasSLN.dominio;
using RecetasSLN.Servicio;
using RecetasSLN.Servicio.Interfaz;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RecetasSLN.presentación
{
    public partial class FrmConsultarRecetas : Form
    {
        private Receta NewReceta;
        private IService Servicio;
        public FrmConsultarRecetas()
        {
            InitializeComponent();
            NewReceta = new Receta();
            Servicio=new ImpFactoryServicio().CrearServicio();
            CargarIngredientes();
        }

        private void CargarIngredientes()
        {
            DataTable table = Servicio.ObtenerIngredientes();
            if (table != null)
            {
                cboIngrediente.DataSource = table;
                cboIngrediente.DisplayMember = "n_ingrediente";
                cboIngrediente.ValueMember = "id_ingrediente";
            }
        }

        

        private void FrmConsultarRecetas_Load(object sender, EventArgs e)
        {
            this.ActiveControl = cboTipo;
            this.ActiveControl = cboIngrediente;
            cboIngrediente.SelectedIndex = -1;
            ProximaReceta();
        }

        private void ProximaReceta()
        {
            int next = Servicio.ProximaReceta();
            if(next>0)
            {
                lblNro.Text="Receta N°:"+next.ToString();
            }
            else
            {
                MessageBox.Show("Error de datos. No se puede obtener Nº de presupuesto!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void totalIngredientes()
        {
            lblTotalIngredientes.Text = "Total de ingredientes: " + dgvDetalles.Rows.Count;
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (cboIngrediente.Text.Equals(String.Empty))
            {
                MessageBox.Show("Debe seleccionar un Ingrediente!", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (cboTipo.Text.Equals(String.Empty))
            {
                MessageBox.Show("Debe seleccionar una Receta!", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if ( !int.TryParse(nudCantidad.Text, out _))
            {
                MessageBox.Show("Debe ingresar una cantidad válida!", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            foreach (DataGridViewRow row in dgvDetalles.Rows)
            {
                if (row.Cells["ingrediente"].Value.ToString().Equals(cboIngrediente.Text))
                {
                    MessageBox.Show("Ingrediente: " + cboIngrediente.Text + " ya se encuentra como detalle!", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;

                }
            }
            DataRowView item = (DataRowView)cboIngrediente.SelectedItem;
            int ingr = Convert.ToInt32(item.Row.ItemArray[0]);
            string nom = item.Row.ItemArray[1].ToString();

            Ingrediente i = new Ingrediente(ingr, nom);
            int cant = Convert.ToInt32(nudCantidad.Value);
            DetalleReceta detalle = new DetalleReceta(i, cant);

            NewReceta.AgregarDetalle(detalle);

            dgvDetalles.Rows.Add(new object[] { ingr, nom, cant });
            totalIngredientes();
        }

        private void dgvDetalles_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvDetalles.CurrentCell.ColumnIndex == 3)
            {
                NewReceta.QuitarDetalle(dgvDetalles.CurrentRow.Index);
                //click button:
                dgvDetalles.Rows.Remove(dgvDetalles.CurrentRow);
                //presupuesto.quitarDetalle();    
                totalIngredientes();
            }
        }
        private void GuardarReceta()
        {
            NewReceta.NroReceta = Servicio.ProximaReceta();
            NewReceta.Nombre = txtNombre.Text;
            NewReceta.Chef = txtCheff.Text;
            NewReceta.TipoReceta = Convert.ToInt32(cboTipo.SelectedIndex);
            if (Servicio.ConfirmarPresupuesto(NewReceta))
            {
                MessageBox.Show("Receta registrado", "Informe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                limpiar();
                
            }
            else
            {
                MessageBox.Show("ERROR. No se pudo registrar la receta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void limpiar()
        {
            txtNombre.Text = string.Empty;
            txtNombre.Focus();
            txtCheff.Text = string.Empty;
            cboTipo.SelectedIndex = -1;
            cboIngrediente.SelectedIndex = -1;
            dgvDetalles.Rows.Clear();
            lblTotalIngredientes.Text = "Total de ingredientes:";
            ProximaReceta();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (txtCheff.Text == "")
            {
                MessageBox.Show("Debe ingresar un Cheff!", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (txtNombre.Text == "")
            {
                MessageBox.Show("Debe ingresar un Nombre!", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (dgvDetalles.Rows.Count < 3)
            {
                MessageBox.Show("Debe ingresar 3 ingredientes como minimo", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cboIngrediente.Focus();
                return;

            }
            GuardarReceta();

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            limpiar();
        }
    }
}
