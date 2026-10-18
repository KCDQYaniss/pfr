namespace EFT;

public sealed class SpawnsLogger : AbstractLogger
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__11_0; //Field offset: 0x8
		public static Func <>9__11_1; //Field offset: 0x10
		public static Func <>9__11_2; //Field offset: 0x18
		public static Func <>9__12_0; //Field offset: 0x20
		public static Func <>9__12_1; //Field offset: 0x28
		public static Func <>9__12_2; //Field offset: 0x30

		private static <>c() { }

		public <>c() { }

		internal SpawnData <Fill>b__11_0(KeyValuePair pair) { }

		internal bool <Fill>b__11_1(KeyValuePair pair) { }

		internal SpawnData <Fill>b__11_2(KeyValuePair pair) { }

		internal SpawnData <FillWithoutJson>b__12_0(KeyValuePair pair) { }

		internal bool <FillWithoutJson>b__12_1(KeyValuePair pair) { }

		internal SpawnData <FillWithoutJson>b__12_2(KeyValuePair pair) { }

	}

	private enum ActionId
	{
		PlayerSpawned = 0,
		PlayerSpawnedWithTeleport = 1,
		BotSpawned = 2,
		BotSpawnedWithTeleport = 3,
	}

	public sealed class LoggerFactory : MulticastDelegate
	{

		public LoggerFactory(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(IDictionary players, IDictionary bots, AsyncCallback callback, object object) { }

		public override SpawnsLogger EndInvoke(IAsyncResult result) { }

		public override SpawnsLogger Invoke(IDictionary players, IDictionary bots) { }

	}

	internal sealed class PlayerSpawnData
	{
		public string ProfileId; //Field offset: 0x10
		public int PlayerId; //Field offset: 0x18
		public ESpawnCategory Category; //Field offset: 0x1C
		public EPlayerSide Side; //Field offset: 0x20
		public Vector3 Position; //Field offset: 0x24
		[JsonProperty(DefaultValueHandling = DefaultValueHandling::Ignore (1))]
		public string GroupId; //Field offset: 0x30
		[JsonProperty(DefaultValueHandling = DefaultValueHandling::Ignore (1))]
		public Nullable DiscardedPosition; //Field offset: 0x38
		public SpawnData[] Players; //Field offset: 0x48
		public SpawnData[] Bots; //Field offset: 0x50

		public PlayerSpawnData() { }

	}

	internal class SpawnData
	{
		public string ProfileId; //Field offset: 0x10
		public ESpawnCategory Category; //Field offset: 0x18
		public EPlayerSide Side; //Field offset: 0x1C
		public Vector3 Position; //Field offset: 0x20
		[JsonProperty(DefaultValueHandling = DefaultValueHandling::Ignore (1))]
		public string GroupId; //Field offset: 0x30

		public SpawnData() { }

	}

	private readonly IDictionary _players; //Field offset: 0x48
	private readonly IDictionary _bots; //Field offset: 0x50
	private StringBuilder _playersStringBuilder; //Field offset: 0x58
	private StringBuilder _botsStringBuilder; //Field offset: 0x60

	internal SpawnsLogger(IDictionary players, IDictionary bots) { }

	[Conditional("UNITY_EDITOR")]
	[Conditional("SERVER")]
	internal void BotSpawned(Player player, bool isBoss) { }

	[Conditional("SERVER")]
	[Conditional("UNITY_EDITOR")]
	internal void BotSpawned(Player player, bool isBoss, Vector3 discardedPosition) { }

	private void Fill(IDictionary properties, Player player, ESpawnCategory category, Nullable discardedPosition = null) { }

	private void FillWithoutJson(IDictionary properties, Player player, ESpawnCategory category, Nullable discardedPosition = null) { }

	[Conditional("SERVER")]
	[Conditional("UNITY_EDITOR")]
	internal void PlayerSpawned(Player player) { }

	[Conditional("SERVER")]
	[Conditional("UNITY_EDITOR")]
	internal void PlayerSpawned(Player player, Vector3 discardedPosition) { }

}

