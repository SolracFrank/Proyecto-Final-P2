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
    public partial class frmAlojamiento : Form
    {
        ManejadorAlojamiento _alojamiento; EntidadAlojamiento alojar;
        public frmAlojamiento()
        {
            _alojamiento = new ManejadorAlojamiento(); alojar = new EntidadAlojamiento();
            InitializeComponent();
        }
        void GuardarEntidad() //Guardamos Entidad para su uso
        {

            try
            {
                alojar.Codigo = txtCodigo.Text;
                alojar.Fecha = txtFecha.Text;
                alojar.FkHotel = txtHotel.Text;
                alojar.FkParticipante = txtCodigoParticipante.Text;
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
                _alojamiento.updateAlojamiento(alojar);
                Close();
            }
            else
            {
                _alojamiento.AddAlojamiento(alojar);
                Close();
            }
        }
       void DetectarModo() //Detectamos si es edit o agregar
        {
            if (frmPrincipal.ModoEdit == true)
            {
                txtCodigo.Enabled = false;
                txtCodigo.Text = frmPrincipal.ealojamiento.Codigo;
                txtFecha.Text = frmPrincipal.ealojamiento.Fecha;
                txtHotel.Text = frmPrincipal.ealojamiento.FkHotel;
                txtCodigoParticipante.Text = frmPrincipal.ealojamiento.FkParticipante;
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

        private void frmAlojamiento_Load(object sender, EventArgs e)
        {
            DetectarModo();
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            Aceptar();
        }
    }
}
