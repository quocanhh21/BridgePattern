using System;
using System.Text;

namespace Bai1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.WriteLine("Chao mừng bạn đến với cửa hàng hoa");
            Console.WriteLine("\n *********** \n");

            Flower fItemHoaHong = new HoaHong();
            fItemHoaHong.ProductType = "Hoa Hong";
            Iprice price = new OnlinePrice(5000);
            fItemHoaHong.Price = price;
            fItemHoaHong.Details();
            price = new ShowroomPrice(7000);
            fItemHoaHong.Price = price;
            fItemHoaHong.Details();
           
            Console.OutputEncoding= Encoding.Unicode;
            Console.WriteLine("Mua sắm Hoa hồng");
            Console.WriteLine("\n *********** \n");

            Flower fItemHoaLan = new HoaLan();
            fItemHoaLan.ProductType = "Hoa Lan";
            Iprice HLprice = new OnlinePrice(6000);
            fItemHoaLan.Price = HLprice;
            fItemHoaLan.Details();

            HLprice = new ShowroomPrice(8000);
            fItemHoaLan.Price = HLprice;
            fItemHoaLan.Details();
          
            Console.OutputEncoding = Encoding.Unicode;
            Console.WriteLine("Mua sắm Hoa Lan");
            Console.WriteLine("\n *********** \n");

            Flower fItemHoaCuc = new HoaCuc();
            fItemHoaCuc.ProductType = "Hoa Cúc";
            Iprice HCprice = new OnlinePrice(9000);
            fItemHoaCuc.Price = HCprice;
            fItemHoaCuc.Details();

            HCprice = new ShowroomPrice(10000);
            fItemHoaCuc.Price = HCprice;
            fItemHoaCuc.Details();

            Console.OutputEncoding = Encoding.Unicode;
            Console.WriteLine("Mua sắm Hoa Cúc");
            Console.WriteLine("\n *********** \n");


        }
    }
}
