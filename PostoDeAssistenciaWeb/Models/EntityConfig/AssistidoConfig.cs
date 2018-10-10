using System.Data.Entity.ModelConfiguration;

namespace PostoDeAssistenciaWeb.Models.EntityConfig
{
    public class AssistidoConfig : EntityTypeConfiguration<Assistido>
    {
        public AssistidoConfig()
        {
            HasKey(a => a.AssistidoId);
            Property(a => a.NomeCompleto).IsRequired().HasMaxLength(150);
            Property(a => a.Observacao).IsRequired().HasMaxLength(500);

            Property(a => a.GrauParentesco).IsOptional();
            Property(a => a.DataNascimento).IsOptional();
            Property(a => a.NumeracaoCalcado).IsOptional();
            Property(a => a.NumeracaoRoupaSuperior).IsOptional();
            Property(a => a.NumeracaoRoupaInferior).IsOptional();
            Property(a => a.Observacao).IsOptional();
            Property(a => a.DependenteId).IsOptional();

            //HasOptional(o => o.Endereco).WithOptionalPrincipal(p => p.Assistido);

            ToTable("Assistidos");
        }
    }
}