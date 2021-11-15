using Entidades;
using AccesoDatos;
using System.Windows.Forms;

namespace Manejadores
{
    public class ManejadorJornada
    {
        conexion _base;
        public ManejadorJornada()
        {
            _base = new conexion("localhost", "root", "", "clubajedrez", 3306);
        }
        public void AddJornada(EntidadJornada Jornada)
        {
            _base.Consultar(string.Format("CALL p_addJornada('{0}','{1}','{2}');",Jornada.Codigo,Jornada.Fecha,Jornada.FkSala));
        }
        public void DelJornada(EntidadJornada Jornada)
        {
            _base.Consultar(string.Format("CALL p_delJornada('{0}');", Jornada.Codigo));
        }
        public void updateJornada(EntidadJornada Jornada)
        {
            _base.Consultar(string.Format("CALL p_updateJornada('{0}','{1}','{2}');", Jornada.Codigo, Jornada.Fecha, Jornada.FkSala));
        }
        public void MostrarJornada(DataGridView tabla, string dato)
        {
            tabla.DataSource = _base.ObtenerDatos(string.Format("SELECT * FROM jornada WHERE codigo LIKE '%{0}%';", dato), "jornada").Tables["jornada"];
            tabla.AutoResizeColumns();
        }
    }
}
