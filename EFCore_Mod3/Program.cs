using EFCore_Mod3.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace EFCore_Mod3
{
    class Program
    {
        static void Main(string[] args)
        {
            //// paso 1: Creamos el objeto
            //var estudiante1 = new Estudiante();
            //estudiante1.Nombre = "Alejandro González";
            //estudiante1.FechaNacimiento = new DateTime(1969, 7, 2);

            //// paso 1: Creamos el objeto
            //var estudiante2 = new Estudiante();
            //estudiante2.Nombre = "Alejandro González";
            //estudiante2.FechaNacimiento = new DateTime(1969, 7, 2);

            //var estudiantes = new List<Estudiante>();

            //for (int i = 0; i < 10; i++)
            //{
            //    estudiantes.Add(new Estudiante()
            //    {
            //        Nombre = "Estudiante " + i.ToString(),
            //        FechaNacimiento = new DateTime(1900 + i, 1, 2)
            //    });
            //}

            //using (var context = new ApplicationDbContext())
            //{
            //    // paso 2: notificamos que queremos agregar un estudiante
            //    context.AddRange(estudiantes);

            //    // paso 3: Guardamos los cambios
            //    context.SaveChanges();
            //var estudiantes = context.Estudiantes.ToList();
            //var estudiantes2 = context.Estudiantes.OrderByDescending(x => x.FechaNacimiento)
            //    .ThenBy(x => x.Nombre).ToList();

            // Da error si no hay registros en la tabla

            //var estudiantes = context.Estudiantes.Select(x => x.Nombre).FirstOrDefault();

            // Proyección a un tipo anónimo
            //var studentsTipoAnonimo = context.Estudiantes.Select(x => new { x.Id, x.Nombre }).ToList();

            // Proyección a una clase
            //var studentsEnClase = context.Estudiantes
            //    .Select(x => new EstudianteViewModel { Id = x.Id, Nombre = x.Nombre }).ToList();

            //var estudiante = context.Estudiantes.Where(x => x.Id == 5).FirstOrDefault();
            //var estudiante = context.Estudiantes.FirstOrDefault(x => x.Id == 5);

            //var estudiantesMayores = context.Estudiantes
            //    .Where(x => x.FechaNacimiento <= DateTime.Today.AddYears(-30) || x.Id == 5).ToList();

            // Modelo conectado
            //var student = context.Estudiantes.First(x => x.Nombre.StartsWith("Estudiante 0"));
            //student.Nombre += " Gonzalez";
            //    //context.SaveChanges();
            //}

            //// Modelo desconectado
            //Estudiante claudia;

            //using (var context = new ApplicationDbContext())
            //{
            //    claudia = context.Estudiantes.First(x => x.Nombre.StartsWith("Estudiante 2"));
            //}

            //claudia.Nombre += " Purcell";

            //using (var context = new ApplicationDbContext())
            //{
            //    // se actualizan todas las columnas
            //    //context.Entry(claudia).State = EntityState.Modified;
            //    // se especifica que columna se actualiza
            //    var entrada = context.Attach(claudia);
            //    entrada.Property(x => x.Nombre).IsModified = true;
            //    context.SaveChanges();
            //}

            // eliminar data
            // Modelo conectado
            //using (var context = new ApplicationDbContext())
            //{
            //    var estudiante1 = context.Estudiantes.FirstOrDefault();
            //    if (estudiante1 != null)
            //    {
            //        Console.WriteLine($"Estudiante a ser removido: { estudiante1.Nombre }");
            //        context.Remove(estudiante1);
            //        context.SaveChanges();
            //    }
            //}

            // Modelo desconectado
            //var studentId = 0;

            //using (var context = new ApplicationDbContext())
            //{
            //    studentId = context.Estudiantes.Select(x => x.Id).First();
            //}

            //using (var context = new ApplicationDbContext())
            //{
            //    var student = new Estudiante();
            //    student.Id = studentId;
            //    context.Entry(student).State = EntityState.Deleted;
            //    context.SaveChanges();
            //}

            //// filtro a nivel de modelo
            //using (var context = new ApplicationDbContext())
            //{
            //    //var estudiantes = context.Estudiantes.ToList();
            //    // para ignorar el filtro
            //    var estudiantesTodos = context.Estudiantes.IgnoreQueryFilters().ToList();
            //}

            //// Skip y Take
            //using (var context = new ApplicationDbContext())
            //{
            //    // ejemplo take
            //    var primeros5Estudiantes = context.Estudiantes.Skip(3).Take(5).ToList();
            //    // ejemplo paginacion
            //    var pagina = 1;
            //    var muestra = 10;

            //    var estudiantes = context.Estudiantes
            //        .Skip((pagina - 1) * muestra).Take(muestra).ToList();
            //}

            //// GroupBy
            //using (var context = new ApplicationDbContext())
            //{
            //    var reporte1 = context.Estudiantes.IgnoreQueryFilters()
            //        .GroupBy(x => new { x.EstaBorrado })
            //        .Select(x => new { x.Key, Count = x.Count() }).ToList();
            //    // Having
            //    var reporte2 = context.Estudiantes.IgnoreQueryFilters()
            //        .GroupBy(x => new { x.FechaNacimiento.Year })
            //        .Where(x => x.Count() >= 2)
            //        .Select(x => new { x.Key, Count = x.Count() })
            //        .ToList();
            //}

            // Queries arbitrarios
            //using (var context = new ApplicationDbContext())
            //{
            //var students = context.Estudiantes
            //    .FromSql(@"SELECT TOP 50 PERCENT Id, FechaNacimiento
            //                FROM Estudiantes ORDER BY FechaNacimiento DESC")
            //    .IgnoreQueryFilters()
            //    .Select(x => new { x.Id, x.FechaNacimiento }).ToList();

            ///////////////////////////////////////////////////////////////////
            //var Id = 4;
            //var parameter = new SqlParameter("@Id", Id);
            //var student = context.Estudiantes.FromSql("SELECT * from Estudiantes where Id = @Id",
            //    new SqlParameter[] { parameter }).FirstOrDefault();

            // String Interpolation con Queries arbitrarios
            //var student = context.Estudiantes.FromSql($"SELECT * from Estudiantes where Id = {Id}")
            //    .FirstOrDefault();

            //}

            // Transacciones
            //using (var context = new ApplicationDbContext())
            //{
            //    using (var transaction = context.Database.BeginTransaction())
            //    {
            //        var estudiante1 = new Estudiante();
            //        estudiante1.Nombre = "Robert Fatou";
            //        context.Add(estudiante1);
            //        context.SaveChanges();
            //        // El Id tendrá un valor válido
            //        Console.WriteLine("Id del estudiante: " + estudiante1.Id);
            //        // Vamos a revertir la operación realizada
            //        //transaction.Rollback();
            //        // para que guarde
            //        transaction.Commit();
            //    }
            //}
            //using (var scope = new TransactionScope())
            //{
            //    using (var context = new ApplicationDbContext())
            //    {
            //        var student1 = new Estudiante();
            //        student1.Nombre = "Transaction Scope 1";
            //        context.Add(student1);
            //        context.SaveChanges();
            //    }

            //    using (var context = new ApplicationDbContext())
            //    {
            //        var student2 = new Estudiante();
            //        student2.Nombre = "Transaction Scope 2";
            //        context.Add(student2);
            //        context.SaveChanges();
            //    }

            //    // Descomenta la siguiente línea de código si quieres que
            //    // las operaciones sean persistidas en la base de datos
            //    //scope.Complete();
            //}

            // Ejecucioon diferida
            //using (var context = new ApplicationDbContext())
            //{
            //    // Forma 1: Funciones en una línea
            //    var estudiantes = context.Estudiantes
            //        .Where(x => x.FechaNacimiento.Year < 1990)
            //        .OrderByDescending(x => x.FechaNacimiento).ToList();

            //    // Forma 2: Funciones en varias líneas
            //    var query = context.Estudiantes.AsQueryable();
            //    if (tal condicion){
            //        query = query.Where(x => x.FechaNacimiento.Year < 1990);
            //    }
            //    query = query.OrderByDescending(x => x.FechaNacimiento);
            //    var student2 = query.ToList();
            //}

            // Data relacionada uno a muchos
            using (var context = new ApplicationDbContext())
            {
                var studentId = context.Estudiantes.Select(x => x.Id).FirstOrDefault();

                var contact = new Contacto();
                contact.Nombre = "Yessica Krystal";
                contact.Relacion = "Hermana";
                contact.EstudianteId = studentId;

                context.Add(contact);
                context.SaveChanges();
            }
        }
    }

    //class EstudianteViewModel
    //{
    //    public int Id { get; set; }
    //    public string Nombre { get; set; }
    //}
}
