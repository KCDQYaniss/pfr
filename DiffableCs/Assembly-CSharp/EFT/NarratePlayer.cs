namespace EFT;

[UsedImplicitly]
public class NarratePlayer : LocalPlayer
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Action <>9__2_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal void <Create>b__2_0() { }

	}

	[CompilerGenerated]
	private struct <Create>d__2 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public GameWorld gameWorld; //Field offset: 0x20
		public int playerId; //Field offset: 0x28
		public Vector3 position; //Field offset: 0x2C
		public EUpdateQueue updateQueue; //Field offset: 0x38
		public EUpdateMode armsUpdateMode; //Field offset: 0x3C
		public EUpdateMode bodyUpdateMode; //Field offset: 0x40
		public Mode characterControllerMode; //Field offset: 0x48
		public Func getSensitivity; //Field offset: 0x50
		public Func getAimingSensitivity; //Field offset: 0x58
		public string prefix; //Field offset: 0x60
		public bool aiControl; //Field offset: 0x68
		public Profile profile; //Field offset: 0x70
		public Quaternion rotation; //Field offset: 0x78
		public string layerName; //Field offset: 0x88
		public EPointOfView pointOfView; //Field offset: 0x90
		public IStatisticsManager statisticsManager; //Field offset: 0x98
		public QuestController questController; //Field offset: 0xA0
		public AchievementsController achievementsController; //Field offset: 0xA8
		public PrestigeController prestigeController; //Field offset: 0xB0
		public BaseTraderDialogController dialogController; //Field offset: 0xB8
		private NarratePlayer <player>5__2; //Field offset: 0xC0
		private TaskAwaiter <>u__1; //Field offset: 0xC8

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <OnGameSessionEnd>d__3 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public NarratePlayer <>4__this; //Field offset: 0x20
		public ExitStatus exitStatus; //Field offset: 0x28
		public float pastTime; //Field offset: 0x2C
		public string locationId; //Field offset: 0x30
		public string exitName; //Field offset: 0x38
		private TaskAwaiter <>u__1; //Field offset: 0x40

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	private sealed class NarrateSlotObserver`1 : SlotObserver
	{
		[CompilerGenerated]
		private sealed class <>c
		{
			public static readonly <>c <>9; //Field offset: 0x0
			public static Action <>9__2_1; //Field offset: 0x0
			public static Func <>9__2_0; //Field offset: 0x0

			private static <>c() { }

			public <>c() { }

			internal Action <.ctor>b__2_0(T _, Action _) { }

			internal void <.ctor>b__2_1() { }

		}


		public virtual T Component
		{
			 get { } //Length: 3
		}

		public NarrateSlotObserver`1(Slot slot) { }

		public virtual T get_Component() { }

	}

	private const float HORIZONTAL_LOOK_LIMIT = 16; //Field offset: 0x0
	private const float VERTICAL_LOOK_LIMIT = 4; //Field offset: 0x0

	public NarratePlayer() { }

	[CompilerGenerated]
	[DebuggerHidden]
	private Task <>n__0(ExitStatus exitStatus, float pastTime, string locationId, string exitName) { }

	public virtual ValueTuple ApplyLookLimit(EFTHardSettings hardSettings) { }

	[AsyncStateMachine(typeof(<Create>d__2))]
	public static Task Create(GameWorld gameWorld, int playerId, Vector3 position, Quaternion rotation, string layerName, string prefix, EPointOfView pointOfView, Profile profile, bool aiControl, EUpdateQueue updateQueue, EUpdateMode armsUpdateMode, EUpdateMode bodyUpdateMode, Mode characterControllerMode, Func getSensitivity, Func getAimingSensitivity, IStatisticsManager statisticsManager, QuestController questController, AchievementsController achievementsController, PrestigeController prestigeController, BaseTraderDialogController dialogController) { }

	protected virtual void CreateSlotObservers() { }

	public virtual void ExecuteShotSkill(Item weapon) { }

	public virtual void ExecuteSkill(Action action) { }

	protected virtual void InitVaultingComponent(bool aiControlled) { }

	[AsyncStateMachine(typeof(<OnGameSessionEnd>d__3))]
	public virtual Task OnGameSessionEnd(ExitStatus exitStatus, float pastTime, string locationId, string exitName) { }

	public virtual void OnHealthEffectAdded(IHealthEffect effect) { }

	public virtual void OnHealthEffectVisualAdded(IHealthEffect effect) { }

	protected virtual void OnSkillLevelChanged(BaseSkill skill) { }

	protected virtual void OnWeaponMastered(Mastering masterSkill) { }

}

