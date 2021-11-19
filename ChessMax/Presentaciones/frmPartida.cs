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
    public partial class frmPartida : Form
    {
        ManejadorPartida _partida; EntidadPartida epartida;
        public frmPartida()
        {
            _partida = new ManejadorPartida(); epartida = new EntidadPartida();
            InitializeComponent();
        }
        void GuardarEntidad() //Guardamos Entidad para su uso
        {
            try
            {
                epartida.Codigo = txtCodigo.Text;
                epartida.FkArbitro = txtArbitro.Text;
                epartida.FkJornada = txtJornada.Text;
                epartida.FkJugador1Blancas = txtBlanca.Text;
                epartida.FkJugador2Negras = txtNegra.Text;
                epartida.Resultadp = txtResultado.Text;
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
                _partida.updatePartida(epartida);
                Close();
            }
            else
            {
                _partida.AddPartida(epartida);
                Close();
            }
        }
        void DetectarModo() //Detectamos si es edit o agregar
        {
            if (frmPrincipal.ModoEdit == true)
            {
                txtCodigo.Enabled = false;
                txtCodigo.Text = frmPrincipal.epartida.Codigo;
                txtArbitro.Text = frmPrincipal.epartida.FkArbitro;
                txtBlanca.Text = frmPrincipal.epartida.FkJugador1Blancas;
                txtNegra.Text = frmPrincipal.epartida.FkJugador2Negras;
                txtJornada.Text = frmPrincipal.epartida.FkJornada;
                txtResultado.Text = frmPrincipal.epartida.Resultadp;
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

        private void frmPartida_Load(object sender, EventArgs e)
        {
            DetectarModo();
        }
    }
}
