namespace LeerData
{
    public class Autor
    {
        public int AutorId {get;set;}
        public string Nombre { get; set; } = string.Empty;
        public string Apellidos {get;set;} = string.Empty;
        public string Grado {get;set;} = string.Empty;
        public byte[]? FotoPerfil {get;set;}
        public ICollection<LibroAutor>? LibroLink {get;set;}
    }
}