﻿using Microsoft.EntityFrameworkCore;

namespace CreditaNelas.Models
{
    public class Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-XXXXXXX; Initial Catalog=Implement_Credita; Integrated Security=True");
        }

        public DbSet<Usuarios> Usuario { get; set; }
        public DbSet<Postagens> Postagem { get; set; }
    }

}
