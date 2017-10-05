namespace WatsonORT.Datos.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class inicial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ConsultasAnalisis",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Email = c.String(nullable: false),
                        Nombre = c.String(nullable: false),
                        Texto = c.String(nullable: false),
                        CodigoConsulta = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.ConsultasAnalisis");
        }
    }
}
