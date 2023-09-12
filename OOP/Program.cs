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
            Console.WriteLine("so con vat la {0}", SucVat.count);
            SucVat lon = new SucVat();
            SucVat ga = new SucVat();
            ga.xuat();
            //phuong thuc khoi tao co 2 tham so
            double w = 16.3;
            double h = 10.5;
            SucVat heo = new SucVat(w,h);
            heo.xuat();

            //su dung bien tinh thong qua ten lop ma khong can thong qua doi tuong
            Console.WriteLine("so con vat la {0}", SucVat.count);
            //su dung phuong thuc tinh thong qua ten lop ma khong can phai tao doi tuong
            //neu khong co phuong thuc tinh thi ta phai tao doi tuong de co the goi phuong thuc tinh tong thong qua doi tuong
            int x = 10;
            int y = 20;
            Console.WriteLine("ket qua tong cua x va y la {0}", TienIch.tinhtong(x, y));        

        }
    }
}

