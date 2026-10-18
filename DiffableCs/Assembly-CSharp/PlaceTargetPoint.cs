//Type is in global namespace

public class PlaceTargetPoint : IPathTargetPoint, IPositionPoint
{
	private readonly IAICorePointLink _point; //Field offset: 0x10

	public override Vector3 Position
	{
		 get { } //Length: 113
	}

	public PlaceTargetPoint(IAICorePointLink point) { }

	public override void BotCome(BotOwner owner) { }

	public override Vector3 get_Position() { }

	public override bool IsSame(IPathTargetPoint point) { }

}

