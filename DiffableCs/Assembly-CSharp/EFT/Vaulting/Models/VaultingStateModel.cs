namespace EFT.Vaulting.Models;

public class VaultingStateModel : IVaultingStateModel, IVaultingStateModelDebug
{
	private readonly Transform _gridRoot; //Field offset: 0x10
	[CompilerGenerated]
	private Nullable <AverageHeight>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	private Nullable <AverageLength>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	private Nullable <AverageDistance>k__BackingField; //Field offset: 0x28
	[CompilerGenerated]
	private Nullable <CurrentMotion>k__BackingField; //Field offset: 0x30
	[CompilerGenerated]
	private float <VerticalOffset>k__BackingField; //Field offset: 0x40

	public override Nullable AverageDistance
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 5
	}

	public override Nullable AverageHeight
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 5
	}

	public override Nullable AverageLength
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 5
	}

	public override Nullable CurrentMotion
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		 set { } //Length: 8
	}

	public override float VerticalOffset
	{
		[CompilerGenerated]
		 get { } //Length: 6
		[CompilerGenerated]
		 set { } //Length: 6
	}

	public VaultingStateModel(Transform gridRoot) { }

	private void CalculateAverageDistantceToObstacle(ref VaultingStateDataTransferModel data) { }

	public override void CalculateParameters(VaultingStateDataTransferModel data) { }

	private void CalculateSurfaceAverageHeight(ref VaultingStateDataTransferModel data) { }

	private void CalculateSurfaceAverageLength(ref VaultingStateDataTransferModel data) { }

	[CompilerGenerated]
	public override Nullable get_AverageDistance() { }

	[CompilerGenerated]
	public override Nullable get_AverageHeight() { }

	[CompilerGenerated]
	public override Nullable get_AverageLength() { }

	[CompilerGenerated]
	public override Nullable get_CurrentMotion() { }

	[CompilerGenerated]
	public override float get_VerticalOffset() { }

	[CompilerGenerated]
	public void set_AverageDistance(Nullable value) { }

	[CompilerGenerated]
	public void set_AverageHeight(Nullable value) { }

	[CompilerGenerated]
	public void set_AverageLength(Nullable value) { }

	[CompilerGenerated]
	public override void set_CurrentMotion(Nullable value) { }

	[CompilerGenerated]
	public override void set_VerticalOffset(float value) { }

}

