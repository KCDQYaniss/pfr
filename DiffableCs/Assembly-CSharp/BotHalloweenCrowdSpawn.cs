//Type is in global namespace

public class BotHalloweenCrowdSpawn
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__13_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal int <GetRandomSpawnParams>b__13_0(CrowdAttackSpawnParam x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass8_0
	{
		public CrowdAttackSpawnParam spawnParams; //Field offset: 0x10
		public BotHalloweenCrowdSpawn <>4__this; //Field offset: 0x18

		public <>c__DisplayClass8_0() { }

		internal void <DoSpawn>b__0() { }

	}

	private class PlayerCrowdSpawnInfo
	{
		public int spawnsRemains; //Field offset: 0x10
		public float nextSpawnsTime; //Field offset: 0x14

		public PlayerCrowdSpawnInfo() { }

	}

	private Dictionary _playersInfo; //Field offset: 0x10
	private List _activePursuits; //Field offset: 0x18
	private BotSpawner _spawner; //Field offset: 0x20
	private AIPeriodAction _spawnerPeriodicAction; //Field offset: 0x28
	private BotHalloween2024 _halloweenConfig; //Field offset: 0x30

	public BotHalloweenCrowdSpawn(List activePursuits, BotSpawner spawner, BotHalloween2024 halloweenConfig) { }

	private void BeginCrowdSpawn(PlayerCrowdSpawnInfo pcsInfo) { }

	private int CalcBotsCanSpawnedPerCrowd() { }

	private void CheckSpawn() { }

	private void CheckSpawnForPursuit() { }

	private void DoSpawn(PlayerCrowdSpawnInfo pcsInfo) { }

	private PlayerCrowdSpawnInfo GetPlayerCrowdSpawnInfo(IPlayer player) { }

	private CrowdAttackSpawnParam GetRandomSpawnParams() { }

	private void InvokeCrowdSpawnEvent(IPlayer player) { }

	public void ManualUpdate() { }

}

