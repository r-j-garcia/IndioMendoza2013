using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using IndioMendoza2013.OrigenesDeDatos;

namespace IndioMendoza2013.Datos
{
    public class ServicioBase
    {
        public IndioMendoza2013Entities bd;
        private string strConexion;

        public ServicioBase(string strConexion)
        {
            // TODO: Complete member initialization
            this.strConexion = strConexion;
            bd = new IndioMendoza2013Entities(strConexion);
        }

    }
}
