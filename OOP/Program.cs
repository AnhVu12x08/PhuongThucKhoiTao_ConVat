using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;

namespace OOP
{
    class program
    {
        static void Main(string[] args)
        {
            //phuong thuc khoi tao doi tuong mac dinh
            Convat cho = new Convat();
            cho.xuat();

            //phuong thuc khoi tao khong tham so
            Animal meo = new Animal();
            meo.xuat();

            //phuong thuc khoi tao khong tham so va 3 tham so
            //phuong thuc khoi tao khong tham so
            SucVat ga = new SucVat();
            ga.xuat();
            //phuong thuc khoi tao co 2 tham so
            double w = 16.3;
            double h = 10.5;
            SucVat heo = new SucVat(w,h);
            heo.xuat();

        }
    }
}

