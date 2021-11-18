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
    public partial class frmHotel : Form
    {
        ManejadorHotel _hotel; EntidadHotel ehotel;
        public frmHotel()
        {
            _hotel = new ManejadorHotel(); ehotel = new EntidadHotel();
            InitializeComponent();
        }
        void GuardarEntidad() //Guardamos Entidad para su uso
        {
            ehotel.NombreHotel = txtNombre.Text;
            ehotel.Colonia = txtColonia.Text;
            ehotel.Calle = txtCalle.Text;
            ehotel.Ciudad = txtCiudad.Text;
            ehotel.Numero = int.Parse(txtNumero.Text);
            ehotel.Telefono = txtTelefono.Text;
        }
        void Aceptar() //Actualizamos o añadimos datos
        {
            GuardarEntidad();
            if (frmPrincipal.ModoEdit == true)
            {
                _hotel.updateHotel(ehotel);
                Close();
            }
            else
            {
                _hotel.AddHotel(ehotel);
                Close();
            }
        }
        void DetectarModo() //Detectamos si es edit o agregar
        {
            if (frmPrincipal.ModoEdit == true)
            {
                txtNombre.Enabled = false;
                txtTelefono.Text = frmPrincipal.ehotel.Telefono;
                txtCalle.Text = frmPrincipal.ehotel.Calle;
                txtCiudad.Text = frmPrincipal.ehotel.Ciudad;
                txtColonia.Text = frmPrincipal.ehotel.Colonia;
                txtNombre.Text = frmPrincipal.ehotel.NombreHotel;
                txtNumero.Text = frmPrincipal.ehotel.Numero.ToString();
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

        private void frmHotel_Load(object sender, EventArgs e)
        {
            DetectarModo();
        }
        private void btnAccept_Click(object sender, EventArgs e)
        {
            Aceptar();
        }
    }
}
