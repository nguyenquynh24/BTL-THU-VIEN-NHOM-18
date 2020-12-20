namespace BTL_THU_VIEN_NHOM_18.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class create_table : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CHITIETPHIEUMUONs",
                c => new
                    {
                        sophieumuonid = c.Int(nullable: false, identity: true),
                        msdocgia = c.String(nullable: false, maxLength: 30),
                        sophieumuon = c.String(),
                        mssach = c.String(),
                        hantra = c.String(),
                        DOCGIA_docgiaid = c.Int(),
                        SACH_sachid = c.Int(),
                    })
                .PrimaryKey(t => t.sophieumuonid)
                .ForeignKey("dbo.DOCGIAs", t => t.DOCGIA_docgiaid)
                .ForeignKey("dbo.SACHes", t => t.SACH_sachid)
                .Index(t => t.DOCGIA_docgiaid)
                .Index(t => t.SACH_sachid);
            
            CreateTable(
                "dbo.DOCGIAs",
                c => new
                    {
                        docgiaid = c.Int(nullable: false, identity: true),
                        msdocgia = c.String(),
                        tendocgia = c.String(),
                        diachidocgia = c.String(nullable: false, maxLength: 15),
                        ngaysinhdocgia = c.String(),
                        emaildocgia = c.String(),
                        gioitinhdocgia = c.String(),
                        sodienthoaidocgia = c.String(),
                    })
                .PrimaryKey(t => t.docgiaid);
            
            CreateTable(
                "dbo.SACHes",
                c => new
                    {
                        sachid = c.Int(nullable: false, identity: true),
                        mssach = c.String(nullable: false, maxLength: 30),
                        tensach = c.String(),
                        msnhaxuatban = c.String(nullable: false, maxLength: 15),
                        maloaisach = c.String(),
                        chuyennganh = c.String(),
                        tinhtrangsach = c.String(),
                        khuvucdesach = c.String(),
                        LOAISACH_id = c.Int(nullable: false),
                        NHAXUATBAN_nhaxuatbanid = c.Int(),
                    })
                .PrimaryKey(t => t.sachid)
                .ForeignKey("dbo.LOAISACHes", t => t.LOAISACH_id, cascadeDelete: true)
                .ForeignKey("dbo.NHAXUATBANs", t => t.NHAXUATBAN_nhaxuatbanid)
                .Index(t => t.LOAISACH_id)
                .Index(t => t.NHAXUATBAN_nhaxuatbanid);
            
            CreateTable(
                "dbo.LOAISACHes",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        tensach = c.String(nullable: false, maxLength: 30),
                        maloaisach = c.String(nullable: false, maxLength: 15),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.NHAXUATBANs",
                c => new
                    {
                        nhaxuatbanid = c.Int(nullable: false, identity: true),
                        msnhaxuatban = c.String(nullable: false, maxLength: 30),
                        tennhaxuatban = c.String(),
                        diachinhaxuatban = c.String(nullable: false, maxLength: 15),
                        websitenhaxuatban = c.String(),
                        thongtinkhacnhaxuatban = c.String(),
                    })
                .PrimaryKey(t => t.nhaxuatbanid);
            
            CreateTable(
                "dbo.MUONSACHes",
                c => new
                    {
                        sophieumuonid = c.Int(nullable: false, identity: true),
                        sophieumuon = c.String(nullable: false, maxLength: 30),
                        msdocgia = c.String(),
                        msnhanvien = c.String(),
                        ngaymuon = c.String(),
                        ngaytra = c.String(),
                        DOCGIA_docgiaid = c.Int(),
                        NHANVIEN_idnhanvien = c.Int(),
                    })
                .PrimaryKey(t => t.sophieumuonid)
                .ForeignKey("dbo.DOCGIAs", t => t.DOCGIA_docgiaid)
                .ForeignKey("dbo.NHANVIENs", t => t.NHANVIEN_idnhanvien)
                .Index(t => t.DOCGIA_docgiaid)
                .Index(t => t.NHANVIEN_idnhanvien);
            
            CreateTable(
                "dbo.NHANVIENs",
                c => new
                    {
                        idnhanvien = c.Int(nullable: false, identity: true),
                        manv = c.String(nullable: false, maxLength: 30),
                        matmanv = c.String(),
                        hotennv = c.String(),
                        diachinv = c.String(nullable: false, maxLength: 15),
                        ngaysinhnv = c.String(),
                        gioitinhnv = c.String(),
                        sodienthoainv = c.String(),
                        emailnv = c.String(),
                        ngayvaolamnv = c.String(),
                    })
                .PrimaryKey(t => t.idnhanvien);
            
            CreateTable(
                "dbo.PHATs",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        mssach = c.String(),
                        msdocgia = c.String(),
                        msnhanvien = c.String(),
                        lydophat = c.String(),
                        DOCGIA_docgiaid = c.Int(),
                        nHANVIEN_idnhanvien = c.Int(),
                        SACH_sachid = c.Int(),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.DOCGIAs", t => t.DOCGIA_docgiaid)
                .ForeignKey("dbo.NHANVIENs", t => t.nHANVIEN_idnhanvien)
                .ForeignKey("dbo.SACHes", t => t.SACH_sachid)
                .Index(t => t.DOCGIA_docgiaid)
                .Index(t => t.nHANVIEN_idnhanvien)
                .Index(t => t.SACH_sachid);
            
            CreateTable(
                "dbo.TAIKHOANs",
                c => new
                    {
                        taikhoan = c.Int(nullable: false, identity: true),
                        FirstName = c.String(nullable: false, maxLength: 50),
                        LastName = c.String(nullable: false, maxLength: 50),
                        Email = c.String(nullable: false),
                        Password = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.taikhoan);
            
            CreateTable(
                "dbo.TRASACHes",
                c => new
                    {
                        sophieumuonid = c.Int(nullable: false, identity: true),
                        mssach = c.String(),
                        msnhanvien = c.String(),
                        ngaytra = c.String(),
                        NHANVIEN_idnhanvien = c.Int(),
                        SACH_sachid = c.Int(),
                    })
                .PrimaryKey(t => t.sophieumuonid)
                .ForeignKey("dbo.NHANVIENs", t => t.NHANVIEN_idnhanvien)
                .ForeignKey("dbo.SACHes", t => t.SACH_sachid)
                .Index(t => t.NHANVIEN_idnhanvien)
                .Index(t => t.SACH_sachid);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.TRASACHes", "SACH_sachid", "dbo.SACHes");
            DropForeignKey("dbo.TRASACHes", "NHANVIEN_idnhanvien", "dbo.NHANVIENs");
            DropForeignKey("dbo.PHATs", "SACH_sachid", "dbo.SACHes");
            DropForeignKey("dbo.PHATs", "nHANVIEN_idnhanvien", "dbo.NHANVIENs");
            DropForeignKey("dbo.PHATs", "DOCGIA_docgiaid", "dbo.DOCGIAs");
            DropForeignKey("dbo.MUONSACHes", "NHANVIEN_idnhanvien", "dbo.NHANVIENs");
            DropForeignKey("dbo.MUONSACHes", "DOCGIA_docgiaid", "dbo.DOCGIAs");
            DropForeignKey("dbo.CHITIETPHIEUMUONs", "SACH_sachid", "dbo.SACHes");
            DropForeignKey("dbo.SACHes", "NHAXUATBAN_nhaxuatbanid", "dbo.NHAXUATBANs");
            DropForeignKey("dbo.SACHes", "LOAISACH_id", "dbo.LOAISACHes");
            DropForeignKey("dbo.CHITIETPHIEUMUONs", "DOCGIA_docgiaid", "dbo.DOCGIAs");
            DropIndex("dbo.TRASACHes", new[] { "SACH_sachid" });
            DropIndex("dbo.TRASACHes", new[] { "NHANVIEN_idnhanvien" });
            DropIndex("dbo.PHATs", new[] { "SACH_sachid" });
            DropIndex("dbo.PHATs", new[] { "nHANVIEN_idnhanvien" });
            DropIndex("dbo.PHATs", new[] { "DOCGIA_docgiaid" });
            DropIndex("dbo.MUONSACHes", new[] { "NHANVIEN_idnhanvien" });
            DropIndex("dbo.MUONSACHes", new[] { "DOCGIA_docgiaid" });
            DropIndex("dbo.SACHes", new[] { "NHAXUATBAN_nhaxuatbanid" });
            DropIndex("dbo.SACHes", new[] { "LOAISACH_id" });
            DropIndex("dbo.CHITIETPHIEUMUONs", new[] { "SACH_sachid" });
            DropIndex("dbo.CHITIETPHIEUMUONs", new[] { "DOCGIA_docgiaid" });
            DropTable("dbo.TRASACHes");
            DropTable("dbo.TAIKHOANs");
            DropTable("dbo.PHATs");
            DropTable("dbo.NHANVIENs");
            DropTable("dbo.MUONSACHes");
            DropTable("dbo.NHAXUATBANs");
            DropTable("dbo.LOAISACHes");
            DropTable("dbo.SACHes");
            DropTable("dbo.DOCGIAs");
            DropTable("dbo.CHITIETPHIEUMUONs");
        }
    }
}
