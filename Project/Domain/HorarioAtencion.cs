using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class HorarioAtencion
    {
        DateTime ahora = DateTime.Now.ToLocalTime();


        public string HorarioApertura(DateTime ahora, TimeSpan apertura, TimeSpan cierre)
        {
            string horarioLaboral = "cerrado";

            if (ahora.TimeOfDay.CompareTo(apertura) >= 0 && ahora.TimeOfDay.CompareTo(cierre) <= 0)
            {
                horarioLaboral = "abierto";
            }
            return horarioLaboral;
        }

    }
}
