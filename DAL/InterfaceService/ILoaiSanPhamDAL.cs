﻿using System.Collections.Generic;
using CuaHangBanThuoc.DTO;

namespace CuaHangBanThuoc.DAL.InterfaceService
{
    public interface ILoaiSanPhamDAL
    {
        int Add(LoaiSanPham loaiSanPham);
        int Update(LoaiSanPham loaiSanPham);
        int Delete(int id);
        List<LoaiSanPham> GetAll();
        LoaiSanPham GetLoaiSanPham(int id);
    }
}