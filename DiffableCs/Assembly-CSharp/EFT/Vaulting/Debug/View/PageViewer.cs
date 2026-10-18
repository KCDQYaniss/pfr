namespace EFT.Vaulting.Debug.View;

public class PageViewer : MonoBehaviour
{
	private const string DEBUG_TOOL_NAME = "VAULTING DEBUG TOOL"; //Field offset: 0x0
	private StartPageView _startPageView; //Field offset: 0x20
	private GridOptionsPageView _gridOptionsPageView; //Field offset: 0x28
	private RestrictionsPageView _heightRestrictionsPageView; //Field offset: 0x30
	private MainInfoPageView _mainInfoPageView; //Field offset: 0x38
	private DiscreteSurfacePageView _discreteSurfacePageView; //Field offset: 0x40
	private AutomaticVaultingPageView _automaticVaultingPageView; //Field offset: 0x48
	private ApproximationPageView _approximationPageView; //Field offset: 0x50
	private IVaultingDebugPageView _currentPage; //Field offset: 0x58

	public IApproximationVaultingPageView ApproximationVaultingPageView
	{
		 get { } //Length: 5
	}

	public IAutomaticVaultingPageView AutomaticVaultingPageView
	{
		 get { } //Length: 5
	}

	public IDiscreteSurfacePageView DiscreteSurfacePageView
	{
		 get { } //Length: 5
	}

	public GridOptionsPageView GridOptionsPageView
	{
		 get { } //Length: 5
	}

	public RestrictionsPageView HeightRestrictionsPageView
	{
		 get { } //Length: 76
	}

	public MainInfoPageView MainInfoPageView
	{
		 get { } //Length: 5
	}

	public StartPageView StartPageView
	{
		 get { } //Length: 5
	}

	public PageViewer() { }

	public IApproximationVaultingPageView get_ApproximationVaultingPageView() { }

	public IAutomaticVaultingPageView get_AutomaticVaultingPageView() { }

	public IDiscreteSurfacePageView get_DiscreteSurfacePageView() { }

	public GridOptionsPageView get_GridOptionsPageView() { }

	public RestrictionsPageView get_HeightRestrictionsPageView() { }

	public MainInfoPageView get_MainInfoPageView() { }

	public StartPageView get_StartPageView() { }

	private GUIStyle GetVaultingHeaderStyle() { }

	private void InitializePages() { }

	private void OnDestroy() { }

	private void OnEnable() { }

	private void OnGUI() { }

	public void SetCurrentPage(IVaultingDebugPageView page) { }

	private void ShowTitle() { }

}

