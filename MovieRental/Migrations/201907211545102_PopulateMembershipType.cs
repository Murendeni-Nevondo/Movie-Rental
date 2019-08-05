namespace MovieRental.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateMembershipType : DbMigration
    {
        public override void Up()
        {
            Sql("SET IDENTITY_INSERT MembershipTypes ON");
            Sql("insert into MembershipTypes (Id,SignUpFee,DurationinMonths,DiscountRate) values (1,0,0,0)");
            Sql("insert into MembershipTypes (Id,SignUpFee,DurationinMonths,DiscountRate) values (2,30,3,10)");
            Sql("insert into MembershipTypes (Id,SignUpFee,DurationinMonths,DiscountRate) values (3,90,6,15)");
            Sql("insert into MembershipTypes (Id,SignUpFee,DurationinMonths,DiscountRate) values (4,300,12,30)");
        }
        
        public override void Down()
        {
        }
    }
}
