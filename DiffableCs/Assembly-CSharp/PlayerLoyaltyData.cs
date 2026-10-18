//Type is in global namespace

public class PlayerLoyaltyData
{
	private const float AGGRESSOR_PERIOD = 180; //Field offset: 0x0
	private double _endAggressor; //Field offset: 0x10
	private readonly IPlayer _player; //Field offset: 0x18
	private readonly FenceTraderInfo _loyaltySetting; //Field offset: 0x20
	private int _regularScavKills; //Field offset: 0x28
	private HashSet _botPmcDamagedScavHashSet; //Field offset: 0x30
	private float _botPmcAggressorStreak; //Field offset: 0x38
	[TupleElementNames(new IL2CPP_TYPE_STRING[] {"standing", "source"})]
	private ValueTuple _aggressorBonus; //Field offset: 0x40
	private readonly Dictionary _enemies; //Field offset: 0x50
	[CompilerGenerated]
	private bool <CanBeFreeKilled>k__BackingField; //Field offset: 0x58
	private bool _isPveOffline; //Field offset: 0x59

	public override bool BossNoAttack
	{
		 get { } //Length: 47
	}

	public float BotPmcAggressorStreak
	{
		 get { } //Length: 6
	}

	public private bool CanBeFreeKilled
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public float ChanceApplyFollowRequest
	{
		 get { } //Length: 48
	}

	public float ChanceApplyGetInCoverRequest
	{
		 get { } //Length: 48
	}

	public float ChanceApplyHelpRequest
	{
		 get { } //Length: 48
	}

	public float ChanceApplySilenceRequest
	{
		 get { } //Length: 48
	}

	public float ChanceApplySpreadoutRequest
	{
		 get { } //Length: 48
	}

	public float ChanceApplyStopRequest
	{
		 get { } //Length: 48
	}

	public override bool HostileScavs
	{
		 get { } //Length: 44
	}

	public bool IsAggressor
	{
		 get { } //Length: 162
	}

	public bool ReactOnMarkOnUnknowns
	{
		 get { } //Length: 44
	}

	public bool ScavAttackSupport
	{
		 get { } //Length: 44
	}

	public PlayerLoyaltyData(IPlayer player) { }

	public override bool get_BossNoAttack() { }

	public float get_BotPmcAggressorStreak() { }

	[CompilerGenerated]
	public bool get_CanBeFreeKilled() { }

	public float get_ChanceApplyFollowRequest() { }

	public float get_ChanceApplyGetInCoverRequest() { }

	public float get_ChanceApplyHelpRequest() { }

	public float get_ChanceApplySilenceRequest() { }

	public float get_ChanceApplySpreadoutRequest() { }

	public float get_ChanceApplyStopRequest() { }

	public override bool get_HostileScavs() { }

	public bool get_IsAggressor() { }

	public bool get_ReactOnMarkOnUnknowns() { }

	public bool get_ScavAttackSupport() { }

	private void GifterKill(Player victim) { }

	private void KillAggressor(PlayerLoyaltyData loyaltyData) { }

	private void KillAsSavage(double standingDelta, EFenceStandingSource standingSource) { }

	private void KillBotPmcAggressor(PlayerLoyaltyData loyaltyData) { }

	public void KillEnemy(Player victim) { }

	private void LogKill(Player victim, string title, double standingDelta) { }

	public void MarkAsAggressor(IPlayer victim) { }

	public void MarkAsCanBeFreeKilled() { }

	private void MyPlayerIsSavage(Player victim) { }

	[CompilerGenerated]
	private void set_CanBeFreeKilled(bool value) { }

	private void SetAsAggressor(ProfileSettings victimSettings) { }

	public void TryAddDamagedScavToHashSet(IPlayer victim) { }

	public bool WasAttackedBy(IPlayer person) { }

}

