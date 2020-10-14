namespace ApiQL.Models {
    public class Album {
        public System.Guid Id { get; set; }
        public string Nombre { get; set; }                
        public Artista Artista { get; set; }
    }
}