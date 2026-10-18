namespace EFT.Vaulting.Controllers;

public class GridMoverController
{
	private readonly IVaultingModel _model; //Field offset: 0x10

	public GridMoverController(IVaultingModel model) { }

	public void Tick(Vector3 forwardProjection, Vector3 playerRealForward) { }

}

