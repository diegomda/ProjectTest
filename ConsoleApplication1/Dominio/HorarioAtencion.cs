using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class HorarioAtencion
    {
        DateTime ahora = DateTime.Now.ToLocalTime();
        string label = "cerrado";
        TimeSpan HoraApertura;
        TimeSpan HoraCierre;

        public void Estado()
        {
            if (DiasApertura(ahora) && HorarioApertura(ahora, HoraApertura, HoraCierre))
            {
                label = "abierto";

            }
            else
            {
                label = "cerrado";
            }
        }
        public  bool HorarioApertura(DateTime ahora, TimeSpan apertura, TimeSpan cierre)
        {
            bool horarioLaboral = false;

            if (ahora.TimeOfDay.CompareTo(apertura) >= 0 && ahora.TimeOfDay.CompareTo(cierre) <= 0)
            {
                horarioLaboral = true;
            }
            return horarioLaboral;
        }

        public  bool DiasApertura(DateTime ahora)
        {
            bool diaLaboral = false;
            switch (ahora.DayOfWeek)
            {
                case DayOfWeek.Friday:
                case DayOfWeek.Monday:
                case DayOfWeek.Thursday:
                case DayOfWeek.Tuesday:
                case DayOfWeek.Wednesday:
                    diaLaboral = true;
                    break;
                default:
                    break;
            }
            return diaLaboral;
        }
    }
}
