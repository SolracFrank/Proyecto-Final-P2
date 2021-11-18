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
    public partial class frmPrincipal : Form
    {
        public static string Seleccionado; //Tabla seleccionada estática
        public static bool ModoEdit = false; //Modo edición estático
        bool AbrirVentata = false;
        //Entidades
        public static EntidadAlojamiento ealojamiento;
        public static EntidadCampeonatosAnteriores eantercamp;
        public static EntidadHotel ehotel;
        //Manejadores
        ManejadorAlojamiento _alojamiento;
        ManejadorCampeonatosAnteriores _campanter;
        ManejadorHotel _hotel;
        ManejadorJornada _jornada;
        ManejadorJugada _jugada;
        ManejadorPais _pais;
        ManejadorParticipante _participante;
        ManejadorPartida _partida;
        ManejadorSala _sala;
        public frmPrincipal()
        {
            _alojamiento = new ManejadorAlojamiento(); ealojamiento = new EntidadAlojamiento();
            _campanter = new ManejadorCampeonatosAnteriores(); eantercamp = new EntidadCampeonatosAnteriores();
            _hotel = new ManejadorHotel(); ehotel = new EntidadHotel();
            _jornada = new ManejadorJornada();
            _jugada = new ManejadorJugada();
            _pais = new ManejadorPais();
            _partida = new ManejadorPartida();
            _sala = new ManejadorSala();
            _participante = new ManejadorParticipante();
            InitializeComponent();
        }
        //Cargar datos en DataGrid
        void CargarDatos()
        {
            if (cmbTablas.Text== "alojamiento")
            {
                _alojamiento.MostrarAlojamiento(dtgDatos, txtBuscar.Text);
                Seleccionado = "alojamiento";
            }
            else if (cmbTablas.Text== "anteriorescampeonatos")
            {
                _campanter.MostrarCampeonatosAnteriores(dtgDatos, txtBuscar.Text);
                Seleccionado = "anteriorescampeonatos";
            }
            else if (cmbTablas.Text == "hotel")
            {
                _hotel.MostrarHotel(dtgDatos, txtBuscar.Text);
                Seleccionado = "hotel";
            }
            else if (cmbTablas.Text == "jornada")
            {
                _jornada.MostrarJornada(dtgDatos, txtBuscar.Text);
                Seleccionado = "jornada";
            }
            else if (cmbTablas.Text == "jugada")
            {
                _jugada.MostrarJugada(dtgDatos, txtBuscar.Text);
                Seleccionado = "jugada";
            }
            else if (cmbTablas.Text == "pais")
            {
                _pais.MostrarPais(dtgDatos, txtBuscar.Text);
                Seleccionado = "pais";
            }
            else if (cmbTablas.Text == "participante")
            {
                _participante.MostrarParticipante(dtgDatos, txtBuscar.Text);
                Seleccionado = "participante";
            }
            else if (cmbTablas.Text == "partida")
            {
                _partida.MostrarPartida(dtgDatos, txtBuscar.Text);
                Seleccionado = "partida";
            }
            else if (cmbTablas.Text == "sala")
            {
                _sala.MostrarSala(dtgDatos, txtBuscar.Text);
                Seleccionado = "sala";
            }
            else
            {
                dtgDatos.DataSource = null;
                Seleccionado = "none";
            }
        }
        //Guardar Datos para cargar en Edición
        void GuardarDatos()
        {
            if (cmbTablas.Text == "alojamiento")
            {
                ealojamiento.Codigo = dtgDatos.CurrentRow.Cells["Codigo"].Value.ToString();
                ealojamiento.Fecha = dtgDatos.CurrentRow.Cells["Fecha"].Value.ToString();
                ealojamiento.FkHotel = dtgDatos.CurrentRow.Cells["fkHotel"].Value.ToString();
                ealojamiento.FkParticipante = dtgDatos.CurrentRow.Cells["fkParticipante"].Value.ToString();
                if (AbrirVentata == true)
                {
                    frmAlojamiento alojar = new frmAlojamiento();
                    alojar.ShowDialog();
                }
            }
            else if (cmbTablas.Text == "anteriorescampeonatos")
            {
                eantercamp.FkParticipante = dtgDatos.CurrentRow.Cells["fkParticipante"].Value.ToString();
                eantercamp.Nombre = dtgDatos.CurrentRow.Cells["Nombre"].Value.ToString();
                eantercamp.Tipo_Participacion = dtgDatos.CurrentRow.Cells["Tipo_Participacion"].Value.ToString();
                if (AbrirVentata == true)
                {
                    frmAnterCamo anter = new frmAnterCamo();
                    anter.ShowDialog();
                }
            }
            else if (cmbTablas.Text == "hotel")
            {
                ehotel.NombreHotel = dtgDatos.CurrentRow.Cells["NombreHotel"].Value.ToString();
                ehotel.Ciudad = dtgDatos.CurrentRow.Cells["Ciudad"].Value.ToString();
                ehotel.Colonia = dtgDatos.CurrentRow.Cells["Colonia"].Value.ToString();
                ehotel.Calle = dtgDatos.CurrentRow.Cells["Calle"].Value.ToString();
                ehotel.Numero = int.Parse(dtgDatos.CurrentRow.Cells["Numero"].Value.ToString());
                ehotel.Telefono = dtgDatos.CurrentRow.Cells["Telefono"].Value.ToString();
                if (AbrirVentata == true)
                {
                    frmHotel hotel = new frmHotel();
                    hotel.ShowDialog();
                }
            }
            else if (cmbTablas.Text == "jornada")
            {
                if (AbrirVentata == true)
                {

                }
            }
            else if (cmbTablas.Text == "jugada")
            {
                if (AbrirVentata == true)
                {

                }
            }
            else if (cmbTablas.Text == "pais")
            {
                if (AbrirVentata == true)
                {

                }
            }
            else if (cmbTablas.Text == "participante")
            {
                if (AbrirVentata == true)
                {

                }
            }
            else if (cmbTablas.Text == "partida")
            {
                if (AbrirVentata == true)
                {

                }
            }
            else if (cmbTablas.Text == "sala")
            {
                if (AbrirVentata == true)
                {

                }
            }
            else
            {
            
            }
        }
        // < Botones de EDICIÓN
        void Anadir()
        {
            AbrirVentata = true;
            if (Seleccionado != "none")
            {
                ModoEdit = false;
                GuardarDatos();
            }
            else
            {
                MessageBox.Show("Selecciona una tabla");
            }
            
        }
        void Eliminar()
        {
            AbrirVentata = false;
            GuardarDatos();
            if (cmbTablas.Text == "alojamiento")
            {
                _alojamiento.DelAlojamiento(ealojamiento);
            }
            else if (cmbTablas.Text == "anteriorescampeonatos")
            {
                _campanter.DelCampeonatosAnteriores(eantercamp);
            }
            else if (cmbTablas.Text == "hotel")
            {
                _hotel.DelHotel(ehotel);
            }
            else if (cmbTablas.Text == "jornada")
            {

            }
            else if (cmbTablas.Text == "jugada")
            {

            }
            else if (cmbTablas.Text == "pais")
            {

            }
            else if (cmbTablas.Text == "participante")
            {

            }
            else if (cmbTablas.Text == "partida")
            {

            }
            else if (cmbTablas.Text == "sala")
            {

            }
            else
            {

            }
        }
        void Editar()
        {
            AbrirVentata = true;
            if (Seleccionado !="none")
            {
                 ModoEdit = true;
                 GuardarDatos();
            }
            else 
            {
                MessageBox.Show("Selecciona una tabla");
            }
        }
        // BOTONES DE EDICIÓN >

        //EVENTOS FORMULARIO
        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void cmbTablas_TextChanged(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Anadir();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            Editar();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            Eliminar();
        }
    }
}
