namespace TelephoneBook.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class entityRelationsUpdatedandSeedMethodCreated : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.DepartmentRoles", "DepartmentId", "dbo.Departments");
            DropForeignKey("dbo.Personnels", "Department_Id", "dbo.Departments");
            DropForeignKey("dbo.Personnels", "DepartmentRole_Id", "dbo.DepartmentRoles");
            DropIndex("dbo.DepartmentRoles", new[] { "DepartmentId" });
            DropIndex("dbo.Personnels", new[] { "Department_Id" });
            DropIndex("dbo.Personnels", new[] { "DepartmentRole_Id" });
            RenameColumn(table: "dbo.Personnels", name: "Department_Id", newName: "DepartmentId");
            RenameColumn(table: "dbo.Personnels", name: "DepartmentRole_Id", newName: "DepartmentRoleId");
            AlterColumn("dbo.DepartmentRoles", "DepartmentRoleName", c => c.String(nullable: false));
            AlterColumn("dbo.Departments", "DepartmentName", c => c.String(nullable: false));
            AlterColumn("dbo.Personnels", "Name", c => c.String(nullable: false));
            AlterColumn("dbo.Personnels", "Surname", c => c.String(nullable: false));
            AlterColumn("dbo.Personnels", "Phone", c => c.String(nullable: false));
            AlterColumn("dbo.Personnels", "DepartmentId", c => c.Int(nullable: false));
            AlterColumn("dbo.Personnels", "DepartmentRoleId", c => c.Int(nullable: false));
            CreateIndex("dbo.Personnels", "DepartmentRoleId");
            CreateIndex("dbo.Personnels", "DepartmentId");
            AddForeignKey("dbo.Personnels", "DepartmentId", "dbo.Departments", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Personnels", "DepartmentRoleId", "dbo.DepartmentRoles", "Id", cascadeDelete: true);
            DropColumn("dbo.DepartmentRoles", "DepartmentId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.DepartmentRoles", "DepartmentId", c => c.Int(nullable: false));
            DropForeignKey("dbo.Personnels", "DepartmentRoleId", "dbo.DepartmentRoles");
            DropForeignKey("dbo.Personnels", "DepartmentId", "dbo.Departments");
            DropIndex("dbo.Personnels", new[] { "DepartmentId" });
            DropIndex("dbo.Personnels", new[] { "DepartmentRoleId" });
            AlterColumn("dbo.Personnels", "DepartmentRoleId", c => c.Int());
            AlterColumn("dbo.Personnels", "DepartmentId", c => c.Int());
            AlterColumn("dbo.Personnels", "Phone", c => c.String());
            AlterColumn("dbo.Personnels", "Surname", c => c.String());
            AlterColumn("dbo.Personnels", "Name", c => c.String());
            AlterColumn("dbo.Departments", "DepartmentName", c => c.String());
            AlterColumn("dbo.DepartmentRoles", "DepartmentRoleName", c => c.String());
            RenameColumn(table: "dbo.Personnels", name: "DepartmentRoleId", newName: "DepartmentRole_Id");
            RenameColumn(table: "dbo.Personnels", name: "DepartmentId", newName: "Department_Id");
            CreateIndex("dbo.Personnels", "DepartmentRole_Id");
            CreateIndex("dbo.Personnels", "Department_Id");
            CreateIndex("dbo.DepartmentRoles", "DepartmentId");
            AddForeignKey("dbo.Personnels", "DepartmentRole_Id", "dbo.DepartmentRoles", "Id");
            AddForeignKey("dbo.Personnels", "Department_Id", "dbo.Departments", "Id");
            AddForeignKey("dbo.DepartmentRoles", "DepartmentId", "dbo.Departments", "Id", cascadeDelete: true);
        }
    }
}
