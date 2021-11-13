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


    }
}
