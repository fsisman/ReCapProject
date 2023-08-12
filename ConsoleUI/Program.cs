using Business.Concrete;
using DataAccess.Concrete.İnmemory;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
       
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new InMemoryCarDal());
            double secim = 0;
            
            while(secim == 0) 
            {
                Car car = new Car();
                Console.WriteLine("------Hoşgeldiniz------ ");
                Menu();
                Console.WriteLine("Seçiminizi giriniz :  ");
                secim = Convert.ToDouble(Console.ReadLine());
                if (secim == 1)
                {
                    carManager.Add(car); 
                }
                else if(secim == 2) 
                {
                    carManager.Delete(car);
                }
                else if(secim == 3) 
                {
                    carManager.Update(car);
                }
                else if (secim == 4) 
                {
                    Listele(carManager);
                }
                else { Console.WriteLine("Yanlış bir tuşlama yaptınız."); }
                Console.WriteLine("İşleme devam etmek için 0'ı çıkmak için 1'i tuşlayınız.");
                secim = Convert.ToDouble(Console.ReadLine());
            }
            

        }
        static void Listele(CarManager carManager)
        {
           
            foreach (var item in carManager.GetAll())
            {
                Console.WriteLine("Araba ID : " + item.Id);
                Console.WriteLine("Arabanın marka ID : " + item.BrandId);
                Console.WriteLine("Arabanın renk ID : " + item.ColorId);
                Console.WriteLine("Arabanın model yılı : " + item.ModelYear);
                Console.WriteLine("Arabanın günlük fiyatı : " + item.DailyPrice);
                Console.WriteLine("Arabanın açıklaması : " + item.Description);
                Console.WriteLine("---------------------------");
            }
        }
        static void Menu() 
        {
            Console.WriteLine("Sisteme araç eklemek için 1'i tuşlayınız");
            Console.WriteLine("Sisteden araç silmek için 2'yi tuşlayınız");
            Console.WriteLine("Sistemdeki bir aracın bilgilerini güncellemek için 3'ü tuşlayınız");
            Console.WriteLine("Sistemedeki araçları listelemek için 4'ü tuşlayınız");
        }
    }
}
