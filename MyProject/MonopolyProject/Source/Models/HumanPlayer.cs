using System;
using MonopolyProject.Source.Interface;

namespace MonopolyProject.Source.Models;

public class HumanPlayer : IPlayer
{
	private int _id;
	private string _name = "";
	public bool SetName(string name)
	{
		if (string.IsNullOrWhiteSpace(name))
		{
			return false;
		}
		_name = name;
		return true;
	}
	public string GetName()
	{
		return _name;
	}
	public bool SetId(int id)
	{
		if (id <= 0)
		{
			return false;
		}
		_id = id;
		return true;
	}
	public int GetId()
	{
		return _id;
	}
}
