//Type is in global namespace

public class BotZoneGroupsDictionary : Dictionary
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__3_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal int <TryGetValue>b__3_0(BotsGroup x) { }

	}

	[CompilerGenerated]
	private Action OnAddGroup; //Field offset: 0x50

	public event Action OnAddGroup
	{
		[CompilerGenerated]
		 add { } //Length: 262
		[CompilerGenerated]
		 remove { } //Length: 262
	}

	public BotZoneGroupsDictionary() { }

	public void Add(BotZone zone, EPlayerSide side, BotsGroup gr, bool isBossOrFollower) { }

	[CompilerGenerated]
	public void add_OnAddGroup(Action value) { }

	public void AddNoKey(BotsGroup gr, BotZone zone) { }

	[CompilerGenerated]
	public void remove_OnAddGroup(Action value) { }

	public bool TryGetValue(BotZone zone, EPlayerSide side, WildSpawnType spawnType, out BotsGroup group, bool isBossOrFollower) { }

}

