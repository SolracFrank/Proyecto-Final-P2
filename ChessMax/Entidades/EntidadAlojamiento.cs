namespace Entidades
{
    public class EntidadAlojamiento
    {
        public EntidadAlojamiento(string codigo, string fecha, string fkHotel, string fkParticipante)
        {
            Codigo = codigo;
            Fecha = fecha;
            FkHotel = fkHotel;
            FkParticipante = fkParticipante;
        }

        public string Codigo { get; set; }
        public string Fecha { get; set; }
        public string FkHotel { get; set; }
        public string FkParticipante { get; set; }

    }
}
