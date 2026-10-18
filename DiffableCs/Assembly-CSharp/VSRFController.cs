//Type is in global namespace

public class VSRFController
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass19_0
	{
		public BotOwner bot; //Field offset: 0x10
		public VSRFController <>4__this; //Field offset: 0x18

		public <>c__DisplayClass19_0() { }

		internal void <OnBotAdd>g__OnMigrated|0(BotOwner obj) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass21_0
	{
		public VSRFController <>4__this; //Field offset: 0x10
		public BotOwner bot; //Field offset: 0x18

		public <>c__DisplayClass21_0() { }

		internal void <SubscribeBotHit>g__handler|0(DamageInfo damageInfo, EBodyPart bodyPart, float damageReducedByArmor) { }

	}

	private const int MAX_KILL_TO_FOREVER_ENEMY = 5; //Field offset: 0x0
	private const int HIT_TO_BECOME_ENEMY = 0; //Field offset: 0x0
	private const float ENEMY_PERIOD = 20; //Field offset: 0x0
	public const int DISTANCE_TO_CHEAT_VISIBILITY = 109; //Field offset: 0x0
	private BotsController _botsController; //Field offset: 0x10
	private List _bossesGroups; //Field offset: 0x18
	private AIPeriodAction _enemiesPeriod; //Field offset: 0x20
	private List _vsrfBots; //Field offset: 0x28
	private Dictionary _vsrfHitsByPlayers; //Field offset: 0x30
	private Dictionary _vsrfKills; //Field offset: 0x38
	private Dictionary _botHitHandlers; //Field offset: 0x40
	private Dictionary _endBeeingEnemy; //Field offset: 0x48
	private HashSet _foreverEnemy; //Field offset: 0x50

	public VSRFController(BotsController botsController) { }

	public void Activate() { }

	private void AddEnemyAndSendInfo(BotsGroup group, IPlayer player) { }

	private void CheckEnemies() { }

	public void Dispose() { }

	private void EndBeeingEnemy(IPlayer damageDealer) { }

	private bool IsSee(BotOwner bossOwner, IPlayer damageDealer) { }

	public void ManualEnemy() { }

	private void OnBotAdd(BotOwner bot) { }

	private void OnBotRemove(BotOwner bot) { }

	public void RegisterHit(BotOwner bot, IPlayer damageDealer) { }

	public void RegisterKill(int playerId, BotOwner bot) { }

	public void SetEnemyInfo(BotOwner bot) { }

	public void SetInfoAboutEnemy(Player enemy) { }

	private void SubscribeBotHit(BotOwner bot) { }

	private void UnsubscribeBotHit(BotOwner bot) { }

}

