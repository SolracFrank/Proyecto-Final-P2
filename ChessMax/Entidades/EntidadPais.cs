namespace Entidades
{
    public class EntidadPais
    {
        public EntidadPais(string no_Correlativo, string nombre, int num_Clubes, string fk_Representante)
        {
            No_Correlativo = no_Correlativo;
            Nombre = nombre;
            Num_Clubes = num_Clubes;
            Fk_Representante = fk_Representante;
        }
        public EntidadPais()
        {

        }
        public string No_Correlativo { get; set; }
        public string Nombre { get; set; }
        public int Num_Clubes { get; set; }
        public string Fk_Representante { get; set; }
    }
}
