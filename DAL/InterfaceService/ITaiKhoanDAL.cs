﻿using CuaHangBanThuoc.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CuaHangBanThuoc.DAL.InterfaceService
{
    internal interface ITaiKhoanDAL
    {
        int Add(TaiKhoan taiKhoan);
        int Update(TaiKhoan taiKhoan);
        int Delete(string id);
        List<TaiKhoan> GetAll();
        TaiKhoan GetTaiKhoan(string TenDangNhap);
        string DangNhap(string TenDangNhap,string MatKhau);
    }
}
