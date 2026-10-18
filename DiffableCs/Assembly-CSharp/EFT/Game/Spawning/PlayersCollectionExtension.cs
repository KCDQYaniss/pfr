namespace EFT.Game.Spawning;

[Extension]
public static class PlayersCollectionExtension
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__2_0; //Field offset: 0x8
		public static Func <>9__3_0; //Field offset: 0x10

		private static <>c() { }

		public <>c() { }

		internal bool <CarePlayers>b__3_0(IPlayer player) { }

		internal bool <ExceptAI>b__2_0(IPlayer person) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass1_0
	{
		public IPlayer exceptPerson; //Field offset: 0x10

		public <>c__DisplayClass1_0() { }

		internal bool <Except>b__0(IPlayer person) { }

	}


	[Extension]
	public static IEnumerable CarePlayers(IEnumerable persons) { }

	[Extension]
	public static IEnumerable Except(IEnumerable persons, IPlayer exceptPerson = null) { }

	[Extension]
	public static IEnumerable ExceptAI(IEnumerable persons) { }

	[Extension]
	public static IEnumerable GroupPlayers(IEnumerable persons, string groupId = null, string teamId = null) { }

}

