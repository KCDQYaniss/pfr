namespace EFT;

public sealed class BossSpawnDelayModel : SpawnDelayModel
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__4_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal WildSpawnType <ToString>b__4_0(Profile profile) { }

	}

	public readonly BossLocationSpawn Wave; //Field offset: 0x40
	public readonly BotSpawnParams SpawnParams; //Field offset: 0x48

	public BossSpawnDelayModel(BossLocationSpawn wave, BotSpawnParams spawnParams, int count, BotCreationData creationData, Action callback) { }

	public virtual string ToString() { }

	public virtual string ZoneName() { }

}

