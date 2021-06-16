namespace SchoolWebAuth.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class teachrforeignkey : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Courses", "Teacherid", c => c.Int());
            CreateIndex("dbo.Courses", "Teacherid");
            AddForeignKey("dbo.Courses", "Teacherid", "dbo.Teachers", "id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Courses", "Teacherid", "dbo.Teachers");
            DropIndex("dbo.Courses", new[] { "Teacherid" });
            DropColumn("dbo.Courses", "Teacherid");
        }
    }
}
