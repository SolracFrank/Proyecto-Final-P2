namespace Entidades
{
    public class EntidadSala
    {
        public EntidadSala(string idSala, int capacidad, byte tv, byte radio, byte video, string fkHotel)
        {
            IdSala = idSala;
            Capacidad = capacidad;
            Tv = tv;
            Radio = radio;
            Video = video;
            FkHotel = fkHotel;
        }
        public string IdSala { get; set; }
        public int Capacidad { get; set; }
        public byte Tv { get; set; }
        public byte Radio { get; set; }
        public byte Video { get; set; }
        public string FkHotel { get; set; }
    }
}
