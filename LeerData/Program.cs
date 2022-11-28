using Microsoft.EntityFrameworkCore;

namespace LeerData
{
    class Program
    {
        static void Main(string[] args)
        {
            using(var db = new AppVentaLibrosContext())
            {
                #region GET
                var libros = db.Libro?.Include(x => x.AutorLink!).ThenInclude(x => x.Autor);

                if (libros is not null)
                {
                    foreach (var libro in libros!)
                    {
                        Console.WriteLine(libro.Titulo);

                        foreach (var autorLink in libro.AutorLink!)
                        {
                            Console.WriteLine("---- " + autorLink.Autor?.Nombre);
                        }
                    }
                }

                //var libros = db.Libro?.Include(x => x.ComentarioLista).AsNoTracking();

                //if (libros is not null)
                //{
                //    foreach (var libro in libros)
                //    {
                //        Console.WriteLine(libro.Titulo);

                //        foreach (var comentario in libro.ComentarioLista!)
                //        {
                //            Console.WriteLine("---- " + comentario.ComentarioTexto);
                //        }
                //    }
                //}

                //var libros = db.Libro?.Include( x => x.PrecioPromocion).AsNoTracking();

                //if (libros is not null)
                //{
                //    foreach (var libro in libros)
                //    {
                //        Console.WriteLine(libro.Titulo + " --- " + libro.PrecioPromocion?.PrecioActual);
                //    }
                //}

                //var libros = db.Libro?.AsNoTracking(); // IQueryable

                //if (libros != null)
                //{
                //    foreach (var libro in libros)
                //    {
                //        Console.WriteLine(libro.Titulo);
                //    }
                //}

                //var autor = db.Autor?.Single(x => x.AutorId == 1002);

                //if(autor != null)
                //{
                //    db.Remove(autor);
                //    var estadoTransaccion = db.SaveChanges();
                //    Console.WriteLine("Estado de transaccion ===> " + estadoTransaccion);
                //}
                #endregion

                #region POST

                //var nuevoAutor = new Autor
                //{
                //    Nombre = "NuevoAutor",
                //    Apellidos = "Appelidos NuewvoAutor",
                //    Grado = "Master"
                //};

                //db.Add(nuevoAutor);

                //var nuevoAutor2 = new Autor
                //{
                //    Nombre = "NuevoAutor2",
                //    Apellidos = "Appelidos NuewvoAutor2",
                //    Grado = "Master"
                //};

                //db.Add(nuevoAutor2);

                //var estadoTransaccion = db.SaveChanges();

                //Console.WriteLine("Estado de transaccion ===> " + estadoTransaccion);

                //db.Dispose();

                #endregion

                #region PUT

                //var autor = db.Autor?.Single(x => x.Nombre == "Autor1");
                //if(autor is not null) 
                //{
                //    autor.Apellidos = "Apellidos Autor1 Update";
                //    autor.Grado = "Grado1 update";

                //    var estadoTransaccion = db.SaveChanges();
                //    Console.WriteLine("Estado de transaccion ===> " + estadoTransaccion);                    
                //}
                #endregion

                #region DELETE
                //var autor = db.Autor?.Single(x => x.AutorId == 1);
                //if (autor is not null)
                //{
                //    db.Remove(autor);
                //    var estadoTransaccion = db.SaveChanges();
                //    Console.WriteLine("Estado de transaccion ===> " + estadoTransaccion);
                //}
                #endregion

            }
        }
    }
}
