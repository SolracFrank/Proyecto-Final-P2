using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccesoDatos;
using Entidades;

namespace Manejadores
{
    public class ManejadorAlojamiento
    {
        conexion _base;
        public ManejadorAlojamiento()
        {
            _base = new conexion("localhost", "root", "", "clubajedrez", 3306);
        }

        public void AddAlojamiento(EntidadAlojamiento alojar)
        {
            _base.Consultar(string.Format("CALL p_addAlojamiento('{0}','{1}','{2}','{3}');", alojar.Codigo, alojar.Fecha, alojar.FkHotel, alojar.FkParticipante));
        }
        public void DelAlojamiento(EntidadAlojamiento alojar)
        {
            _base.Consultar(string.Format("CALL p_delAlojamiento('{0}');", alojar.Codigo));
        }
        public void updateAlojamiento(EntidadAlojamiento alojar)
        {
            _base.Consultar(string.Format("CALL p_updateAlojamiento('{0}','{1}','{2}','{3}');", alojar.Codigo, alojar.Fecha, alojar.FkHotel, alojar.FkParticipante));
        }
        public void MostrarAlojamiento(DataGridView tabla, string dato)
        {

        }
    }
}
