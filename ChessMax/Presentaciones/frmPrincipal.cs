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
        public static EntidadJornada ejornada;
        public static EntidadJugada ejugada;
        public static EntidadPais epais;
        public static EntidadPartida epartida;
        public static EntidadParticipante eparticipante;
        public static EntidadSala esala;
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
            _jornada = new ManejadorJornada(); ejornada = new EntidadJornada();
            _jugada = new ManejadorJugada(); ejugada = new EntidadJugada();
            _pais = new ManejadorPais(); epais = new EntidadPais();
            _partida = new ManejadorPartida(); epartida = new EntidadPartida();
            _sala = new ManejadorSala();  esala = new EntidadSala();
            _participante = new ManejadorParticipante(); eparticipante = new EntidadParticipante();
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
                ejornada.Codigo = dtgDatos.CurrentRow.Cells["codigo"].Value.ToString();
                ejornada.Fecha = dtgDatos.CurrentRow.Cells["fecha"].Value.ToString();
                ejornada.FkSala = dtgDatos.CurrentRow.Cells["fkSala"].Value.ToString();
                if (AbrirVentata == true)
                {
                    frmJornada jornada = new frmJornada();
                    jornada.ShowDialog();
                }
            }
            else if (cmbTablas.Text == "jugada")
            {
                ejugada.Codigo = dtgDatos.CurrentRow.Cells["codigo"].Value.ToString();
                ejugada.Movimiento = dtgDatos.CurrentRow.Cells["movimiento"].Value.ToString();
                ejugada.Comentario = dtgDatos.CurrentRow.Cells["comentario"].Value.ToString();
                ejugada.FkidPartida = dtgDatos.CurrentRow.Cells["fkIdPartida"].Value.ToString();
                if (AbrirVentata == true)
                {
                    frmJugada jugada = new frmJugada();
                    jugada.ShowDialog();
                }
            }
            else if (cmbTablas.Text == "pais")
            {
                epais.No_Correlativo = dtgDatos.CurrentRow.Cells["No_Correlativo"].Value.ToString();
                epais.Nombre = dtgDatos.CurrentRow.Cells["Nombre"].Value.ToString();
                epais.Fk_Representante = dtgDatos.CurrentRow.Cells["fkRepresentante"].Value.ToString();
                epais.Num_Clubes = int.Parse(dtgDatos.CurrentRow.Cells["Num_Clubes"].Value.ToString());
                if (AbrirVentata == true)
                {
                    frmPais pais = new frmPais();
                    pais.ShowDialog();
                }
            }
            else if (cmbTablas.Text == "participante")
            {
                eparticipante.NoAsociado = dtgDatos.CurrentRow.Cells["No_Asociado"].Value.ToString();
                eparticipante.Nombre = dtgDatos.CurrentRow.Cells["Nombre"].Value.ToString();
                eparticipante.ApellidoP = dtgDatos.CurrentRow.Cells["ApellidoP"].Value.ToString();
                eparticipante.ApellidoM = dtgDatos.CurrentRow.Cells["ApellidoM"].Value.ToString();
                eparticipante.Tipo_Participacion = dtgDatos.CurrentRow.Cells["Tipo_Participacion"].Value.ToString();
                eparticipante.Nivel = int.Parse(dtgDatos.CurrentRow.Cells["NivelJuego"].Value.ToString());
                eparticipante.FkPais = dtgDatos.CurrentRow.Cells["fkPais"].Value.ToString();
                if (AbrirVentata == true)
                {
                    frmParticipante participante = new frmParticipante();
                    participante.ShowDialog();
                }
            }
            else if (cmbTablas.Text == "partida")
            {
                epartida.Codigo = ejugada.FkidPartida = dtgDatos.CurrentRow.Cells["codigo"].Value.ToString();
                epartida.FkJugador1Blancas = ejugada.FkidPartida = dtgDatos.CurrentRow.Cells["fkJugador1Blancas"].Value.ToString();
                epartida.FkJugador2Negras = ejugada.FkidPartida = dtgDatos.CurrentRow.Cells["fkJugador2Negras"].Value.ToString();
                epartida.FkArbitro = ejugada.FkidPartida = dtgDatos.CurrentRow.Cells["fkArbitro"].Value.ToString();
                epartida.Resultadp = ejugada.FkidPartida = dtgDatos.CurrentRow.Cells["resultado"].Value.ToString();
                epartida.FkJornada = ejugada.FkidPartida = dtgDatos.CurrentRow.Cells["fkJornada"].Value.ToString();
                if (AbrirVentata == true)
                {
                    frmPartida partida = new frmPartida();
                    partida.ShowDialog();
                }
            }
            else if (cmbTablas.Text == "sala")
            {
                esala.IdSala = dtgDatos.CurrentRow.Cells["Sala"].Value.ToString();
                esala.Radio = byte.Parse(dtgDatos.CurrentRow.Cells["Radio"].Value.ToString());
                esala.Tv = byte.Parse(dtgDatos.CurrentRow.Cells["TV"].Value.ToString());
                esala.Video = byte.Parse(dtgDatos.CurrentRow.Cells["Video"].Value.ToString());
                esala.Capacidad = int.Parse(dtgDatos.CurrentRow.Cells["Capacidad"].Value.ToString());
                esala.FkHotel = dtgDatos.CurrentRow.Cells["fkHotel"].Value.ToString();
                if (AbrirVentata == true)
                {
                    frmSala sala = new frmSala();
                    sala.ShowDialog();
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
                _jornada.DelJornada(ejornada);
            }
            else if (cmbTablas.Text == "jugada")
            {
                _jugada.DelJugada(ejugada);
            }
            else if (cmbTablas.Text == "pais")
            {
                _pais.DelPais(epais);
            }
            else if (cmbTablas.Text == "participante")
            {
                _participante.DelParticipante(eparticipante);
            }
            else if (cmbTablas.Text == "partida")
            {
                _partida.DelPartida(epartida);
            }
            else if (cmbTablas.Text == "sala")
            {
                _sala.DelSala(esala);
            }
            else
            {
                MessageBox.Show("No tabla seleccionada");
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
