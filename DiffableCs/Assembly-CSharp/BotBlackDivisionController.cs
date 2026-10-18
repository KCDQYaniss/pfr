//Type is in global namespace

public class BotBlackDivisionController
{
	private const float SDIST_TO_HELP = 10000; //Field offset: 0x0
	private const float DELTA_LAST_PERSONL_SEEN_TO_HELP = 20; //Field offset: 0x0
	private List _bosses; //Field offset: 0x10
	private BotsController _botsController; //Field offset: 0x18
	public BlackDivisionTalkingControl TalkingControl; //Field offset: 0x20

	public BotBlackDivisionController(BotsController botsController) { }

	public void Activate() { }

	public bool AskHelpForAttack(BossBlackDivision helpRequester, bool isEnemyRunAway) { }

	public void AskHelpForDefence(BossBlackDivision helpRequester) { }

	private bool CanDoFlank(BossBlackDivision requester, BossBlackDivision potentialHelper, out Nullable flankPoint, out Nullable targetPoint) { }

	private bool CanHelp(BossBlackDivision blackDivision, BossBlackDivision helpRequester) { }

	public float ClosestBossSdist(BossBlackDivision bossBlackDivision) { }

	private void OnBotAdd(BotOwner bot) { }

}

