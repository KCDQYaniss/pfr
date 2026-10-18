namespace EFT.Vaulting.Models;

public interface IVaultingModel
{

	public IAutomaticVaultingModel AutomaticVaultingModel
	{
		 get { } //Length: 0
	}

	public IGridPointsModel GridPointsModel
	{
		 get { } //Length: 0
	}

	public IGridRootMoverModel GridRootMoverModel
	{
		 get { } //Length: 0
	}

	public IGridSettingsModel GridSettingsModel
	{
		 get { } //Length: 0
	}

	public IObstacleCalculatorModel ObstacleCalculatorModel
	{
		 get { } //Length: 0
	}

	public IStairsCalculator StairsCalculatorModel
	{
		 get { } //Length: 0
	}

	public ISurfaceApproximatorModel SurfaceApproximatorModel
	{
		 get { } //Length: 0
	}

	public IVaultingRestrictionsModel VaultingRestrictionsModel
	{
		 get { } //Length: 0
	}

	public IVaultingStateModel VaultingStateModel
	{
		 get { } //Length: 0
	}

	public IVaulingMovesModel VaultingStatesModel
	{
		 get { } //Length: 0
	}

	public IWeightCalculatorModel WeightCalculatorModel
	{
		 get { } //Length: 0
	}

	public IAutomaticVaultingModel get_AutomaticVaultingModel() { }

	public IGridPointsModel get_GridPointsModel() { }

	public IGridRootMoverModel get_GridRootMoverModel() { }

	public IGridSettingsModel get_GridSettingsModel() { }

	public IObstacleCalculatorModel get_ObstacleCalculatorModel() { }

	public IStairsCalculator get_StairsCalculatorModel() { }

	public ISurfaceApproximatorModel get_SurfaceApproximatorModel() { }

	public IVaultingRestrictionsModel get_VaultingRestrictionsModel() { }

	public IVaultingStateModel get_VaultingStateModel() { }

	public IVaulingMovesModel get_VaultingStatesModel() { }

	public IWeightCalculatorModel get_WeightCalculatorModel() { }

}

