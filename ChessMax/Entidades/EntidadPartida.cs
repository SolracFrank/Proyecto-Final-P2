namespace Entidades
{
    public class EntidadPartida
    {
        public EntidadPartida(string codigo, string fkJugador1Blancas, string fkJugador2Negras, string fkArbitro, string resultadp, string fkJornada)
        {
            Codigo = codigo;
            FkJugador1Blancas = fkJugador1Blancas;
            FkJugador2Negras = fkJugador2Negras;
            FkArbitro = fkArbitro;
            Resultadp = resultadp;
            FkJornada = fkJornada;
        }
        public EntidadPartida()
        {

        }
        public string Codigo { get; set; }
        public string FkJugador1Blancas { get; set; }
        public string FkJugador2Negras { get; set; }
        public string FkArbitro { get; set; }
        public string Resultadp { get; set; }
        public string FkJornada { get; set; }
    }
}
