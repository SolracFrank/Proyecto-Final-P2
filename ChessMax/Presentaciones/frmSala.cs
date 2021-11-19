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
    public partial class frmSala : Form
    {
        ManejadorSala _sala; EntidadSala esala;
        public frmSala()
        {
            _sala = new ManejadorSala(); esala = new EntidadSala();
            InitializeComponent();
        }
        void GuardarEntidad() //Guardamos Entidad para su uso
        {
            try
            {
                esala.IdSala = txtSala.Text;
                esala.FkHotel = txtHotel.Text;
                esala.Tv = byte.Parse(txtTv.Text);
                esala.Radio = byte.Parse(txtRadio.Text);
                esala.Video = byte.Parse(txtVideo.Text);
                esala.Capacidad = int.Parse(txtCapacidad.Text);
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
                _sala.UpdateSala(esala);
                Close();
            }
            else
            {
                _sala.AddSala(esala);
                Close();
            }
        }
        void DetectarModo() //Detectamos si es edit o agregar
        {
            if (frmPrincipal.ModoEdit == true)
            {
                txtSala.Enabled = false;
                txtSala.Text = frmPrincipal.esala.IdSala;
                txtCapacidad.Text = frmPrincipal.esala.Capacidad.ToString();
                txtRadio.Text = frmPrincipal.esala.Radio.ToString();
                txtTv.Text = frmPrincipal.esala.Tv.ToString();
                txtHotel.Text = frmPrincipal.esala.FkHotel;
                txtVideo.Text = frmPrincipal.esala.Video.ToString();
            }
        }

        private void frmSala_Load(object sender, EventArgs e)
        {
            DetectarModo();
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            Aceptar();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            frmPrincipal.ModoEdit = false;
            Close();
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            frmPrincipal.ModoEdit = false;
            Close();
        }
    }
}
