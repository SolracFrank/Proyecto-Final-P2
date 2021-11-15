using Entidades;
using AccesoDatos;
using System.Windows.Forms;

namespace Manejadores
{
    public class ManejadorJugada
    {
        conexion _base;
        public ManejadorJugada()
        {
            _base = new conexion("localhost", "root", "", "clubajedrez", 3306);
        }
        public void AddJugada(EntidadJugada jugada)
        {
            _base.Consultar(string.Format("CALL p_addJugada('{0}','{1}','{2}','{3}');", jugada.Codigo,jugada.Movimiento,jugada.Comentario,jugada.FkidPartida));
        }
        public void DelJugada(EntidadJugada jugada)
        {
            _base.Consultar(string.Format("CALL p_delJugada('{0}');", jugada.Codigo));
        }
        public void updateJugada(EntidadJugada jugada)
        {
            _base.Consultar(string.Format("CALL p_updateJugada('{0}','{1}','{2}','{3}');", jugada.Codigo, jugada.Movimiento, jugada.Comentario, jugada.FkidPartida));
        }
        public void MostrarJugada(DataGridView tabla, string dato)
        {
            tabla.DataSource = _base.ObtenerDatos(string.Format("SELECT * FROM jugada WHERE codigo LIKE '%{0}%';", dato), "jugada").Tables["jugada"];
            tabla.AutoResizeColumns();
        }
    }
}
