//Type is in global namespace

public class FinalStatisticsScreen : StatedEftScreen
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass11_0
	{
		public FinalStatisticsScreen <>4__this; //Field offset: 0x10
		public FinalStatisticController controller; //Field offset: 0x18

		public <>c__DisplayClass11_0() { }

		internal void <Show>b__0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass20_0
	{
		public FinalStatisticsScreen <>4__this; //Field offset: 0x10
		public AudioClipConfig musicConfig; //Field offset: 0x18
		public GUISounds guiSounds; //Field offset: 0x20

		public <>c__DisplayClass20_0() { }

		internal void <TryPlayFinalMusic>g__PlayFinalMusic|0() { }

	}

	[CompilerGenerated]
	private struct <TryCloseScreen>d__12 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public FinalStatisticController controller; //Field offset: 0x20
		public FinalStatisticsScreen <>4__this; //Field offset: 0x28
		private FinalStatsArgs <finalStats>5__2; //Field offset: 0x30
		private TaskAwaiter <>u__1; //Field offset: 0x38
		private TaskAwaiter <>u__2; //Field offset: 0x40

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <TrySetEndingBackground>d__15 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public IResult rewardResult; //Field offset: 0x20
		public EFinalType finalType; //Field offset: 0x28
		private SettingsWithController <gameSettings>5__2; //Field offset: 0x30
		private TaskAwaiter <>u__1; //Field offset: 0x38

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	internal enum EFinalStatisticsIcon
	{
		None = 0,
		CharacterLevel = 1,
		FavoriteWeapon = 2,
		PrestigeLevel = 3,
		KdRate = 4,
		TotalPlayedTime = 5,
		GameStyle = 6,
		GameEdition = 7,
		PMCEliminated = 8,
		GameMode = 9,
		ScavEliminated = 10,
		TotalRaidCount = 11,
		BossEliminated = 12,
		LongestWinStreak = 13,
		SurvivalRate = 14,
	}

	internal sealed class FinalStatisticController : EftSequenceScreenController
	{
		[CompilerGenerated]
		private readonly FinalStatsArgs <FinalStatsArgs>k__BackingField; //Field offset: 0x60

		public FinalStatsArgs FinalStatsArgs
		{
			[CompilerGenerated]
			 get { } //Length: 5
		}

		public virtual EEftScreenType ScreenType
		{
			 get { } //Length: 6
		}

		public FinalStatisticController(FinalStatsArgs args) { }

		[CompilerGenerated]
		public FinalStatsArgs get_FinalStatsArgs() { }

		public virtual EEftScreenType get_ScreenType() { }

	}

	internal class FinalStatsArgs
	{
		public FinalStatisticSceneSettings SceneSettings; //Field offset: 0x10
		public bool IsPvPMode; //Field offset: 0x18
		public EFinalType FinalType; //Field offset: 0x1C
		public int UnlockedFinalsCount; //Field offset: 0x20
		public int TotalEndingsCount; //Field offset: 0x24
		public string FavoriteWeapon; //Field offset: 0x28
		public int FavoriteWeaponKillCount; //Field offset: 0x30
		public int TotalRaids; //Field offset: 0x34
		public string SurvivalRate; //Field offset: 0x38
		public int LongestSurvivalStreak; //Field offset: 0x40
		public int Deaths; //Field offset: 0x44
		public AchievementsController AchievementsController; //Field offset: 0x48
		public QuestController QuestController; //Field offset: 0x50
		public IEftSession Session; //Field offset: 0x58
		public List Rewards; //Field offset: 0x60
		public EndingElement CurrentEnding; //Field offset: 0x68
		public string PlayerNickname; //Field offset: 0x70
		public int PlayerLevel; //Field offset: 0x78
		public int PrestigeLevel; //Field offset: 0x7C
		public TimeSpan TotalPlayTime; //Field offset: 0x80
		public string GameEdition; //Field offset: 0x88
		public string GameMode; //Field offset: 0x90
		public float KillDeathRatio; //Field offset: 0x98
		public string PlayStyle; //Field offset: 0xA0
		public int PmcKills; //Field offset: 0xA8
		public int SavageKills; //Field offset: 0xAC
		public int BossKills; //Field offset: 0xB0
		public Profile Profile; //Field offset: 0xB8

		public FinalStatsArgs() { }

	}

	public const float ANIMATION_SPEED_FACTOR = 2; //Field offset: 0x0
	[SerializeField]
	private FinalStatisticScreenStage[] _stages; //Field offset: 0xC8
	[SerializeField]
	protected FinalStatisticSceneSettings _finalStatisticSceneSettings; //Field offset: 0xD0
	[SerializeField]
	private Image _background; //Field offset: 0xD8
	[SerializeField]
	protected Image _pveGlow; //Field offset: 0xE0
	[SerializeField]
	protected Image _pvpGlow; //Field offset: 0xE8
	[SerializeField]
	private int _backgroundMusicMinVolumeIndex; //Field offset: 0xF0

	public FinalStatisticsScreen() { }

	private static void AddAvailableEnding(EndingInfo ending, MongoID endingId, bool isPve) { }

	private static void ApplyObtainedEnding(FinalStatsArgs finalStats) { }

	protected virtual bool CanGoBackOnState(int stateIndex) { }

	public virtual void Close() { }

	private void FadeOutBackgroundMusic() { }

	protected virtual bool ForceDisablePreviousButton(int stateIndex) { }

	public virtual void Show(FinalStatisticController controller) { }

	[ContextMenu("TEST")]
	private void Test() { }

	protected virtual ETranslateResult TranslateCommand(ECommand command) { }

	[AsyncStateMachine(typeof(<TryCloseScreen>d__12))]
	private Task TryCloseScreen(FinalStatisticController controller) { }

	private void TryPlayFinalMusic(EFinalType finalType) { }

	[AsyncStateMachine(typeof(<TrySetEndingBackground>d__15))]
	private static Task TrySetEndingBackground(IResult rewardResult, EFinalType finalType) { }

}

