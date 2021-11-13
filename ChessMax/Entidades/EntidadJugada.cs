namespace Entidades
{
    public class EntidadJugada
    {
        public EntidadJugada(string codigo, string movimiento, string comentario, string fkIdSala)
        {
            Codigo = codigo;
            Movimiento = movimiento;
            Comentario = comentario;
            FkIdSala = fkIdSala;
        }

        public string Codigo { get; set; }
        public string Movimiento { get; set; }
        public string Comentario { get; set; }
        public string FkIdSala { get; set; }
    }
}
