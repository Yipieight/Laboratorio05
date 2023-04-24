namespace Laboratorio05
{
    public class Torneo
    {
        public static Equipo[][] SimularTorneo(Equipo[] equipos)
        {
            if (equipos.Length < 2 || !isPowerOf2(equipos.Length))
            {
                throw new Exception("La cantidad de equipos debe ser una potencia de dos y deben existir al menos dos equipos");
            }
            int newSize = (int)Math.Log2(equipos.Length) + 1;

            Equipo[][] resultado = new Equipo[newSize][];

            resultado[0] = equipos;

            int equiposRestantes = equipos.Length;
            int fase = 1;

            while (equiposRestantes > 1)
            {
                resultado[fase] = new Equipo[equiposRestantes / 2];

                for (int i = 0; i < equiposRestantes / 2; i++)
                {
                    Partido partido = new Partido(resultado[fase - 1][i], resultado[fase - 1][equiposRestantes - i - 1]);
                    Equipo ganador = partido.SeleccionarEquipoGanador();
                    resultado[fase][i] = ganador;
                }

                equiposRestantes = equiposRestantes / 2;

                fase++;
            }

            return resultado;
        }

        private static bool isPowerOf2(int x)
        {
            double log2 = Math.Log2(x);

            return (log2 - (int)log2) == 0.0;
        }

        private static Equipo[] copyArray(Equipo[] equipos)
        {
            Equipo[] copy = new Equipo[equipos.Length];

            for (int i = 0; i < equipos.Length; i++)
            {
                copy[i] = equipos[i];
            }

            return copy;
        }
    }
}