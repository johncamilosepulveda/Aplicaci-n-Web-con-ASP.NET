using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;

namespace MvcMovie.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MvcMovieContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<MvcMovieContext>>()))
            {
                // Look for any movies.
                if (context.Evento.Any())
                {
                    return;   // DB has been seeded
                }

                context.Evento.AddRange(
                    new Evento
                    {
                        solicitud = "Decoración fiesta de cumpleaños",
                        tipoEvento = "Cumpleaños",
                        lugar = "Calle 35 #5b",
                        invitados = 25,
                        detalles = ""
                    },

                    new Evento      
                    {
                        solicitud = "Catering de bodas",
                        tipoEvento = "Boda",
                        lugar = "Hotel Intercontinental",
                        invitados = 150,
                        detalles = ""
                    },

                    new Evento
                    {
                        solicitud = "Organización con motivo de revelación de genero",
                        tipoEvento = "BabyShower",
                        lugar = "Karen's Pizza Cañasgordas",
                        invitados = 30,
                        detalles = ""
                    },

                    new Evento
                    {
                        solicitud = "When Harry Met Sally",
                        tipoEvento = "Fiesta Infantil",
                        lugar = " ",
                        invitados = 56,
                        detalles = ""
                    }
                );
                context.SaveChanges();
            }
        }
    }
}