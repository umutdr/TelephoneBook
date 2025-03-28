﻿namespace TelephoneBook.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PersonnelsTableAdded : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Personnels",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Surname = c.String(),
                        Role = c.String(),
                        Department = c.String(),
                        Phone = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Personnels");
        }
    }
}
