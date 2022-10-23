// See https://aka.ms/new-console-template for more information
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using TestEntitiesCodeFIrst;

Console.WriteLine("Hello, World!");

var builder = new ConfigurationBuilder();

builder.SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appsetting.json");

var config = builder.Build();

string connectionString = config.GetConnectionString("DefaultConnection");

DbContextOptionsBuilder optionsBuilder = new DbContextOptionsBuilder();

optionsBuilder.UseSqlServer(connectionString);

using (DefaultContext  contexte = new DefaultContext(optionsBuilder.Options))
{

    Etudiant e = new Etudiant { Name = "imad" };


    var query = from Etudiant in contexte.Etudiants
                   select Etudiant;

    foreach (var etudiant in query)
    {
        Console.WriteLine("Name is : "+etudiant.Name);
    }

}
