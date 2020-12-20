namespace BTL_THU_VIEN_NHOM_18.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class lienket : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.DOCGIAs", "DOCGIA_docgiaid", c => c.Int());
            AddColumn("dbo.NHANVIENs", "NHANVIEN_idnhanvien", c => c.Int());
            AddColumn("dbo.TRASACHes", "CHITIETPHIEUMUON_sophieumuonid", c => c.Int());
            CreateIndex("dbo.DOCGIAs", "DOCGIA_docgiaid");
            CreateIndex("dbo.NHANVIENs", "NHANVIEN_idnhanvien");
            CreateIndex("dbo.TRASACHes", "CHITIETPHIEUMUON_sophieumuonid");
            AddForeignKey("dbo.DOCGIAs", "DOCGIA_docgiaid", "dbo.DOCGIAs", "docgiaid");
            AddForeignKey("dbo.NHANVIENs", "NHANVIEN_idnhanvien", "dbo.NHANVIENs", "idnhanvien");
            AddForeignKey("dbo.TRASACHes", "CHITIETPHIEUMUON_sophieumuonid", "dbo.CHITIETPHIEUMUONs", "sophieumuonid");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.TRASACHes", "CHITIETPHIEUMUON_sophieumuonid", "dbo.CHITIETPHIEUMUONs");
            DropForeignKey("dbo.NHANVIENs", "NHANVIEN_idnhanvien", "dbo.NHANVIENs");
            DropForeignKey("dbo.DOCGIAs", "DOCGIA_docgiaid", "dbo.DOCGIAs");
            DropIndex("dbo.TRASACHes", new[] { "CHITIETPHIEUMUON_sophieumuonid" });
            DropIndex("dbo.NHANVIENs", new[] { "NHANVIEN_idnhanvien" });
            DropIndex("dbo.DOCGIAs", new[] { "DOCGIA_docgiaid" });
            DropColumn("dbo.TRASACHes", "CHITIETPHIEUMUON_sophieumuonid");
            DropColumn("dbo.NHANVIENs", "NHANVIEN_idnhanvien");
            DropColumn("dbo.DOCGIAs", "DOCGIA_docgiaid");
        }
    }
}
