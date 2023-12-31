﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    internal class Convat
    {
        //phuong thuc khoi tao mac dinh

        //thuoc tinh weight va height nen de pham vi truy cap mac dinh (private) nham che giau thong tin va chi su dung duoc trong noi bo class
        //thuoc tinh o ben duoi de pham vi truy cap la public voi muc dich lam vi du.
        private double weight;
        public double height;
        //phuong thuc nen de pham vi truy cap la public
        public void xuat()
        {
            Console.WriteLine("Chieu cao cua cho la {0}  Can nang la {1}",height, weight);
        }
    }


    //phuong thuc khoi tao khong tham so 
    internal class Animal
    {
        private double weight;
        private double height;
        //phuong thuc khoi tao khong tham so
        public Animal()
        {
            weight = 20.3;
            height = 1.2;
        }
        public void xuat()
        {
            Console.WriteLine("Chieu cao cua meo la {0}  Can nang la {1}", height, weight);
        }
    }


    //phuong thuc khoi tao khong tham so va co 2 tham so (tuy chon)
    internal class SucVat
    {
        private double weight =123.2;
        private double height =523.1;
        //bien tinh la bien dung chung cua lop. goi thong qua ten class ma khong can khoi tao doi tuong, tu do tranh lang phi bo nho
        public static int count = 0;
        //phuong thuc khoi tao khong tham so
        public SucVat()
        {
            weight = 100;
            height = 120.3;
            count++;
        }
        //phuong thuc khoi tao 2 tham so
        public SucVat(double h, double w)
        {
            weight=w;
            height=h;
            count++;
        }
        public void xuat()
        {
            Console.WriteLine("Chieu cao cua ga/heo la {0}  Can nang la {1}", height, weight);
        }

    }

    //lop tinh la lop chua cac bien va phuong thuc tinh. khong the tao doi tuong thuoc lop tinh, nham tranh lang phi bo nho
    //trong c# co nhieu lop tinh mac dinh nhu Math. lop nay chua hang so PI, E,...va cac phong thuc tinh nhu Min, Max,...
    public static class TienIch
    {
        //phuong thuc tinh la phong thuc dung chung cua lop. goi thong qua ten class ma khong can khoi tao doi tuong, tu do tranh lang phi bo nho
        public static int tinhtong(int x, int y)
        {
            return x + y;
        }
    }

}
