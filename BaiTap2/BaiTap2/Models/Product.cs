using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BaiTap2.Models
{
    public class Product
    {
        public int MaSP { get; set; }
        public string TenSP { get; set; }
        public decimal Gia { get; set; }
        public int SoLuong { get; set; }
        public decimal ThanhTien { get; set; }
        //Constructor không tham số
        public Product()
        {

        }
        public Product(int ma, string ten, decimal gia, int soLuong)
        {
            this.MaSP = ma;
            this.TenSP = ten;
            this.Gia = gia;
            this.SoLuong = soLuong;
            this.ThanhTien = this.Gia * this.SoLuong;
        }

    }
}