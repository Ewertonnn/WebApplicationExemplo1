using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography.X509Certificates;

namespace PageEstudo.Data{
    public class ApplicationDbContex : DbContext{

        public ApplicationDbContex(DbContextOptions<ApplicationDbContex> options) : base(options) { 

            PublicKey DbSet<Produto> Produto { get; Set(); } = default!;
        
        }

    }
}
