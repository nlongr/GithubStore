//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DienMayServices.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class SanPham
    {
        public SanPham()
        {
            this.HoaDonChiTiets = new HashSet<HoaDonChiTiet>();
        }
    
        public int SanPhamID { get; set; }
        public Nullable<int> NhaSanXuatID { get; set; }
        public Nullable<int> LoaiID { get; set; }
        public string Ten { get; set; }
        public string TrangThai { get; set; }
        public string MoTa { get; set; }
        public int GiaBan { get; set; }
        public int SoLuong { get; set; }
        public string KichCo { get; set; }
        public string BangTan { get; set; }
        public string Camera { get; set; }
        public string GPRS { get; set; }
        public string XuatXu { get; set; }
        public string DacTinh { get; set; }
        public string Hinh { get; set; }
        public string BiDanh { get; set; }
    
        public virtual ICollection<HoaDonChiTiet> HoaDonChiTiets { get; set; }
        public virtual Loai Loai { get; set; }
        public virtual NhaSanXuat NhaSanXuat { get; set; }
    }
}
