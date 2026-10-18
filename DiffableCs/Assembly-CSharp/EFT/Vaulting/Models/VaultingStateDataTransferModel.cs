namespace EFT.Vaulting.Models;

public struct VaultingStateDataTransferModel
{
	[CompilerGenerated]
	private float <SteppingLengthX>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	private float <GridOffsetZ>k__BackingField; //Field offset: 0x4
	[CompilerGenerated]
	private VaultingPoint <MaxWeightPoint>k__BackingField; //Field offset: 0x8
	[CompilerGenerated]
	private List <ForwardHitPoints>k__BackingField; //Field offset: 0x30
	[CompilerGenerated]
	private List <VerticalHitPoints>k__BackingField; //Field offset: 0x38

	public List ForwardHitPoints
	{
		[CompilerGenerated]
		[IsReadOnly]
		 get { } //Length: 76
		[CompilerGenerated]
		 set { } //Length: 82
	}

	public float GridOffsetZ
	{
		[CompilerGenerated]
		[IsReadOnly]
		 get { } //Length: 6
		[CompilerGenerated]
		 set { } //Length: 6
	}

	public VaultingPoint MaxWeightPoint
	{
		[CompilerGenerated]
		[IsReadOnly]
		 get { } //Length: 29
		[CompilerGenerated]
		 set { } //Length: 98
	}

	public float SteppingLengthX
	{
		[CompilerGenerated]
		[IsReadOnly]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 5
	}

	public List VerticalHitPoints
	{
		[CompilerGenerated]
		[IsReadOnly]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 82
	}

	[CompilerGenerated]
	[IsReadOnly]
	public List get_ForwardHitPoints() { }

	[CompilerGenerated]
	[IsReadOnly]
	public float get_GridOffsetZ() { }

	[CompilerGenerated]
	[IsReadOnly]
	public VaultingPoint get_MaxWeightPoint() { }

	[CompilerGenerated]
	[IsReadOnly]
	public float get_SteppingLengthX() { }

	[CompilerGenerated]
	[IsReadOnly]
	public List get_VerticalHitPoints() { }

	[CompilerGenerated]
	public void set_ForwardHitPoints(List value) { }

	[CompilerGenerated]
	public void set_GridOffsetZ(float value) { }

	[CompilerGenerated]
	public void set_MaxWeightPoint(VaultingPoint value) { }

	[CompilerGenerated]
	public void set_SteppingLengthX(float value) { }

	[CompilerGenerated]
	public void set_VerticalHitPoints(List value) { }

}

