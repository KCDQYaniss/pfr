namespace EFT;

public class PlayerOwner : InputNode, IPlayerOwner
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Callback <>9__34_0; //Field offset: 0x8
		public static Callback <>9__57_0; //Field offset: 0x10
		public static Callback <>9__57_1; //Field offset: 0x18

		private static <>c() { }

		public <>c() { }

		internal void <Run>b__34_0(Result result) { }

		internal void <ValidateOnUsedCallback>b__57_0(Result result) { }

		internal void <ValidateOnUsedCallback>b__57_1(Result result) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass37_0
	{
		public IPlayerInputTranslator playerInputTranslator; //Field offset: 0x10
		public PlayerOwner <>4__this; //Field offset: 0x18

		public <>c__DisplayClass37_0() { }

		internal void <CreateInputTranslators>b__0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass46_0
	{
		public PlayerOwner <>4__this; //Field offset: 0x10
		public Item previousItem; //Field offset: 0x18
		public IQuickUseItem quickUseController; //Field offset: 0x20

		public <>c__DisplayClass46_0() { }

		internal void <SetHandsController>b__0(Result resultController) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass48_0
	{
		public PlayerOwner <>4__this; //Field offset: 0x10
		public Item previousItem; //Field offset: 0x18
		public IGrenadeController grenadeController; //Field offset: 0x20

		public <>c__DisplayClass48_0() { }

		internal void <SetHandsController>b__0(Result resultController) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass53_0
	{
		public PlayerOwner <>4__this; //Field offset: 0x10
		public Item previousItem; //Field offset: 0x18
		public IMedsController medsController; //Field offset: 0x20

		public <>c__DisplayClass53_0() { }

		internal void <SetHandsController>b__0(Result resultController) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass54_0
	{
		public PlayerOwner <>4__this; //Field offset: 0x10
		public Item previousItem; //Field offset: 0x18
		public IRecorderController recorderController; //Field offset: 0x20

		public <>c__DisplayClass54_0() { }

		internal void <SetHandsController>b__0(Result resultController) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass55_0
	{
		public PlayerOwner <>4__this; //Field offset: 0x10
		public Item previousItem; //Field offset: 0x18
		public IQuickGrenadeThrowController grenadeQuickUseController; //Field offset: 0x20

		public <>c__DisplayClass55_0() { }

		internal void <SetHandsController>b__0(Result resultController) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass56_0
	{
		public PlayerOwner <>4__this; //Field offset: 0x10
		public Item previousItem; //Field offset: 0x18
		public IQuickKnifeKickController quickKnifeKickController; //Field offset: 0x20

		public <>c__DisplayClass56_0() { }

		internal void <SetHandsController>b__0(Result resultController) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass60_0
	{
		public WorldInteractiveObject worldInteractiveObject; //Field offset: 0x10

		public <>c__DisplayClass60_0() { }

		internal bool <GetKey>b__0(KeyComponent x) { }

	}

	internal enum EState
	{
		None = 0,
		Started = 1,
		Stopped = 2,
	}

	private static readonly WaitForSeconds _waitForThreeSeconds; //Field offset: 0x0
	protected static readonly HashSet ignoredCommands; //Field offset: 0x8
	protected readonly CompositeDisposable OnDestroyCompositeDisposable; //Field offset: 0x70
	[CompilerGenerated]
	private EState <State>k__BackingField; //Field offset: 0x78
	private MoveInputTranslator _moveInputTranslator; //Field offset: 0x80
	[CompilerGenerated]
	private IPlayerInputTranslator <PlayerInputTranslator>k__BackingField; //Field offset: 0x88
	[CompilerGenerated]
	private IHandsInputTranslator <HandsInputTranslator>k__BackingField; //Field offset: 0x90
	[CompilerGenerated]
	private Player <Player>k__BackingField; //Field offset: 0x98
	[CompilerGenerated]
	private IInputTree <InputTree>k__BackingField; //Field offset: 0xA0
	[CanBeNull]
	public Item PreviousItem; //Field offset: 0xA8
	private Coroutine _moveCoroutine; //Field offset: 0xB0
	private Action _invertXBinding; //Field offset: 0xB8
	private Action _invertYBinding; //Field offset: 0xC0

	public override IHandsInputTranslator HandsInputTranslator
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 82
	}

	public private IInputTree InputTree
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public private Player Player
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public override IPlayerInputTranslator PlayerInputTranslator
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 82
	}

	protected override bool SetItemInHandsImmediately
	{
		 get { } //Length: 3
	}

	public private EState State
	{
		[CompilerGenerated]
		 get { } //Length: 4
		[CompilerGenerated]
		private set { } //Length: 4
	}

	private static PlayerOwner() { }

	public PlayerOwner() { }

	[CompilerGenerated]
	private void <Run>b__34_1(bool x) { }

	[CompilerGenerated]
	private void <Run>b__34_2(bool y) { }

	protected override void CleanupOnDestroy() { }

	internal static T Create(Player player, IInputTree inputTree) { }

	protected override void CreateInputTranslators() { }

	[CompilerGenerated]
	public override IHandsInputTranslator get_HandsInputTranslator() { }

	[CompilerGenerated]
	public IInputTree get_InputTree() { }

	[CompilerGenerated]
	public Player get_Player() { }

	[CompilerGenerated]
	public override IPlayerInputTranslator get_PlayerInputTranslator() { }

	protected override bool get_SetItemInHandsImmediately() { }

	[CompilerGenerated]
	public EState get_State() { }

	public IEnumerable GetAllKeyCards() { }

	[CanBeNull]
	public KeyComponent GetKey(WorldInteractiveObject worldInteractiveObject) { }

	protected override IHandsInputTranslator GrenadeInputTranslatorFactory(IGrenadeController grenadeController) { }

	protected override void MakeBindActionHandler(int command, bool aggressive) { }

	protected override void MumbleDropdownChangedHandler(bool active) { }

	protected override void MumbleStatusChangedHandler(bool active) { }

	public void Mute(bool muted) { }

	private void OnDestroy() { }

	protected override IPlayerInputTranslator PlayerInputTranslatorFactory(Player player) { }

	protected override void QuickMumbleHandler() { }

	private void RefreshHandsController(IHandsController controller) { }

	protected override void ResetHands() { }

	internal override void Run() { }

	[CompilerGenerated]
	public override void set_HandsInputTranslator(IHandsInputTranslator value) { }

	[CompilerGenerated]
	private void set_InputTree(IInputTree value) { }

	[CompilerGenerated]
	private void set_Player(Player value) { }

	[CompilerGenerated]
	public override void set_PlayerInputTranslator(IPlayerInputTranslator value) { }

	[CompilerGenerated]
	private void set_State(EState value) { }

	protected override void SetHandsController(IQuickGrenadeThrowController grenadeQuickUseController) { }

	protected override void SetHandsController(IQuickKnifeKickController quickKnifeKickController) { }

	protected override void SetHandsController(IRecorderController recorderController) { }

	private void SetHandsController(IQuickUseItem quickUseController) { }

	protected override void SetHandsController(IEmptyHandsController controller) { }

	protected override void SetHandsController(IKnifeController knifeController) { }

	protected override void SetHandsController(IUsableItemController usableItemController) { }

	protected override void SetHandsController(IGrenadeController grenadeController) { }

	protected override void SetHandsController(IFirearmHandsController controller) { }

	protected override void SetHandsController(IMedsController medsController) { }

	protected virtual ECursorResult ShouldLockCursor() { }

	internal override void Stop() { }

	protected virtual void TranslateAxes(ref float[] axes) { }

	protected virtual ETranslateResult TranslateCommand(ECommand command) { }

	private static bool TranslatePlayerInput(ECommand command) { }

	private void ValidateOnUsedCallback(Item previousItem, object controller) { }

}

