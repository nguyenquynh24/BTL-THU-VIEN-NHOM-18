namespace BTL_THU_VIEN_NHOM_18.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class taikhoan : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.TAIKHOANs", "roleID", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.TAIKHOANs", "roleID");
        }
    }
}
