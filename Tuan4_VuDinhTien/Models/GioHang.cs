﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Tuan4_VuDinhTien.Models;
using PagedList;
using System.Web.Mvc;
using System.ComponentModel.DataAnnotations;

namespace Tuan4_VuDinhTien.Models
{
    public class GioHang
    {
        MyDataDataContext data = new MyDataDataContext();
        public int masach { get; set; }

        [Display(Name = "Tên sách")]
        public String tensach { get; set; }

        [Display(Name = "Ảnh bìa")]
        public string hinh { get; set; }

        [Display(Name = "Giá bán")]
        public Double giaban { get; set; }

        [Display(Name = "Số lượng")]
        public int isoluong { get; set; }

        [Display(Name = "Thành tiền")]
        public Double dThanhtien 
        {
            get {return isoluong * giaban; }
        }
        public GioHang(int id)
        {
            masach = id;
            Sach sach = data.Saches.Single(n => n.masach == masach);
            tensach = sach.tensach;
            hinh = sach.hinh;
            giaban = double.Parse(sach.giaban.ToString());
            isoluong = 1;
        }
    }
}