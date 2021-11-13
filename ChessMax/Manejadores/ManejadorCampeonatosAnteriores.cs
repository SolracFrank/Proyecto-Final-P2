using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using AccesoDatos;

namespace Manejadores
{
    public class ManejadorCampeonatosAnteriores
    {
        conexion _base;
        public ManejadorCampeonatosAnteriores()
        {
            _base = new conexion("localhost", "root", "", "clubajedrez", 3306);
        }
    }
}
