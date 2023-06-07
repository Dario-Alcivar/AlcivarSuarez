namespace AlcivarSuarez.Models
{
    public class Pais
    {
        public int Id { get; set; }
        public String NombrePais { get; set; }
        public Boolean Estado { get; set; }
        public ICollection<Usuario> usuarios { get; set; }
    }
}
