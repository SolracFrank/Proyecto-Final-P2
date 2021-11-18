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

namespace Presentaciones
{
    public partial class frmPrincipal : Form
    {
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
            _alojamiento = new ManejadorAlojamiento();
            _campanter = new ManejadorCampeonatosAnteriores();
            _hotel = new ManejadorHotel();
            _jornada = new ManejadorJornada();
            _jugada = new ManejadorJugada();
            _pais = new ManejadorPais();
            _partida = new ManejadorPartida();
            _sala = new ManejadorSala();
            _participante = new ManejadorParticipante();
            InitializeComponent();
        }
        void Cargar()
        {
            if (cmbTablas.Text== "alojamiento")
            {
                _alojamiento.MostrarAlojamiento(dtgDatos, txtBuscar.Text);
            }
            else if (cmbTablas.Text== "anteriorescampeonatos")
            {
                _campanter.MostrarCampeonatosAnteriores(dtgDatos, txtBuscar.Text);
            }
            else if (cmbTablas.Text == "hotel")
            {
                _hotel.MostrarHotel(dtgDatos, txtBuscar.Text);
            }
            else if (cmbTablas.Text == "jornada")
            {
                _jornada.MostrarJornada(dtgDatos, txtBuscar.Text);
            }
            else if (cmbTablas.Text == "jugada")
            {
                _jugada.MostrarJugada(dtgDatos, txtBuscar.Text);
            }
            else if (cmbTablas.Text == "pais")
            {
                _pais.MostrarPais(dtgDatos, txtBuscar.Text);
            }
            else if (cmbTablas.Text == "participante")
            {
                _participante.MostrarParticipante(dtgDatos, txtBuscar.Text);
            }
            else if (cmbTablas.Text == "partida")
            {
                _partida.MostrarPartida(dtgDatos, txtBuscar.Text);
            }
            else if (cmbTablas.Text == "sala")
            {
                _sala.MostrarSala(dtgDatos, txtBuscar.Text);
            }
            else
            {
                dtgDatos.DataSource = null;
            }
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            Cargar();
        }

        private void cmbTablas_TextChanged(object sender, EventArgs e)
        {
            Cargar();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            Cargar();
        }
    }
}
