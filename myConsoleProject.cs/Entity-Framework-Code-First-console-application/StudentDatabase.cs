using Entity_Framework_Code_First_console_application;
using System.Data.Entity;

public class SchoolContext : DbContext
{
    public DbSet<Student> Students { get; set; }
}
