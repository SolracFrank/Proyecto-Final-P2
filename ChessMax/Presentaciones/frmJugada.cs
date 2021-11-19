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
    public partial class frmJugada : Form
    {
        ManejadorJugada _jugada; EntidadJugada ejugada;
        public frmJugada()
        {
            _jugada = new ManejadorJugada(); ejugada = new EntidadJugada();
            InitializeComponent();
        }
        void GuardarEntidad() //Guardamos Entidad para su uso
        {
            try
            {
                ejugada.Codigo = txtCodigo.Text;
                ejugada.Comentario = txtComentario.Text;
                ejugada.FkidPartida = txtPartida.Text;
                ejugada.Movimiento = txtmovimiento.Text;
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
                _jugada.updateJugada(ejugada);
                Close();
            }
            else
            {
                _jugada.AddJugada(ejugada);
                Close();
            }
        }
        void DetectarModo() //Detectamos si es edit o agregar
        {
            if (frmPrincipal.ModoEdit == true)
            {
                txtCodigo.Enabled = false;
                txtCodigo.Text = frmPrincipal.ejugada.Codigo;
                txtComentario.Text = frmPrincipal.ejugada.Comentario;
                txtmovimiento.Text = frmPrincipal.ejugada.Movimiento;
                txtPartida.Text = frmPrincipal.ejugada.FkidPartida;
            }
        }

        private void frmJugada_Load(object sender, EventArgs e)
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
