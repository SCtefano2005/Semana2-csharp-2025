using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana2
{
    public class Conductor
    {
        public string NombreConductor { get; set; }
        public string Licencia { get; set; }
        public string Transporte { get; set; }

        // Lista estática para almacenar todos los conductores creados
        public static List<Conductor> ListaConductores { get; set; } = new List<Conductor>();
    }
}
