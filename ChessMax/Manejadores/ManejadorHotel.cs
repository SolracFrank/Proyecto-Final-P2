using Entidades;
using AccesoDatos;
using System.Windows.Forms;

namespace Manejadores
{
    public class ManejadorHotel
    {
        conexion _base;
        public ManejadorHotel()
        {
            _base = new conexion("localhost", "root", "", "clubajedrez", 3306);
        }
        public void AddHotel(EntidadHotel Hotel)
        {
            _base.Consultar(string.Format("CALL p_addHotel('{0}','{1}','{2}','{3}',{4},'{5}');",Hotel.NombreHotel,Hotel.Ciudad,Hotel.Colonia,Hotel.Calle,Hotel.Numero,Hotel.Telefono));
        }
        public void DelHotel(EntidadHotel Hotel)
        {
            _base.Consultar(string.Format("CALL p_delHotel('{0}');", Hotel.NombreHotel));
        }
        public void updateHotel(EntidadHotel Hotel)
        {
            _base.Consultar(string.Format("CALL p_updateHotel('{0}', '{1}', '{2}', '{3}',{4},'{5}'); ",Hotel.NombreHotel,Hotel.Ciudad,Hotel.Colonia,Hotel.Calle,Hotel.Numero,Hotel.Telefono));
        }
        public void MostrarHotel(DataGridView tabla, string dato)
        {
            tabla.DataSource = _base.ObtenerDatos(string.Format("SELECT * FROM hotel WHERE NombreHotel LIKE '%{0}%';", dato), "hotel").Tables["hotel"];
            tabla.AutoResizeColumns();
        }
    }
}
