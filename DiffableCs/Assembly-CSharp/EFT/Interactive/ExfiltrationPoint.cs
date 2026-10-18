namespace EFT.Interactive;

public class ExfiltrationPoint : MonoBehaviour, IPhysicsTrigger, IInteractive
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass53_0
	{
		public string profileId; //Field offset: 0x10

		public <>c__DisplayClass53_0() { }

		internal string <GetTips>b__0(ExfiltrationRequirement x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass64_0
	{
		public int playerId; //Field offset: 0x10

		public <>c__DisplayClass64_0() { }

		internal bool <OnItemTransferred>b__0(IPlayer x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass74_0
	{
		public Player player; //Field offset: 0x10
		public ExfiltrationPoint <>4__this; //Field offset: 0x18

		public <>c__DisplayClass74_0() { }

		internal bool <UnmetRequirements>b__0(ExfiltrationRequirement x) { }

	}

	[CompilerGenerated]
	private MongoID <Id>k__BackingField; //Field offset: 0x20
	public Collider ExtendedCollider; //Field offset: 0x38
	public Switch Switch; //Field offset: 0x40
	private string _currentTip; //Field offset: 0x48
	protected readonly List _playersMetAllRequirements; //Field offset: 0x50
	[SerializeField]
	private EExfiltrationStatus _status; //Field offset: 0x58
	[CompilerGenerated]
	private readonly string <Description>k__BackingField; //Field offset: 0x60
	[CompilerGenerated]
	private float <FenceRep>k__BackingField; //Field offset: 0x68
	[CompilerGenerated]
	private int <CharismaLevel>k__BackingField; //Field offset: 0x6C
	public float ExfiltrationStartTime; //Field offset: 0x70
	[CompilerGenerated]
	private Action OnStatusChanged; //Field offset: 0x78
	[CompilerGenerated]
	private Action OnStatusChangedForPlaybleObject; //Field offset: 0x80
	[SerializeField]
	private GameObject _root; //Field offset: 0x88
	public readonly List QueuedPlayers; //Field offset: 0x90
	public ExitTriggerSettings Settings; //Field offset: 0x98
	public ExfiltrationRequirement[] Requirements; //Field offset: 0xA0
	public Action OnStartExtraction; //Field offset: 0xA8
	public Action OnCancelExtraction; //Field offset: 0xB0
	public readonly BindableList Entered; //Field offset: 0xB8
	public string[] EligibleEntryPoints; //Field offset: 0xC0
	public bool Reusable; //Field offset: 0xC8
	[SerializeField]
	private bool _strictExfiltrationPrice; //Field offset: 0xC9
	private BoxCollider _collider; //Field offset: 0xD0
	private Coroutine _maxTimeCoroutine; //Field offset: 0xD8
	private Coroutine _minTimeCoroutine; //Field offset: 0xE0
	private List _switches; //Field offset: 0xE8
	protected bool _authorityToChangeStatusExternally; //Field offset: 0xF0

	public event Action OnStatusChanged
	{
		[CompilerGenerated]
		 add { } //Length: 262
		[CompilerGenerated]
		 remove { } //Length: 262
	}

	public event Action OnStatusChangedForPlaybleObject
	{
		[CompilerGenerated]
		 add { } //Length: 278
		[CompilerGenerated]
		 remove { } //Length: 278
	}

	public int CharismaLevel
	{
		[CompilerGenerated]
		 get { } //Length: 4
		[CompilerGenerated]
		 set { } //Length: 4
	}

	public override string Description
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public float FenceRep
	{
		[CompilerGenerated]
		 get { } //Length: 6
		[CompilerGenerated]
		 set { } //Length: 6
	}

	public bool HasRequirements
	{
		 get { } //Length: 66
	}

	public MongoID Id
	{
		[CompilerGenerated]
		 get { } //Length: 21
		[CompilerGenerated]
		 set { } //Length: 98
	}

	public override EExfiltrationStatus Status
	{
		 get { } //Length: 5
		 set { } //Length: 1775
	}

	public bool StrictExfiltrationPrice
	{
		 get { } //Length: 8
	}

	public TransferItemRequirement TransferItemRequirement
	{
		 get { } //Length: 98
	}

	public ExfiltrationPoint() { }

	[CompilerGenerated]
	private ExfiltrationRequirement <LoadSettings>b__56_0(ExfiltrationRequirement x) { }

	[CompilerGenerated]
	public void add_OnStatusChanged(Action value) { }

	[CompilerGenerated]
	public void add_OnStatusChangedForPlaybleObject(Action value) { }

	private void Awake() { }

	private void ChainStateChanged(WorldInteractiveObject arg1, EDoorState arg2, EDoorState arg3) { }

	protected void ChainSubscribe() { }

	private void ChainUnsubscribe() { }

	public void CooperationPlayerDied(Player player, IPlayer lastAgressor, DamageInfo damage, EBodyPart part) { }

	public void Disable() { }

	public void Disable(EExfiltrationStatus prevStatus) { }

	private void DisableAllSwitches() { }

	public void DisableInteraction() { }

	public void Enable() { }

	public void EnableInteraction() { }

	public void ExternalSetStatus(EExfiltrationStatus targetStatus, string signature = "") { }

	[CompilerGenerated]
	public int get_CharismaLevel() { }

	[CompilerGenerated]
	public override string get_Description() { }

	[CompilerGenerated]
	public float get_FenceRep() { }

	public bool get_HasRequirements() { }

	[CompilerGenerated]
	public MongoID get_Id() { }

	public override EExfiltrationStatus get_Status() { }

	public bool get_StrictExfiltrationPrice() { }

	public TransferItemRequirement get_TransferItemRequirement() { }

	public float GetRemainingExfiltrationTime(float pastTime) { }

	public string[] GetTips(string profileId) { }

	public bool HasMetRequirements(string profileId) { }

	public override bool InfiltrationMatch(Player player) { }

	private override bool IPhysicsTrigger.get_enabled() { }

	private override void IPhysicsTrigger.OnTriggerEnter(Collider col) { }

	private override void IPhysicsTrigger.OnTriggerExit(Collider col) { }

	private override void IPhysicsTrigger.set_enabled(bool value) { }

	public override void LoadSettings(MongoID exfilId, BackendExitTriggerSettings settings, bool authority) { }

	private void OnDestroy() { }

	public override void OnItemTransferred(IPlayer player) { }

	public void OnItemTransferred(int playerId) { }

	protected void OnPlayerEnter(Player obj) { }

	protected void OnPlayerExit(Player obj) { }

	public override void Proceed(Player player, bool manuallyStarted = false) { }

	[CompilerGenerated]
	public void remove_OnStatusChanged(Action value) { }

	[CompilerGenerated]
	public void remove_OnStatusChangedForPlaybleObject(Action value) { }

	private void RemoveTransferPlayer(IPlayer iPlayer) { }

	public int ResolveTransferPaymentCount(IPlayer player, int requirementCount) { }

	[CompilerGenerated]
	protected void set_CharismaLevel(int value) { }

	[CompilerGenerated]
	protected void set_FenceRep(float value) { }

	[CompilerGenerated]
	protected void set_Id(MongoID value) { }

	public override void set_Status(EExfiltrationStatus value) { }

	public void SetInitialStatus() { }

	public void SetStatusLogged(EExfiltrationStatus targetStatus, string signature = "") { }

	public IEnumerable UnmetRequirements(Player player) { }

	public IEnumerable UnmetRequirements(string profileId) { }

}

