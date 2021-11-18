namespace Entidades
{
     public class EntidadCampeonatosAnteriores
    {
        public EntidadCampeonatosAnteriores(string fkParticipante, string nombre, string tipo_Participacion)
        {
            FkParticipante = fkParticipante;
            Nombre = nombre;
            Tipo_Participacion = tipo_Participacion;
        }
        public string FkParticipante { get; set; }
        public string Nombre { get; set; }
        public string Tipo_Participacion { get; set; }
        public EntidadCampeonatosAnteriores()
        {

        }

    }
}
