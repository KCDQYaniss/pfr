//Type is in global namespace

public struct AIGrenadeThrowPositionPair
{
	public const float MaxDistanceBetweenPositions = 1.5; //Field offset: 0x0
	public const float MaxHorizontalOffset = 0.2; //Field offset: 0x0
	public Vector3 StayPosition; //Field offset: 0x0
	public Vector3 ThrowFromPosition; //Field offset: 0xC

	public AIGrenadeThrowPositionPair(Vector3 stayPosition, Vector3 throwFromPosition) { }

	public bool IsValid(out string error) { }

	public static bool TryValidate(Vector3 stayPosition, Vector3 throwFromPosition, out string error) { }

}

