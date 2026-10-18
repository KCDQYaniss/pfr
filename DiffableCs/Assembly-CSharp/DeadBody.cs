//Type is in global namespace

public class DeadBody : IPositionPoint
{
	[CompilerGenerated]
	private Vector3 <Position>k__BackingField; //Field offset: 0x10
	public float CreatedTime; //Field offset: 0x1C
	public Player Player; //Field offset: 0x20
	private bool IsFound; //Field offset: 0x28
	[CompilerGenerated]
	private bool <IsOnNavMesh>k__BackingField; //Field offset: 0x29
	private readonly List groups; //Field offset: 0x30
	private readonly bool isAI; //Field offset: 0x38
	private int _observer; //Field offset: 0x3C
	[CompilerGenerated]
	private readonly EPlayerSide <Side>k__BackingField; //Field offset: 0x40
	[CompilerGenerated]
	private readonly Vector3 <BodyPosition>k__BackingField; //Field offset: 0x44

	public Vector3 BodyPosition
	{
		[CompilerGenerated]
		 get { } //Length: 19
	}

	public private bool IsOnNavMesh
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public override Vector3 Position
	{
		[CompilerGenerated]
		 get { } //Length: 19
		[CompilerGenerated]
		 set { } //Length: 16
	}

	public EPlayerSide Side
	{
		[CompilerGenerated]
		 get { } //Length: 4
	}

	public DeadBody(BotsGroup coreGroup, List groups, bool isAI, EPlayerSide side, Vector3 pos, IPlayer player) { }

	[CompilerGenerated]
	public Vector3 get_BodyPosition() { }

	[CompilerGenerated]
	public bool get_IsOnNavMesh() { }

	[CompilerGenerated]
	public override Vector3 get_Position() { }

	[CompilerGenerated]
	public EPlayerSide get_Side() { }

	public void InspectionComplete() { }

	public bool IsEnemiesBody(EPlayerSide sideFounder) { }

	public bool IsFreeFor(BotOwner owner) { }

	[CompilerGenerated]
	private void set_IsOnNavMesh(bool value) { }

	[CompilerGenerated]
	public void set_Position(Vector3 value) { }

	public void SetUnderWork(BotOwner owner) { }

}

