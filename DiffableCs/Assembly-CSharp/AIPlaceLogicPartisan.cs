//Type is in global namespace

public class AIPlaceLogicPartisan : AIPlaceInfoLogic
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__11_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal bool <Init>b__11_0(BossLocationSpawn x) { }

	}

	public const string PARTISAN_TRIGGER = "PARTISAN_TRIGGER"; //Field offset: 0x0
	private static bool _isLogPrint; //Field offset: 0x0
	private AIPlaceInfo _aiPlaceInfo; //Field offset: 0x20
	public HashSet IdsOfVisitedPlayers; //Field offset: 0x28
	private float MIN_OFFSET; //Field offset: 0x30
	private float MAX_OFFSET; //Field offset: 0x34
	private BotSettingsComponents _partisanSettings; //Field offset: 0x38
	private List allPartisans; //Field offset: 0x40
	private bool _isPartisansWavesinited; //Field offset: 0x48
	private float _nextCheckTime; //Field offset: 0x4C
	public bool IsEnableTimeTest; //Field offset: 0x50

	public AIPlaceLogicPartisan() { }

	public virtual void Dispose() { }

	public virtual void Init(AIPlaceInfo aiPlaceInfo, BotsController botsController) { }

	private void OnPlayerEnter(Player player) { }

	private IPlayer PlayerWithWorstKarma() { }

	private float RndCoord() { }

	private void Update() { }

}

