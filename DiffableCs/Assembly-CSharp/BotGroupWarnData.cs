//Type is in global namespace

public class BotGroupWarnData
{
	private readonly Dictionary _playersWarned; //Field offset: 0x10
	private List _warnTargets; //Field offset: 0x18
	private readonly BotsGroup _group; //Field offset: 0x20
	private readonly HashSet _warningPlayers; //Field offset: 0x28

	public BotOwner Boss
	{
		 get { } //Length: 39
	}

	private float WARN_PLAYER_PERIOD
	{
		private get { } //Length: 79
	}

	public BotGroupWarnData(BotsGroup group) { }

	private void AddPlayersToEnemies(List players2Enemies) { }

	private void CollectWarnTargets(Dictionary warnTargets) { }

	public void DisposeCallback(IPlayer player) { }

	private float DistToShootSQR(IPlayer player) { }

	private float DistToWarningSQR(IPlayer player) { }

	private float DistToWarningSQRBear(IPlayer player) { }

	private float DistToWarningSQRUsec(IPlayer player) { }

	private void FindNearestAllyToWarnAndWarnIntruders(BotGroupEnemyInfo targetToWarn, ref List players2Enemies) { }

	public BotOwner get_Boss() { }

	private float get_WARN_PLAYER_PERIOD() { }

	private bool IsCorrectTarget(BotGroupEnemyInfo enemyInfo) { }

	private float MaxYDistToStartWarnRequestToRequester(IPlayer player) { }

	public void PlayerDead(Player player) { }

	private bool ShallBossAttack(Player enemyInfo) { }

	private void StartWarnTarget(IPlayer playerToWarn, IBotOwner closestBot) { }

	public override void UpdateDistToScavsPlayersAndWarnIntruders() { }

	private List UpdateWarnTargets(List warnTargets) { }

	public void WarnComplete(IPlayer player) { }

}

