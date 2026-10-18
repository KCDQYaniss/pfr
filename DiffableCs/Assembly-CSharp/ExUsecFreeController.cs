//Type is in global namespace

public class ExUsecFreeController
{
	private readonly BotsController _botsController; //Field offset: 0x10
	private readonly List _bosses; //Field offset: 0x18
	private readonly HashSet _members; //Field offset: 0x20
	[CompilerGenerated]
	private bool <CallSupportOnOutdoorDeath>k__BackingField; //Field offset: 0x28

	public bool CallSupportOnOutdoorDeath
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 4
	}

	public ExUsecFreeController(BotsController botsController) { }

	public void Activate() { }

	private void AskRandomGroupSupport(BotOwner deadBot, Vector3 supportPos, int envId) { }

	private void AskSupportAllOtherBosses(BotOwner victimBot, Vector3 supportPos, int victimEnv, ExUsecFreeBossLogic excludedBoss) { }

	public void Dispose() { }

	private BotOwner FindAnyAliveCaller(BotOwner deadBot) { }

	[CompilerGenerated]
	public bool get_CallSupportOnOutdoorDeath() { }

	private ExUsecFreeBossLogic GetBossOf(BotOwner bot) { }

	private void OnBeingHit(DamageInfo damageInfo, Player victim) { }

	private void OnBotRemove(BotOwner bot) { }

	public void RegisterBoss(ExUsecFreeBossLogic bossLogic) { }

	public void RegisterMember(BotOwner bot) { }

	[CompilerGenerated]
	public void set_CallSupportOnOutdoorDeath(bool value) { }

	public void UnregisterBoss(ExUsecFreeBossLogic bossLogic) { }

	public void UnregisterMember(BotOwner bot) { }

}

