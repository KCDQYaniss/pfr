//Type is in global namespace

public class VectorTargetPoint : IPathTargetPoint, IPositionPoint
{
	[CompilerGenerated]
	private readonly Vector3 <Position>k__BackingField; //Field offset: 0x10

	public override Vector3 Position
	{
		[CompilerGenerated]
		 get { } //Length: 19
	}

	public VectorTargetPoint(Vector3 target) { }

	public override void BotCome(BotOwner owner) { }

	[CompilerGenerated]
	public override Vector3 get_Position() { }

	public override bool IsSame(IPathTargetPoint point) { }

}

