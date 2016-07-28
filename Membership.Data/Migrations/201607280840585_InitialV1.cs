namespace Membership.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialV1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.WebUserIp",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        WebUserId = c.Int(nullable: false),
                        Ip = c.String(),
                        RequestIp = c.String(),
                        CreateTime = c.DateTime(),
                        UpdateTime = c.DateTime(),
                        DeleteTime = c.DateTime(),
                        CreatedBy = c.Int(),
                        UpdatedBy = c.Int(),
                        DeletedBy = c.Int(),
                        IsDeleted = c.Byte(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.WebUser",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ApplicationId = c.Int(nullable: false),
                        RequestIp = c.String(),
                        CreateTime = c.DateTime(),
                        UpdateTime = c.DateTime(),
                        DeleteTime = c.DateTime(),
                        CreatedBy = c.Int(),
                        UpdatedBy = c.Int(),
                        DeletedBy = c.Int(),
                        IsDeleted = c.Byte(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.WebUser");
            DropTable("dbo.WebUserIp");
        }
    }
}
