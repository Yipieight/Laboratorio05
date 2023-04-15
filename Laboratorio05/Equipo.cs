using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio05
{
    public class Equipo
    {
        private string nombre;
        private int partidosGanados;
        private int partidosEmpatados;
        private int partidosPerdidos;
        private int golesFavor;
        private int golesContra;
        public Equipo(string nombre, int partidosGanados, int partidosEmpatados, int partidosPerdidos, int golesFavor, int golesContra)
        {
            this.nombre = nombre;
            this.partidosGanados = partidosGanados;
            this.partidosEmpatados = partidosEmpatados;
            this.golesFavor = golesFavor;
            this.golesContra = golesContra;
        }

        public string GetNombre()
        {
            return "";
        }

        public int GetPartidosGanados()
        {
            return 0;
        }

        public int GetPartidosEmpatados()
        {
            return 0;
        }

        public int GetPartidosPerdidos()
        {
            return 0;
        }

        public int GetGolesFavor()
        {
            return 0;
        }

        public int GetGolesContra()
        {
            return 0;
        }
    }
}
