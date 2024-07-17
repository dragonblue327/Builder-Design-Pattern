﻿namespace Practice.BuilderDesignPattern.Before;

public class Property
{
	public string Address { get; set; }
	public TransactionType TransactionType { get; set; }
	public PropertyType PropertyType { get; set; }
	public int TotalBedrooms { get; set; }
	public double FloorArea { get; set; }
	public decimal Price { get; set; }
	public int TotalBathrooms { get; set; }
	public int TotalStoreys { get; set; }
	public int YearBuilt { get; set; }
	public bool HasSwimmingPool { get; set; }
	public bool HasWifi { get; set; }
	public bool HasGym { get; set; }
	public bool HasParking { get; set; }
	public bool HasPlayground { get; set; }


	public Property(
		string address, TransactionType transactionType, PropertyType propertyType,
		int totalBedrooms, double floorArea, decimal price, int totalBathrooms,
		int totalStoreys, int yearBuilt, bool hasSwimmingPool, bool hasWifi,
		bool hasGym, bool hasParking, bool hasPlayground)
	{
		Address = address;
		TransactionType = transactionType;
		PropertyType = propertyType;
		TotalBedrooms = totalBedrooms;
		FloorArea = floorArea;
		Price = price;
		TotalBathrooms = totalBathrooms;
		TotalStoreys = totalStoreys;
		YearBuilt = yearBuilt;
		HasSwimmingPool = hasSwimmingPool;
		HasWifi = hasWifi;
		HasGym = hasGym;
		HasParking = hasParking;
		HasPlayground = hasPlayground;
	}


	public Property(
		string address, TransactionType transactionType,
		PropertyType propertyType, decimal price)
		: this(address, transactionType, propertyType, 1, 1, price, 1, 1, 1900, false, false,
			  false, false, false)

	{

	}



	public override string ToString()
	{
		return $"Property: {TransactionType}, " +
		 $"\nProperty Type: {PropertyType}, " +
		 $"\nFloor Area: {FloorArea} m², " +
		 $"\nStoreys: {TotalStoreys}, " +
		 $"\nPrice: {Price:C}, " +
		 $"\nAddress: {Address}, " +
		 $"\nBedrooms: {TotalBedrooms}, " +
		 $"\nBathrooms: {TotalBathrooms}, " +
		 $"\nBuilt in: {YearBuilt}, " +
		 $"\nAmenities: " +
		 $"\n\t Swimming Pool : {(HasSwimmingPool ? "Y" : "N")}" +
		 $"\n\t Gym : {(HasGym ? "Y" : "N")}" +
		 $"\n\t Parking: {(HasParking ? "Y" : "N")}" +
		 $"\n\t Playground : {(HasPlayground ? "Y" : "N")}" +
		 $"\n\t WIFI : {(HasWifi ? "Y" : "N")}";
	}
}