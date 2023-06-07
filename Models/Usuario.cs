namespace AlcivarSuarez.Models
{
    public class Usuario
    {
        public int Id { get; set; }
        public String NombreUsuario { get; set; }
        public int Clave { get; set; }
        public Boolean Estado { get; set; }
        public int GeneroID { get; set; }
        public Genero Genero { get; set; }
        public int PaisID { get; set; }
        public Pais Pais { get; set; }
    }
}
