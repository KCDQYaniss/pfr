namespace EFT.Quests;

public class QuestTemplate
{
	[CompilerGenerated]
	private struct <LoadIconSprite>d__143 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public QuestTemplate <>4__this; //Field offset: 0x20
		public IImageLoader session; //Field offset: 0x28
		private Task <loadIconTask>5__2; //Field offset: 0x30
		private TaskAwaiter <>u__1; //Field offset: 0x38

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	internal enum EQuestType
	{
		PickUp = 0,
		Elimination = 1,
		Discover = 2,
		Completion = 3,
		Exploration = 4,
		Levelling = 5,
		Experience = 6,
		Standing = 7,
		Loyalty = 8,
		Merchant = 9,
		Skill = 10,
		Multi = 11,
		WeaponAssembly = 12,
		ArenaWinMatch = 13,
		ArenaWinRound = 14,
	}

	internal enum EStatQuestType
	{
		BringItemToTrader = 0,
		Eliminate = 1,
		SurviveOnLocation = 2,
		PickUp = 3,
		ArenaWinMatch = 4,
	}

	[CompilerGenerated]
	private string <Id>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private string <LocationId>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	private int <Level>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	private bool <Restartable>k__BackingField; //Field offset: 0x24
	[CompilerGenerated]
	private string <TraderId>k__BackingField; //Field offset: 0x28
	[CompilerGenerated]
	private string <Image>k__BackingField; //Field offset: 0x30
	[CompilerGenerated]
	private string <IconURL>k__BackingField; //Field offset: 0x38
	[CompilerGenerated]
	private EQuestType <QuestType>k__BackingField; //Field offset: 0x40
	[CompilerGenerated]
	private string <TemplateId>k__BackingField; //Field offset: 0x48
	[CompilerGenerated]
	private EQuestStatus <AppearStatus>k__BackingField; //Field offset: 0x50
	[CompilerGenerated]
	private bool <KeyQuest>k__BackingField; //Field offset: 0x54
	[CompilerGenerated]
	private Dictionary <Rewards>k__BackingField; //Field offset: 0x58
	[CompilerGenerated]
	private IReadOnlyList <RewardsInfo>k__BackingField; //Field offset: 0x60
	[CompilerGenerated]
	private ConditionsDict <Conditions>k__BackingField; //Field offset: 0x68
	[CompilerGenerated]
	private bool <CanShowNotificationsInGame>k__BackingField; //Field offset: 0x70
	[CompilerGenerated]
	private bool <InstantComplete>k__BackingField; //Field offset: 0x71
	[CompilerGenerated]
	private EPlayerGroup <PlayerGroup>k__BackingField; //Field offset: 0x74
	[CompilerGenerated]
	private ETierAccessoryType <Tier>k__BackingField; //Field offset: 0x78
	[CompilerGenerated]
	private bool <ServerOnly>k__BackingField; //Field offset: 0x7C
	[JsonProperty("dialogueId")]
	public Nullable DialogId; //Field offset: 0x80
	[CompilerGenerated]
	private DialogInvitationMessageSettings <DialogInvitationMessageSettings>k__BackingField; //Field offset: 0xA0
	[CompilerGenerated]
	private bool <InBufferZoneOnly>k__BackingField; //Field offset: 0xA8
	[CompilerGenerated]
	private bool <IsInvisible>k__BackingField; //Field offset: 0xA9
	[CompilerGenerated]
	private Dictionary <Localization>k__BackingField; //Field offset: 0xB0
	[CompilerGenerated]
	private Sprite <Sprite>k__BackingField; //Field offset: 0xB8
	[CompilerGenerated]
	private Sprite <IconSprite>k__BackingField; //Field offset: 0xC0
	[CompilerGenerated]
	private Sprite <Icon>k__BackingField; //Field offset: 0xC8
	[JsonProperty("name")]
	public string _questName; //Field offset: 0xD0
	[JsonProperty("successMessageText")]
	public string QuestSuccessMessageKey; //Field offset: 0xD8
	[JsonProperty("changeQuestMessageText")]
	public string _changeQuestMessageText; //Field offset: 0xE0
	[JsonProperty("description")]
	public string _description; //Field offset: 0xE8
	[JsonProperty("acceptPlayerMessage")]
	public string AcceptPlayerMessageKey; //Field offset: 0xF0
	[JsonProperty("declinePlayerMessage")]
	public string DeclinePlayerMessageKey; //Field offset: 0xF8
	[JsonProperty("completePlayerMessage")]
	public string CompletePlayerMessageKey; //Field offset: 0x100
	[JsonProperty("acceptanceAndFinishingSource")]
	public EProfileType acceptanceAndFinishingSource; //Field offset: 0x108
	[JsonProperty("progressSource")]
	public EProfileType progressSource; //Field offset: 0x10C
	[JsonProperty("rankingModes")]
	public string[] rankingModes; //Field offset: 0x110
	[JsonProperty("gameModes")]
	public string[] gameModes; //Field offset: 0x118
	[JsonProperty("arenaLocations")]
	public string[] arenaLocationIds; //Field offset: 0x120
	[CompilerGenerated]
	private bool <IsMainQuest>k__BackingField; //Field offset: 0x128
	[CompilerGenerated]
	private Dictionary <Notes>k__BackingField; //Field offset: 0x130

