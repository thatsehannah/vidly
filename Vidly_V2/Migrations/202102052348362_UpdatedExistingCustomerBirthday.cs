namespace Vidly_V2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdatedExistingCustomerBirthday : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE Customers SET Birthday = \'12-31-1993\' WHERE Name = \'Elliot Hannah\'");
        }
        
        public override void Down()
        {
        }
    }
}
