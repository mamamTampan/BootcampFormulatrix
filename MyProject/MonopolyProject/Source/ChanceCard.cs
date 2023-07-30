using System;
using System.Collections.Generic;

namespace MonopolyProject.Source
{
	public class ChanceCard : Interface.ICard
	{
		private ChanceCardType _type;
		private string _description;

		private Dictionary<ChanceCardType, string> cards = new Dictionary<ChanceCardType, string>
		{
			{ ChanceCardType.Fine, "Pay a Fine: You violated traffic rules. Pay a $15 fine."},
			{ ChanceCardType.Reward, "Get a Reward: You received a performance bonus. Collect $50 from the bank."},
			{ ChanceCardType.Tax, "Pay Tax: Property taxes have increased. Pay $100 to the bank."},
			{ ChanceCardType.GoToJail, "Go to Jail: You have been arrested by the police! Go directly to Jail. Do not pass Start, do not collect $200."},
			{ ChanceCardType.FreeFromJail, "Free from Jail: Get out of Jail free! Keep this card for future use or sell it for a good price."},
			{ ChanceCardType.HeadToLandmark, "Head to Landmark: Advance to the Sports Field. If unowned, you may buy it. If owned, pay rent."},
			{ ChanceCardType.BackToLandmark, "Back to Landmark: Go back to the Palace. If unowned, you may buy it. If owned, pay rent."},
			{ ChanceCardType.StepForward, "Step Forward: Advance 3 spaces. If you pass Go, collect $200."},
			{ ChanceCardType.StepBack, "Step Back: Move back 2 spaces. If you land on Go, collect $50."},
			{ ChanceCardType.HeadToStart, "Head to Start: Go back to Start. Collect $200 from the bank."}
		};
		public ChanceCard(ChanceCardType type, string description)
		{
			_type = type;
			_description = description;
		}

		public string OpenCard()
		{
			return _description;
		}
	}
}