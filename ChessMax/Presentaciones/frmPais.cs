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
    public partial class frmPais : Form
    {
        ManejadorPais _pais; EntidadPais epais;
        public frmPais()
        {
            _pais = new ManejadorPais(); epais = new EntidadPais();
            InitializeComponent();
        }
        void GuardarEntidad() //Guardamos Entidad para su uso
        {
            try
            {
                epais.No_Correlativo = txtNCorrelativo.Text;
                epais.Nombre = txtNombre.Text;
                epais.Num_Clubes = int.Parse(txtNum_Clubes.Text);
                epais.Fk_Representante = txtRepresentante.Text;
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
                _pais.updatePais(epais);
                Close();
            }
            else
            {
                _pais.AddPais(epais);
                Close();
            }
        }
        void DetectarModo() //Detectamos si es edit o agregar
        {
            if (frmPrincipal.ModoEdit == true)
            {
                txtNCorrelativo.Enabled = false;
                txtNCorrelativo.Text = frmPrincipal.epais.No_Correlativo;
                txtNombre.Text = frmPrincipal.epais.Nombre;
                txtNum_Clubes.Text = frmPrincipal.epais.Num_Clubes.ToString();
                txtRepresentante.Text = frmPrincipal.epais.Fk_Representante;
            }
        }
        private void frmPais_Load(object sender, EventArgs e)
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
