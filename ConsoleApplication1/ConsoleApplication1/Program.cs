using Dominio;
using System;

namespace Program

{
    public class Program
    {
        public static void Main(string[] args)
        {


            DateTime ahora = DateTime.Now.ToLocalTime();
            string label = "cerrado";
            TimeSpan HoraApertura;
            TimeSpan HoraCierre;
            string hrApertura, hrCierre;

            Console.WriteLine("Ingrese un horario de apertura, ej: 00,00,0");
            hrApertura = Console.ReadLine();
            HoraApertura = TimeSpan.Parse(hrApertura);

            Console.WriteLine("Ingrese un horario de cierre, ej: 00,00,0");
            hrCierre = Console.ReadLine();
            HoraCierre = TimeSpan.Parse(hrCierre);


            if (DiasApertura(ahora) && HorarioApertura(ahora, HoraApertura, HoraCierre))
            {
                label = "abierto";
                Console.WriteLine(label);

            }
            else
            {
                Console.WriteLine(label);
            }
        }

        private static bool HorarioApertura(DateTime ahora, TimeSpan apertura, TimeSpan cierre)
        {
            bool horarioLaboral = false;

            if (ahora.TimeOfDay.CompareTo(apertura) >= 0 && ahora.TimeOfDay.CompareTo(cierre) <= 0)
            {
                horarioLaboral = true;
            }
            return horarioLaboral;
        }

        private static bool DiasApertura(DateTime ahora)
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


