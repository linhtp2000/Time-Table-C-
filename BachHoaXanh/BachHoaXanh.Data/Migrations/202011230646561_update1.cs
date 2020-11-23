﻿namespace BachHoaXanh.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class update1 : DbMigration
    {
        public override void Up()
        {
            //DropIndex("dbo.Branches", new[] { "ManagerId" });
            //DropIndex("dbo.Employees", new[] { "ManagerId" });
            //DropIndex("dbo.Employees", new[] { "Employee_Id" });
            //DropIndex("dbo.Employees", new[] { "Administrator_Id" });
            //DropIndex("dbo.Employees", new[] { "Employee_Id1" });
            //DropIndex("dbo.Employees", new[] { "ManageBranch_Id" });
            //DropIndex("dbo.Employees", new[] { "WorkAtBranch_Id" });
            //DropIndex("dbo.Employees", new[] { "Branch_Id" });          
            //DropColumn("dbo.Employees", "BranchId");
            //DropColumn("dbo.Employees", "Employee_Id");
            //DropColumn("dbo.Employees", "Administrator_Id");
            //DropColumn("dbo.Employees", "Employee_Id1");
            //DropColumn("dbo.Employees", "ManageBranch_Id");
            //DropColumn("dbo.Employees", "WorkAtBranch_Id");
            //DropColumn("dbo.Employees", "Branch_Id");

            //DropIndex("dbo.User_Authorize", new[] { "User_Id", "User_Email" });
            //DropColumn("dbo.User_Authorize", "UserId");
            //RenameColumn(table: "dbo.User_Authorize", name: "User_Id", newName: "UserId");
            //DropPrimaryKey("dbo.Users");
            //DropPrimaryKey("dbo.User_Authorize");
            //AddColumn("dbo.Branches", "Employee_Id", c => c.String(maxLength: 255));
            //AddColumn("dbo.Employees", "PhoneNumber", c => c.String());
            //AddColumn("dbo.Employees", "UserId", c => c.String(maxLength: 255));
            //AddColumn("dbo.Users", "Name", c => c.String());
            //AlterColumn("dbo.Customers", "PhoneNumber", c => c.String());
            //AlterColumn("dbo.User_Authorize", "UserId", c => c.String(nullable: false, maxLength: 255));
            //AddPrimaryKey("dbo.Users", "Id");
            //AddPrimaryKey("dbo.User_Authorize", new[] { "UserId", "AuthId" });
            //CreateIndex("dbo.Branches", "Employee_Id");
            //CreateIndex("dbo.Employees", "UserId");
            //CreateIndex("dbo.User_Authorize", "UserId");
            //AddForeignKey("dbo.Employees", "UserId", "dbo.Users", "Id");
            //AddForeignKey("dbo.User_Authorize", "UserId", "dbo.Users", "Id", cascadeDelete: true);
            //AddForeignKey("dbo.Branches", "Employee_Id", "dbo.Employees", "Id");


            DropColumn("dbo.Users", "Email");
            DropColumn("dbo.Users", "PassWord");

            DropColumn("dbo.User_Authorize", "User_Email");
            CreateTable(
                "dbo.WorkAts",
                c => new
                {
                    EmployeeId = c.String(nullable: false, maxLength: 255),
                    BranchId = c.String(nullable: false, maxLength: 255),
                    Position = c.String(maxLength: 255),
                })
                .PrimaryKey(t => new { t.EmployeeId, t.BranchId })
                .ForeignKey("dbo.Branches", t => t.BranchId, cascadeDelete: true)
                .ForeignKey("dbo.Employees", t => t.EmployeeId, cascadeDelete: true)
                .Index(t => t.EmployeeId)
                .Index(t => t.BranchId);
        }

        public override void Down()
        {
        }
    }
}