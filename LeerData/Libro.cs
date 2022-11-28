namespace LeerData
{
    public class Libro
    {
        public int LibroId {get;set;}
        public string Titulo { get; set; } = string.Empty;
        public string Descripcion { get; set; } = string.Empty;
        public DateTime FechaPublicacion { get;set; }
        public byte[]? FotoPortada { get; set; }
        public Precio? PrecioPromocion {get;set;}    
        public ICollection<Comentario>? ComentarioLista {get;set;}
        public ICollection<LibroAutor>? AutorLink {get;set;}
    }
}