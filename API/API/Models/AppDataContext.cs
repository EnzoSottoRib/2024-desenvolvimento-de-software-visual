using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Migrations;

namespace API.Models;

//Implementar a herança da classe DbContext
public class AppDataContext : DbContext
{
    //Informar quais classes serão tabelas no banco de dados
    public DbSet<Produto> Produtos { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        MigrationBuilder.CreateTable(
            name: "Produtos",
            columns: table => new {
                Id = 
            }
        )
        optionsBuilder.UseSqlite("DataSource=Ecommerce.db");
    }
}
