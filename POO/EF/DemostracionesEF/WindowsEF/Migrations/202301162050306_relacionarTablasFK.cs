namespace WindowsEF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class relacionarTablasFK : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Producto", "Categoria_Id", "dbo.Categoria");
            DropIndex("dbo.Producto", new[] { "Categoria_Id" });
            RenameColumn(table: "dbo.Producto", name: "Categoria_Id", newName: "CatId");
            AlterColumn("dbo.Producto", "CatId", c => c.Int(nullable: false));
            CreateIndex("dbo.Producto", "CatId");
            AddForeignKey("dbo.Producto", "CatId", "dbo.Categoria", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Producto", "CatId", "dbo.Categoria");
            DropIndex("dbo.Producto", new[] { "CatId" });
            AlterColumn("dbo.Producto", "CatId", c => c.Int());
            RenameColumn(table: "dbo.Producto", name: "CatId", newName: "Categoria_Id");
            CreateIndex("dbo.Producto", "Categoria_Id");
            AddForeignKey("dbo.Producto", "Categoria_Id", "dbo.Categoria", "Id");
        }
    }
}
