namespace UI.Hideout;

public sealed class HideoutCustomizationScreen : UIScreen
{
	private sealed class TabController : SimpleTabController
	{
		private readonly HideoutCustomizationScreen _screen; //Field offset: 0x10
		private readonly EHideoutCustomizationType _customizationType; //Field offset: 0x18

		public TabController(HideoutCustomizationScreen screen, EHideoutCustomizationType customizationType) { }

		public virtual void Show() { }

	}

	private const string STARTUP_POINT_NAME = "Wall"; //Field offset: 0x0
	[SerializeField]
	private Tab _wallButton; //Field offset: 0x90
	[SerializeField]
	private Tab _floorButton; //Field offset: 0x98
	[SerializeField]
	private Tab _ceilingButton; //Field offset: 0xA0
	[SerializeField]
	private Tab _lightButton; //Field offset: 0xA8
	[SerializeField]
	private Tab _shootingRangeTargetsButton; //Field offset: 0xB0
	[SerializeField]
	private Tab _postersButton; //Field offset: 0xB8
	[SerializeField]
	private Tab _itemsButton; //Field offset: 0xC0
	[SerializeField]
	private Button _closeButton; //Field offset: 0xC8
	[SerializeField]
	private HideoutCustomizationOptionsWithSlotsPanel _optionWithSlotsPanel; //Field offset: 0xD0
	[SerializeField]
	private HideoutCustomizationSimpleOptionsPanel _simpleOptionPanel; //Field offset: 0xD8
	private HideoutCustomizationController _customizationController; //Field offset: 0xE0
	private HideoutCustomizationItemModelSpawnPoint _currentChosenObject; //Field offset: 0xE8
	private TabGroup _tabs; //Field offset: 0xF0
	private Action _closeAction; //Field offset: 0xF8

	public HideoutCustomizationScreen() { }

	private void ChooseObject(HideoutCustomizationItemModelSpawnPoint customizationItemModelSpawnPoint) { }

	public virtual void Close() { }

	private void CreateTabGroup() { }

	public void Init(HideoutCustomizationController customizationController) { }

	private void OnCellClickHandler(HideoutCustomizationOffer offer) { }

	public void Show(Action closeAction = null) { }

	private void ShowCustomizationContentPanel(EHideoutCustomizationType customizationType) { }

	protected virtual ETranslateResult TranslateCommand(ECommand command) { }

}

