using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using MySqlConnector;

namespace Hanori.Service.EFCore
{
    /// <summary>
    /// Sample DbContext
    /// </summary>
    public class SampleDbContext : DbContext
    {
        public DbSet<Sample> Sample { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = "server=localhost;user=root;password=pne1234;database=efcore_test";
            var serverVersion = new MySqlServerVersion(new Version(8, 0, 31));
            optionsBuilder.UseMySql(connectionString, serverVersion);
        }
    }

    /// <summary>
    /// Sample Class
    /// </summary>
    [Table("Sample")]
    public class Sample
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key, Column(Order = 0)]
        public int Id { get; set; }
        [Column(TypeName = "varchar(50)")]
        public string? Name { get; set; }
        [Column(TypeName = "varchar(50)")]
        public string? Value { get; set; }
    }
}
