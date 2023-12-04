using Business.Concrete;
using Core.Utilities.Results;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using Entities.DTOs;

//CarNameTest();
//ColorNameTest();
//CarTest();

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

//static void ColorNameTest()
//{
//    ColorManager colorManager = new ColorManager(new EfColorDal());

//    foreach (var color in colorManager.IDataResult<List<Color>>.GetAll())
//    {
//        Console.WriteLine(color.Name);
//    }
//}

//static void CarTest()
//{
//    CarManager carManager = new CarManager(new EfCarDal());
//    var result = carManager.GetAll();
//    if (result.Success == true)
//    {
//        foreach (var car in result.Message)
//        {
//            Console.WriteLine(Name + "/" +Id);
//        }
//    }
//    else
//    {
//        Console.WriteLine(result.Message);
//    }
//}


