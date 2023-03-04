using Microsoft.DotNet.Scaffolding.Shared.CodeModifier.CodeChange;

namespace CodingAssessment.Models
{
    public class CarModel : IDisposable
    {
        public int Id { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public int Doors { get; set; }
        public string Color { get; set; }
        public int Price { get; set; }

        //private List<CarModel> listcars{ get; set; }
    //public List<CarModel> DefaultList => Seed();
    //{
    //get {
    //    //if (DefaultList.Count()>0)
    //    //{
    //    return Seed();
    //    //    }
    //    //    return DefaultList;
    //    //}
    //}
    public static List<CarModel> Seed()
        {
            List<CarModel> cars = new List<CarModel>
            {
                new CarModel { Id = 1, Make = "Audi", Model = "R8", Year = 2018, Doors = 2, Color = "Red", Price = 79995 },
                new CarModel { Id = 2, Make = "Tesla", Model = "3", Year = 2018, Doors = 4, Color = "Black", Price = 54995 },
                new CarModel { Id = 3, Make = "Porsche", Model = " 911 991", Year = 2020, Doors = 2, Color = "White", Price = 155000 },
                new CarModel { Id = 4, Make = "Mercedes-Benz", Model = "GLE 63S", Year = 2021, Doors = 5, Color = "Blue", Price = 83995 },
                new CarModel { Id = 5, Make = "BMW", Model = "X6 M", Year = 2020, Doors = 5, Color = "Silver", Price = 62995 },
            };

            return cars;
        }
        public void CreateCar(CarModel retu)
        {
            //retu.DefaultList.Add(new CarModel { Id = retu.Id, Make = retu.Make, Model = retu.Make, Year = retu.Year, Doors = retu.Doors, Color = retu.Color, Price = retu.Price }); 
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
