namespace musicAPP.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class IntegracionModelo : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Canciones",
                c => new
                    {
                        CancionId = c.Int(nullable: false, identity: true),
                        Titulo = c.String(),
                        Album = c.String(),
                        Artista = c.String(),
                        Genero = c.String(),
                        Compositor = c.String(),
                        Duracion = c.String(),
                        Ubicacion = c.String(),
                    })
                .PrimaryKey(t => t.CancionId);
            
            CreateTable(
                "dbo.CancionPlaylists",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CancionId = c.Int(nullable: false),
                        PlayListId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.PlayLists",
                c => new
                    {
                        PlayListId = c.Int(nullable: false, identity: true),
                        Nombre = c.String(),
                    })
                .PrimaryKey(t => t.PlayListId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.PlayLists");
            DropTable("dbo.CancionPlaylists");
            DropTable("dbo.Canciones");
        }
    }
}
