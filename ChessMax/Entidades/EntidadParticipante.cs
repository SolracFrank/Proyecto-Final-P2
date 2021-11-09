namespace Entidades
{
    public class EntidadParticipante
    {
        public EntidadParticipante(string noAsociado, string nombre, string apellidoP, string apellidoM, string tipo_Participacion, int nivel, string fkPais)
        {
            NoAsociado = noAsociado;
            Nombre = nombre;
            ApellidoP = apellidoP;
            ApellidoM = apellidoM;
            Tipo_Participacion = tipo_Participacion;
            Nivel = nivel;
            FkPais = fkPais;
        }

        public string NoAsociado { get; set; }
        public string Nombre { get; set; }
        public string ApellidoP { get; set; }
        public string ApellidoM { get; set; }
        public string Tipo_Participacion { get; set; }
        public int Nivel { get; set; }
        public string FkPais { get; set; }
    }
}
