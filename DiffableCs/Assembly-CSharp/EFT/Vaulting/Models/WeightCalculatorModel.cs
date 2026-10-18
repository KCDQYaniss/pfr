namespace EFT.Vaulting.Models;

public class WeightCalculatorModel : IWeightCalculatorModel, IWeightCalculatorModelDebug
{
	private readonly Transform _gridRoot; //Field offset: 0x10
	private readonly IVaulingMovesModel _movesModel; //Field offset: 0x18
	[CompilerGenerated]
	private VaultingPoint <MaxWeightPoint>k__BackingField; //Field offset: 0x20

	public private override VaultingPoint MaxWeightPoint
	{
		[CompilerGenerated]
		 get { } //Length: 29
		[CompilerGenerated]
		private set { } //Length: 98
	}

	public WeightCalculatorModel(Transform gridRoot, IVaulingMovesModel movesModel) { }

	public override void CalculateWeights(List hits) { }

	private bool CheckHeightRestriction(float height) { }

	[CompilerGenerated]
	public override VaultingPoint get_MaxWeightPoint() { }

	[CompilerGenerated]
	private void set_MaxWeightPoint(VaultingPoint value) { }

}

