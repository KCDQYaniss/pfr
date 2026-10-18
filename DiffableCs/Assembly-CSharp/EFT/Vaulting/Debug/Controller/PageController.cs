namespace EFT.Vaulting.Debug.Controller;

public class PageController
{
	private readonly PageViewer _pageViewer; //Field offset: 0x10
	private readonly IVaultingModelDebug _vaultingModel; //Field offset: 0x18
	private readonly VaultingController _vaultingController; //Field offset: 0x20
	private StartPageController _startPageController; //Field offset: 0x28
	private GridOptionsPageController _gridOptionsController; //Field offset: 0x30
	private VaultingRestrictionsPageController _heightRestrictionsController; //Field offset: 0x38
	private MainInfoPageController _mainInfoPageController; //Field offset: 0x40
	private DiscreteSurfacePageController _discreteSurfacePageController; //Field offset: 0x48
	private AutomaticVaultingPageController _automaticVaultingPageController; //Field offset: 0x50
	private ApproximationPageController _approximationVaultingPageController; //Field offset: 0x58

	public PageController(PageViewer pageView, IVaultingModelDebug model, VaultingController controller) { }

	protected virtual void Finalize() { }

	private void InitializePageControllers() { }

	private void Subscribe() { }

	private void Unsubscribe() { }

}

