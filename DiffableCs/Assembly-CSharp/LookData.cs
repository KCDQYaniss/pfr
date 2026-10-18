//Type is in global namespace

public class LookData : BotData
{
	protected int _lastSideSign; //Field offset: 0x18
	protected float _nextCheckTimeSetLookAnotherSide; //Field offset: 0x1C
	protected float LOOK_TO_ENEMY_TIME; //Field offset: 0x20
	protected float _nextCheckTimeSetLookHearing; //Field offset: 0x24

	public LookData(BotOwner owner) { }

	private static Vector3 ClampVerticalIfIndoor(Vector3 source, bool isIndoor) { }

	public static LookData Create(BotOwner owner) { }

	protected override bool IsLookPointExistAndValid(CustomNavigationPoint point) { }

	public void ResetUpdateTime() { }

	public Vector3 RotateWallBySide(CustomNavigationPoint covPoint, int side = 0) { }

	public override void SetLookPointByHearing(CustomNavigationPoint closestPoint = null) { }

	protected Vector3 UsePlaceForCheck(PlaceForCheck palce) { }

}

