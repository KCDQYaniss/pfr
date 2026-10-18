namespace EFT;

public class LocalPlayer : Player
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Action <>9__0_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal void <Create>b__0_0() { }

	}

	[CompilerGenerated]
	private struct <Create>d__0 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public Profile profile; //Field offset: 0x20
		public GameWorld gameWorld; //Field offset: 0x28
		public int playerId; //Field offset: 0x30
		public Vector3 position; //Field offset: 0x34
		public EUpdateQueue updateQueue; //Field offset: 0x40
		public EUpdateMode armsUpdateMode; //Field offset: 0x44
		public EUpdateMode bodyUpdateMode; //Field offset: 0x48
		public Mode characterControllerMode; //Field offset: 0x50
		public Func getSensitivity; //Field offset: 0x58
		public Func getAimingSensitivity; //Field offset: 0x60
		public string prefix; //Field offset: 0x68
		public bool aiControl; //Field offset: 0x70
		public bool isYourPlayer; //Field offset: 0x71
		public ELocalMode localMode; //Field offset: 0x74
		public bool isBot; //Field offset: 0x78
		public IEftSession session; //Field offset: 0x80
		public Quaternion rotation; //Field offset: 0x88
		public string layerName; //Field offset: 0x98
		public EPointOfView pointOfView; //Field offset: 0xA0
		public IStatisticsManager statisticsManager; //Field offset: 0xA8
		public ICustomizationFilter filter; //Field offset: 0xB0
		private LocalPlayer <player>5__2; //Field offset: 0xB8
		private SinglePlayerInventoryController <inventoryController>5__3; //Field offset: 0xC0
		private QuestLocationObjectsController <questLocationObjectsController>5__4; //Field offset: 0xC8
		private TaskAwaiter <>u__1; //Field offset: 0xD0

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private sealed class <GetAvailableTraderServices>d__34 : IEnumerable, IEnumerable, IEnumerator, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private TraderServiceAvailabilityData <>2__current; //Field offset: 0x18
		private int <>l__initialThreadId; //Field offset: 0x20
		private string traderId; //Field offset: 0x28
		public string <>3__traderId; //Field offset: 0x30
		public LocalPlayer <>4__this; //Field offset: 0x38
		private IEnumerator <>7__wrap1; //Field offset: 0x40

		private override TraderServiceAvailabilityData System.Collections.Generic.IEnumerator<EFT.TraderServiceAvailabilityData>.Current
		{
			[DebuggerHidden]
			private get { } //Length: 5
		}

		private override object System.Collections.IEnumerator.Current
		{
			[DebuggerHidden]
			private get { } //Length: 5
		}

		[DebuggerHidden]
		public <GetAvailableTraderServices>d__34(int <>1__state) { }

		private void <>m__Finally1() { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override IEnumerator System.Collections.Generic.IEnumerable<EFT.TraderServiceAvailabilityData>.GetEnumerator() { }

		[DebuggerHidden]
		private override TraderServiceAvailabilityData System.Collections.Generic.IEnumerator<EFT.TraderServiceAvailabilityData>.get_Current() { }

		[DebuggerHidden]
		private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

		[DebuggerHidden]
		private override object System.Collections.IEnumerator.get_Current() { }

		[DebuggerHidden]
		private override void System.Collections.IEnumerator.Reset() { }

		[DebuggerHidden]
		private override void System.IDisposable.Dispose() { }

	}

	[CompilerGenerated]
	private struct <OnGameSessionEnd>d__19 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public LocalPlayer <>4__this; //Field offset: 0x20
		public ExitStatus exitStatus; //Field offset: 0x28
		public float pastTime; //Field offset: 0x2C
		public string locationId; //Field offset: 0x30
		public string exitName; //Field offset: 0x38
		private TaskAwaiter <>u__1; //Field offset: 0x40

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <UpdateBtrTraderServiceData>d__35 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public LocalPlayer <>4__this; //Field offset: 0x20
		private List <traderServices>5__2; //Field offset: 0x28
		private TaskAwaiter <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <UpdateTradersServiceData>d__36 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public LocalPlayer <>4__this; //Field offset: 0x20
		public string traderID; //Field offset: 0x28
		private List <traderServices>5__2; //Field offset: 0x30
		private YieldAwaiter <>u__1; //Field offset: 0x38

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private PlayerHealthController <PlayerHealthController>k__BackingField; //Field offset: 0xC88
	private readonly HashSet _notYetPurchasedTraderServiceTypes; //Field offset: 0xC90
	private OfflinePlayerCulling botPlayerCulling; //Field offset: 0xC98
	private bool _wasInvincibleBefore; //Field offset: 0xCA0
	private bool _damageIgnored; //Field offset: 0xCA1
	private TraderInfo _keeperTraderInfo; //Field offset: 0xCA8
	private SinglePlayerInventoryController _singlePlayerInventoryController; //Field offset: 0xCB0
	private ELocalMode _playerInMode; //Field offset: 0xCB8
	private bool _sessionExpUiSubscribed; //Field offset: 0xCBC

	public PlayerHealthController PlayerHealthController
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 82
	}

	public LocalPlayer() { }

	[CompilerGenerated]
	[DebuggerHidden]
	private Task <>n__0(ExitStatus exitStatus, float pastTime, string locationId, string exitName) { }

	internal virtual void BtrInteraction(BTRSide btr, byte placeId, EInteractionType interaction) { }

	[AsyncStateMachine(typeof(<Create>d__0))]
	public static Task Create(GameWorld gameWorld, int playerId, Vector3 position, Quaternion rotation, string layerName, string prefix, EPointOfView pointOfView, Profile profile, bool aiControl, EUpdateQueue updateQueue, EUpdateMode armsUpdateMode, EUpdateMode bodyUpdateMode, Mode characterControllerMode, Func getSensitivity, Func getAimingSensitivity, IStatisticsManager statisticsManager, ICustomizationFilter filter, IEftSession session, ELocalMode localMode, bool isYourPlayer, bool isBot) { }

	public virtual void Dispose() { }

	internal virtual void EventObjectInteraction(EventObjectController controller, int objectId, EInteraction interaction) { }

	private DeathPacket FormatDeathPacket() { }

	[CompilerGenerated]
	public PlayerHealthController get_PlayerHealthController() { }

	[IteratorStateMachine(typeof(<GetAvailableTraderServices>d__34))]
	public IEnumerable GetAvailableTraderServices(string traderId) { }

	public void Hide() { }

	public void IgnoreDamage(bool flag) { }

	public virtual bool IsNonTrainingPlayer() { }

	protected virtual void ManageAggressor(DamageInfo damageInfo, EBodyPart bodyPart, EBodyPartColliderType colliderType) { }

	public virtual void ManualUpdate(float deltaTime, Nullable platformDeltaTime = null, int loop = 1) { }

	protected virtual void OnBeenKilledByAggressor(IPlayer aggressor, DamageInfo damageInfo, EBodyPart bodyPart, EDamageType lethalDamageType) { }

	protected virtual void OnDead(EDamageType damageType) { }

	[AsyncStateMachine(typeof(<OnGameSessionEnd>d__19))]
	public virtual Task OnGameSessionEnd(ExitStatus exitStatus, float pastTime, string locationId, string exitName) { }

	private void OnSessionExpCounterChanged(Identifier identifier) { }

	protected virtual void OnSkillLevelChanged(BaseSkill skill) { }

	protected virtual void OnWeaponMastered(Mastering masterSkill) { }

	public virtual void PauseAllEffectsOnPlayer() { }

	protected virtual void Proceed(FoodDrink foodDrink, float amount, Callback callback, int animationVariant, bool scheduled = true) { }

	protected virtual void Proceed(Meds meds, OneAndList bodyParts, Callback callback, int animationVariant, bool scheduled = true) { }

	protected virtual void Proceed(RecorderItem recorder, Callback callback, bool scheduled = true) { }

	protected virtual void Proceed(KnifeComponent knife, Callback callback, bool scheduled = true) { }

	protected virtual void Proceed(Item item, Callback callback, bool scheduled = true) { }

	protected virtual void Proceed(ThrowWeap throwWeap, Callback callback, bool scheduled = true) { }

	protected virtual void Proceed(Weapon weapon, Callback callback, bool scheduled = true) { }

	protected virtual void Proceed(ThrowWeap throwWeap, Callback callback, bool scheduled = true) { }

	protected virtual void Proceed(KnifeComponent knife, Callback callback, bool scheduled = true) { }

	protected virtual void Proceed(bool withNetwork, Callback callback, bool scheduled = true) { }

	protected virtual void ProceedLocalAbsorbedDamage(ref DamageInfo damageInfo, float absorbedDamage) { }

	public void ProcessTraderServicePurchase(ETraderServiceType serviceType) { }

	private void RefreshExitTriggerRunnerVisual() { }

	[CompilerGenerated]
	protected void set_PlayerHealthController(PlayerHealthController value) { }

	public virtual void SetExfiltrationPoint(ExfiltrationPoint point, bool entered) { }

	public void SetTraderServiceAvailability(ETraderServiceType serviceType, bool available) { }

	public void SetWeaponRoot(Transform targetTransform) { }

	public void ToggleTriggerColliderSearcher(bool toggle) { }

	protected virtual void TraderStandingHandler(TraderInfo traderInfo) { }

	internal virtual void TransitInteraction(TransitController controller, int transitPointId, string keyId, EDateTime time) { }

	internal virtual void TripwireInteraction(TripwireSynchronizableObject tripwire) { }

	private void TryDestroyCultistAmuletOnStandingChange() { }

	private void TryDestroyCultistAmuletOnTransmitterStatusChange(RadioTransmitterStatus status) { }

	public virtual void UnpauseAllEffectsOnPlayer() { }

	private void UnsubscribeSessionExpUi() { }

	[AsyncStateMachine(typeof(<UpdateBtrTraderServiceData>d__35))]
	public Task UpdateBtrTraderServiceData() { }

	private void UpdateTraderServiceData(IEnumerable traderServices) { }

	[AsyncStateMachine(typeof(<UpdateTradersServiceData>d__36))]
	public Task UpdateTradersServiceData(string traderID) { }

}

