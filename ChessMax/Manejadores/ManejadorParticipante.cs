using Entidades;
using AccesoDatos;
using System.Windows.Forms;

namespace Manejadores
{
    public class ManejadorParticipante
    {
        conexion _base;
        public ManejadorParticipante()
        {
            _base = new conexion("localhost", "root", "", "clubajedrez", 3306);
        }
        public void AddParticipante(EntidadParticipante participante)
        {
            _base.Consultar(string.Format("CALL p_addParticipante('{0}','{1}',{2},'{3}','{4}',{5},'{6}');", participante.NoAsociado,participante.Nombre,participante.ApellidoP,participante.ApellidoM,participante.Tipo_Participacion,participante.Nivel,participante.FkPais));
        }
        public void DelParticipante(EntidadParticipante participante)
        {
            _base.Consultar(string.Format("CALL p_delParticipante('{0}');",participante.NoAsociado));
        }
        public void updateParticipante(EntidadParticipante participante)
        {
            _base.Consultar(string.Format("CALL p_updateParticipante('{0}','{1}',{2},'{3}','{4}',{5},'{6}');", participante.NoAsociado, participante.Nombre, participante.ApellidoP, participante.ApellidoM, participante.Tipo_Participacion, participante.Nivel, participante.FkPais));
        }
        public void MostrarParticipante(DataGridView tabla, string dato)
        {
            tabla.DataSource = _base.ObtenerDatos(string.Format("SELECT * FROM participante WHERE No_Asociado LIKE '%{0}%';", dato), "participante").Tables["participante"];
            tabla.AutoResizeColumns();
        }
    }
}
