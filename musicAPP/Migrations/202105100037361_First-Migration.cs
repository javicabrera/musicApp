namespace musicAPP.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FirstMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Cancions",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nombre = c.String(),
                        Autor = c.String(),
                        Album = c.String(),
                        Ubicacion = c.String(),
                        PlayList_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.PlayLists", t => t.PlayList_Id)
                .Index(t => t.PlayList_Id);
            
            CreateTable(
                "dbo.PlayLists",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nombre = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Cancions", "PlayList_Id", "dbo.PlayLists");
            DropIndex("dbo.Cancions", new[] { "PlayList_Id" });
            DropTable("dbo.PlayLists");
            DropTable("dbo.Cancions");
        }
    }
}
