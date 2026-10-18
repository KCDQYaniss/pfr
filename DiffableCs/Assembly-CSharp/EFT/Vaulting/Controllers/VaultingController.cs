namespace EFT.Vaulting.Controllers;

public class VaultingController
{
	private readonly IVaultingView _view; //Field offset: 0x10
	private readonly IVaultingModel _model; //Field offset: 0x18
	private GridPointsController _gridCalculatorController; //Field offset: 0x20
	private VaultingStateController _vaultingStateController; //Field offset: 0x28
	private GridMoverController _gridMoverController; //Field offset: 0x30
	private GridSurfaceCalculatorController _gridSurfaceCalculatorController; //Field offset: 0x38
	private HitPointsApproximatorController _approximatorController; //Field offset: 0x40
	private WeightCalculatorController _weightCalculatorController; //Field offset: 0x48

	public GridPointsController GridPointsController
	{
		 get { } //Length: 5
	}

	public VaultingController(IVaultingModel model, IVaultingView view) { }

	public GridPointsController get_GridPointsController() { }

	private void InitializeSubcontrollers() { }

	public void Tick(VaultingTransferModel data) { }

}

