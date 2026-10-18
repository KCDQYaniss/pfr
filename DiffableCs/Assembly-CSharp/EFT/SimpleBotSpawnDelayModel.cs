namespace EFT;

public sealed class SimpleBotSpawnDelayModel : SpawnDelayModel
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__3_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal WildSpawnType <ToString>b__3_0(Profile profile) { }

	}

	public BotZone BotZone; //Field offset: 0x40

	public SimpleBotSpawnDelayModel(BotZone botZone, int count, BotCreationData creationData, Action callback) { }

	public virtual string ToString() { }

	public virtual string ZoneName() { }

}

