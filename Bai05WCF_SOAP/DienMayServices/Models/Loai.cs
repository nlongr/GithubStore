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
    
    public partial class Loai
    {
        public Loai()
        {
            this.SanPhams = new HashSet<SanPham>();
        }
    
        public int LoaiID { get; set; }
        public string Ten { get; set; }
        public Nullable<int> ChungLoaiID { get; set; }
        public string BiDanh { get; set; }
    
        public virtual ChungLoai ChungLoai { get; set; }
        public virtual ICollection<SanPham> SanPhams { get; set; }
    }
}
