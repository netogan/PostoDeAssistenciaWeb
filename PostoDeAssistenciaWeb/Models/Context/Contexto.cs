using PostoDeAssistenciaWeb.Models.EntityConfig;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace PostoDeAssistenciaWeb.Models.Context
{
    [DbConfigurationType(typeof(MySql.Data.Entity.MySqlEFConfiguration))]
    public class Contexto : DbContext
    {
        public Contexto() : base("Contexto")
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();

            modelBuilder.Properties<string>().Configure(m => m.HasMaxLength(200).HasColumnType("nvarchar"));
            modelBuilder.Properties<string>().Configure(m => m.HasMaxLength(200).HasColumnType("varchar"));

            modelBuilder.Configurations.Add(new AssistidoConfig());
            modelBuilder.Configurations.Add(new EnderecoConfig());

            base.OnModelCreating(modelBuilder);
    }

        public DbSet<Assistido> Assistidos { get; set; }

        public DbSet<Endereco> Enderecos { get; set; }
    }
}