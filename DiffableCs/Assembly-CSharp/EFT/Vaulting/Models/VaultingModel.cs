namespace EFT.Vaulting.Models;

public class VaultingModel : IVaultingModel, IVaultingModelDebug
{
	private readonly Transform _gridRootTransform; //Field offset: 0x10
	private readonly IVaultingSettings _globalSettings; //Field offset: 0x18
	private readonly IVaultingContext _vaultingContext; //Field offset: 0x20
	private readonly GridPointsModel _gridPointsModel; //Field offset: 0x28
	private readonly GridSettingsModel _gridSettingsModel; //Field offset: 0x30
	private readonly VaultingRestrictionsModel _restrictionsModel; //Field offset: 0x38
	private readonly VaultingStateModel _vaultingStateModel; //Field offset: 0x40
	private readonly GridRootMoverModel _gridRootMoverModel; //Field offset: 0x48
	private readonly ObstacleCalculatorModel _obstacleCalculatorModel; //Field offset: 0x50
	private readonly AutomaticVaultingRestrictionsModel _automaticVaultingModel; //Field offset: 0x58
	private readonly DouglasPeuckerSurfaceApproximator _approximatorModel; //Field offset: 0x60
	private readonly WeightCalculatorModel _weightCalculatorModel; //Field offset: 0x68
	private readonly StairsCalculatorModel _stairsCalculatorModel; //Field offset: 0x70
	private readonly VaultingMovesModel _vaultingMovesModel; //Field offset: 0x78

	public override IAutomaticVaultingModel AutomaticVaultingModel
	{
		 get { } //Length: 5
	}

	public override IAutomaticVaultingModelDebug AutomaticVaultingModelDebug
	{
		 get { } //Length: 5
	}

	public override IGridPointsModel GridPointsModel
	{
		 get { } //Length: 5
	}

	public override IGridPointsModelDebug GridPointsModelDebug
	{
		 get { } //Length: 5
	}

	public override IGridRootMoverModelDebug GridRootModelDebug
	{
		 get { } //Length: 5
	}

	public override IGridRootMoverModel GridRootMoverModel
	{
		 get { } //Length: 5
	}

	public override IGridSettingsModel GridSettingsModel
	{
		 get { } //Length: 76
	}

	public override IGridSettingsModelDebug GridSettingsModelDebug
	{
		 get { } //Length: 76
	}

	public override IObstacleCalculatorModel ObstacleCalculatorModel
	{
		 get { } //Length: 5
	}

	public override IObstacleCalculatorModelDebug ObstacleCalculatorModelDebug
	{
		 get { } //Length: 5
	}

	public override IStairsCalculator StairsCalculatorModel
	{
		 get { } //Length: 5
	}

	public override ISurfaceApproximatorModel SurfaceApproximatorModel
	{
		 get { } //Length: 5
	}

	public override ISurfaceApproximatorModelDebug SurfaceApproximatorModelDebug
	{
		 get { } //Length: 5
	}

	public override IVaultingRestrictionsModel VaultingRestrictionsModel
	{
		 get { } //Length: 5
	}

	public override IVaultingRestrictionsModelDebug VaultingRestrictionsModelDebug
	{
		 get { } //Length: 5
	}

	public override IVaultingStateModel VaultingStateModel
	{
		 get { } //Length: 5
	}

	public override IVaultingStateModelDebug VaultingStateModelDebug
	{
		 get { } //Length: 5
	}

	public override IVaulingMovesModel VaultingStatesModel
	{
		 get { } //Length: 5
	}

	public override IWeightCalculatorModel WeightCalculatorModel
	{
		 get { } //Length: 5
	}

	public override IWeightCalculatorModelDebug WeightCalculatorModelDebug
	{
		 get { } //Length: 5
	}

	public VaultingModel(IVaultingSettings vaultingGlobalSettings, IVaultingContext vaultingContext) { }

	[CompilerGenerated]
	private bool <.ctor>b__14_0() { }

	public override IAutomaticVaultingModel get_AutomaticVaultingModel() { }

	public override IAutomaticVaultingModelDebug get_AutomaticVaultingModelDebug() { }

	public override IGridPointsModel get_GridPointsModel() { }

	public override IGridPointsModelDebug get_GridPointsModelDebug() { }

	public override IGridRootMoverModelDebug get_GridRootModelDebug() { }

	public override IGridRootMoverModel get_GridRootMoverModel() { }

	public override IGridSettingsModel get_GridSettingsModel() { }

	public override IGridSettingsModelDebug get_GridSettingsModelDebug() { }

	public override IObstacleCalculatorModel get_ObstacleCalculatorModel() { }

	public override IObstacleCalculatorModelDebug get_ObstacleCalculatorModelDebug() { }

	public override IStairsCalculator get_StairsCalculatorModel() { }

	public override ISurfaceApproximatorModel get_SurfaceApproximatorModel() { }

	public override ISurfaceApproximatorModelDebug get_SurfaceApproximatorModelDebug() { }

	public override IVaultingRestrictionsModel get_VaultingRestrictionsModel() { }

	public override IVaultingRestrictionsModelDebug get_VaultingRestrictionsModelDebug() { }

	public override IVaultingStateModel get_VaultingStateModel() { }

	public override IVaultingStateModelDebug get_VaultingStateModelDebug() { }

	public override IVaulingMovesModel get_VaultingStatesModel() { }

	public override IWeightCalculatorModel get_WeightCalculatorModel() { }

	public override IWeightCalculatorModelDebug get_WeightCalculatorModelDebug() { }

}