	[JsonProperty("status")]
	public private EQuestStatus AppearStatus
	{
		[CompilerGenerated]
		 get { } //Length: 4
		[CompilerGenerated]
		private set { } //Length: 4
	}

	[JsonProperty("canShowNotificationsInGame")]
	public private bool CanShowNotificationsInGame
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 4
	}

	[JsonIgnore]
	public string ChangeQuestText
	{
		 get { } //Length: 120
	}

	[JsonProperty("conditions")]
	public private ConditionsDict Conditions
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 82
	}

	[JsonIgnore]
	public string Description
	{
		 get { } //Length: 120
	}

	[JsonIgnore]
	public string DescriptionKey
	{
		 get { } //Length: 8
	}

	[JsonProperty("mailSettings")]
	public private DialogInvitationMessageSettings DialogInvitationMessageSettings
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 82
	}

	[JsonIgnore]
	public private Sprite Icon
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 82
	}

	[JsonIgnore]
	public private Sprite IconSprite
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 82
	}

	[JsonProperty("icon")]
	public private string IconURL
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 82
	}

	[JsonProperty("_id")]
	public private string Id
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 82
	}

	[JsonProperty("image")]
	public private string Image
	{
		[CompilerGenerated]
		 get { } //Length: 76
		[CompilerGenerated]
		private set { } //Length: 82
	}

	[JsonProperty("inBufferZoneOnly")]
	public private bool InBufferZoneOnly
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 7
	}

	[JsonProperty("instantComplete")]
	public private bool InstantComplete
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 4
	}

	[JsonProperty("notDisplayedQuest")]
	public private bool IsInvisible
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 7
	}

	[JsonProperty("isStoryQuest")]
	public private bool IsMainQuest
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 7
	}

	[JsonProperty("KeyQuest")]
	public private bool KeyQuest
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 4
	}

	[JsonProperty("min_level")]
	public private int Level
	{
		[CompilerGenerated]
		 get { } //Length: 4
		[CompilerGenerated]
		private set { } //Length: 4
	}

	[JsonProperty("localization")]
	public private Dictionary Localization
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 82
	}

	[JsonProperty("location")]
	public private string LocationId
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 82
	}

	[JsonIgnore]
	public string Name
	{
		 get { } //Length: 135
	}

	[JsonIgnore]
	public override string NameLocaleKey
	{
		 get { } //Length: 90
	}

	[JsonProperty("notes")]
	public private Dictionary Notes
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 82
	}

	[JsonProperty("side")]
	public private EPlayerGroup PlayerGroup
	{
		[CompilerGenerated]
		 get { } //Length: 4
		[CompilerGenerated]
		private set { } //Length: 4
	}

	[JsonProperty("type")]
	public private EQuestType QuestType
	{
		[CompilerGenerated]
		 get { } //Length: 4
		[CompilerGenerated]
		private set { } //Length: 4
	}

	[JsonProperty("restartable")]
	public private bool Restartable
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 4
	}

	[JsonProperty("rewards")]
	public private Dictionary Rewards
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 82
	}

	[JsonProperty("rewardsInfo")]
	public private IReadOnlyList RewardsInfo
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 82
	}

	[JsonProperty("secretQuest")]
	public private bool ServerOnly
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 4
	}

	[JsonIgnore]
	public private Sprite Sprite
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 82
	}

	[JsonIgnore]
	public string SuccessMessageText
	{
		 get { } //Length: 120
	}

	[JsonProperty("templateId")]
	public private string TemplateId
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 82
	}

	[JsonProperty("tierAccessory")]
	public private ETierAccessoryType Tier
	{
		[CompilerGenerated]
		 get { } //Length: 4
		[CompilerGenerated]
		private set { } //Length: 4
	}

	[JsonProperty("traderId")]
	public private string TraderId
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public QuestTemplate() { }

	public QuestTemplate(string id) { }

	public override Quest CreateNewQuest(QuestBook questBook, QuestStatusData statusData, Dictionary conditionCounters, bool fromServer, bool inRaid) { }

	[CompilerGenerated]
	public EQuestStatus get_AppearStatus() { }

	[CompilerGenerated]
	public bool get_CanShowNotificationsInGame() { }

	public string get_ChangeQuestText() { }

	[CompilerGenerated]
	public ConditionsDict get_Conditions() { }

	public string get_Description() { }

	public string get_DescriptionKey() { }

	[CompilerGenerated]
	public DialogInvitationMessageSettings get_DialogInvitationMessageSettings() { }

	[CompilerGenerated]
	public Sprite get_Icon() { }

	[CompilerGenerated]
	public Sprite get_IconSprite() { }

	[CompilerGenerated]
	public string get_IconURL() { }

	[CompilerGenerated]
	public string get_Id() { }

	[CompilerGenerated]
	public string get_Image() { }

	[CompilerGenerated]
	public bool get_InBufferZoneOnly() { }

	[CompilerGenerated]
	public bool get_InstantComplete() { }

	[CompilerGenerated]
	public bool get_IsInvisible() { }

	[CompilerGenerated]
	public bool get_IsMainQuest() { }

	[CompilerGenerated]
	public bool get_KeyQuest() { }

	[CompilerGenerated]
	public int get_Level() { }

	[CompilerGenerated]
	public Dictionary get_Localization() { }

	[CompilerGenerated]
	public string get_LocationId() { }

	public string get_Name() { }

	public override string get_NameLocaleKey() { }

	[CompilerGenerated]
	public Dictionary get_Notes() { }

	[CompilerGenerated]
	public EPlayerGroup get_PlayerGroup() { }

	[CompilerGenerated]
	public EQuestType get_QuestType() { }

	[CompilerGenerated]
	public bool get_Restartable() { }

	[CompilerGenerated]
	public Dictionary get_Rewards() { }

	[CompilerGenerated]
	public IReadOnlyList get_RewardsInfo() { }

	[CompilerGenerated]
	public bool get_ServerOnly() { }

	[CompilerGenerated]
	public Sprite get_Sprite() { }

	public string get_SuccessMessageText() { }

	[CompilerGenerated]
	public string get_TemplateId() { }

	[CompilerGenerated]
	public ETierAccessoryType get_Tier() { }

	[CompilerGenerated]
	public string get_TraderId() { }

	public ETaskPlayerSide GetPlayerSide() { }

	[AsyncStateMachine(typeof(<LoadIconSprite>d__143))]
	public Task LoadIconSprite(IImageLoader session) { }

	[CompilerGenerated]
	private void set_AppearStatus(EQuestStatus value) { }

	[CompilerGenerated]
	private void set_CanShowNotificationsInGame(bool value) { }

	[CompilerGenerated]
	private void set_Conditions(ConditionsDict value) { }

	[CompilerGenerated]
	private void set_DialogInvitationMessageSettings(DialogInvitationMessageSettings value) { }

	[CompilerGenerated]
	private void set_Icon(Sprite value) { }

	[CompilerGenerated]
	private void set_IconSprite(Sprite value) { }

	[CompilerGenerated]
	private void set_IconURL(string value) { }

	[CompilerGenerated]
	private void set_Id(string value) { }

	[CompilerGenerated]
	private void set_Image(string value) { }

	[CompilerGenerated]
	private void set_InBufferZoneOnly(bool value) { }

	[CompilerGenerated]
	private void set_InstantComplete(bool value) { }

	[CompilerGenerated]
	private void set_IsInvisible(bool value) { }

	[CompilerGenerated]
	private void set_IsMainQuest(bool value) { }

	[CompilerGenerated]
	private void set_KeyQuest(bool value) { }

	[CompilerGenerated]
	private void set_Level(int value) { }

	[CompilerGenerated]
	private void set_Localization(Dictionary value) { }

	[CompilerGenerated]
	private void set_LocationId(string value) { }

	[CompilerGenerated]
	private void set_Notes(Dictionary value) { }

	[CompilerGenerated]
	private void set_PlayerGroup(EPlayerGroup value) { }

	[CompilerGenerated]
	private void set_QuestType(EQuestType value) { }

	[CompilerGenerated]
	private void set_Restartable(bool value) { }

	[CompilerGenerated]
	private void set_Rewards(Dictionary value) { }

	[CompilerGenerated]
	private void set_RewardsInfo(IReadOnlyList value) { }

	[CompilerGenerated]
	private void set_ServerOnly(bool value) { }

	[CompilerGenerated]
	private void set_Sprite(Sprite value) { }

	[CompilerGenerated]
	private void set_TemplateId(string value) { }

	[CompilerGenerated]
	private void set_Tier(ETierAccessoryType value) { }

	[CompilerGenerated]
	private void set_TraderId(string value) { }

	public void SetIconSprite(Sprite sprite) { }

}

