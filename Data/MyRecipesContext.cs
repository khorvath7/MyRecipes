using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MyRecipes.Data
{
    public class MyRecipesContext : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public MyRecipesContext() : base("name=MyRecipesContext")
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<MyRecipesContext, Migrations.Configuration>());
        }

        public System.Data.Entity.DbSet<MyRecipes.Models.Recipe> Recipes { get; set; }
    }
}
