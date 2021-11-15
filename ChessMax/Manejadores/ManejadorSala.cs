using Entidades;
using AccesoDatos;
using System.Windows.Forms;

namespace Manejadores
{
    public class ManejadorSala
    {
        conexion _base;
        public ManejadorSala()
        {
            _base = new conexion("localhost", "root", "", "clubajedrez", 3306);
        }
        public void AddSala(EntidadSala sala)
        {
            _base.Consultar(string.Format("CALL p_addSala('{0}',{1},{2},{3},{4},'{5}');", sala.IdSala,sala.Capacidad,sala.Tv,sala.Radio,sala.Video,sala.FkHotel));
        }
        public void DelSala(EntidadSala sala)
        {
            _base.Consultar(string.Format("CALL p_delSala('{0}');",sala.IdSala));
        }
        public void UpdateSala(EntidadSala sala)
        {
            _base.Consultar(string.Format("CALL p_updateSala('{0}',{1},{2},{3},{4},'{5}');", sala.IdSala, sala.Capacidad, sala.Tv, sala.Radio, sala.Video, sala.FkHotel));
        }
        public void MostrarSala(DataGridView tabla, string dato)
        {
            tabla.DataSource = _base.ObtenerDatos(string.Format("SELECT * FROM sala WHERE sala LIKE '%{0}%';", dato), "sala").Tables["sala"];
            tabla.AutoResizeColumns();
        }


    }
}
