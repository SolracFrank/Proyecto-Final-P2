using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
using Manejadores;

namespace Presentaciones
{
    public partial class frmParticipante : Form
    {
        ManejadorParticipante _participante; EntidadParticipante eparticipante;
        public frmParticipante()
        {
            _participante = new ManejadorParticipante(); eparticipante = new EntidadParticipante();
            InitializeComponent();
        }
        void GuardarEntidad() //Guardamos Entidad para su uso
        {
            try
            {
                eparticipante.NoAsociado = txtNumAsociado.Text;
                eparticipante.Nombre = txtNombre.Text;
                eparticipante.ApellidoM = txtApellidoM.Text;
                eparticipante.ApellidoP = txtApellidP.Text;
                eparticipante.Nivel = int.Parse(txtNivel.Text);
                eparticipante.Tipo_Participacion = txtTipo.Text;
                eparticipante.FkPais = txtPais.Text;
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
                _participante.updateParticipante(eparticipante);
                Close();
            }
            else
            {
                _participante.AddParticipante(eparticipante);
                Close();
            }
        }
        void DetectarModo() //Detectamos si es edit o agregar
        {
            if (frmPrincipal.ModoEdit == true)
            {
                txtNumAsociado.Enabled = false;
                txtNumAsociado.Text = frmPrincipal.eparticipante.NoAsociado;
                txtNombre.Text = frmPrincipal.eparticipante.Nombre;
                txtApellidP.Text = frmPrincipal.eparticipante.ApellidoP;
                txtApellidoM.Text = frmPrincipal.eparticipante.ApellidoM;
                txtNivel.Text = frmPrincipal.eparticipante.Nivel.ToString();
                txtPais.Text = frmPrincipal.eparticipante.FkPais;
                txtTipo.Text = frmPrincipal.eparticipante.Tipo_Participacion;
            }
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

        private void frmParticipante_Load(object sender, EventArgs e)
        {
            DetectarModo();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            frmPrincipal.ModoEdit = false;
            Close();
        }
    }
}
