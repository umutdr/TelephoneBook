namespace TelephoneBook.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class entitiesAddedAndRelations : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.DepartmentRoles",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        DepartmentRoleName = c.String(),
                        DepartmentId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Departments", t => t.DepartmentId, cascadeDelete: true)
                .Index(t => t.DepartmentId);
            
            CreateTable(
                "dbo.Departments",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        DepartmentName = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Personnels", "Department_Id", c => c.Int());
            AddColumn("dbo.Personnels", "DepartmentRole_Id", c => c.Int());
            CreateIndex("dbo.Personnels", "Department_Id");
            CreateIndex("dbo.Personnels", "DepartmentRole_Id");
            AddForeignKey("dbo.Personnels", "Department_Id", "dbo.Departments", "Id");
            AddForeignKey("dbo.Personnels", "DepartmentRole_Id", "dbo.DepartmentRoles", "Id");
            DropColumn("dbo.Personnels", "Role");
            DropColumn("dbo.Personnels", "Department");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Personnels", "Department", c => c.String());
            AddColumn("dbo.Personnels", "Role", c => c.String());
            DropForeignKey("dbo.Personnels", "DepartmentRole_Id", "dbo.DepartmentRoles");
            DropForeignKey("dbo.Personnels", "Department_Id", "dbo.Departments");
            DropForeignKey("dbo.DepartmentRoles", "DepartmentId", "dbo.Departments");
            DropIndex("dbo.Personnels", new[] { "DepartmentRole_Id" });
            DropIndex("dbo.Personnels", new[] { "Department_Id" });
            DropIndex("dbo.DepartmentRoles", new[] { "DepartmentId" });
            DropColumn("dbo.Personnels", "DepartmentRole_Id");
            DropColumn("dbo.Personnels", "Department_Id");
            DropTable("dbo.Departments");
            DropTable("dbo.DepartmentRoles");
        }
    }
}
