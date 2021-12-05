namespace MyRecipes.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Recipes",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 120),
                        Description = c.String(nullable: false),
                        Diffictuly = c.Int(nullable: false),
                        CookTime = c.String(),
                        Ingredients = c.String(nullable: false),
                        Instructions = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Recipes");
        }
    }
}
