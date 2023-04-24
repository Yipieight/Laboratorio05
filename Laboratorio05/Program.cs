namespace Laboratorio05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Equipo equipo1 = new Equipo("Barcelona",3,0,0,0,0);
            Equipo equipo2 = new Equipo("Read Madrid",3,0,0,0,0);

            Partido pardido = new Partido(equipo1, equipo1);

            for(int i = 0;i < 10; i++)
            {
                Console.WriteLine(pardido.SeleccionarEquipoGanador().GetNombre());
            }

            Torneo.SimularTorneo(null);
        }
    }
}