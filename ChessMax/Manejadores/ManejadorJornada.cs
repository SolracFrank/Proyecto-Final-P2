using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using AccesoDatos;

namespace Manejadores
{
    public class ManejadorJornada
    {
        conexion _base;
        public ManejadorJornada()
        {
            _base = new conexion("localhost", "root", "", "clubajedrez", 3306);
        }
    }
}
