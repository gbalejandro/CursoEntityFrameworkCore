using EFCore_Mod3.Models;
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

            using (var context = new ApplicationDbContext())
            {
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
                var studentsEnClase = context.Estudiantes
                    .Select(x => new EstudianteViewModel { Id = x.Id, Nombre = x.Nombre }).ToList();
            }
        }
    }

    class EstudianteViewModel
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
    }
}
