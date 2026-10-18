//Type is in global namespace

public sealed class MiddleGraphPoint : IMiddleGraphPoint, IMiddleGraphPointIncome, IAICorePointLink
{
	private readonly List _outgoing; //Field offset: 0x10
	private AICorePoint _corePointResolved; //Field offset: 0x18
	[CompilerGenerated]
	private readonly int <Id>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	private readonly int <CorePointId>k__BackingField; //Field offset: 0x24
	[CompilerGenerated]
	private readonly Vector3 <Position>k__BackingField; //Field offset: 0x28
	public float pathLength; //Field offset: 0x34
	public MiddleGraphPoint nodeFrom; //Field offset: 0x38
	public int SearchWayId; //Field offset: 0x40
	public int MiddleGraphAstarGen; //Field offset: 0x44

	public override int CorePointId
	{
		[CompilerGenerated]
		 get { } //Length: 4
	}

	public override AICorePoint CorePointInGame
	{
		 get { } //Length: 5
	}

	public int Id
	{
		[CompilerGenerated]
		 get { } //Length: 4
	}

	public override IReadOnlyList OutgoingWays
	{
		 get { } //Length: 5
	}

	public override Vector3 Position
	{
		[CompilerGenerated]
		 get { } //Length: 19
	}

	public MiddleGraphPoint(int id, Vector3 position, int corePointId) { }

	internal void AddOutgoing(MiddleGraphWay way) { }

	[CompilerGenerated]
	public override int get_CorePointId() { }

	public override AICorePoint get_CorePointInGame() { }

	[CompilerGenerated]
	public int get_Id() { }

	public override IReadOnlyList get_OutgoingWays() { }

	[CompilerGenerated]
	public override Vector3 get_Position() { }

	internal void SetCorePointResolved(AICorePoint corePoint) { }

	internal bool TryRemoveOutgoingWayTo(int targetPointId) { }

}

