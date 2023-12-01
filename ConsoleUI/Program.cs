using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using Microsoft.Data.SqlClient;



CarManager carManager = new CarManager(new EfCarDal());
	foreach (var car in carManager.GetAllByDailyPrice(500,1500))
	{
		Console.WriteLine(car.Name, car.DailyPrice);
	}
