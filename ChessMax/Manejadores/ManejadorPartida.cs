using Entidades;
using AccesoDatos;
using System.Windows.Forms;

namespace Manejadores
{
    public class ManejadorPartida
    {
        conexion _base;
        public ManejadorPartida()
        {
            _base = new conexion("localhost", "root", "", "clubajedrez", 3306);
        }
        public void AddPartida(EntidadPartida partida)
        {
            _base.Consultar(string.Format("CALL p_addPartida('{0}','{1}',{2},'{3}','{4}','{5}');",partida.Codigo,partida.FkJugador1Blancas,partida.FkJugador2Negras,partida.FkArbitro,partida.Resultadp,partida.FkJornada));
        }
        public void DelPartida(EntidadPartida partida)
        {
            _base.Consultar(string.Format("CALL p_delPartida('{0}');", partida.Codigo));
        }
        public void updatePartida(EntidadPartida partida)
        {
            _base.Consultar(string.Format("CALL p_updatePartida('{0}','{1}',{2},'{3}','{4}','{5}');", partida.Codigo, partida.FkJugador1Blancas, partida.FkJugador2Negras, partida.FkArbitro, partida.Resultadp, partida.FkJornada));
        }
        public void MostrarPartida(DataGridView tabla, string dato)
        {
            tabla.DataSource = _base.ObtenerDatos(string.Format("SELECT * FROM partida WHERE codigo LIKE '%{0}%';", dato), "partida").Tables["partida"];
            tabla.AutoResizeColumns();
        }
    }
}
