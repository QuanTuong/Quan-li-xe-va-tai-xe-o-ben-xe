//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Taixevaxe
{
    using System;
    using System.Collections.Generic;
    
    public partial class PhieuDangTai
    {
        public string MaTuyen { get; set; }
        public string MaXe { get; set; }
        public System.DateTime ThoiGian { get; set; }
    
        public virtual TuyenDuong TuyenDuong { get; set; }
        public virtual XE XE { get; set; }
    }
}