﻿public class RepairEventArgs : EventArgs
{
	public string CarModel { get; set; }
	public string RepairDescription { get; set; }

	public RepairEventArgs(string carModel, string repairDescription)
	{
		CarModel = carModel;
		RepairDescription = repairDescription;
	}
}

public class Workshop
{
	public event EventHandler<RepairEventArgs> RepairCompleted;
	public void RepairCar(string carModel, string repairDescription)
	{
		Console.WriteLine($"Memperbaiki mobil {carModel}: {repairDescription}");

		RepairEventArgs repairEventArgs = new RepairEventArgs(carModel, repairDescription);

		OnRepairCompleted(repairEventArgs);
	}

	protected virtual void OnRepairCompleted(RepairEventArgs e)
	{
		RepairCompleted?.Invoke(this, e);
	}
}

public class CarOwner
{
	public string Name { get; set; }

	public CarOwner(string name)
	{
		Name = name;
	}
	private void Workshop_RepairCompleted(object sender, RepairEventArgs e)
	{
		Console.WriteLine($"[Pemilik Mobil] {Name} menerima mobilnya yang telah diperbaiki: {e.CarModel}");
		Console.WriteLine($"Deskripsi perbaikan: {e.RepairDescription}");
	}
	public void RegisterWorkshop(Workshop workshop)
	{
		workshop.RepairCompleted += Workshop_RepairCompleted;
	}
	public void UnregisterWorkshop(Workshop workshop)
	{
		workshop.RepairCompleted -= Workshop_RepairCompleted;
	}
}

class Program
{
	static void Main()
	{
		Workshop workshop = new Workshop();
		CarOwner carOwner = new CarOwner("John");
		carOwner.RegisterWorkshop(workshop);
		
		workshop.RepairCar("SUV", "Ganti oli dan periksa rem");
		carOwner.UnregisterWorkshop(workshop);
		workshop.RepairCar("Sedan", "Ganti ban");

		Console.ReadLine();
	}
}