namespace EFT;

public sealed class LocalTransitController : ClientTransitController
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__1_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal string <.ctor>b__1_0(string current, string location) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass1_0
	{
		public LocalTransitController <>4__this; //Field offset: 0x10
		public Player player; //Field offset: 0x18

		public <>c__DisplayClass1_0() { }

		internal void <.ctor>b__1() { }

	}

	private readonly LocalRaidSettings _localRaidSettings; //Field offset: 0xB8

	public LocalTransitController(TransitGlobalSettings settings, TransitParameters[] parameters, Profile profile, LocalRaidSettings localRaidSettings) { }

	public virtual void Dispose() { }

	public void HandleExits() { }

	public virtual void InteractWithTransit(Player player, InteractWithTransitPacket packet) { }

	private void OnItemAdded(AddItemEventArgs addItemEventArgs) { }

	private void PlayerEnter(TransitPoint point, Player player) { }

	private void PlayerExit(TransitPoint point, Player player) { }

	public virtual void Sizes(int pointId, Dictionary sizes) { }

	public virtual void Timers(int pointId, Dictionary timers) { }

	public virtual Task Transit(TransitPoint point, int playersCount, string hash, Dictionary keys, Player player) { }

	public void UpdateTimers() { }

}

