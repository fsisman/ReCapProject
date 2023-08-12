using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.İnmemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _car;

        public InMemoryCarDal()
        {
            _car = new List<Car>{
            new Car {Id = 1 , BrandId = 1, ColorId = 1 , ModelYear = "1994", DailyPrice = 500, Description = "Mercedes C200" },
            new Car {Id = 2 , BrandId = 1, ColorId = 2 , ModelYear = "2000", DailyPrice = 1000, Description = "BMW 318i" },
            new Car {Id = 3 , BrandId = 2, ColorId = 2 , ModelYear = "2005", DailyPrice = 750, Description = "Renault clio" },
            new Car {Id = 4 , BrandId = 2, ColorId = 3 , ModelYear = "1989", DailyPrice = 200, Description = "Tofaş kartal" },
            new Car {Id = 5 , BrandId = 3, ColorId = 4, ModelYear = "1991", DailyPrice = 400, Description = "Audi 80" },
            new Car {Id = 6 , BrandId = 3, ColorId = 5 , ModelYear = "1993", DailyPrice = 350, Description = "Toyota Corolla" },
            new Car {Id = 7 , BrandId = 3, ColorId = 6 , ModelYear = "2010", DailyPrice = 1500, Description = "Wolswogen polo" },
            new Car {Id = 8 , BrandId = 4, ColorId = 6 , ModelYear = "2007", DailyPrice = 1250, Description = "Fiat Tempra" },
            new Car {Id = 9 , BrandId = 5, ColorId = 7 , ModelYear = "2012", DailyPrice = 2000, Description = "Lamborghini " }
            };
        }
        int _Id = 9;
        public void Add(Car car)
        {
            _Id++;
            car.Id = _Id;
            Console.WriteLine("Arabanın marka ID'sini giriniz : ");
            car.BrandId = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Arabanın renk ID'sini giriniz  : ");
            car.ColorId = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Arabanın model yılını giriniz :  ");
            car.ModelYear = Console.ReadLine();
            Console.WriteLine("Arabanın günlük fiyatını giriniz : ");
            car.DailyPrice = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Arabanın açıklamasını giriniz : ");
            car.Description = Console.ReadLine();
            Console.WriteLine(car.ModelYear+" Model "+car.Description +" Aracınız sisteme eklenmiştir. ");
            _car.Add(car);
        }

        public void Delete(Car car)
        {
            Console.WriteLine("Silinecek aracın Id numarasını giriniz : ");
            car.Id = Convert.ToInt32(Console.ReadLine());
            Car carToDelete = _car.SingleOrDefault(c => c.Id == car.Id);
            _car.Remove(carToDelete);
            Console.WriteLine("Aracınız başarıyla listeden silindi.");

        }


        public List<Car> GetAll()
        {
            return _car;
        }

        public List<Car> GetById(int brandId)
        {
            return _car.Where(c => c.BrandId == brandId).ToList();
        }

        public void Update(Car car)
        {
            Console.WriteLine("Güncellenecek Aracın Id'sini giriniz : ");
            car.Id = Convert.ToInt32(Console.ReadLine());
            Car carToUpdate = _car.SingleOrDefault(c => c.Id == car.Id);
            Console.WriteLine("Aracın güncel Marka ID'sini giriniz : ");
            carToUpdate.BrandId = Convert.ToInt32(Console.ReadLine()) ;
            Console.WriteLine("Aracın güncel renk Id'sini giriniz : ");
            carToUpdate.ColorId = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Aracın güncel günlük fiyatını giriniz : ");
            carToUpdate.DailyPrice = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Aracın güncel açıklamasını giriniz");
            carToUpdate.Description = Console.ReadLine();
            Console.WriteLine("Aracın güncel yılını giriniz : ");
            carToUpdate.ModelYear = Console.ReadLine();
            car = carToUpdate;
            Console.WriteLine("Aracınız  Başarıyla güncellendi.");
        }
    }
}
