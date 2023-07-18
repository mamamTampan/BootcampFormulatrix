﻿﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace GenericDictionaryDemo
{
	class Program
	{
		static void Main()
		{
            //List<string> myString = new();
            //Creating a Dictionary with Key and value both are string type
            Dictionary<string, string> carBrands = new Dictionary<string, string>();

			//Adding Elements to the Dictionary using Add Method of Dictionary class
			carBrands.Add("Toyota", "Corolla, Camry, RAV4");
			carBrands.Add("Ford", "F-150, Mustang, Explorer");
			carBrands.Add("Honda", "Civic, Accord, CR-V");

			//Accessing Dictionary Elements using For Each Loop
			Console.WriteLine("Accessing Dictionary Elements using For Each Loop");
			foreach (KeyValuePair<string, string> KVP in carBrands)
			{
				Console.WriteLine($"Key:{KVP.Key}, Value: {KVP.Value}");
			}

			//Accessing Dictionary Elements using For Loop
			Console.WriteLine("\nAccessing Dictionary Elements using For Loop");
			for (int i = 0; i < carBrands.Count; i++)
			{
				string key = carBrands.Keys.ElementAt(i);
				string values = carBrands[key];
				Console.WriteLine($"Key: {key}, Value: {values}");
			}

			//Accessing Dictionary Elements using Keys
			Console.WriteLine("\nAccessing Dictionary Elements using Keys");
			Console.WriteLine($"Key: Toyota, Value: {carBrands["Toyota"]}");
			Console.WriteLine($"Key: Ford, Value: {carBrands["Ford"]}");
			Console.WriteLine($"Key: Honda, Value: {carBrands["Honda"]}");

			//Assigning a new value to a key
			carBrands["Toyota"] = "Corolla, Camry, Highlander, RAV4";
			Console.WriteLine("\nUpdated value of key 'Toyota': " + carBrands["Toyota"]);

			//Checking if a key or value exists in the dictionary
			Console.WriteLine("\nDictionary contains 'Toyota': " + carBrands.Contains(new KeyValuePair<string, string>("Toyota", "Corolla, Camry, Highlander, RAV4")));
			Console.WriteLine("Dictionary contains key 'Ford': " + carBrands.ContainsKey("Ford"));
			Console.WriteLine("Dictionary contains value 'Explorer': " + carBrands.ContainsValue("Explorer"));

			//Removing a key-value pair from the dictionary
			carBrands.Remove("Honda");
			Console.WriteLine("\nDictionary after removing key-value pair for 'Honda':");
			foreach (KeyValuePair<string, string> KVP in carBrands)
			{
				Console.WriteLine($"Key:{KVP.Key}, Value: {KVP.Value}");
			}

			//Clearing the dictionary
			carBrands.Clear();
			Console.WriteLine("\nDictionary after clearing all key-value pairs:");
			Console.WriteLine("Count: " + carBrands.Count);

			//Trying to add a new key-value pair to the dictionary
			bool added = carBrands.TryAdd("Tesla", "Model S, Model 3, Model X, Model Y");
			Console.WriteLine("\nTrying to add a new key-value pair for 'Tesla': " + added);

			//Trying to get the value for a given key
			string value;
			bool retrieved = carBrands.TryGetValue("Ford", out value);
			if (retrieved)
			{
				Console.WriteLine("\nThe value for key 'Ford' is: " + value);
			}
			else
			{
				Console.WriteLine("\nThe dictionary does not contain a key for 'Ford'");
			}

			Console.ReadKey();
		}
	}
}