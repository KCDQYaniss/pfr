//Type is in global namespace

public class BotLighthouseKeeperFriendlyExUsecs : BotTraderServiceFriendlyBase
{
	[CompilerGenerated]
	private bool <Disposed>k__BackingField; //Field offset: 0x38

	public private bool Disposed
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public BotLighthouseKeeperFriendlyExUsecs(BotLighthouseKeeperServices services, IPlayersCollection allBots, Player player) { }

	protected virtual void ActivateService(Player playerServiceOwner, bool reactivate) { }

	public void Dispose() { }

	[CompilerGenerated]
	public bool get_Disposed() { }

	public bool IgnoreTargetCauseExUsecFriendly(int aggressorId, int targetId) { }

	private void OnBeingHitFriendlyExUsec(DamageInfo damageInfo, Player victim) { }

	public void OnFriendlyExUsecActivated(Player playerServiceOwner, bool reactivate) { }

	private void OnKillFriendlyExUsec(IPlayer killer, IPlayer target) { }

	protected virtual bool OutOfRange(Vector3 position) { }

	private void ProcessFriendlyPlayerAttackTarget(DamageInfo damageInfo, Player victim) { }

	private void ProcessFriendlyTeammateAttackTarget(DamageInfo damageInfo, Player victim) { }

	private void ProcessTargetAttackFriendlyPlayer(DamageInfo damageInfo, Player victim) { }

	private void ProcessTargetAttackFriendlyTeammate(DamageInfo damageInfo, Player victim) { }

	[CompilerGenerated]
	private void set_Disposed(bool value) { }

	private bool TargetIsNeutralPlayerInLighthouseZoneWithGreenTransmitter(IPlayer player) { }

}

