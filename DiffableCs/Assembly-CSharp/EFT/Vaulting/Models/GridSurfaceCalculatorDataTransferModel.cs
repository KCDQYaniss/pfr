namespace EFT.Vaulting.Models;

public struct GridSurfaceCalculatorDataTransferModel
{
	[CompilerGenerated]
	private float <GridSteppingZ>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	private VaultingPoint <MaxWeightPoint>k__BackingField; //Field offset: 0x8
	[CompilerGenerated]
	private List <VerticalHitPoints>k__BackingField; //Field offset: 0x30

	public float GridSteppingZ
	{
		[CompilerGenerated]
		[IsReadOnly]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 5
	}

	public VaultingPoint MaxWeightPoint
	{
		[CompilerGenerated]
		[IsReadOnly]
		 get { } //Length: 29
		[CompilerGenerated]
		 set { } //Length: 98
	}

	public List VerticalHitPoints
	{
		[CompilerGenerated]
		[IsReadOnly]
		 get { } //Length: 76
		[CompilerGenerated]
		 set { } //Length: 82
	}

	[CompilerGenerated]
	[IsReadOnly]
	public float get_GridSteppingZ() { }

	[CompilerGenerated]
	[IsReadOnly]
	public VaultingPoint get_MaxWeightPoint() { }

	[CompilerGenerated]
	[IsReadOnly]
	public List get_VerticalHitPoints() { }

	[CompilerGenerated]
	public void set_GridSteppingZ(float value) { }

	[CompilerGenerated]
	public void set_MaxWeightPoint(VaultingPoint value) { }

	[CompilerGenerated]
	public void set_VerticalHitPoints(List value) { }

}

