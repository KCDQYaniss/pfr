//Type is in global namespace

public struct FollowerPatrolTargetStruct
{
	public Vector3 Position; //Field offset: 0x0
	public bool SitAtEnd; //Field offset: 0xC
	public PointWithLookSides LookSides; //Field offset: 0x10
	[CompilerGenerated]
	private readonly bool <HasValue>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	private readonly bool <HasLookSides>k__BackingField; //Field offset: 0x19

	public bool HasLookSides
	{
		[CompilerGenerated]
		[IsReadOnly]
		 get { } //Length: 5
	}

	public bool HasValue
	{
		[CompilerGenerated]
		[IsReadOnly]
		 get { } //Length: 5
	}

	public FollowerPatrolTargetStruct(Vector3 position, bool sitAtEnd, PointWithLookSides sides) { }

	public FollowerPatrolTargetStruct(Vector3 position, bool sitAtEnd) { }

	public FollowerPatrolTargetStruct(Vector3 position) { }

	[CompilerGenerated]
	[IsReadOnly]
	public bool get_HasLookSides() { }

	[CompilerGenerated]
	[IsReadOnly]
	public bool get_HasValue() { }

	private bool HaveLookDirectionsCheck() { }

}

