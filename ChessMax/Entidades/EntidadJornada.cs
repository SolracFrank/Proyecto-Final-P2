namespace Entidades
{
    public class EntidadJornada
    {
        public EntidadJornada(string codigo, string fecha, string fkSala)
        {
            Codigo = codigo;
            Fecha = fecha;
            FkSala = fkSala;
        }

        public string Codigo { get; set; }
        public string Fecha { get; set; }
        public string FkSala { get; set; }
        public EntidadJornada()
        {

        }
    }
}
