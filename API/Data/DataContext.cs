using API.Entities;
using Microsoft.EntityFrameworkCore;

namespace API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {//Construtor

        }

    public DbSet<AppUser> Users {get; set;}
    //Dentro desse DBSet vai morar os dados da tabela Users
    
    }
}