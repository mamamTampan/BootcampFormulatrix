namespace MonopolyProject.Source;

public enum TransactionStatus
{
	SUCCESSFUL,
	ALREADY_OWNED,
	OWNED_BY_OTHERS,
	SOLD,
	PAID,
	BALANCE_NOT_ENOUGH
}
public enum TileType
{
	START,
	GO_TO_JAIL,
	BONUS,
	IN_JAIL,
	CHANCE_CARD,
	COMMUNITY_CARD,
	PUBLIC_PLACE,
	LANDMARK,
	TAX
}
public enum PieceType
{
	BLUE,
	YELLOW,
	RED,
	WHITE
}
public enum GameStatus
{
	NOT_STARTED,
	ONGOING,
	WIN
}
public enum ChanceCardType
{
	Fine,
	Reward,
	Tax,
	GoToJail,
	FreeFromJail,
	HeadToLandmark,
	BackToLandmark,
	StepForward,
	StepBack,
	HeadToStart
}
public enum CommunityCardType
{
	FineOrTakeChanceCard,
	Reward,
	Tax,
	GoToJail,
	FreeFromJail,
	BackToLandmark,
	HeadToStart
}