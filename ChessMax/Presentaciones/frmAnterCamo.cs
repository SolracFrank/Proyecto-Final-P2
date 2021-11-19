using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Manejadores;
using Entidades;

namespace Presentaciones
{
    public partial class frmAnterCamo : Form
    {
        ManejadorCampeonatosAnteriores _antercamp; EntidadCampeonatosAnteriores eantercamp;
        public frmAnterCamo()
        {
            _antercamp = new ManejadorCampeonatosAnteriores(); eantercamp = new EntidadCampeonatosAnteriores();
            InitializeComponent();
        }
        void GuardarEntidad() //Guardamos Entidad para su uso
        {
            try
            {
                eantercamp.FkParticipante = txtParticipante.Text;
                eantercamp.Nombre = txtNombre.Text;
                eantercamp.Tipo_Participacion = txtTipoParticipacion.Text;
            }
            catch (Exception)
            {

                throw;
            }
        }
        void Aceptar() //Actualizamos o añadimos datos
        {
            GuardarEntidad();
            if (frmPrincipal.ModoEdit == true)
            {
                _antercamp.updateCampeonatosAnteriores(eantercamp);
                Close();
            }
            else
            {
                _antercamp.AddCampeonatosAnteriores(eantercamp);
                Close();
            }
        }
        void DetectarModo() //Detectamos si es edit o agregar
        {
            if (frmPrincipal.ModoEdit == true)
            {
                txtNombre.Enabled = false;
                txtParticipante.Enabled = false;
                txtParticipante.Text = frmPrincipal.eantercamp.FkParticipante;
                txtNombre.Text = frmPrincipal.eantercamp.Nombre;
                txtTipoParticipacion.Text = frmPrincipal.eantercamp.Tipo_Participacion;
            }
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            frmPrincipal.ModoEdit = false;
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            frmPrincipal.ModoEdit = false;
            Close();
        }
        private void btnAccept_Click(object sender, EventArgs e)
        {
            Aceptar();
        }
        private void frmAnterCamo_Load(object sender, EventArgs e)
        {
            DetectarModo();
        }
    }
}
