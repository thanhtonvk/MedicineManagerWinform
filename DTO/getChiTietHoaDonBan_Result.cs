//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CuaHangBanThuoc.DTO
{
    using System;
    using System.ComponentModel;

    public partial class getChiTietHoaDonBan_Result
    {
        public int ID { get; set; }
        [DisplayName("Tên sản phẩm")]
        public string TenSP { get; set; }
        [DisplayName("Số lượng")]
        public Nullable<int> SoLuong { get; set; }
        [DisplayName("Giá bán")]
        public Nullable<int> GiaBan { get; set; }
        [DisplayName("Thành tiền")]
        public Nullable<int> Thành_tiền { get; set; }
    }
}
