namespace LeerData
{
    public class Comentario
    {
        public int ComentarioId {get;set;}
        public string Alumno { get; set; } = string.Empty;
        public int Puntaje {get;set;}
        public string ComentarioTexto { get; set; } = string.Empty;
        public int LibroId {get;set;}
        public Libro? Libro {get;set;}
    }
}