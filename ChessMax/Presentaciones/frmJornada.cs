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
    public partial class frmJornada : Form
    {
        ManejadorJornada _jornada; EntidadJornada ejornada;

        public frmJornada()
        {
            _jornada = new ManejadorJornada(); ejornada = new EntidadJornada();
            InitializeComponent();
        }
        void GuardarEntidad() //Guardamos Entidad para su uso
        {
            try
            {
                ejornada.Codigo = txtCodigo.Text;
                ejornada.Fecha = txtFecha.Text;
                ejornada.FkSala = txtSala.Text;
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
                _jornada.updateJornada(ejornada);
                Close();
            }
            else
            {
                _jornada.AddJornada(ejornada);
                Close();
            }
        }
        void DetectarModo() //Detectamos si es edit o agregar
        {
            if (frmPrincipal.ModoEdit == true)
            {
                txtCodigo.Enabled = false;
                txtCodigo.Text = frmPrincipal.ejornada.Codigo;
                txtFecha.Text = frmPrincipal.ejornada.Fecha;
                txtSala.Text = frmPrincipal.ejornada.FkSala;
            }
        }
        private void frmJornada_Load(object sender, EventArgs e)
        {
            DetectarModo();
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

        private void btnClose_Click(object sender, EventArgs e)
        {
            frmPrincipal.ModoEdit = false;
            Close();
        }
    }
}
