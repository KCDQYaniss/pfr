namespace EFT.Achievements;

public sealed class AchievementTemplate
{
	[CompilerGenerated]
	private struct <LoadIconSprite>d__59 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public IImageLoader session; //Field offset: 0x20
		public AchievementTemplate <>4__this; //Field offset: 0x28
		private TaskAwaiter <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private int <Index>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private string <Id>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	private string <ImageUrl>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	private string <AssetPath>k__BackingField; //Field offset: 0x28
	[CompilerGenerated]
	private bool <Hidden>k__BackingField; //Field offset: 0x30
	[CompilerGenerated]
	private bool <ShowConditions>k__BackingField; //Field offset: 0x31
	[CompilerGenerated]
	private bool <ShowProgressBar>k__BackingField; //Field offset: 0x32
	[CompilerGenerated]
	private IReadOnlyList <Rewards>k__BackingField; //Field offset: 0x38
	[CompilerGenerated]
	private ConditionsDict <Conditions>k__BackingField; //Field offset: 0x40
	[CompilerGenerated]
	private bool <ShowProgress>k__BackingField; //Field offset: 0x48
	[CompilerGenerated]
	private EAchievementRarity <Rarity>k__BackingField; //Field offset: 0x4C
	[CompilerGenerated]
	private ETaskPlayerSide <PlayerSide>k__BackingField; //Field offset: 0x50
	[JsonIgnore]
	public float GlobalProgress; //Field offset: 0x54
	[CompilerGenerated]
	private Sprite <Sprite>k__BackingField; //Field offset: 0x58

	[JsonProperty("assetPath")]
	public private string AssetPath
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 82
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
		 get { } //Length: 171
	}

	[JsonProperty("hidden")]
	public private bool Hidden
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 4
	}

	[JsonProperty("id")]
	public private string Id
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 82
	}

	[JsonProperty("imageUrl")]
	public private string ImageUrl
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 82
	}

	[JsonProperty("index")]
	public private int Index
	{
		[CompilerGenerated]
		 get { } //Length: 164
		[CompilerGenerated]
		private set { } //Length: 4
	}

	[JsonProperty("side")]
	public private ETaskPlayerSide PlayerSide
	{
		[CompilerGenerated]
		 get { } //Length: 4
		[CompilerGenerated]
		private set { } //Length: 4
	}

	[JsonProperty("rarity")]
	public private EAchievementRarity Rarity
	{
		[CompilerGenerated]
		 get { } //Length: 4
		[CompilerGenerated]
		private set { } //Length: 4
	}

	[JsonProperty("rewards")]
	public private IReadOnlyList Rewards
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 82
	}

	[JsonProperty("showConditions")]
	public private bool ShowConditions
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 4
	}

	[JsonProperty("showProgress")]
	public private bool ShowProgress
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 4
	}

	[JsonProperty("progressBarEnabled")]
	public private bool ShowProgressBar
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
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 82
	}

	[JsonIgnore]
	public string Title
	{
		 get { } //Length: 171
	}

	public AchievementTemplate() { }

	public AchievementTemplate(string id, string imageUrl, string assetPath, bool hidden) { }

	[CompilerGenerated]
	public string get_AssetPath() { }

	[CompilerGenerated]
	public ConditionsDict get_Conditions() { }

	public string get_Description() { }

	[CompilerGenerated]
	public bool get_Hidden() { }

	[CompilerGenerated]
	public string get_Id() { }

	[CompilerGenerated]
	public string get_ImageUrl() { }

	[CompilerGenerated]
	public int get_Index() { }

	[CompilerGenerated]
	public ETaskPlayerSide get_PlayerSide() { }

	[CompilerGenerated]
	public EAchievementRarity get_Rarity() { }

	[CompilerGenerated]
	public IReadOnlyList get_Rewards() { }

	[CompilerGenerated]
	public bool get_ShowConditions() { }

	[CompilerGenerated]
	public bool get_ShowProgress() { }

	[CompilerGenerated]
	public bool get_ShowProgressBar() { }

	[CompilerGenerated]
	public Sprite get_Sprite() { }

	public string get_Title() { }

	[AsyncStateMachine(typeof(<LoadIconSprite>d__59))]
	public Task LoadIconSprite(IImageLoader session) { }

	[CompilerGenerated]
	private void set_AssetPath(string value) { }

	[CompilerGenerated]
	private void set_Conditions(ConditionsDict value) { }

	[CompilerGenerated]
	private void set_Hidden(bool value) { }

	[CompilerGenerated]
	private void set_Id(string value) { }

	[CompilerGenerated]
	private void set_ImageUrl(string value) { }

	[CompilerGenerated]
	private void set_Index(int value) { }

	[CompilerGenerated]
	private void set_PlayerSide(ETaskPlayerSide value) { }

	[CompilerGenerated]
	private void set_Rarity(EAchievementRarity value) { }

	[CompilerGenerated]
	private void set_Rewards(IReadOnlyList value) { }

	[CompilerGenerated]
	private void set_ShowConditions(bool value) { }

	[CompilerGenerated]
	private void set_ShowProgress(bool value) { }

	[CompilerGenerated]
	private void set_ShowProgressBar(bool value) { }

	[CompilerGenerated]
	private void set_Sprite(Sprite value) { }

}

