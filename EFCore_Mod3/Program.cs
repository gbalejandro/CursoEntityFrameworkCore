using EFCore_Mod3.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            //// paso 2: notificamos que queremos agregar un estudiante
            //context.AddRange(estudiantes);

            //// paso 3: Guardamos los cambios
            //context.SaveChanges();
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
            //context.SaveChanges();
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

            // GroupBy
            using (var context = new ApplicationDbContext())
            {
                var reporte1 = context.Estudiantes.IgnoreQueryFilters()
                    .GroupBy(x => new { x.EstaBorrado })
                    .Select(x => new { x.Key, Count = x.Count() }).ToList();
                // Having
                var reporte2 = context.Estudiantes.IgnoreQueryFilters()
                    .GroupBy(x => new { x.FechaNacimiento.Year })
                    .Where(x => x.Count() >= 2)
                    .Select(x => new { x.Key, Count = x.Count() })
                    .ToList();
            }
        }
    }

    //class EstudianteViewModel
    //{
    //    public int Id { get; set; }
    //    public string Nombre { get; set; }
    //}
}
