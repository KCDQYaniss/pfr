namespace EFT.Interactive;

[DisallowMultipleComponent]
public sealed class TransitPoint : MonoBehaviour, IPhysicsTrigger, IInteractive
{
	[CompilerGenerated]
	private struct <Transit>d__38 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public HashSet players; //Field offset: 0x20
		public TransitPoint <>4__this; //Field offset: 0x28
		private int <playersCount>5__2; //Field offset: 0x30
		private string <transitionHash>5__3; //Field offset: 0x38
		private Dictionary <profileKeys>5__4; //Field offset: 0x40
		private Enumerator <>7__wrap4; //Field offset: 0x48
		private Player <player>5__6; //Field offset: 0x60
		private TaskAwaiter <>u__1; //Field offset: 0x68

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <UpdateGroupTimers>d__39 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public TransitPoint <>4__this; //Field offset: 0x20
		private Enumerator <>7__wrap1; //Field offset: 0x28
		private TaskAwaiter <>u__1; //Field offset: 0x40

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	public const int DEFAULT_MAX_GROUP_SIZE = 5; //Field offset: 0x0
	public TransitParameters parameters; //Field offset: 0x20
	[CompilerGenerated]
	private TransitController <Controller>k__BackingField; //Field offset: 0x28
	public List Requirements; //Field offset: 0x30
	private readonly HashSet _confirmedPlayers; //Field offset: 0x38
	[CompilerGenerated]
	private bool <Enabled>k__BackingField; //Field offset: 0x40
	[CompilerGenerated]
	private bool <IsActive>k__BackingField; //Field offset: 0x41
	private readonly Dictionary _playerGroups; //Field offset: 0x48
	private readonly Dictionary _groupTimers; //Field offset: 0x50
	private readonly Dictionary _groupSize; //Field offset: 0x58
	private readonly Dictionary _groupSavage; //Field offset: 0x60
	private double _lastUpdateTime; //Field offset: 0x68
	private readonly HashSet _playerEnterBuffer; //Field offset: 0x70

	public TransitController Controller
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 82
	}

	public override string Description
	{
		 get { } //Length: 27
	}

	public bool Enabled
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 4
	}

	public bool IsActive
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 4
	}

	public TransitPoint() { }

	private void AddPlayerToGroup(Player player, string groupId) { }

	private void ChangeGroupSize(string groupId, int value, string profile) { }

	public bool CheckAlivePartySizeRequirement(Player player) { }

	public bool CheckInitialRequirements(Player player) { }

	private void CreateGroup(string groupId, bool isSavage) { }

	[CompilerGenerated]
	public TransitController get_Controller() { }

	public override string get_Description() { }

	[CompilerGenerated]
	public bool get_Enabled() { }

	[CompilerGenerated]
	public bool get_IsActive() { }

	private static int GetAliveGroupMembersCount(string groupId, int stopAt) { }

	private int GetMaxGroupSize() { }

	public void GroupEnter(Player player) { }

	public void GroupExit(Player player) { }

	private static IEnumerable GroupPlayers(string groupId) { }

	private override bool IPhysicsTrigger.get_enabled() { }

	private override void IPhysicsTrigger.set_enabled(bool value) { }

	private static bool IsActiveRaidParticipant(IPlayer player) { }

	public bool IsConfirmed(string profileId) { }

	private bool IsGroupSavage(string groupId) { }

	public static int NormalizeMaxGroupSize(int maxGroupSize) { }

	private void OnPlayerDead(Player player, IPlayer lastAggressor, DamageInfo damageInfo, EBodyPart part) { }

	public override void OnTriggerEnter(Collider col) { }

	public override void OnTriggerExit(Collider col) { }

	private void SendTimer(string profileId, string groupId) { }

	private HashSet SeparateGroupPlayers(string groupId, out HashSet singlePlayers, out HashSet partyPlayers, out bool partyIsFull) { }

	[CompilerGenerated]
	public void set_Controller(TransitController value) { }

	[CompilerGenerated]
	public void set_Enabled(bool value) { }

	[CompilerGenerated]
	public void set_IsActive(bool value) { }

	public void SetConfirmed(string profileId) { }

	[AsyncStateMachine(typeof(<Transit>d__38))]
	private Task Transit(HashSet players) { }

	private static bool TryGetPlayer(Collider col, out Player player) { }

	private void Update() { }

	private void UpdateActivation() { }

	[AsyncStateMachine(typeof(<UpdateGroupTimers>d__39))]
	private Task UpdateGroupTimers() { }

}

