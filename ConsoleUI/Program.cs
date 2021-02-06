using Business.Concrate;
using Business.Concrete;
using DataAccess.Concrate;
using DataAccess.Concrate.EntityFramework;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrate;
using System;
using System.Collections.Generic;

namespace ConsoleUI
{
    class Program
    {
        static int indexMainMenu = 0;
        static void Main(string[] args)
        {

            CarManager carManager = new CarManager(new EfCarDal());
            foreach (var product in carManager.GetAll())
            {
                Console.WriteLine(product.ModelYear);
            }
            Console.WriteLine("--CAR--");

            BrandManager brandManager = new BrandManager(new EfBrandDal());
            foreach (var brand in brandManager.GetAll())
            {
                Console.WriteLine(brand.BrandName);
            }
            Console.WriteLine("--BRAND--");

            ColorManager colorManager = new ColorManager(new EfColorDal());
            foreach (var color in colorManager.GetAll())
            {
                Console.WriteLine(color.ColorName);
            }
            Console.WriteLine("--COLOR--");

            List<string> menuItems = new List<string>()
            {
                "Yeni Araç Kayıt",
                "Araç Silme İşlemi",
                "Tüm Araçları Listele",
                "Araç Bilgisi Güncelle",
                "Yeni Marka Girişi",
                "Marka Silme İşlemi",
                "Tüm Markaları Listele",
                "Model Yıllarına Göre Listele",
                "Fiyatına Göre Listele",
                "Çıkış"
            };
        }
    }
}
