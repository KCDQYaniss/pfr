//Type is in global namespace

public class PlaceForCheck
{
	public Vector3 BasePoint; //Field offset: 0x10
	public BotOwner CheckingPlayer; //Field offset: 0x20
	public bool Reacheble; //Field offset: 0x28
	private bool _isCome; //Field offset: 0x29
	private readonly List points2look; //Field offset: 0x30
	private readonly List isPointChecked; //Field offset: 0x38
	[CompilerGenerated]
	private readonly CustomNavigationPoint <Point>k__BackingField; //Field offset: 0x40
	[CompilerGenerated]
	private PlaceForCheckType <Type>k__BackingField; //Field offset: 0x48
	[CompilerGenerated]
	private float <CreatedTime>k__BackingField; //Field offset: 0x4C
	[CompilerGenerated]
	private float <DieTime>k__BackingField; //Field offset: 0x50
	public int _environmentId; //Field offset: 0x54
	public int ConnectionGroupId; //Field offset: 0x58

	public private float CreatedTime
	{
		[CompilerGenerated]
		 get { } //Length: 6
		[CompilerGenerated]
		private set { } //Length: 6
	}

	public private float DieTime
	{
		[CompilerGenerated]
		 get { } //Length: 6
		[CompilerGenerated]
		private set { } //Length: 6
	}

	public int EnvironmentId
	{
		 get { } //Length: 4
	}

	public bool IsCome
	{
		 get { } //Length: 5
		 set { } //Length: 22
	}

	public bool IsDanger
	{
		 get { } //Length: 9
	}

	public CustomNavigationPoint Point
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public Vector3 Position
	{
		 get { } //Length: 80
	}

	public private PlaceForCheckType Type
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 5
	}

	public PlaceForCheck(Vector3 Point, PlaceForCheckType type) { }

	public PlaceForCheck(CustomNavigationPoint Point, Vector3 basePoint, PlaceForCheckType type) { }

	private void CalcPointsToLook() { }

	private void CreatetimeUpdate(PlaceForCheckType type) { }

	[CompilerGenerated]
	public float get_CreatedTime() { }

	[CompilerGenerated]
	public float get_DieTime() { }

	public int get_EnvironmentId() { }

	public bool get_IsCome() { }

	public bool get_IsDanger() { }

	[CompilerGenerated]
	public CustomNavigationPoint get_Point() { }

	public Vector3 get_Position() { }

	[CompilerGenerated]
	public PlaceForCheckType get_Type() { }

	public int GetPointToLook(out Nullable point) { }

	public bool IsOld() { }

	public bool IsThisPointClose(Vector3 testPoint) { }

	public void PointLookComplete(int index) { }

	private void RefreshEnvironment() { }

	[CompilerGenerated]
	private void set_CreatedTime(float value) { }

	[CompilerGenerated]
	private void set_DieTime(float value) { }

	public void set_IsCome(bool value) { }

	[CompilerGenerated]
	private void set_Type(PlaceForCheckType value) { }

	public virtual string ToString() { }

}

