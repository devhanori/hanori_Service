using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;

namespace Hanori.Service.EFCore
{
    /// <summary>
    /// Sample DbContext
    /// </summary>
    public class OrangeDbContext : DbContext
    {
        public DbSet<TestSample> TestSample { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = "";
            var serverVersion = new MariaDbServerVersion(new Version(10, 3, 2));
            optionsBuilder.UseMySql(connectionString, serverVersion)
                                .LogTo(Console.WriteLine, LogLevel.Information)
                                .EnableSensitiveDataLogging()
                                .EnableDetailedErrors();
        }
    }

    /// <summary>
    /// Sample Class
    /// </summary>
    [Table("TestSample")]
    public class TestSample
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key, Column(Order = 0)]
        public int Id { get; set; } = 0;
        [Column(TypeName = "varchar(50)")]
        public string? Name { get; set; } = "";
        [Column(TypeName = "varchar(50)")]
        public string? Value { get; set; } = "";
    }
}
