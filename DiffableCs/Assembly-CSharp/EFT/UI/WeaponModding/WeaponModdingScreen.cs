namespace EFT.UI.WeaponModding;

public sealed class WeaponModdingScreen : ItemObserveScreen
{
	internal sealed class WeaponModdingScreenController : EftScreenController
	{
		public readonly Item Item; //Field offset: 0x58
		public readonly InventoryController InventoryController; //Field offset: 0x60
		public readonly CompoundItem[] Collections; //Field offset: 0x68

		protected virtual EStateSwitcher EnvironmentOverlay
		{
			 get { } //Length: 6
		}

		public virtual EEftScreenType ScreenType
		{
			 get { } //Length: 6
		}

		public WeaponModdingScreenController(Item item, InventoryController inventoryController, CompoundItem[] collections) { }

		protected virtual EStateSwitcher get_EnvironmentOverlay() { }

		public virtual EEftScreenType get_ScreenType() { }

	}

	[SerializeField]
	private TextMeshProUGUI _headerLabel; //Field offset: 0x180
	[SerializeField]
	private Toggle _allClassesToggle; //Field offset: 0x188
	[SerializeField]
	private GameObject _warningPanel; //Field offset: 0x190
	[SerializeField]
	private LocalizedText _warningLabel; //Field offset: 0x198
	private CompoundItem[] _collections; //Field offset: 0x1A0

	public WeaponModdingScreen() { }

	[CompilerGenerated]
	private void <Awake>b__6_0(bool x) { }

	protected virtual void Awake() { }

	protected virtual void CheckForVitalParts() { }

	protected virtual DropdownManipulation CreateBuildManipulation() { }

	public virtual void Show(WeaponModdingScreenController controller) { }

	private void Show(Item item, InventoryController inventoryController, CompoundItem[] collections) { }

	protected virtual void ToggleChangedHandler() { }

	protected virtual ETranslateResult TranslateCommand(ECommand command) { }

}

