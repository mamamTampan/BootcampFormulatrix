namespace MonopolyProject.Source.Interface;

public interface IPiece
{
	bool SetPiece(PieceType pieceType);
	PieceType GetPiece();
}