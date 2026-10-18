//Type is in global namespace

public class BotGroupHostility
{
	private BotHostilityService _botHostilityService; //Field offset: 0x10
	private readonly BotsGroup OwnedGroup; //Field offset: 0x18
	public Dictionary Enemies; //Field offset: 0x20
	public Dictionary Warns; //Field offset: 0x28
	public Dictionary Neutrals; //Field offset: 0x30
	public Dictionary Allies; //Field offset: 0x38
	public List Dead; //Field offset: 0x40
	public Dictionary LastHostilityStatus; //Field offset: 0x48
	[CompilerGenerated]
	private BotGroupInnerHostilityData <InnerHostilityData>k__BackingField; //Field offset: 0x50
	[CompilerGenerated]
	private Action OnAddNeutral; //Field offset: 0x58
	[CompilerGenerated]
	private Action OnEnemyAdd; //Field offset: 0x60
	[CompilerGenerated]
	private Action OnEnemyRemove; //Field offset: 0x68

	public event Action OnAddNeutral
	{
		[CompilerGenerated]
		 add { } //Length: 262
		[CompilerGenerated]
		 remove { } //Length: 262
	}

	public event Action OnEnemyAdd
	{
		[CompilerGenerated]
		 add { } //Length: 262
		[CompilerGenerated]
		 remove { } //Length: 262
	}

	public event Action OnEnemyRemove
	{
		[CompilerGenerated]
		 add { } //Length: 262
		[CompilerGenerated]
		 remove { } //Length: 262
	}

	public private BotGroupInnerHostilityData InnerHostilityData
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public BotGroupHostility(BotsGroup group, BotOwner initialBot, AdditionalHostilitySettings[] backendAdditionalHostilitySettings, BotsController botsController) { }

	[CompilerGenerated]
	public void add_OnAddNeutral(Action value) { }

	[CompilerGenerated]
	public void add_OnEnemyAdd(Action value) { }

	[CompilerGenerated]
	public void add_OnEnemyRemove(Action value) { }

	private void AddEnemyAction(IPlayer player, BotGroupEnemyInfo info) { }

	private void AddNeutralAction(IPlayer player) { }

	public void Clear() { }

	[CompilerGenerated]
	public BotGroupInnerHostilityData get_InnerHostilityData() { }

	private bool IsOwnedGroupMember(IPlayer player) { }

	private void LogChanceHostilityStatusLog(IPlayer player, BotHostilityStatus newStatus) { }

	private bool NeutralsToAdd(IPlayer player, BotGroupEnemyInfo info, ENeutralAddReason reason) { }

	private void OwnedGroupCalcActionNextFrame() { }

	[CompilerGenerated]
	public void remove_OnAddNeutral(Action value) { }

	[CompilerGenerated]
	public void remove_OnEnemyAdd(Action value) { }

	[CompilerGenerated]
	public void remove_OnEnemyRemove(Action value) { }

	private void RemoveEnemyAction(IPlayer player) { }

	[CompilerGenerated]
	private void set_InnerHostilityData(BotGroupInnerHostilityData value) { }

	public void UpdateHostilityStatusForAllPlayers() { }

	private bool UpdatePlayerHostilityCollection(IPlayer player, HostilityEvaluationResult status) { }

}

