using System.Data.Entity.ModelConfiguration;

namespace PostoDeAssistenciaWeb.Models.EntityConfig
{
    public class EnderecoConfig : EntityTypeConfiguration<Endereco>
    {
        public EnderecoConfig()
        {
            HasKey(a => a.EnderecoId);
            Property(a => a.Logradouro).IsRequired().HasMaxLength(500);
            Property(a => a.Complemento).IsOptional().HasMaxLength(500);

            HasOptional(o => o.Assistido).WithOptionalPrincipal(p => p.Endereco);

            ToTable("Enderecos");
        }
    }
}