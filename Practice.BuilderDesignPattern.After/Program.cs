namespace Practice.BuilderDesignPattern.After;

class Program
{
	static void Main(string[] args)
	{

		var property1 = new PropertyBuilder()
			.SetAddress("123 Kazan st.")
			.WithTransactionType(TransactionType.Sale)
			.WithPropertyType(PropertyType.House)
			.SetPrice(400_000)
			.SetTotalBedrooms(4)
			.SetFloorArea(190.0)
			.SetTotalBathrooms(3)
			.SetTotalStoreys(2)
			.SetYearBuilt(2019)
			.HasGym(false)
			.HasSwimmingPool(true)
			.HasWifi(false)
			.HasParking(true)
			.HasPlayground(true)
			.Build();

		Console.WriteLine(property1);

		Console.WriteLine("----------------------------------");

		var property2 = new PropertyBuilder().SetAddress("452 Kazan st.")
		   .WithPropertyType(PropertyType.Apartment)
		   .WithTransactionType(TransactionType.Rent)
		   .SetPrice(2_000)
		   .Build();

		Console.WriteLine(property2);
		try
		{
			var property3 = new PropertyBuilder().SetAddress("452 Kazan st.")
		   .WithPropertyType(PropertyType.Apartment)
		   .WithTransactionType(TransactionType.Rent)
		   .Build();
			Console.WriteLine(property2);

		}catch(Exception ex)
		{
			Console.WriteLine(ex.ToString());
		}
		finally
		{
			Console.ReadKey();
		}
		
	}
}