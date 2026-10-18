namespace CommonAssets.Scripts.Game;

public sealed class ExfiltrationController
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__26_0; //Field offset: 0x8
		public static Func <>9__26_1; //Field offset: 0x10
		public static Func <>9__26_2; //Field offset: 0x18
		public static Func <>9__30_0; //Field offset: 0x20
		public static Func <>9__33_2; //Field offset: 0x28
		public static Func <>9__33_1; //Field offset: 0x30
		public static Func <>9__34_0; //Field offset: 0x38
		public static Func <>9__44_0; //Field offset: 0x40

		private static <>c() { }

		public <>c() { }

		internal bool <EligiblePoints>b__33_1(ExfiltrationPoint x) { }

		internal bool <EligiblePoints>b__33_2(ExfiltrationPoint x) { }

		internal bool <EventDisableAllExitsExceptOne>b__30_0(ExfiltrationPoint point) { }

		internal bool <GetScavSecretExits>b__44_0(SecretExfiltrationPoint x) { }

		internal bool <InitAllExfiltrationPoints>b__26_0(ExfiltrationPoint x) { }

		internal bool <InitAllExfiltrationPoints>b__26_1(ExfiltrationPoint x) { }

		internal bool <InitAllExfiltrationPoints>b__26_2(ExfiltrationPoint x) { }

		internal bool <SecretEligiblePoints>b__34_0(SecretExfiltrationPoint x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass26_0
	{
		public string exitName; //Field offset: 0x10

		public <>c__DisplayClass26_0() { }

		internal bool <InitAllExfiltrationPoints>b__3(BackendExitTriggerSettings x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass26_1
	{
		public string exitName; //Field offset: 0x10

		public <>c__DisplayClass26_1() { }

		internal bool <InitAllExfiltrationPoints>b__4(BackendSecretExitTriggerSettings x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass33_0
	{
		public string entryPointName; //Field offset: 0x10

		public <>c__DisplayClass33_0() { }

		internal bool <EligiblePoints>b__0(ExfiltrationPoint x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass37_0
	{
		public string name; //Field offset: 0x10

		public <>c__DisplayClass37_0() { }

		internal bool <ReadStates>b__0(ExfiltrationPoint x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass38_0
	{
		public string name; //Field offset: 0x10

		public <>c__DisplayClass38_0() { }

		internal bool <UpdatePoint>b__0(ExfiltrationPoint x) { }

		internal bool <UpdatePoint>b__1(ScavExfiltrationPoint x) { }

		internal bool <UpdatePoint>b__2(SecretExfiltrationPoint x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass40_0
	{
		public Vector3 position; //Field offset: 0x10

		public <>c__DisplayClass40_0() { }

		internal float <ScavExfiltrationClaim>b__0(ScavExfiltrationPoint x) { }

	}

	[CompilerGenerated]
	private Action StatusChanged; //Field offset: 0x10
	[CompilerGenerated]
	private SecretExfilitranionController <SecretExfilitranionController>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	private ExfiltrationPoint[] <ExfiltrationPoints>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	private ScavExfiltrationPoint[] <ScavExfiltrationPoints>k__BackingField; //Field offset: 0x28
	[CompilerGenerated]
	private SecretExfiltrationPoint[] <SecretExfiltrationPoints>k__BackingField; //Field offset: 0x30
	public readonly HashSet BannedPlayers; //Field offset: 0x38
	private List _optionalExitsBuffer; //Field offset: 0x40
	private List _mandatoryExitsBuffer; //Field offset: 0x48

	public event Action StatusChanged
	{
		[CompilerGenerated]
		 add { } //Length: 262
		[CompilerGenerated]
		 remove { } //Length: 262
	}

	public private ExfiltrationPoint[] ExfiltrationPoints
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public static ExfiltrationController Instance
	{
		 get { } //Length: 61
	}

	public ExfiltrationLogger Logger
	{
		 get { } //Length: 311
	}

	public private ScavExfiltrationPoint[] ScavExfiltrationPoints
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public private SecretExfilitranionController SecretExfilitranionController
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public private SecretExfiltrationPoint[] SecretExfiltrationPoints
	{
		[CompilerGenerated]
		 get { } //Length: 76
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public ExfiltrationController() { }

	[CompilerGenerated]
	public void add_StatusChanged(Action value) { }

	public void AssignScavIdToPoint(ScavExfiltrationPoint point, string profileId) { }

	public void CancelExtractionForPlayer(Player player) { }

	public void DisableExitsInteraction() { }

	public void Dispose() { }

	public ExfiltrationPoint[] EligiblePoints(string entryPointName) { }

	public ExfiltrationPoint[] EligiblePoints(Profile profile) { }

	public void EnableExitsInteraction() { }

	public void EventDisableAllExitsExceptOne(string exitNameToSave) { }

	[CompilerGenerated]
	public ExfiltrationPoint[] get_ExfiltrationPoints() { }

	public static ExfiltrationController get_Instance() { }

	public ExfiltrationLogger get_Logger() { }

	[CompilerGenerated]
	public ScavExfiltrationPoint[] get_ScavExfiltrationPoints() { }

	[CompilerGenerated]
	public SecretExfilitranionController get_SecretExfilitranionController() { }

	[CompilerGenerated]
	public SecretExfiltrationPoint[] get_SecretExfiltrationPoints() { }

	public int GetScavExfiltrationMask(string profileId) { }

	public SecretExfiltrationPoint[] GetScavSecretExits() { }

	public void InitAllExfiltrationPoints(MongoID locationId, BackendExitTriggerSettings[] settings, BackendSecretExitTriggerSettings[] secretExitsSettings, bool justLoadSettings = false, string disabledScavExits = "", bool giveAuthority = true) { }

	public void InitSecretExfils(Player player) { }

	public bool IsMyPlayerBanned() { }

	public void LogDebug(string message, object[] args) { }

	public void LogError(string message, object[] args) { }

	public void LogInfo(string message, object[] args) { }

	public void ReadStates(NetworkReader reader) { }

	[CompilerGenerated]
	public void remove_StatusChanged(Action value) { }

	public void RemoveProfileIdFromPoints(string profileId) { }

	private bool RollChance(ExfiltrationPoint trigger) { }

	public void ScavExfiltrationClaim(Vector3 position, string profileId, int count) { }

	public ExfiltrationPoint[] ScavExfiltrationClaim(int mask, string profileId) { }

	public SecretExfiltrationPoint[] SecretEligiblePoints() { }

	[CompilerGenerated]
	private void set_ExfiltrationPoints(ExfiltrationPoint[] value) { }

	[CompilerGenerated]
	private void set_ScavExfiltrationPoints(ScavExfiltrationPoint[] value) { }

	[CompilerGenerated]
	private void set_SecretExfilitranionController(SecretExfilitranionController value) { }

	[CompilerGenerated]
	private void set_SecretExfiltrationPoints(SecretExfiltrationPoint[] value) { }

	public void UpdatePoint(string name, EExfiltrationStatus command, List queuedPlayers, bool itemTransferred) { }

	public void WriteStates(NetworkWriter writer) { }

}

