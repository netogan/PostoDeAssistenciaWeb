namespace PostoDeAssistenciaWeb.Migrations
{
    using MySql.Data.Entity;
    using System.Data.Entity.Migrations;

    internal sealed class Configuration : DbMigrationsConfiguration<Models.Context.Contexto>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
            SetSqlGenerator("MySql.Data.MySqlClient", new myMigrationSQLGenerator());
            CodeGenerator = new MyCodeGenerator();
            //ContextKey = "TesteMysql.Models.Context.BancoContext";
        }

        protected override void Seed(Models.Context.Contexto context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
        }
    }
}
