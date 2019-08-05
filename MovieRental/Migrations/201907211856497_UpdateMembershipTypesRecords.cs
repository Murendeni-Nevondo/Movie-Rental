namespace MovieRental.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateMembershipTypesRecords : DbMigration
    {
        public override void Up()
        {
            Sql("update MembershipTypes set Name='Pay As You Go' where Id=1");
            Sql("update MembershipTypes set Name='Monthly' where Id=2");
            Sql("update MembershipTypes set Name='Quaterly' where Id=3");
            Sql("update MembershipTypes set Name='Yearly' where Id=4");
        }
        
        public override void Down()
        {
        }
    }
}
