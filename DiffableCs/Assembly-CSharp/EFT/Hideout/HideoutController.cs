namespace EFT.Hideout;

public sealed class HideoutController : SerializedMonoBehaviour, IHideoutMonoBehaviour, IEventSystemHandler
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass19_0
	{
		public HideoutController <>4__this; //Field offset: 0x10
		public HideoutRepresentation hideout; //Field offset: 0x18

		public <>c__DisplayClass19_0() { }

		internal void <HideoutAwake>b__0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass20_0
	{
		public HideoutController <>4__this; //Field offset: 0x10
		public HideoutRepresentation hideout; //Field offset: 0x18

		public <>c__DisplayClass20_0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass20_1
	{
		public AreaData data; //Field offset: 0x10
		public AreaBehaviour behaviour; //Field offset: 0x18
		public <>c__DisplayClass20_0 CS$<>8__locals1; //Field offset: 0x20

		public <>c__DisplayClass20_1() { }

		internal void <InitHideoutAreas>b__0(bool silent) { }

		internal void <InitHideoutAreas>b__1(bool silent) { }

		internal void <InitHideoutAreas>b__2(bool value) { }

		internal void <InitHideoutAreas>b__3() { }

	}

	private static readonly IReadOnlyCollection _lightingPriority; //Field offset: 0x0
	[FormerlySerializedAs("CustomizationSpawnPointsStorage")]
	[SerializeField]
	private HideoutCustomizationItemsInstaller CustomizationItemsInstaller; //Field offset: 0x60
	[SerializeField]
	private HideoutCameraController _hideoutCameraController; //Field offset: 0x68
	[SerializeField]
	private AmbianceController _ambianceController; //Field offset: 0x70
	[SerializeField]
	private Dictionary _globalLighting; //Field offset: 0x78
	[SerializeField]
	private Dictionary _areas; //Field offset: 0x80
	[SerializeField]
	private HideoutDialogEntryPoint[] _dialogEntryPoints; //Field offset: 0x88
	private HideoutScreenOverlay _hideoutScreenOverlay; //Field offset: 0x90
	private EnergyController _energyController; //Field offset: 0x98
	private HideoutCustomizationController _customizationController; //Field offset: 0xA0
	private CompositeDisposable _unsubs; //Field offset: 0xA8
	private readonly HashSet _availableLightingLevels; //Field offset: 0xB0
	private ELightingLevel _currentLightingLevel; //Field offset: 0xB8
	private bool _lightInitialized; //Field offset: 0xBC

	public Dictionary Areas
	{
		 get { } //Length: 8
	}

	private IEnumerable AvailableLightingLevels
	{
		private get { } //Length: 212
	}

	private static HideoutController() { }

	public HideoutController() { }

	[CompilerGenerated]
	private bool <get_AvailableLightingLevels>b__15_0(ELightingLevel level) { }

	private void AddNewLightingLevel(ELightingLevel level, bool switchToNewLevel) { }

	[UsedImplicitly]
	private void Awake() { }

	private void EnergySupplyChanged(bool value) { }

	public Dictionary get_Areas() { }

	private IEnumerable get_AvailableLightingLevels() { }

	public override void HideoutAwake() { }

	private void HideoutInitedHandler() { }

	private void InitHideoutAreas(HideoutRepresentation hideout) { }

	[UsedImplicitly]
	private void OnDestroy() { }

	private void RefreshLightLevels(HideoutRepresentation hideout, AreaData data) { }

	public void Select(AreaData data, bool wait) { }

	private void SetHighlight(AreaData data, bool value) { }

	private void SetLightLevel(ELightingLevel level) { }

	private void UpdateCameraFlashlight() { }

}

