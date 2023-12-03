using Business.Concrete;
using DataAccess.Concrete.EntityFramework;

//CarNameTest();
//ColorNameTest();
CarTest();

static void CarNameTest()
{
    CarManager carManager = new CarManager(new EfCarDal());
    var result = carManager.GetCarDetails();

    foreach (var car in carManager.GetCarDetails().Data)
    {
        if (car.CarName.Length < 3)
        {
            Console.WriteLine("isim en az 3 karakter olmalı");
        }
        else
        {
            Console.WriteLine(car.CarName);
        }
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

static void CarTest()
{
    CarManager carManager = new CarManager(new EfCarDal());
    var result = carManager.GetCarDetails();
    if (result.Success == true)
    {
        foreach (var car in result.Data)
        {
            Console.WriteLine(car.CarName + "/" + car.CarId);
        }
    }
    else
    {
        Console.WriteLine(result.Message);
    }
}


