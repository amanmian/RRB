namespace RB3._2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;

    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.StudentDetails",
                c => new
                {
                    Id = c.Int(nullable: false, identity: true),
                    PermanentAddress = c.String(),
                    CurrentAddress = c.String(),
                    Phone = c.String(),
                })
                .PrimaryKey(t => t.Id);

            CreateTable(
                "dbo.Students",
                c => new
                {
                    Id = c.Int(nullable: false, identity: true),
                    FName = c.String(),
                    LName = c.String(),
                    Class = c.String(),
                    studentdetails_Id = c.Int(),
                })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.StudentDetails", t => t.studentdetails_Id)
                .Index(t => t.studentdetails_Id);

        }

        public override void Down()
        {
            DropForeignKey("dbo.Students", "studentdetails_Id", "dbo.StudentDetails");
            DropIndex("dbo.Students", new[] { "studentdetails_Id" });
            DropTable("dbo.Students");
            DropTable("dbo.StudentDetails");
        }
    }
}
