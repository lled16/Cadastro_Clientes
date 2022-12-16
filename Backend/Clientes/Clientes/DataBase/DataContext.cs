using Clientes.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;


namespace Clientes.DataBase
{
    public class DataContext : DbContext
    {
        public virtual DbSet<ClienteModel> CADASTRO_CLIENTES { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            optionsBuilder.UseSqlServer("server=DESKTOP-278IVMV;database=CLIENTES;trusted_connection=true;Integrated Security=SSPI;TrustServerCertificate=True;");


        }
    }
}
