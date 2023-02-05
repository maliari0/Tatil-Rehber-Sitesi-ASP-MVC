namespace WebProje2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class deneme : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Admins", "Kullanici", c => c.String(nullable: false));
            AlterColumn("dbo.Admins", "Sifre", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Admins", "Sifre", c => c.String());
            AlterColumn("dbo.Admins", "Kullanici", c => c.String());
        }
    }
}
