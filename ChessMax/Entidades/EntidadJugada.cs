namespace Entidades
{
    public class EntidadJugada
    {
        public EntidadJugada(string codigo, string movimiento, string comentario, string fkIdPartida)
        {
            Codigo = codigo;
            Movimiento = movimiento;
            Comentario = comentario;
            FkidPartida = fkIdPartida;
        }

        public string Codigo { get; set; }
        public string Movimiento { get; set; }
        public string Comentario { get; set; }
        public string FkidPartida { get; set; }
    }
}
