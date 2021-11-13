using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using AccesoDatos;

namespace Manejadores
{
    public class ManejadorPais
    {
        conexion _base;
        public ManejadorPais()
        {
            _base = new conexion("localhost", "root", "", "clubajedrez", 3306);
        }
    }
}
