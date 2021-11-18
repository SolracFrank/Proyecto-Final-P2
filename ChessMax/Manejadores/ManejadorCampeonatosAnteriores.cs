using AccesoDatos;
using Entidades;
using System.Windows.Forms;

namespace Manejadores
{
    public class ManejadorCampeonatosAnteriores
    {
        conexion _base;
        public ManejadorCampeonatosAnteriores()
        {
            _base = new conexion("localhost", "root", "", "clubajedrez", 3306);
        }
        public void AddCampeonatosAnteriores(EntidadCampeonatosAnteriores campAnt)
        {
            _base.Consultar(string.Format("CALL p_addAnterCamp('{0}','{1}','{2}');", campAnt.FkParticipante,campAnt.Nombre,campAnt.Tipo_Participacion));
        }
        public void DelCampeonatosAnteriores(EntidadCampeonatosAnteriores campAnt)
        {
            _base.Consultar(string.Format("CALL p_delAnterCamp('{0}','{1}');", campAnt.FkParticipante, campAnt.Nombre));
        }
        public void updateCampeonatosAnteriores(EntidadCampeonatosAnteriores campAnt)
        {
            _base.Consultar(string.Format("CALL p_updateAnterCamp('{0}','{1}','{2}');", campAnt.FkParticipante, campAnt.Nombre, campAnt.Tipo_Participacion));
        }
        public void MostrarCampeonatosAnteriores(DataGridView tabla, string dato)
        {
            tabla.DataSource = _base.ObtenerDatos(string.Format("SELECT * FROM anteriorescampeonatos WHERE Nombre LIKE '%{0}%' OR fkParticipante LIKE '%{1}%';", dato,dato), "anteriorescampeonatos").Tables["anteriorescampeonatos"];
            tabla.AutoResizeColumns();
        }
    }
}
