namespace EFT.Vaulting.Debug.Models.DataModels;

public struct GridPointsDataModel
{
	[CompilerGenerated]
	private Vector3 <RootGridPosition>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	private List <FrontFromPositions>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private List <TopFromPositions>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	private List <HitPointsXY>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	private List <HitPointsYZ>k__BackingField; //Field offset: 0x28
	[CompilerGenerated]
	private VaultingPoint <MaxWeightPoint>k__BackingField; //Field offset: 0x30

	public List FrontFromPositions
	{
		[CompilerGenerated]
		[IsReadOnly]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 82
	}

	public List HitPointsXY
	{
		[CompilerGenerated]
		[IsReadOnly]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 82
	}

	public List HitPointsYZ
	{
		[CompilerGenerated]
		[IsReadOnly]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 82
	}

	public VaultingPoint MaxWeightPoint
	{
		[CompilerGenerated]
		[IsReadOnly]
		 get { } //Length: 29
		[CompilerGenerated]
		 set { } //Length: 98
	}

	public Vector3 RootGridPosition
	{
		[CompilerGenerated]
		[IsReadOnly]
		 get { } //Length: 18
		[CompilerGenerated]
		 set { } //Length: 15
	}

	public List TopFromPositions
	{
		[CompilerGenerated]
		[IsReadOnly]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 82
	}

	[CompilerGenerated]
	[IsReadOnly]
	public List get_FrontFromPositions() { }

	[CompilerGenerated]
	[IsReadOnly]
	public List get_HitPointsXY() { }

	[CompilerGenerated]
	[IsReadOnly]
	public List get_HitPointsYZ() { }

	[CompilerGenerated]
	[IsReadOnly]
	public VaultingPoint get_MaxWeightPoint() { }

	[CompilerGenerated]
	[IsReadOnly]
	public Vector3 get_RootGridPosition() { }

	[CompilerGenerated]
	[IsReadOnly]
	public List get_TopFromPositions() { }

	[CompilerGenerated]
	public void set_FrontFromPositions(List value) { }

	[CompilerGenerated]
	public void set_HitPointsXY(List value) { }

	[CompilerGenerated]
	public void set_HitPointsYZ(List value) { }

	[CompilerGenerated]
	public void set_MaxWeightPoint(VaultingPoint value) { }

	[CompilerGenerated]
	public void set_RootGridPosition(Vector3 value) { }

	[CompilerGenerated]
	public void set_TopFromPositions(List value) { }

}

