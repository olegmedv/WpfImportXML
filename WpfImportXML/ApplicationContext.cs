using System.Data.Entity;

class ApplicationContext : DbContext
{
    public ApplicationContext() : base("dbImportXML") { }
    public DbSet<Client> Clients { get; set; }
}

