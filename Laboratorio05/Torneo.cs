using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio05
{
    public class Torneo
    {
        public static Equipo[][] SimularTorneo(Equipo[] equipos)
        {
            if (equipos.Length < 2 || !IsPowerOf2(equipos.Length))
            {
                throw new ArgumentException("La cantidad de equipos debe ser una potencia de dos y deben existir al menos dos equipos");
            }

            int newSize = GetNewSize(equipos.Length);

            Equipo[][] result = new Equipo[newSize][];
            result[0] = equipos;

            int equiposRestantes = equipos.Length;
            int fase = 1;

            while (equiposRestantes > 1)
            {
                result[fase] = new Equipo[equiposRestantes / 2];

                for (int i = 0; i < equiposRestantes / 2; i++)
                {
                    Equipo equipoA = result[fase - 1][i];
                    Equipo equipoB = result[fase - 1][equiposRestantes - i - 1];

                    Partido partido = new Partido(equipoA, equipoB);

                    Equipo ganador = partido.SeleccionarEquipoGanador();

                    result[fase][i] = ganador;
                }

                equiposRestantes /= 2;
                fase++;
            }

            return result;
        }

        private static bool IsPowerOf2(int x)
        {
            return (x > 0) && ((x & (x - 1)) == 0);
        }

        private static int GetNewSize(int length)
        {
            return (int)Math.Log2(length) + 1;
        }
    }
}
