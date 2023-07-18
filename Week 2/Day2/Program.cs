public delegate void UpdateHargaEventHandler(object sender, UpdateHargaEventArgs e);

public class UpdateHargaEventArgs : EventArgs
{
	public decimal HargaLama { get; set; }
	public decimal HargaBaru { get; set; }
}

public class Produk
{
	private decimal harga;

	public event UpdateHargaEventHandler UpdateHarga;

	public decimal Harga
	{
		get { return harga; }
		set
		{
			if (harga != value)
			{
				UpdateHargaEventArgs args = new UpdateHargaEventArgs
				{
					HargaLama = harga,
					HargaBaru = value
				};

				harga = value;
				OnUpdateHarga(args);
			}
		}
	}

	protected virtual void OnUpdateHarga(UpdateHargaEventArgs e)
	{
		if (UpdateHarga != null)
		{
			UpdateHarga(this, e);
		}
	}
}

public class Pembeli
{
	public void HandlePriceChanged(object sender, UpdateHargaEventArgs e)
	{
		Console.WriteLine($"Harga Lama: {e.HargaLama}");
		Console.WriteLine($"Harga Baru: {e.HargaBaru}");
	}
}

public static class Program
{
	public static void Main()
	{
		Produk produk = new Produk();
		Pembeli pembeli = new Pembeli();

		produk.UpdateHarga += pembeli.HandlePriceChanged;
		
		Console.WriteLine("Masukan Harga Baru:");
		string masukan = Console.ReadLine();
		decimal newHarga = decimal.Parse(masukan);
		try
		{	
			
		}
		catch (FormatException e)
		{
			Console.WriteLine("");
		}

		
		produk.Harga = newHarga;

	}
}