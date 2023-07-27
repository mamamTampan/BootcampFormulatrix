using System;
using MonopolyProject.Source.Interface;
using System.Collections.Generic;

namespace MonopolyProject.Source.Models;

public class PlayerConfig : IPlayerConfig
{
	private PieceType _pieceColor = new PieceType;
	private int _position;
	private int _balance;
	private bool _isInJail;
	private ICard _keptCard;
	private Dictionary <Tile.KeyValuePair<string,int>> _propertyMap = new Dictionary<Tile.KeyValuePair<string,int>>();

}

