namespace EFT;

public abstract class GamePlayerOwner : PlayerOwner
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__59_0; //Field offset: 0x8
		public static Func <>9__85_2; //Field offset: 0x10
		public static Func <>9__85_3; //Field offset: 0x18
		public static Func <>9__92_0; //Field offset: 0x20
		public static Func <>9__104_0; //Field offset: 0x28
		public static Func <>9__104_1; //Field offset: 0x30
		public static Func <>9__104_2; //Field offset: 0x38

		private static <>c() { }

		public <>c() { }

		internal Transform <ParentedModelChangeHandler>b__92_0(TacticalComboVisualController x) { }

		internal Item <ReleaseTactical>b__104_0(Slot x) { }

		internal LightsState <ReleaseTactical>b__104_1(LightComponent x) { }

		internal bool <ReleaseTactical>b__104_2(LightsState x) { }

		internal bool <Stop>b__59_0(UIInputNode child) { }

		internal bool <SwitchMagazine>b__85_2(GridItemAddress g) { }

		internal int <SwitchMagazine>b__85_3(GridItemAddress g) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass0_0`1
	{
		public TPlayerOwner owner; //Field offset: 0x0
		public Player player; //Field offset: 0x0

		public <>c__DisplayClass0_0`1() { }

		internal void <Create>b__1() { }

		internal void <Create>g__RemoveItemHandler|0(RemoveItemEventArgs removeItemEventArgs) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass103_0
	{
		public GamePlayerOwner <>4__this; //Field offset: 0x10
		public WishlistManager wishlistManager; //Field offset: 0x18

		public <>c__DisplayClass103_0() { }

		internal void <InitWishlist>b__0() { }

		internal void <InitWishlist>g__OnItemAdded|1(AddItemEventArgs args) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass85_0
	{
		public Item searchItem; //Field offset: 0x10

		public <>c__DisplayClass85_0() { }

		internal GridItemAddress <SwitchMagazine>b__1(Grid grid) { }

	}

	private static EIgnoreInputSource _ignoreInputSource; //Field offset: 0x0
	[CompilerGenerated]
	private static bool <IgnoreInputInNPCDialog>k__BackingField; //Field offset: 0x4
	[CompilerGenerated]
	private static bool <IgnoreInputWithKeepResetLook>k__BackingField; //Field offset: 0x5
	private static Player _myPlayer; //Field offset: 0x8
	[CompilerGenerated]
	private static IHandsInputTranslator <MyHandsInputTranslator>k__BackingField; //Field offset: 0x10
	private Coroutine _dropdownCoroutine; //Field offset: 0xC8
	private bool _quickMumbleAvailable; //Field offset: 0xD0
	protected Location _location; //Field offset: 0xD8
	private BattleUIPanelExtraction _objectivesPanel; //Field offset: 0xE0
	protected ExtractionTimersPanel _timerPanel; //Field offset: 0xE8
	private ConsoleScreen _console; //Field offset: 0xF0
	private IFirearmHandsController _firearmHandsController; //Field offset: 0xF8
	private readonly CompositeDisposable _handsControllerDisposable; //Field offset: 0x100
	private bool _exitScreenVisible; //Field offset: 0x108
	protected InsuranceCompany _insurance; //Field offset: 0x110
	private bool _isBreachingAngle; //Field offset: 0x118
	[CompilerGenerated]
	private IEftSession <Session>k__BackingField; //Field offset: 0x120
	protected IBattleUIScreenController BattleUIScreenController; //Field offset: 0x128
	protected GameDateTime _gameDateTime; //Field offset: 0x130
	private readonly HashSet _wishlistItemsIgnoreNotification; //Field offset: 0x138
	protected HeadLightsValidator _headLightsValidator; //Field offset: 0x140
	[CompilerGenerated]
	private Action OnLeave; //Field offset: 0x148
	public readonly BindableState AvailableInteractionState; //Field offset: 0x150

	public event Action OnLeave
	{
		[CompilerGenerated]
		 add { } //Length: 251
		[CompilerGenerated]
		 remove { } //Length: 251
	}

	public virtual IHandsInputTranslator HandsInputTranslator
	{
		 get { } //Length: 8
		 set { } //Length: 89
	}

	private static bool IgnoreInput
	{
		private get { } //Length: 62
	}

	public private static bool IgnoreInputInNPCDialog
	{
		[CompilerGenerated]
		 get { } //Length: 60
		[CompilerGenerated]
		private set { } //Length: 65
	}

	public private static bool IgnoreInputWithKeepResetLook
	{
		[CompilerGenerated]
		 get { } //Length: 60
		[CompilerGenerated]
		private set { } //Length: 65
	}

	public Location Location
	{
		 get { } //Length: 8
	}

	public private static IHandsInputTranslator MyHandsInputTranslator
	{
		[CompilerGenerated]
		 get { } //Length: 60
		[CompilerGenerated]
		private set { } //Length: 151
	}

	public static Player MyPlayer
	{
		 get { } //Length: 60
	}

	protected private IEftSession Session
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 82
	}

	protected GamePlayerOwner() { }

	[CompilerGenerated]
	private void <MumbleDropdown>b__79_0() { }

	[CompilerGenerated]
	private void <MumbleDropdown>b__79_1(EPhraseTrigger x) { }

	[CompilerGenerated]
	private void <MumbleDropdown>b__79_2() { }

	[CompilerGenerated]
	private int <OnPropVisibilityChanged>b__68_0() { }

	[CompilerGenerated]
	private GridItemAddress <SwitchMagazine>g__GetGridAddress|85_0(Item searchItem) { }

	[CompilerGenerated]
	public void add_OnLeave(Action value) { }

	public static void AddIgnoreInputCommands(IEnumerable commands) { }

	public bool CanSwitchMagazine() { }

	private bool CanTranslateCommand(ECommand command) { }

	public bool CanUseMeds() { }

	protected virtual void CleanupOnDestroy() { }

	public void ClearInteractionState() { }

	protected abstract IEnumerator CloseBattleUi() { }

	public abstract void CloseInventoryIfOpen() { }

	public void CloseMumbleDropdown() { }

	public void CloseObjectivesPanel() { }

	private void CompassStateChanged(bool isActive) { }

	private void ConfigureUIContext() { }

	internal static TPlayerOwner Create(Player player, IInputTree inputTree, InsuranceCompany insurance, IEftSession session, GameUI gameUI, GameDateTime gameDateTime, Location location) { }

	public void DisplayPreloaderUiNotification(string message) { }

	private void DoorBreachMenuHandler() { }

	public virtual IHandsInputTranslator get_HandsInputTranslator() { }

	private static bool get_IgnoreInput() { }

	[CompilerGenerated]
	public static bool get_IgnoreInputInNPCDialog() { }

	[CompilerGenerated]
	public static bool get_IgnoreInputWithKeepResetLook() { }

	public Location get_Location() { }

	[CompilerGenerated]
	public static IHandsInputTranslator get_MyHandsInputTranslator() { }

	public static Player get_MyPlayer() { }

	[CompilerGenerated]
	protected IEftSession get_Session() { }

	public Weapon GetCurrentWeapon() { }

	private void HeadLightsValidator() { }

	protected override void Init() { }

	protected override void InitBattleUIScreen() { }

	private void InitWishlist() { }

	protected override void InteractionsChangedHandler() { }

	private void LateUpdate() { }

	public void MakeBindAction(int index, bool aggressive) { }

	protected virtual void MakeBindActionHandler(int command, bool aggressive) { }

	private void MumbleDropdown(bool value) { }

	protected virtual void MumbleDropdownChangedHandler(bool active) { }

	protected virtual void MumbleStatusChangedHandler(bool active) { }

	private void OnApplicationFocus(bool hasFocus) { }

	private void OnApplicationQuit() { }

	protected void OnLeaveHandler() { }

	private void OnOnPhraseToldHandler(EPhraseTrigger trigger, TaggedClip match, TagBank bank, BaseSpeaker baseSpeaker) { }

	private void OnOnShowFireMode(EFireMode fireMode) { }

	private void OnPropVisibilityChanged(bool isVisible) { }

	private void OnShowAmmoCountZeroingPanel(string message) { }

	private void ParentedModelChangeHandler(GameObject model) { }

	private void PlayerOnOnShowAmmoDetails(int ammoCount, int maxAmmoCount, int mastering, string details, bool foldingMechanimWeapon) { }

	public void PlayPhraseOrGesture(int actionId, bool aggressive) { }

	protected virtual void QuickMumbleHandler() { }

	public void QuickMumbleStart() { }

	protected void ReleaseTactical() { }

	[CompilerGenerated]
	public void remove_OnLeave(Action value) { }

	public static void RemoveIgnoreInputCommands(IEnumerable commands) { }

	protected virtual void ResetHands() { }

	internal virtual void Run() { }

	public virtual void set_HandsInputTranslator(IHandsInputTranslator value) { }

	[CompilerGenerated]
	private static void set_IgnoreInputInNPCDialog(bool value) { }

	[CompilerGenerated]
	private static void set_IgnoreInputWithKeepResetLook(bool value) { }

	[CompilerGenerated]
	private static void set_MyHandsInputTranslator(IHandsInputTranslator value) { }

	[CompilerGenerated]
	private void set_Session(IEftSession value) { }

	protected virtual void SetHandsController(IKnifeController knifeController) { }

	protected virtual void SetHandsController(IEmptyHandsController controller) { }

	protected virtual void SetHandsController(IFirearmHandsController controller) { }

	protected virtual void SetHandsController(IGrenadeController grenadeController) { }

	public static void SetIgnoreInput(bool ignore, EIgnoreInputSource source) { }

	public static void SetIgnoreInput(bool ignore) { }

	public static void SetIgnoreInputInNPCDialog(bool ignore) { }

	public static void SetIgnoreInputWithKeepResetLook(bool ignore) { }

	protected override void ShowBattleUIScreen() { }

	public override void ShowInventoryScreenLoot(CompoundItem loot, Action callback, bool isFakeContainer = false) { }

	public void ShowObjectivesPanel(string textKey, float time) { }

	internal virtual void Stop() { }

	public void SwitchMagazine(Weapon weapon, Item item) { }

	public void ToggleMumbleDropdown() { }

	protected virtual void TranslateAxes(ref float[] axes) { }

	protected virtual ETranslateResult TranslateCommand(ECommand command) { }

	protected override bool TranslateExitScreenInput(ECommand command) { }

	protected override bool TranslateInventoryScreenInput(ECommand command) { }

}

