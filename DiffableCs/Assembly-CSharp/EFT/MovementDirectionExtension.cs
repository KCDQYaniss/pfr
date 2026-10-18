namespace EFT;

[Extension]
public static class MovementDirectionExtension
{
	private static readonly Dictionary CONVERSION_DICTIONARY; //Field offset: 0x0
	private static readonly Dictionary INVERT_CONVERSION_DICTIONARY; //Field offset: 0x8

	private static MovementDirectionExtension() { }

	public static EMovementDirection ConvertToMovementDirection(Vector2 movementDirection) { }

	[Extension]
	public static float InvertDirection(EMovementDirection direction) { }

	[Extension]
	public static bool IsDiagonal(EMovementDirection direction) { }

	[Extension]
	public static Vector2 ToVector2(EMovementDirection direction) { }

}

