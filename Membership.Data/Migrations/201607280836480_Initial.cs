namespace Membership.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.AccountAddress",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        AccountId = c.Int(nullable: false),
                        AddressCode = c.String(),
                        AddressType = c.Int(nullable: false),
                        AddressTitle = c.String(),
                        CountryId = c.Int(nullable: false),
                        CityId = c.Int(nullable: false),
                        DistrictId = c.Int(nullable: false),
                        CountryIsoCode = c.String(),
                        CityIsoCode = c.String(),
                        Address = c.String(),
                        ZipCode = c.String(),
                        TaxOffice = c.String(),
                        TaxNumber = c.String(),
                        CompanyName = c.String(),
                        Status = c.Byte(nullable: false),
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
                "dbo.Account",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ApplicationId = c.Int(nullable: false),
                        ResellerId = c.Int(nullable: false),
                        RegistrationId = c.String(),
                        AccountCode = c.String(),
                        Email = c.String(),
                        Password = c.String(),
                        Name = c.String(),
                        Surname = c.String(),
                        IdentityNo = c.String(),
                        Gender = c.Byte(nullable: false),
                        Gsm = c.String(),
                        BirthDate = c.DateTime(),
                        Locale = c.String(),
                        AccountType = c.Int(nullable: false),
                        AlternativeEmail = c.String(),
                        RiskLevel = c.Int(nullable: false),
                        ReferenceAccountId = c.Int(nullable: false),
                        LastLoginTime = c.DateTime(),
                        Status = c.Byte(nullable: false),
                        SystemStatus = c.Byte(nullable: false),
                        Salt = c.String(),
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
                "dbo.Application",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ApplicationCode = c.String(),
                        ApplicationName = c.String(),
                        Description = c.String(),
                        Status = c.Byte(nullable: false),
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
            DropTable("dbo.Application");
            DropTable("dbo.Account");
            DropTable("dbo.AccountAddress");
        }
    }
}
