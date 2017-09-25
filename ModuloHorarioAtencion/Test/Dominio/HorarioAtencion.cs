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
        //string label = "cerrado";
        //TimeSpan HoraApertura;
        //TimeSpan HoraCierre;

        //public string Estado()
        //{
        //    if (DiasApertura(ahora) && HorarioApertura(ahora, HoraApertura, HoraCierre))
        //    {
        //        return label = "abierto";
                

        //    }
        //    else
        //    {
        //        return label = "cerrado";
                
        //    }
        //}
        public string HorarioApertura(DateTime ahora, TimeSpan apertura, TimeSpan cierre)
        {
            string horarioLaboral = "cerrado";

            if (ahora.TimeOfDay.CompareTo(apertura) >= 0 && ahora.TimeOfDay.CompareTo(cierre) <= 0)
            {
                horarioLaboral = "abierto";
            }
            return horarioLaboral;
        }

        public bool DiasApertura(DateTime ahora)
        {


            bool diaLaboral = false;
            switch (ahora.DayOfWeek)
            {

                case DayOfWeek.Friday:
                case DayOfWeek.Monday:
                case DayOfWeek.Thursday:
                case DayOfWeek.Tuesday:
                case DayOfWeek.Wednesday:
                case DayOfWeek.Saturday:
                case DayOfWeek.Sunday:
                    diaLaboral = true;
                    break;
                default:
                    break;
            }
            return diaLaboral;
        }
    }
}
