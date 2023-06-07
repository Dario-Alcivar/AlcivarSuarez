namespace AlcivarSuarez.Models
{
    public class Genero
    {
        public int Id { get; set; }
        public String TipoGenero { get; set; }
        public Boolean Estado { get; set; }
        public ICollection<Usuario> usuarios { get; set; }
    }
}
