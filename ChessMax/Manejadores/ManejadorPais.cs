using Entidades;
using AccesoDatos;
using System.Windows.Forms;

namespace Manejadores
{
    public class ManejadorPais
    {
        conexion _base;
        public ManejadorPais()
        {
            _base = new conexion("localhost", "root", "", "clubajedrez", 3306);
        }
        public void AddPais(EntidadPais Pais)
        {
            _base.Consultar(string.Format("CALL p_addPais('{0}','{1}',{2},'{3}');",Pais.No_Correlativo,Pais.Nombre,Pais.Num_Clubes,Pais.Fk_Representante));
        }
        public void AddPaisNoRep(EntidadPais Pais)
        {
            _base.Consultar(string.Format("CALL P_addPaisNoRep('{0}','{1}',{2});", Pais.No_Correlativo, Pais.Nombre, Pais.Num_Clubes));
        }
        public void DelPais(EntidadPais Pais)
        {
            _base.Consultar(string.Format("CALL p_delPais('{0}');",Pais.No_Correlativo));
        }
        public void updatePais(EntidadPais Pais)
        {
            _base.Consultar(string.Format("CALL p_updatePais('{0}','{1}',{2},'{3}');", Pais.No_Correlativo, Pais.Nombre, Pais.Num_Clubes, Pais.Fk_Representante));
        }
        public void MostrarPais(DataGridView tabla, string dato)
        {
            tabla.DataSource = _base.ObtenerDatos(string.Format("SELECT * FROM pais WHERE No_Correlativo LIKE '%{0}%';", dato), "pais").Tables["pais"];
            tabla.AutoResizeColumns();
        }
    }
}
