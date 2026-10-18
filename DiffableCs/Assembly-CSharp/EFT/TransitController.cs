namespace EFT;

public abstract class TransitController : IDisposable
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass20_0
	{
		public TransitController <>4__this; //Field offset: 0x10
		public Player player; //Field offset: 0x18
		public Action <>9__0; //Field offset: 0x20

		public <>c__DisplayClass20_0() { }

		internal void <HandleExits>b__0() { }

	}

	[CompilerGenerated]
	private struct <>c__DisplayClass29_0
	{
		public TransitController controller; //Field offset: 0x0
		public List spawnPoints; //Field offset: 0x8

	}

	protected readonly TransitGlobalSettings settings; //Field offset: 0x10
	protected int _currentTransitPointId; //Field offset: 0x18
	protected Dictionary pointsById; //Field offset: 0x20
	public readonly Dictionary transitPlayers; //Field offset: 0x28
	public readonly Dictionary summonedTransits; //Field offset: 0x30
	public readonly Dictionary alreadyTransits; //Field offset: 0x38
	public readonly Dictionary profileKeys; //Field offset: 0x40
	public readonly Dictionary profileTime; //Field offset: 0x48
	public readonly List locationOrigins; //Field offset: 0x50
	public readonly HashSet usedSpawnPoints; //Field offset: 0x58
	public Action OnPlayerEnter; //Field offset: 0x60
	public Action OnPlayerExit; //Field offset: 0x68
	public Action OnSetTimers; //Field offset: 0x70
	[CompilerGenerated]
	private TransferItemsController <TransferItemsController>k__BackingField; //Field offset: 0x78

	public TransferItemsController TransferItemsController
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 82
	}

	protected TransitController(TransitGlobalSettings settings, TransitParameters[] parameters) { }

	[CompilerGenerated]
	internal static bool <TryGetTransitSpawnPoint>g__SpawnPointsWithoutUsed|29_0(ref <>c__DisplayClass29_0 unnamed_param_0) { }

	public override void AccessNotGranted(Player player, IEnumerable reasons) { }

	protected override bool DisableExits(Player player) { }

	public static void DisableTransitPoints() { }

	public override void Dispose() { }

	protected override bool EnableExits(Player player) { }

	public void EnablePoints(bool exceptEvents = true) { }

	public static bool Exist(out T transitController) { }

	[CompilerGenerated]
	public TransferItemsController get_TransferItemsController() { }

	private ISpawnPoint GetClosestSpawn(IEnumerable spawnPoints, LocationOrigin origin, IReadOnlyCollection avoidPlayers) { }

	protected int GetCurrentPointMaxGroupSize() { }

	public InteractWithTransitPacket GetInteractPacket(int transitPointId, string keyId, EDateTime time) { }

	protected void HandleExits(ICollection activePoints, Player player) { }

	public abstract void InactivePointNotification(int playerId, int pointId) { }

	private void InitLocationOrigins() { }

	private void InitTransitPoints(TransitParameters[] parameters) { }

	public override void InteractWithTransit(Player player, InteractWithTransitPacket packet) { }

	private static bool IsInAvoidPlayersDistance(IEnumerable avoidPlayers, ISpawnPoint point) { }

	private bool IsInUsedSpawnPointsDistance(ISpawnPoint point) { }

	public static bool IsTransit(string profileId, out int count) { }

	public static bool IsTransit(string profileId, out string location) { }

	public bool IsTransitPlayer(string profileId, out string location) { }

	public bool IsTransitPlayer(string profileId, out int count) { }

	public override void OverGroupSize(Player player, TransitPoint transitPoint) { }

	public void PauseEventPoints() { }

	[CompilerGenerated]
	protected void set_TransferItemsController(TransferItemsController value) { }

	public abstract void Sizes(int pointId, Dictionary sizes) { }

	public abstract void Timers(int pointId, Dictionary timers) { }

	public override Task Transit(TransitPoint point, int playersCount, string hash, Dictionary keys, Player player) { }

	public override void TransitRequirementFailed(Player player, TransitPoint transitPoint) { }

	private bool TryGetLocationOrigin(string location, out LocationOrigin origin) { }

	public bool TryGetMarathon(MongoID profileId, out Transit transit) { }

	public static bool TryGetTransitSpawnPoint(string profileId, List spawnPoints, IReadOnlyCollection avoidPlayers, out ISpawnPoint spawnPoint, out string log) { }

	private static void TryInitCompletedQuestRequirement(TransitPoint point) { }

	private void TryInitRequirementReferences(TransitPoint point) { }

}

