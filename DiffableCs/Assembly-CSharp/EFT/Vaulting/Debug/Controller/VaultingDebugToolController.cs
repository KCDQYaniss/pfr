namespace EFT.Vaulting.Debug.Controller;

public class VaultingDebugToolController
{
	private readonly VaultingDebugToolView _view; //Field offset: 0x10
	private readonly IVaultingModelDebug _vaultingModel; //Field offset: 0x18
	private readonly VaultingController _vaultingController; //Field offset: 0x20
	private PageController _pageController; //Field offset: 0x28

	public VaultingDebugToolController(VaultingDebugToolView view, IVaultingModelDebug vaultingModel, VaultingController vaultingController) { }

	protected virtual void Finalize() { }

	private void InitializeControllers() { }

	private void Subscribe() { }

	private void Unsubscribe() { }

}

