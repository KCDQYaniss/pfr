//Type is in global namespace

public class AIPointsCounterSegment
{
	public NavPoint P1; //Field offset: 0x10
	public NavPoint P2; //Field offset: 0x18
	[CompilerGenerated]
	private AIPointsCounterSegment <Left>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	private AIPointsCounterSegment <Right>k__BackingField; //Field offset: 0x28
	[CompilerGenerated]
	private float <LeftAng>k__BackingField; //Field offset: 0x30
	[CompilerGenerated]
	private float <RightAng>k__BackingField; //Field offset: 0x34
	[CompilerGenerated]
	private int <GroupId>k__BackingField; //Field offset: 0x38
	[CompilerGenerated]
	private float <Magnitude>k__BackingField; //Field offset: 0x3C
	private NavEdge _edge; //Field offset: 0x40
	private Func _cutEdge; //Field offset: 0x48
	public int CorePointId; //Field offset: 0x50

	public Vector3 GetCenter
	{
		 get { } //Length: 109
	}

	public int GroupId
	{
		[CompilerGenerated]
		 get { } //Length: 4
		[CompilerGenerated]
		 set { } //Length: 4
	}

	public private AIPointsCounterSegment Left
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public private float LeftAng
	{
		[CompilerGenerated]
		 get { } //Length: 6
		[CompilerGenerated]
		private set { } //Length: 6
	}

	public private float Magnitude
	{
		[CompilerGenerated]
		 get { } //Length: 6
		[CompilerGenerated]
		private set { } //Length: 6
	}

	public private AIPointsCounterSegment Right
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public private float RightAng
	{
		[CompilerGenerated]
		 get { } //Length: 6
		[CompilerGenerated]
		private set { } //Length: 6
	}

	public AIPointsCounterSegment(NavEdge edge, Func cutEdge, int corePointId) { }

	public bool CreatedPoint(PointAtCounter np1) { }

	public void DebugDraw(Vector3 offset) { }

	public Vector3 get_GetCenter() { }

	[CompilerGenerated]
	public int get_GroupId() { }

	[CompilerGenerated]
	public AIPointsCounterSegment get_Left() { }

	[CompilerGenerated]
	public float get_LeftAng() { }

	[CompilerGenerated]
	public float get_Magnitude() { }

	[CompilerGenerated]
	public AIPointsCounterSegment get_Right() { }

	[CompilerGenerated]
	public float get_RightAng() { }

	public NavPoint GetOther(NavPoint prevPoint) { }

	public Vector3 OrtNoraml() { }

	[CompilerGenerated]
	public void set_GroupId(int value) { }

	[CompilerGenerated]
	private void set_Left(AIPointsCounterSegment value) { }

	[CompilerGenerated]
	private void set_LeftAng(float value) { }

	[CompilerGenerated]
	private void set_Magnitude(float value) { }

	[CompilerGenerated]
	private void set_Right(AIPointsCounterSegment value) { }

	[CompilerGenerated]
	private void set_RightAng(float value) { }

	public void SetLeft(AIPointsCounterSegment segment, float ang) { }

	public void SetRight(AIPointsCounterSegment segment, float ang) { }

}

