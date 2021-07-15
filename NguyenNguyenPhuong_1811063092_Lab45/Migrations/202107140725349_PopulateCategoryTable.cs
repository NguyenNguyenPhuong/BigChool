namespace NguyenNguyenPhuong_1811063092_Lab45.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateCategoryTable : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO CATEGORIES (ID, NAME) VALUES (1,'DEVELOPMENT')");
            Sql("INSERT INTO CATEGORIES (ID, NAME) VALUES (2,'BUSYNESS')");
            Sql("INSERT INTO CATEGORIES (ID, NAME) VALUES (3,'MARKETING')");

        }
        
        public override void Down()
        {
        }
    }
}
