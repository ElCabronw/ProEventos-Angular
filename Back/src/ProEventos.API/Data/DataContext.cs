using Microsoft.EntityFrameworkCore;
using ProEventos.API.Models;

namespace ProEventos.API.Data
{
        public class DataContext : DbContext {
            public DataContext() { }
            public DataContext(DbContextOptions<DataContext> options) : base (options) { }
    
             public DbSet<Evento> Eventos { get; set; }


              protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Evento>().HasData(
                new Evento{EventoId = 1, Local = "Belo Horizonte", DataEvento = "01-01-2022", ImagemURL = "test.png", Lote = "1", QtdPessoas = 2, Tema = "Angular"},
                new Evento{EventoId = 2, Local = "Contagem", DataEvento = "01-01-2022", ImagemURL = "test2.png", Lote = "2", QtdPessoas = 3, Tema = "Angular"}
            );
              
        }
        }
}