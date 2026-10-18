namespace EFT;

public abstract class ClientTransitController : TransitController
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Action <>9__31_1; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal void <EnsureConfirmed>b__31_1() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass16_0
	{
		public ClientTransitController <>4__this; //Field offset: 0x10
		public Player player; //Field offset: 0x18

		public <>c__DisplayClass16_0() { }

		internal void <.ctor>b__0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass31_0
	{
		public TransitPoint point; //Field offset: 0x10
		public Player player; //Field offset: 0x18
		public Action onConfirmed; //Field offset: 0x20

		public <>c__DisplayClass31_0() { }

		internal void <EnsureConfirmed>b__0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass32_0
	{
		public ClientTransitController <>4__this; //Field offset: 0x10
		public Player player; //Field offset: 0x18
		public int pointId; //Field offset: 0x20
		public string keyId; //Field offset: 0x28
		public EDateTime time; //Field offset: 0x30

		public <>c__DisplayClass32_0() { }

		internal void <ShowInteraction>b__0() { }

		internal void <ShowInteraction>b__1() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass38_0
	{
		public GameUI gameUI; //Field offset: 0x10
		public Player player; //Field offset: 0x18
		public ClientTransitController <>4__this; //Field offset: 0x20
		public int pointId; //Field offset: 0x28
		public string keyId; //Field offset: 0x30
		public EDateTime time; //Field offset: 0x38
		public Action <>9__1; //Field offset: 0x40

		public <>c__DisplayClass38_0() { }

		internal void <InteractionAction>b__0(bool successful) { }

		internal void <InteractionAction>b__1() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass39_0
	{
		public Player player; //Field offset: 0x10
		public ClientTransitController <>4__this; //Field offset: 0x18
		public int pointId; //Field offset: 0x20
		public string keyId; //Field offset: 0x28
		public EDateTime time; //Field offset: 0x30

		public <>c__DisplayClass39_0() { }

		internal void <OpenTransferItemsScreen>b__0() { }

	}

	private const string LONG_TAP_TO_INTERACT = "Transit/LONG_TAP_TO_INTERACT"; //Field offset: 0x0
	private const string ACCESS_NOT_GRANTED = "Transit/AccessNotGranted"; //Field offset: 0x0
	private const string OVER_GROUP_SIZE = "Transit/OverGroupSize"; //Field offset: 0x0
	private const string INACTIVE_POINT = "Transit/InactivePoint"; //Field offset: 0x0
	private const string INTERACTION = "Transit/Interaction"; //Field offset: 0x0
	private const float LONG_PRESS_EXFIL_SECONDS = 2; //Field offset: 0x0
	protected CompositeDisposable _disposables; //Field offset: 0x80
	protected HashSet _waitForVisibleTransitPoints; //Field offset: 0x88
	protected List _buffer; //Field offset: 0x90
	private AvailableInteractionState _availableInteractionState; //Field offset: 0x98
	private SingletonMessageNotification _transitInteractionNotification; //Field offset: 0xA0
	private Player _interactionPlayer; //Field offset: 0xA8
	[CompilerGenerated]
	private AvailableInteractionState <AvailableInteractionState>k__BackingField; //Field offset: 0xB0

	public private AvailableInteractionState AvailableInteractionState
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 82
	}

	protected ClientTransitController(TransitGlobalSettings settings, TransitParameters[] parameters) { }

	public virtual void AccessNotGranted(Player player, IEnumerable reasons) { }

	protected void AccessNotGrantedNotification() { }

	protected void Cancel(Player player) { }

	protected virtual bool DisableExits(Player player) { }

	public virtual void Dispose() { }

	protected virtual bool EnableExits(Player player) { }

	protected void EnsureConfirmed(TransitPoint point, Player player, Action onConfirmed) { }

	[CompilerGenerated]
	public AvailableInteractionState get_AvailableInteractionState() { }

	protected EDateTime GetSelectedTime() { }

	protected override bool HasMetCompletedQuestRequirement(TransitPoint transitPoint, Player player) { }

	private static bool HasMetEntryRequirements(TransitPoint transitPoint, Player player) { }

	protected void HideTransitInteractionNotification() { }

	public virtual void InactivePointNotification(int playerId, int pointId) { }

	private void InteractionAction(Player player, int pointId, string keyId, EDateTime time) { }

	protected bool IsVisibleTransitPoint(TransitPoint transitPoint) { }

	private void OnItemAdded(AddItemEventArgs addItemEventArgs) { }

	private void OnPlayerDead(Player player, IPlayer lastAggressor, DamageInfo damageInfo, EBodyPart part) { }

	private void OpenTransferItemsScreen(Player player, int pointId, string keyId, EDateTime time) { }

	public virtual void OverGroupSize(Player player, TransitPoint transitPoint) { }

	protected bool ProtectedLocation(int pointId, out IReadOnlyDictionary accessKeyCount) { }

	[CompilerGenerated]
	private void set_AvailableInteractionState(AvailableInteractionState value) { }

	protected void SetTimers(ICollection activePoints, Player player, bool eventOnly = false) { }

	protected void ShowInteraction(int pointId, Player player, EDateTime time) { }

	protected void ShowPanel(int pointId) { }

	private void SubscribePlayerDeath(Player player) { }

	protected bool TryGetAccessToLocation(Player player, int pointId, out string keyId) { }

	private bool TryGetLocation(string locationId, out Location location) { }

	private void UnsubscribePlayerDeath() { }

}

