﻿namespace Mvc_CURD_Operation.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class emp_app : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Employees",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Department = c.String(nullable: false),
                        Salary = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Employees");
        }
    }
}
