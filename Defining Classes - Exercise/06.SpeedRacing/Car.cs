using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;

namespace _06.SpeedRacing
{
    public class Car
    {
		private string model;
		private double fuelAmount;
		private double fuelConsumtion;
		private double traveledDistance;

		public Car (string model, double fuelAmount, double fuelConsumtion)
		{
			Model = model;
			FuelAmount = fuelAmount;
			this.fuelConsumtion = fuelConsumtion;
		}

		public double TraveledDistance
		{
			get { return traveledDistance; }
			set { traveledDistance = value; }
		}


		public double FuelConsumption
		{
			get { return fuelConsumtion; }
			set { fuelConsumtion = value; }
		}


		public double FuelAmount
		{
			get { return fuelAmount; }
			set { fuelAmount = value; }
		}


		public string Model
		{
			get { return model; }
			set { model = value; }
		}

		public void Drive(double distance)
		{
			if (FuelAmount-(fuelConsumtion*distance)>=0)
			{
				FuelAmount -= fuelConsumtion * distance;
				TraveledDistance += distance;
			}
			else
			{
				Console.WriteLine("Insufficient fuel for the drive");
			}
		}

		public void PrintCarInfo()
		{
			Console.WriteLine($"{Model} {FuelAmount:f2} {TraveledDistance}");
		}

	}
}
