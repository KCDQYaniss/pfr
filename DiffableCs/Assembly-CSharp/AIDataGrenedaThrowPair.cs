//Type is in global namespace

public struct AIDataGrenedaThrowPair
{
	public Vector3 StayPosition; //Field offset: 0x0
	public Vector3 ThrowFromPosition; //Field offset: 0xC
	public Vector3 Target; //Field offset: 0x18
	public int ConnectionGroupId; //Field offset: 0x24

	public AIGrenadeThrowPositionPair Positions
	{
		 get { } //Length: 34
	}

	public AIDataGrenedaThrowPair(Vector3 stayPosition, Vector3 throwFromPosition, Vector3 target, int connectionGroupId = -1) { }

	public AIGrenadeThrowPositionPair get_Positions() { }

}

