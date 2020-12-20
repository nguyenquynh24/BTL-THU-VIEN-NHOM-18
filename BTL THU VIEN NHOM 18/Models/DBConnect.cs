namespace BTL_THU_VIEN_NHOM_18.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    using System.Collections.Generic;

    public partial class DBConnect : DbContext
    {

        public DBConnect()
            : base("name=DBConnect")
        {
        }
        public  DbSet<CHITIETPHIEUMUON> cHITIETPHIEUMUONs { get; set; }
        public  DbSet<DOCGIA> dOCGIAs { get; set; }
        public  DbSet<LOAISACH> lOAISACHes { get; set; }
        public  DbSet<MUONSACH> mUONSACHes { get; set; }
        public  DbSet<NHANVIEN> nHANVIENs { get; set; }
        public  DbSet<NHAXUATBAN> nHAXUATBANs { get; set; }
        public  DbSet<PHAT> pHATs { get; set; }
        public  DbSet<SACH> sAChes { get; set; }
        public  DbSet<TAIKHOAN> tAIKHOANs { get; set; }
        public    DbSet<TRASACH> tRASACHes { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
