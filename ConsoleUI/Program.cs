using Business.Concrete;
using DataAccess.Concrete.EntityFramework;

CarNameTest();
//ColorNameTest();

static void CarNameTest()
{
    CarManager carManager = new CarManager(new EfCarDal());

    foreach (var car in carManager.GetCarDetails())
    {
        Console.WriteLine(car.CarName + "/"+ car.BrandName);
    }
}

static void ColorNameTest()
{
    ColorManager colorManager = new ColorManager(new EfColorDal());

    foreach (var color in colorManager.GetAll())
    {
        Console.WriteLine(color.Name);
    }
}